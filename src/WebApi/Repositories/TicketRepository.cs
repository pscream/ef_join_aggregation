using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using WebApi.DataContext;
using WebApi.Models.Business;
using WebApi.Models.Database;

namespace WebApi.Repositories
{

    public class TicketRepository : ITicketRepository
    {

        private readonly TicketContext _context;

        public TicketRepository(TicketContext context)
        {
            _context = context;
        }

        public async Task<List<SlaProgress>> GetTicketListAsync(DateTime referenceTime)
        {

            DateTime currentDate = referenceTime;

            var queryTicketSla = _context.TicketSlas
                .Join(_context.Tickets, outer => outer.TicketId, inner => inner.Id, (ts, ticket) => new { ts = ts, ticket = ticket })
                .Join(_context.Slas, outer => outer.ts.SlaId, inner => inner.Id, (ts, sla) => new { ts = ts.ts, sla = sla, ticket = ts.ticket })
                .Where(joined => joined.ts.IsActive && joined.sla.IsActive && joined.ticket.IsActive);

            var queryMatchTicketSlaCaches = _context.TicketSlaCaches
                                            .Where(e => e.IsActive && e.StartDate <= currentDate && e.EndDate > currentDate);

            var queryMinStartDateCachesInternal = _context.TicketSlaCaches
                                .Where(e => e.IsActive && e.StartDate > currentDate)
                                .GroupBy(e => e.TicketSlaId)
                                .Select(e => new
                                {
                                    ticketSlaId = e.Key,
                                    startDate = e.Min(x => x.StartDate)
                                });

            var queryMinStartDateCaches = _context.TicketSlaCaches
                    .Join(queryMinStartDateCachesInternal, outer => new { TicketSlaId = outer.TicketSlaId, StartDate = outer.StartDate }, inner => new { TicketSlaId = inner.ticketSlaId, StartDate = inner.startDate },
                                            (outer, inner) => new { cache = outer })
                    .Where(joined => joined.cache.IsActive)
                    .Select(e => e.cache);

            var queryCache = queryTicketSla
                .GroupJoin(queryMatchTicketSlaCaches, outer => outer.ts.Id, inner => inner.TicketSlaId, (ts, caches) => new { ts = ts, matchCaches = caches })
                .SelectMany(joined => joined.matchCaches.DefaultIfEmpty(),
                            (joined, grouping) =>
                            new
                            {
                                ts = joined.ts,
                                matchCache = grouping,
                            })
                .GroupJoin(queryMinStartDateCaches, outer => outer.ts.ts.Id, inner => inner.TicketSlaId, (ts, caches) => new { ts = ts.ts.ts, matchCache = ts.matchCache, minCaches = caches })
                .SelectMany(joined => joined.minCaches.DefaultIfEmpty(),
                            (joined, grouping) =>
                            new SlaProgress()
                            {
                                TicketSlaId = joined.ts.Id,
                                TicketId = joined.ts.TicketId,
                                SlaId = joined.ts.SlaId,
                                CacheMatchId = joined.matchCache.Id,
                                CacheMatchStartDate = joined.matchCache.StartDate,
                                CacheMatchEndDate = joined.matchCache.EndDate,
                                CacheMinId = grouping.Id,
                                CacheMinStartDate = grouping.StartDate,
                                CacheMinEndDate = grouping.EndDate,
                                minutes1Target = joined.matchCache.Timer1StartMins != null ?
                                                    joined.matchCache.Timer1SlaMins :
                                                    grouping.Timer1SlaMins,
                                minutes1Spent = joined.matchCache.Timer1StartMins != null ?
                                                    joined.matchCache.Timer1StartMins + (EF.Functions.DateDiffMinute(joined.matchCache.StartDate, currentDate)) :
                                                    grouping.Timer1StartMins,
                                minutes1Left =
                                                joined.matchCache.Timer1StartMins != null ?
                                                    joined.matchCache.Timer1SlaMins -
                                                        (joined.matchCache.Timer1StartMins + (EF.Functions.DateDiffMinute(joined.matchCache.StartDate, currentDate))) :
                                                    grouping.Timer1SlaMins - grouping.Timer1StartMins,

                                minutes2Target = joined.matchCache.Timer2StartMins != null ?
                                                    joined.matchCache.Timer2SlaMins :
                                                    grouping.Timer2SlaMins,
                                minutes2Spent = joined.matchCache.Timer2StartMins != null ?
                                                    joined.matchCache.Timer2StartMins + (EF.Functions.DateDiffMinute(joined.matchCache.StartDate, currentDate)) :
                                                    grouping.Timer2StartMins,
                                minutes2Left =
                                                joined.matchCache.Timer2StartMins != null ?
                                                    joined.matchCache.Timer2SlaMins -
                                                        (joined.matchCache.Timer2StartMins + (EF.Functions.DateDiffMinute(joined.matchCache.StartDate, currentDate))) :
                                                    grouping.Timer2SlaMins - grouping.Timer2StartMins,

                                //ts = joined.ts,
                                //matchCache = joined.matchCache,
                                //minCache = grouping,
                            }).OrderBy(e => e.minutes2Left);

            return await queryCache.ToListAsync();

        }

    }

}

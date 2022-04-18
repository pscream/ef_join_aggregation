using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using WebApi.DataContext;
using WebApi.Models.Database;

namespace WebApi.Repositories
{

    public class TimesheetRepository : ITimesheetRepository
    {

        private Guid OPEN_STATUS_ID = new Guid("00000000-0000-0000-0000-000000000001");

        private readonly TimesheetContext _context;

        public TimesheetRepository(TimesheetContext context)
        {
            _context = context;
        }

        public async Task<List<TimesheetRowCount>> GetTimesheetRow(DateTime startDate, DateTime endDate)
        {

            var listCountQuery = _context.TimesheetRows
                .Include(e => e.Timesheet)
                .Where(e => e.Timesheet.IsActive && e.IsActive && e.Timesheet.StatusId == OPEN_STATUS_ID)
                .GroupBy(e => new { e.Timesheet.StartDate, e.Timesheet.EndDate })
                .Select(e => new { key = e.Key, count = e.Count() });

            var listCount = await _context.TimesheetWeeks
                    //.Where(e => e.IsActive && e.StartDate >= new DateTime(2022, 02, 01) && e.EndDate <= new DateTime(2022, 04, 30))
                    .Where(e => e.IsActive && e.StartDate >= startDate && e.EndDate <= endDate)
                    .GroupJoin(listCountQuery, e => new { e.StartDate, e.EndDate }, e => new { e.key.StartDate, e.key.EndDate }, (week, grouping) => new { week = week, grouping = grouping })
                    .SelectMany(join => join.grouping.DefaultIfEmpty(),
                    (join, grouping) =>
                    new TimesheetRowCount
                    {
                        StartDate = join.week.StartDate,
                        EndDate = join.week.EndDate,
                        RowCount = grouping.count
                    })
                    .ToListAsync();

            return listCount;

        }

        public DateTime EndOfWeek(DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = dt.DayOfWeek - startOfWeek;
            if (diff < 0)
            {
                diff += 7;
            }
            return dt.AddDays(6 - diff).Date;
        }

    }

}
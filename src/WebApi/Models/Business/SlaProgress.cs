using System;

namespace WebApi.Models.Business
{

    public class SlaProgress
    {

        public Guid TicketSlaId { get; set; }
        public Guid TicketId { get; set; }
        public Guid SlaId { get; set; }
        public Guid? CacheMatchId { get; set; }
        public DateTime? CacheMatchStartDate { get; set; }
        public DateTime? CacheMatchEndDate { get; set; }
        public Guid? CacheMinId { get; set; }
        public DateTime? CacheMinStartDate { get; set; }
        public DateTime? CacheMinEndDate { get; set; }

        public int? minutes1Target { get; set; }
        public int? minutes1Spent { get; set; }
        public int? minutes1Left { get; set; }

        public int? minutes2Target { get; set; }
        public int? minutes2Spent { get; set; }
        public int? minutes2Left { get; set; }

    }

}

using System;

namespace WebApi.Models.Database
{

    public class TicketSlaCache
    {

        public Guid Id { get; set; }

        public Guid TicketSlaId { get; set; }
        public TicketSla TicketSla { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int Timer1SlaMins { get; set; }
        public int? Timer1StartMins { get; set; }
        public int Timer1EndMins { get; set; }

        public int Timer2SlaMins { get; set; }
        public int? Timer2StartMins { get; set; }
        public int Timer2EndMins { get; set; }

        public Guid CreatedById { get; set; }
        public User CreatedBy { get; set; }

        public Guid UpdatedById { get; set; }
        public User UpdatedBy { get; set; }

        public bool IsActive { get; set; }

    }

}

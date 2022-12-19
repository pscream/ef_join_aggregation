using System;

namespace WebApi.Models.Database
{

    public class TicketSla
    {

        public Guid Id { get; set; }

        public Guid TicketId { get; set; }
        public Ticket Ticket { get; set; }

        public Guid SlaId { get; set; }
        public Sla Sla { get; set; }

        public Guid CreatedById { get; set; }
        public User CreatedBy { get; set; }

        public Guid UpdatedById { get; set; }
        public User UpdatedBy { get; set; }

        public bool IsActive { get; set; }
    
    }

}

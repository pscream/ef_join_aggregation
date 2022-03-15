using System;

namespace WebApi.Models.Database
{

     public class Timesheet
    {
        
        public Guid Id { get; set; }

        public Guid ResourceId { get; set; }
        public Resource Resource { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Guid StatusId { get; set; }
        public Status Status { get; set; }

        public Guid CreatedById { get; set; }
        public User CreatedBy { get; set; }

        public Guid UpdatedById { get; set; } 
        public User UpdatedBy { get; set; }

        public bool IsActive { get; set; }

    }

}
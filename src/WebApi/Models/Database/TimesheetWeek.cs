using System;

namespace WebApi.Models.Database
{

     public class TimesheetWeek
    {
        
        public Guid Id { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Guid CreatedById { get; set; }
        public User CreatedBy { get; set; }

        public Guid UpdatedById { get; set; } 
        public User UpdatedBy { get; set; }

        public bool IsActive { get; set; }

    }

}
using System;

namespace WebApi.Models.Database
{
    public class TimesheetRow
    {

        public Guid Id { get; set; }

        public Guid TimesheetId { get; set; }
        public Timesheet Timesheet { get; set; }

        public Guid EngagementId { get; set; }
        public Engagement Engagement { get; set; }

        public Guid StatusId { get; set; }
        public Status Status { get; set; }

        public Guid CreatedById { get; set; }
        public User CreatedBy { get; set; }

        public Guid UpdatedById { get; set; }
        public User UpdatedBy { get; set; }

        public bool IsActive { get; set; }

    }
}

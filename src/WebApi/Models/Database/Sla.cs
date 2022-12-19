using System;

namespace WebApi.Models.Database
{

    public class Sla
    {

        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid CreatedById { get; set; }
        public User CreatedBy { get; set; }

        public Guid UpdatedById { get; set; }
        public User UpdatedBy { get; set; }

        public bool IsActive { get; set; }

    }

}

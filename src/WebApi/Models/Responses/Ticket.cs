using System;

namespace WebApi.Models.Responses
{

    public class Ticket
    {

        public Guid Id { get; set; }

        public string Code { get; set; }

        public bool IsActive { get; set; }
    
    }

}

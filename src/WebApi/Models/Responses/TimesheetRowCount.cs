using System;

namespace WebApi.Models.Responses
{

    public class TimesheetRowCount
    {

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int RowCount { get; set; }
    
    }

}

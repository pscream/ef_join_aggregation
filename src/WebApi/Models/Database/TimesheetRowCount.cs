using System;

namespace WebApi.Models.Database
{

    public class TimesheetRowCount
    {

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int RowCount { get; set; }
    
    }

}

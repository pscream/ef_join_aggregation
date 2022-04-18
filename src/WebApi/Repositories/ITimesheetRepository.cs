using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using WebApi.Models.Database;

namespace WebApi.Repositories
{

    public interface ITimesheetRepository
    {

        Task<List<TimesheetRowCount>> GetTimesheetRow(DateTime startDate, DateTime endDate);

        DateTime EndOfWeek(DateTime dt, DayOfWeek startOfWeek);

    }

}
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using WebApi.Models.Database;

namespace WebApi.Repositories
{

    public interface ITimesheetRepository
    {

        Task<List<Timesheet>> GetTimesheet(Guid id);

        Task<List<TimesheetRowCount>> GetTimesheetRow(Guid id);

    }

}
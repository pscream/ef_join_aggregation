using AutoMapper;

using TimesheetRowCountDatabase = WebApi.Models.Database.TimesheetRowCount;
using TimesheetRowCountResponse = WebApi.Models.Responses.TimesheetRowCount;

namespace WebApi.Models.Mapping
{

    public class TimesheetProfile : Profile
    {

        public TimesheetProfile()
        {
            CreateMap<TimesheetRowCountDatabase, TimesheetRowCountResponse>();
        }

    }

}
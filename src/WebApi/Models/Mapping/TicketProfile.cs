using AutoMapper;

using TicketDatabase = WebApi.Models.Database.Ticket;
using TicketResponse = WebApi.Models.Responses.Ticket;

namespace WebApi.Models.Mapping
{

    public class TicketProfile : Profile
    {

        public TicketProfile()
        {
            CreateMap<TicketDatabase, TicketResponse>();
        }

    }

}
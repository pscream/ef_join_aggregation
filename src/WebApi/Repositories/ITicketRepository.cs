using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using WebApi.Models.Business;

namespace WebApi.Repositories
{

    public interface ITicketRepository
    {

        Task<List<SlaProgress>> GetTicketListAsync(DateTime referenceTime);

    }

}

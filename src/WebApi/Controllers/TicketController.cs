using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using AutoMapper;

using WebApi.Repositories;
using WebApi.Models.Responses;
using WebApi.Models.Business;
using System;

namespace WebApi.Controllers
{

    [Route("[controller]")]
    public class TicketController : Controller
    {

        private ITicketRepository _repository;
        private IMapper _mapper;

        public TicketController(ITicketRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<SlaProgress>> Get(DateTime referenceTime)
        {
            return await _repository.GetTicketListAsync(referenceTime);
        }

    }

}

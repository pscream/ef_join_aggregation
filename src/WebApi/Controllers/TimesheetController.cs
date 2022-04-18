using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using AutoMapper;

using WebApi.Models.Responses;
using WebApi.Repositories;

namespace WebApi.Controllers
{

    [Route("[controller]")]
    public class TimesheetController : Controller
    {

        private ITimesheetRepository _repository;
        private IMapper _mapper;

        public TimesheetController(ITimesheetRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<TimesheetRowCount>> Get(DateTime startDate, DateTime endDate)
        {
            return _mapper.Map<List<TimesheetRowCount>>(await _repository.GetTimesheetRow(startDate, endDate));
        }

        [HttpGet]
        [Route("endOfWeek")]
        public DateTime GetEndOfWeek(DateTime dt, DayOfWeek startOfWeek)
        {
            return _repository.EndOfWeek(dt, startOfWeek);
        }

    }

}

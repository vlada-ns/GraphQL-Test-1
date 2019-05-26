using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp5.Models;
using WebApp5.Repository;

namespace WebApp5.Controllers
{
    [Route("api/[controller]")]
    public class PersonsController : Controller
    {
        private readonly PersonRepository _personRepository;

        public PersonsController(PersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet("[action]")]
        public async Task<IEnumerable<Person>> List()
        {
            return await _personRepository.GetAll();
        }
    }
}
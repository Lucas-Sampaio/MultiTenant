using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MultiTenant.Api.Data;
using MultiTenant.Api.Domain;
using System.Collections.Generic;
using System.Linq;

namespace MultiTenant.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Person> Get([FromServices] ApplicationContext db)
        {
            var people = db.People.ToArray();

            return people;
        }
    }
}

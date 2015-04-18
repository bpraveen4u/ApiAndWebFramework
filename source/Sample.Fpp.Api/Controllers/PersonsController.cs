using Sample.Fpp.Business.Managers;
using Sample.Fpp.Data.Impl;
using Sample.Fpp.Entities;
using Sample.Fpp.Infrastructure.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Sample.Fpp.Api.Controllers
{
    public class PersonsController : ApiController
    {
        private readonly PersonManager manager;

        public PersonsController()
            :this(new PersonManager())
        {

        }

        public PersonsController(PersonManager manager)
        {
            this.manager = manager;
        }

        public Person Get(int id)
        {
            return manager.Get(id);
        }

        public IEnumerable<Person> Get()
        {
            return manager.GetAll();
        }
    }
}

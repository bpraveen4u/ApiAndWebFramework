using Sample.Fpp.Data.Contract;
using Sample.Fpp.Data.Impl;
using Sample.Fpp.Entities;
using Sample.Fpp.Infrastructure.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Fpp.Business.Managers
{
    public class PersonManager
    {
        private readonly IPersonRepository repository;
        private readonly ILogger logger;
        public PersonManager()
            :this(new PersonRepository(), new NLogLogger())
        {

        }

        public PersonManager(IPersonRepository repository, ILogger logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        public Person Get(int id)
        {
            return repository.Get(id);
        }

        public IEnumerable<Person> GetAll()
        {
            logger.Info("GetAll called");
            return repository.GetAll(null);
        }
    }
}

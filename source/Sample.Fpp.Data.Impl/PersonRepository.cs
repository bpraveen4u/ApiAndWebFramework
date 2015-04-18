using Sample.Fpp.Data.Contract;
using Sample.Fpp.Entities;
using Sample.Fpp.Infrastructure.DbHelper;
using Sample.Fpp.Infrastructure.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Fpp.Data.Impl
{
    public class PersonRepository : IPersonRepository
    {
        private DBHelper _dbHelper = new DBHelper(Constants.DEFAULT_PROVIDER);
        public PersonRepository()
        {

        }

        public IEnumerable<Person> GetAll(Func<Person, bool> predicate = null)
        {
            List<Person> result = new List<Person>();
            IDbConnection connection = _dbHelper.GetConnObject();
            
            using (var reader = _dbHelper.ExecuteDataReader("select * from Persons", connection))
            {
                while (reader.Read())
                {
                    var person = new Person()
                    {
                        Id = Convert.ToInt16(reader["Id"]),
                        FirstName = Convert.ToString(reader["FirstName"]),
                        MiddleName = Convert.ToString(reader["MiddleName"]),
                        LastName = Convert.ToString(reader["LastName"]),
                        Email = Convert.ToString(reader["Email"]),
                        PhoneNr = Convert.ToString(reader["PhoneNr"]),
                    };
                    result.Add(person);
                }

            }
            return result;
        }

        public Person Get(int id)
        {
            Person result = null;
            IDbConnection connection = _dbHelper.GetConnObject();
            DBParameter param1 = new DBParameter("@id", id);
            using (var reader =_dbHelper.ExecuteDataReader("select * from Persons where ID = @id", connection, param1))
            {
                if (reader.Read())
                {
                    result = new Person()
                    {
                        Id = Convert.ToInt16(reader["Id"]),
                        FirstName = Convert.ToString(reader["FirstName"]),
                        MiddleName = Convert.ToString(reader["MiddleName"]),
                        LastName = Convert.ToString(reader["LastName"]),
                        Email = Convert.ToString(reader["Email"]),
                        PhoneNr = Convert.ToString(reader["PhoneNr"]),
                    };
                }
                
            }
            return result;
        }

        public void Add(Person entity)
        {
            throw new NotImplementedException();
        }

        public void Attach(Person entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}

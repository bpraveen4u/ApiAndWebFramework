using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Fpp.Entities
{
    public class Person : BaseEntity
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNr { get; set; }

        public override string ToString()
        {
            return String.Format("Person - {0}, {1}, {2}", this.Id, this.FirstName, this.LastName);
        }
    }
}

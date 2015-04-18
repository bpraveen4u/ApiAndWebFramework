using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Fpp.Entities
{
    public interface IEntity
    {
    }

    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}

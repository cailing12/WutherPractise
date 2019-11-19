using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wuther.GraphQl.Model;

namespace Wuther.GraphQl.Interface
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAll();
        Person GetById(int id);
    }
}

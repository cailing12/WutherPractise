using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wuther.GraphQl.Interface;
using Wuther.GraphQl.Model;

namespace Wuther.GraphQl.Service
{
    public class PersonRepository : IPersonRepository
    {
        public IEnumerable<Person> GetAll()
        {
            var michael = new Person()
            {
                Id = 1,
                Name = "Michael",
                Email = "michael.gmail.com"
            };
            var carol = new Person()
            {
                Id = 2,
                Name = "Carol",
                Email = "carol.gmail.com"
            };
            var dave = new Person()
            {
                Id = 3,
                Name = "Dave",
                Email = "dave.gmail.com",
                Parents = new[] {michael,carol}
            };
            var nick = new Person()
            {
                Id = 4,
                Name = "Nick",
                Email = "nick.gmail.com",
                Parents = new[] {michael,carol,dave}
            };
            return new List<Person>{michael,carol,dave,nick};
        }

        public Person GetById(int id)
        {
            return GetAll().SingleOrDefault(c => c.Id == id);
        }
    }
}

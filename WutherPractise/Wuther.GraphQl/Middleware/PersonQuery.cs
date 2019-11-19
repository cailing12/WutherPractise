using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using Wuther.GraphQl.Interface;

namespace Wuther.GraphQl.Middleware
{
    public class PersonQuery : ObjectGraphType
    {
        public PersonQuery(IPersonRepository personRepository)
        {
            Field<PersonType>("person", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "Id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return personRepository.GetById(id);
                });
            Field<ListGraphType<PersonType>>("persons",
                resolve: context => { return personRepository.GetAll(); });
        }
    }
}

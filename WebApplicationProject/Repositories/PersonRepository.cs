using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationProject.Models;

namespace WebApplicationProject.Repositories
{
    public class PersonRepository:Repository<Person>
    {
        public PersonRepository() : base()
        {}
        public int? Create(Person person)
        {
            using(IDbConnection context = new SqlConnection(connectionString))
            {
                string command = $"Insert into Person(FirstName, LastName, MiddleName) Values('{person.FirstName}', '{person.LastName}', '{person.MiddleName}')";
                int Id = context.Query<int>(command + "SELECT CAST(SCOPE_IDENTITY() as int)").FirstOrDefault();
                return Id;
            }
        }

    }
}

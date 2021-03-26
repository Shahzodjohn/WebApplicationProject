using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
namespace WebApplicationProject.Repositories
{
    public abstract class Repository<Model>
    {
        public string connectionString = @"Data source=WIN-5RSC18PG333\SQLEXPRESS;initial catalog=People;integrated security=true";
        public List<Model> Select()
        {

            using (IDbConnection context = new SqlConnection(connectionString))
            {
                return context.Query<Model>($"Select * from {typeof(Model).Name}").ToList();
            }
        }

    }
}

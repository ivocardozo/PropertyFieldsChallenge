using PropertyApp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Dapper;
using Microsoft.Data.Sqlite;
using System.Linq;


namespace PropertyApp.Data
{
    public class DataRepository : IDataRepository
    {
        private readonly string connectionString;

        public DataRepository(IConfiguration configuration)
        {
            connectionString = configuration["ConnectionStrings:DefaultSQLite"];

        }
        public PropertyModel GetPropertyModelById(int id)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                string query = $"SELECT * FROM PropertyFields WHERE StoredId = '{id}';" ;
                var property = connection.Query<PropertyModel>(query).First();
                return property;
            }
        }

        public PropertyModel PostProperty(PropertyModel propertyModel)
        {
            using(var connection = new SqliteConnection(connectionString))
            {
                string query =
                    "INSERT INTO PropertyFields (Id, Address, YearBuild, ListPrice, MonthlyPrice, GrossYield) " +
                    "VALUES(@Id, @Address, @YearBuild, @ListPrice, @MonthlyPrice, @GrossYield); " +
                    "SELECT last_insert_rowid()";
                var id = connection.Query<int>(query, propertyModel).Single();
                return GetPropertyModelById(id);
            }
        }
    }
}

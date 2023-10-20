using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositories
{
    internal class ProviderRepository : BaseRepository, IProviderRepository
    {
        public ProviderRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(ProviderModel providerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Providers VALUES (@name, @address, @phone)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providerModel.Name;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = providerModel.Address;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = providerModel.Phone;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Providers WHERE Provider_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProviderModel providerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Providers
                                        SET Provider_Name =@name,
                                        Provider_Address = @address
                                        Provider_Phone = @phone
                                        WHERE Provider_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providerModel.Name;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = providerModel.Address;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = providerModel.Phone;
                command.Parameters.Add("@id", SqlDbType.Int).Value = providerModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProviderModel> GetAll()
        {
            var ProviderList = new List<ProviderModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Providers ORDER BY Provider_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providerModel = new ProviderModel();
                        providerModel.Id = (int)reader["Provider_Id"];
                        providerModel.Name = reader["Provider_Name"].ToString();
                        providerModel.Address = reader["Provider_Address"].ToString();
                        providerModel.Phone = reader["Provider_Phone"].ToString();
                        ProviderList.Add(providerModel);
                    }
                }
            }
            return ProviderList;
        }

        public IEnumerable<ProviderModel> GetByValue(string value)
        {
            var providerList = new List<ProviderModel>();
            int providerId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string providerName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Provider
                                        WHERE Provider_Id = @id or Provider_Name LIKE @name+ '%'
                                        ORDER By Provider_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = providerId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providerName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providerModel = new ProviderModel();
                        providerModel.Id = (int)reader["Provider_Id"];
                        providerModel.Name = reader["Provider_Name"].ToString();
                        providerModel.Address = reader["Provider_Address"].ToString();
                        providerModel.Phone = reader["Provider_Phone"].ToString();
                        providerList.Add(providerModel);
                    }
                }
            }
            return providerList;
        }
    }
}

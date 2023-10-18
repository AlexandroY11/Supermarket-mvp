using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarket_mvp.Models;
using System.Data;

namespace Supermarket_mvp._Repositories
{
    internal class PayModeRepository : BaseRepository, IPayModeRepository
    {
        public PayModeRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(PayModeModel payModeModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(PayModeModel payModeModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PayModeModel> GetAll()
        {
            var PayModeList = new List<PayModeModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM PayMode ORDER BY Pay_Mode_Id DESC";
                using(var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var payModeModel = new PayModeModel();
                        payModeModel.IdPayMode = (int)reader["Pay_Mode_Id"];
                        payModeModel.NamePayMode = reader["Pay_Mode_Name"].ToString();
                        payModeModel.ObservationPayMode = reader["Pay_Mode_Observation"].ToString();
                        PayModeList.Add(payModeModel);
                    }
                }
            }
            return PayModeList;
        }

        public IEnumerable<PayModeModel> GetByValue(string value)
        {
            var PayModeList = new List<PayModeModel>();
            int PayModeId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string PayModeName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM PayMode
                                        WHERE Pay_Mode_Id = @id or Pay_Mode_Name LIKE @name+ '%'
                                        ORDER BY Pay_Mode_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = PayModeId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = PayModeName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var payModeModel = new PayModeModel();
                        payModeModel.IdPayMode = (int)reader["Pay_Mode_Id"];
                        payModeModel.NamePayMode = reader["Pay_Mode_Name"].ToString();
                        payModeModel.ObservationPayMode = reader["Pay_Mode_Observation"].ToString();
                        PayModeList.Add(payModeModel);
                    }
                }
            }
            return PayModeList;
        }
    }
}

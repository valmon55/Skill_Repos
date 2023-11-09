using ADO_NET.Library.Configurations;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET.Library
{
    public class MainConnector
    {
        readonly SqlConnection connection = new SqlConnection(ConnectionString.MsSqlConnection);
        public async Task<bool> ConnectAsync()
        {
            bool result;
            try
            {
                //connection = new SqlConnection(ConnectionString.MsSqlConnection);
                await connection.OpenAsync();
                result = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);  
                result = false;
            }

            return result;
        }
        public async void DisconnectAsync()
        {
            if (connection.State == ConnectionState.Open)
            {
                await connection.CloseAsync();
            }
        }
        public SqlConnection GetConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                return connection;
            }
            else
            {
                throw new Exception("Подключение уже закрыто!");
            }
        }
    }
}

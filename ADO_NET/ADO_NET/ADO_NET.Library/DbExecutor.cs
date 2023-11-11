﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET.Library
{
    public class DbExecutor
    {
        private MainConnector connector;
        public DbExecutor(MainConnector connector)
        {
            this.connector = connector;
        }
        /// <summary>
        /// Отсоединённая модель
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public DataTable SelectAll(string table) 
        {
            var selectcommandtext = "select * from " + table;
            var adapter = new SqlDataAdapter(
                                selectcommandtext,
                                connector.GetConnection()
                        );
            var ds = new DataSet();
            adapter.Fill(ds);

            return ds.Tables[0];
        }
        /// <summary>
        /// Присоединённая модель
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public SqlDataReader SelectAllCommandReader(string table)
        {
            var command = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "select * from " + table,
                Connection = connector.GetConnection(),
            };

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                return reader;
            }

            return null;
        }
    }
}

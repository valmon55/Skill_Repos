﻿using ADO_NET.Library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ADO_NET.Prog
{
    public class Manager
    {
        private MainConnector connector;
        private DbExecutor dbExecutor;

        public Manager()
        {
            connector = new MainConnector();
        }
        public void Connect()
        {
            var result = connector.ConnectAsync();

            if (result.Result)
            {
                Console.WriteLine("Подключено успешно!");
                var db = new DbExecutor(connector);
            }
            else
            {
                Console.WriteLine("Ошибка подключения!");
            }
        }
        public void Disconnect()
        {
            Console.WriteLine("Отключаем БД!");
            connector.DisconnectAsync();
        }
        public void ShowData()
        {
            var tablename = "NetworkUser";

            Console.WriteLine("Получаем данные таблицы " + tablename);

            var data = dbExecutor.SelectAll(tablename);
            Console.WriteLine($"Количество строк в {tablename}: {data.Rows.Count}");

            foreach (DataColumn column in data.Columns)
            {
                Console.Write($"{column.ColumnName}\t");
            }
            Console.WriteLine();

            foreach (DataRow row in data.Rows)
            {
                var cells = row.ItemArray;
                foreach (var cell in cells)
                {
                    Console.Write($"{cell}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

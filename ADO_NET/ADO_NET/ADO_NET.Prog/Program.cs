using ADO_NET.Library;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ADO_NET.Prog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var manager = new Manager();

            manager.Connect();
            manager.ShowData();
            manager.Disconnect();



            var data = new DataTable();
            var connector = new MainConnector();
            var result = connector.ConnectAsync();

            if (result.Result)
            {
                Console.WriteLine("Подключено успешно!");
                var db = new DbExecutor(connector);

                var tablename = "NetworkUser";

                Console.WriteLine("Получаем данные таблицы " + tablename);

                data = db.SelectAll(tablename);
                Console.WriteLine($"Количество строк в {tablename}: {data.Rows.Count}");

                foreach(DataColumn column in data.Columns)
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

                Console.WriteLine("Отключаем БД!");
                connector.DisconnectAsync();

                //result = connector.ConnectAsync();
                //if (result.Result)
                //{
                //    Console.WriteLine($"Количество строк в {tablename}: {data.Rows.Count}");
                //}
                //connector.DisconnectAsync();
                result = connector.ConnectAsync();

                if (result.Result)
                {
                    SqlDataReader reader = db.SelectAllCommandReader(tablename);
                    var columnList = new List<string>();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var name = reader.GetName(i);
                        columnList.Add(name);
                    }
                    for (int i = 0; i < columnList.Count; i++)
                    {
                        Console.Write($"{columnList[i]}\t");
                    }
                    Console.WriteLine();
                    while (reader.Read())
                    {
                        for (int i = 0; i < columnList.Count; i++)
                        {
                            var value = reader[columnList[i]];
                            Console.Write($"{value}\t");
                        }

                        Console.WriteLine();
                    }
                    Console.WriteLine("Отключаем БД!");
                    connector.DisconnectAsync();
                }
            }
            else 
            {
                Console.WriteLine("Ошибка подключения!");
            }


            if(Debugger.IsAttached)
                Console.ReadKey();
        }
    }
}
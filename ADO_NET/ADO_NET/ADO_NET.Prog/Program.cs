using ADO_NET.Library;
using System.Data;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ADO_NET.Prog
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

                Console.WriteLine("Отключаем БД!");
                connector.DisconnectAsync();

                result = connector.ConnectAsync();
                if (result.Result)
                {
                    Console.WriteLine($"Количество строк в {tablename}: {data.Rows.Count}");
                }
                connector.DisconnectAsync();
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
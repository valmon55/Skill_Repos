using ADO_NET.Library;
using System.Diagnostics;

namespace ADO_NET.Prog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connector = new MainConnector();
            var result = connector.ConnectAsync();

            if (result.Result)
            {
                Console.WriteLine("Подключено успешно!");
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
using ADO_NET.Library;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ADO_NET.Prog
{
    public class Program
    {
        static Manager manager;
        public enum Commands 
        { 
            stop,
            add,
            delete,
            update,
            show
        };
        public static void Main(string[] args)
        {
            manager = new Manager();

            manager.Connect();
            
            Console.WriteLine("Список команд для работы консоли:");
            Console.WriteLine(Commands.stop + ": прекращение работы");
            Console.WriteLine(Commands.add + ": добавление данных");
            Console.WriteLine(Commands.delete + ": удаление данных");
            Console.WriteLine(Commands.update + ": обновление данных");
            Console.WriteLine(Commands.show + ": просмотр данных");

            string command;
            do
            {
                Console.WriteLine("Введите команду:");
                command = Console.ReadLine();
                Console.WriteLine();
                switch(command)
                {
                    case nameof(Commands.stop):
                        break;
                    case nameof(Commands.add):
                        Add();
                        break;
                    case nameof(Commands.delete):
                        Delete();
                        break;
                    case nameof(Commands.update):
                        Update();
                        break;
                    case nameof(Commands.show):
                        manager.ShowData();
                        break;
                    default:
                        Console.WriteLine("Неверная комманда!");
                        break;
                }
            }
            while (command != nameof(Commands.stop));

            manager.Disconnect();

            if (Debugger.IsAttached)
                Console.ReadKey();
        }
        static void Update()
        {
            Console.WriteLine("Введите логин для обновления:");
            var login = Console.ReadLine();
            Console.WriteLine("Введите имя для обновления:");
            var name = Console.ReadLine();
            manager.UpdateUser(name, login);
            manager.ShowData();
        }
        static void Add()
        {
            Console.WriteLine("Введите логин для добавления:");
            var login = Console.ReadLine();
            Console.WriteLine("Введите имя для добавления:");
            var name = Console.ReadLine();
            manager.AddUser(name, login);
            manager.ShowData();
        }
        static void Delete()
        {
            Console.WriteLine("Введите логин для удаления:");
            var deleted = manager.DeleteUserByLogin(Console.ReadLine());
            Console.WriteLine($"Удалено {deleted.ToString()} строк");
            manager.ShowData();
        }
    }
}
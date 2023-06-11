namespace CS_Basic.Module_5_Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            ShowData(InputData());
        }
        static (string name, string lastname, int age, bool has_pet, string[] pet_nicknames, string[] favcolors) UserData;
        
        static (string name, string lastname, int age, bool has_pet, string[] pet_nicknames, string[] favcolors) InputData()
        {
            return UserData;
        }

        static void ShowData((string name, string lastname, int age, bool has_pet, string[] pet_nicknames, string[] favcolors) user_data)
        { 
            
        }
    }
}
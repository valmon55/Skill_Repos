﻿namespace CS_Basic.Module_5_Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowData(InputData());
        }
        static (string name, string lastname, int age, string[] pet_nicknames, string[] favcolors) UserData;
        
        static (string name, string lastname, int age, string[] pet_nicknames, string[] favcolors) InputData()
        {
            Console.WriteLine("Ваше имя?");
            UserData.name = Console.ReadLine();

            Console.WriteLine("Ваша фамилия?");
            UserData.lastname = Console.ReadLine();

            Console.WriteLine("Ваш возраст?");
            UserData.age = InputCorrectNumber();

            Console.WriteLine("Есть питомец? (да/ другое = нет)");

            if(Console.ReadLine() == "да" ? true : false) 
            {
                Console.WriteLine("Сколько у вас питомцев?");
                UserData.pet_nicknames = InputPets(InputCorrectNumber());
            }

            Console.WriteLine("Сколько у вас любимых цветов?");
            UserData.favcolors = InputFavColors(InputCorrectNumber());

            return UserData;
        }

        static void ShowData((string name, string lastname, int age, string[] pet_nicknames, string[] favcolors) user_data)
        {
            Console.WriteLine("Имя " + user_data.name);
            Console.WriteLine("Фамилия " + user_data.lastname);
            Console.WriteLine("Возраст " + user_data.age.ToString());

            if (user_data.pet_nicknames != null)
            {
                Console.WriteLine("Имена питомцев:");
                foreach (string pet in user_data.pet_nicknames)
                {
                    Console.WriteLine(pet);
                }
            }
            if (user_data.favcolors != null)
            {
                Console.WriteLine("Любимые цвета:");
                foreach (string color in user_data.favcolors)
                {
                    Console.WriteLine(color);
                }
            }
        }

        static string[] InputPets(int count)
        {
            string[] pets = new string[count];
            for(int i = 0; i < pets.Length; i++) 
            { 
                Console.WriteLine("Введите имя питомца №" + i.ToString());
                pets[i] = Console.ReadLine();
            }

            return pets;
        }

        static string[] InputFavColors(int count)
        {
            string[] f_colors = new string[count];
            for (int i = 0; i < f_colors.Length; i++)
            {
                Console.WriteLine("Введите название цвета №" + i.ToString());
                f_colors[i] = Console.ReadLine();
            }

            return f_colors;
        }
        static int InputCorrectNumber()
        {
            int i = 0;
            while(!int.TryParse(Console.ReadLine(), out i) || i <= 0)
            {
                Console.WriteLine("Неверное значение! Число должно быть > 0");
            }    

            return i;
        }

    }
}
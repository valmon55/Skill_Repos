using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var contacts = new List<Contact>()
            {
               new Contact() { Name = "Андрей", Phone = 7999945005 },
               new Contact() { Name = "Сергей", Phone = 799990455 },
               new Contact() { Name = "Иван", Phone = 79999675 },
               new Contact() { Name = "Игорь", Phone = 8884994 },
               new Contact() { Name = "Анна", Phone = 665565656 },
               new Contact() { Name = "Василий", Phone = 3434 }
            };

            

            while(true)
            {
                var key = Console.ReadKey().KeyChar;
                Console.Clear();

                IEnumerable<Contact> page = null;

                switch (key)
                {
                    case '1':
                        page = contacts.Take(2);
                        break;
                    case '2':
                        page = contacts.Skip(2).Take(2);
                        break;
                    case '3':
                        page = contacts.Skip(4).Take(2);
                        break;
                }

                if(page != null)
                    foreach (Contact contact in page)
                        Console.WriteLine(contact.Name + " - " + contact.Phone.ToString());

            }
        }
    }
}

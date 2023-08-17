using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Dictionary
{
    class Program
    {
        //Contact contact;
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();

            Dictionary<string, Contact> contactDict = new Dictionary<string, Contact>()
            {

                ["Patric"] = new Contact(1111, "123@cbi.com"),
                ["Rigsby"] = new Contact(1222, "223@cbi.com"),
            };
            Console.WriteLine("Список контактов");
            foreach (var contact in contactDict)
            {
                Console.WriteLine($"NAME {contact.Key} PHONE {contact.Value.PhoneNumber} EMAIL {contact.Value.EMail}");
            }

            if (!contactDict.ContainsKey("Lisbon"))
                contactDict.Add("Lisbon", new Contact(1234, "1234@cbi.com"));

            Console.WriteLine("Обновленный список контактов");
            foreach (var contact in contactDict)
            {
                Console.WriteLine($"NAME {contact.Key} PHONE {contact.Value.PhoneNumber} EMAIL {contact.Value.EMail}");
            }

            //contactDict.TryGetValue("Lisbon", out Contact contact);
            if (contactDict.ContainsKey("Lisbon"))
                contactDict["Lisbon"].PhoneNumber = 1212;

            Console.WriteLine("Список контактов после изменения");
            foreach (var contact in contactDict)
            {
                Console.WriteLine($"NAME {contact.Key} PHONE {contact.Value.PhoneNumber} EMAIL {contact.Value.EMail}");
            }

            Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);
            Console.ReadKey();

        }
        static void AddUnique(Contact contact, ref Dictionary<int,Contact> phoneBook)
        {
            try
            {
                bool isUnique = false;
                int i = 0;
                int key = i;

                //
                while (!isUnique && i < phoneBook.Count)
                {
                    if (!phoneBook.ContainsValue(contact))
                        isUnique = true;
                    i++;
                }

                phoneBook.Add(key,contact);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return;
        }
    }
}

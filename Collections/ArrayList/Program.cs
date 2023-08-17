using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace ArrayList_sample
{
    class Program
    {
        Contact contact;
        static void Main(string[] args)
        {
            List<Contact> contactList = new List<Contact>
                {
                    new Contact("Patric", 1111, "123@cbi.com"),
                    new Contact("Rigsby", 1222, "223@cbi.com"),
                    new Contact("Lisbon", 1112, "124@cbi.com"),
                };
            AddUnique(new Contact("Patric", 1234, "123@cbi.com"),ref contactList);
            AddUnique(new Contact("Patric", 9234, "123@cbi.com"), ref contactList);

            //contactList.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));
            foreach (Contact contact in contactList)
            {
                Console.WriteLine($"NAME {contact.Name} PHONE {contact.PhoneNumber} EMAIL {contact.EMail}");
            }
            ////ArrayList arr = new ArrayList { 1, "1st ", 2, 3, 5, " 2nd ", " 3-rd" };
            ////SumAndConcat(arr);
            //Months();

            Console.ReadKey();
        }
        //13.3.4
        static void AddUnique(Contact contact,ref List<Contact> phoneBook)
        {
            try
            {
                bool isUnique = false;
                int i = 0;

                while (!isUnique && i < phoneBook.Count)
                {
                    if (phoneBook[i].Name != contact.Name
                        || phoneBook[i].PhoneNumber != contact.PhoneNumber
                        || phoneBook[i].EMail != contact.EMail
                        )
                        isUnique = true;
                    i++;
                }

                phoneBook.Add(contact);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return;
        }
        //13.2.6
        static ArrayList SumAndConcat(ArrayList input)
        {
            ArrayList res = new ArrayList();
            int sum = 0;
            string concat = string.Empty;
            for(int i = 0; i < input.Count; i++)
            {
                //Console.WriteLine(input[i].GetType());

                if (input[i].GetType().ToString() == "System.Int32")
                {
                    sum += (int)input[i];
                }
                if (input[i].GetType().ToString() == "System.String")
                {
                    concat += (string)input[i];
                }

            }
            res.Add(sum);
            res.Add(concat);

            foreach (Object o in res)
                Console.WriteLine(o);


            return res;
        }
        //13.2.5
        static void Months()
        {
            var months = new[] { "Jan", "Feb", "Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec" };
            var num = new[] {1,2,3,4,5,6,7,8,9,10,11,12 };
            ArrayList arr = new ArrayList();
            for(int i = 0; i < months.Length; i++)
            {
                arr.Add(months[i]);
                arr.Add(num[i]);
            }
            foreach (Object o in arr)
                Console.WriteLine(o);
        }
        static void Sample()
        {
            var list = new ArrayList() { 1, "nnn", new Random() };

            foreach (Object o in list)
            {
                Console.WriteLine(o);
            }

            Console.ReadKey();

        }
    }
}

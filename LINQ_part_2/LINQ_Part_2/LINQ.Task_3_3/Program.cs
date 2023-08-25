namespace LINQ.Task_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", 799900000013, "serg@gmail.com"));
            phoneBook.Add(new Contact("Иннокентий", 799900000013, "innokentii@example.com"));

            var contacts = phoneBook.Select(p => p)
                                    .GroupBy(p => p.Email.Contains("example")
                                            )
                                    .Select(g => new
                                    {
                                        IsFake = g.Key,
                                        Contacts = g.Select(p => p)
                                    }
                                    );
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact.IsFake);
                foreach (var c in contact.Contacts)
                    Console.WriteLine($"{c.Name} {c.Phone} {c.Email}");
            }
            Console.ReadKey();
        }
    }
}
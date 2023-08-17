using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_sample
{
    public class Contact
    {
        public Contact(string name, long phoneNumber,string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            EMail = email;
        }
        public String Name { get; }
        public long PhoneNumber { get; }
        public String EMail { get; }

    }
}

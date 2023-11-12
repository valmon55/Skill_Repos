using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET.Prog
{
    public class Table
    {
        public Table() 
        { 
            Fields = new List<string>();
        }
        public List<string> Fields { get; set; }
        public string Name { get; set; }
        public string ImportantField { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET.Library.Configurations
{
    public static class ConnectionString
    {
        //public static string MsSqlConnection => @"Server=NORKA\SQLEXPRESS;Database=TestDB;Trusted_Connection=True;";
        public static string MsSqlConnection => @"Data Source=NORKA\SQLEXPRESS;Initial Catalog=TestDB;" +
            //"Persist Security Info=False;" +
            "Integrated Security = true;" +
            //"User ID=yacoo;" +
            //"Password=0607;" +
            "Trust Server Certificate=True";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET.Library.Configurations
{
    public static class ConnectionString
    {
        public static string MsSqlConnection => @"Server=NORKA\SQLEXPRESS;Database=TestDB;Trusted_Connection=True;";
    }
}

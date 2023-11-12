﻿using ADO_NET.Library;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ADO_NET.Prog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var manager = new Manager();

            manager.Connect();
            manager.ShowData();
            manager.Disconnect();

            if(Debugger.IsAttached)
                Console.ReadKey();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1
{
    class City
    {
        public City(string name, long population)
        {
            Name = name;
            Population = population;
        }

        public string Name { get; set; }
        public long Population { get; set; }

    }
}

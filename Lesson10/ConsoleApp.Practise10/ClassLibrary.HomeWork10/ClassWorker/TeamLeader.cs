﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public class TeamLeader
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public TeamLeader(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}

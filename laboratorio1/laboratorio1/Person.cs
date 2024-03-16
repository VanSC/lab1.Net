﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio1
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string GetFullName()
        { 
            return Name + " " + LastName;
        }

        public bool EsMayorEdad()
        {
            return Age > 18;
        }

    }
}

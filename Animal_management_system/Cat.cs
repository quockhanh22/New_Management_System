﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_management_system
{
    internal class Cat : Program
    {
        int id;
        string name;
        int age;
        public int ID
        {
            set
            {
                id = value;
            }
            get
            {
                return id;

            }

        }
        public string Name
        {
            set
            {
                name = value;

            }
            get
            {
                return name;
            }
        }
        public int Age
        {
            set
            {
                age = value;

            }
            get
            {
                return age;
            }
        }



        public void Move()
        {
            Console.WriteLine("run");
        }
        public override string ToString()
        {
            Console.WriteLine(GetType());
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            return "";
        }
    }
 
}
    

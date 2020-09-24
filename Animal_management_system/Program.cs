﻿using System;
using System.Drawing;

namespace Animal_management_system
{
    class Program
    {
            
      
           interface IAnimal
   
        {
           
       int ID{get;set;}
            string Name{get;set;}
            int Age { get; set; }
        }
        interface ITerrestrialAnimal : IAnimal
        {
            void Move();
        }
        interface IMarineAnimal : IAnimal
        {
            void Move();
        }
        
        }
            
}

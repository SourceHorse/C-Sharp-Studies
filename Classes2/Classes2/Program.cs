﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes2.Math;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ross = new Person();
            ross.FirstName = "Ross";
            ross.LastName = "Scarborough";
            ross.Age = 32;
            ross.FavoriteShow = "Game of Thrones";
            ross.Introduce();


            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(3,5));
            Console.WriteLine(calculator.Subtract(7,2));
        }
    }
}

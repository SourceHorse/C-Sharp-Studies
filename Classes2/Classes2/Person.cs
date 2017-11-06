using System;
using System.Runtime.InteropServices;


namespace Classes2
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public byte Age;
        public string FavoriteShow;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName + ".");
            Console.WriteLine("I am " + Age + " years old.");
            Console.WriteLine("My favorite show is " + FavoriteShow + ".");
        }

        
    }
}
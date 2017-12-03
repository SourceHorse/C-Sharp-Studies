﻿using System;

namespace accessModifers
{
    public class Person
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }


        //public void SetBirthdate(DateTime birthdate)
        //{
        //    _birthdate = birthdate;
        //}

        //public DateTime GetBirthdate()
        //{
        //    return _birthdate;
        //}

        //public void SetName(string name)
        //{
        //    if (!String.IsNullOrWhiteSpace(name))
        //    {
        //        this._name = name;
        //    }
        //}

        //public string GetName()
        //{
        //    return _name;
        //}
    }
}
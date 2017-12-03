using System;

namespace accessModifers
{
    public class Person
    {
        private string _name;

        public DateTime Birthdate { get; set; }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                        _name = value;
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
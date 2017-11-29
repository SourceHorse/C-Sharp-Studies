using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IntClasses
{
    class Customer
    {
        public string Name;
        public int ID;
        public bool Prime;

        public Customer()
        {
        }

        public Customer(string name)
        {
            this.Name = name;
        }

        public Customer(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public Customer(bool prime, int id, string name)
        {
            this.Prime = prime;
            this.ID = id;
            this.Name = name;
        }
    }
}

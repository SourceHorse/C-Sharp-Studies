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
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }
        
        public Customer(string name)
            : this()
        {
            this.Name = name;
        }

        public Customer(string name, int id)
            : this(name)
        {
            this.ID = id;
        }
    }
}

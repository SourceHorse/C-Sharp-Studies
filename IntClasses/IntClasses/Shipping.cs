using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntClasses
{
    public class Shipping
    {
        public string FreeShipping(bool prime)
        {
            if (prime)
            {
                return "This customer is elidgible for free shipping.";
            }
                return "Free shipping is reserved for prime members";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLib_v1._0
{
    public class Order
    {   
        public int rn { get; private set; }
        public long phone { get; private set; }
        
        public Order(int rn, long phone)
        {
            this.phone = phone;
            this.rn = rn;
        }
    }
}

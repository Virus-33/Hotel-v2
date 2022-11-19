using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLib_v1._0
{
    public class OrderList
    {
        public List<Order> orders
        {
            get;
            private set;
        }
        public OrderList()
        {
            this.orders = new();
        }

        public void Read(List<Order> temp)
        {
            this.orders.Clear();
            this.orders = temp;
        }

        public void RO(long num)
        {
            int stopper = this.orders.Count;

            for (int i = 0; i < stopper; i++)
            {
                if (this.orders[i].phone == num)
                {
                    this.orders.RemoveAt(i);
                    stopper--;
                }
            }
        }
    }
}

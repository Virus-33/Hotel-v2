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
            orders = new();
        }

        public void Read(string path)
        {
            orders.Clear();
            orders = FileWorks.RJ(path);
        }
    }
}

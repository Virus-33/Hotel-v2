using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLib_v1._0
{
    public class Hotel
    {
        string J_Path;
        string Bd_path;
        private Reception Re;
        private OrderList J;

        

        public Hotel(string path, string a_path)
        {
            Bd_path = path;
            J_Path = a_path;
            J = new();
            Re = new(Bd_path);
        }

        public bool CancelBookingByPN(long num)
        {

            J.Read(J_Path);

            return Re.Unbook(J.orders, num);


        }

        public int Order(string h)
        {
            if (h != "q")
            {
                if (IsNum(h))
                {
                    if (Re.BookByNum(int.Parse(h)) == 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            } else
            {
                return 2;
            }
        }

        public void NewOrder(int rn, long phone)
        {
            J.orders.Add(new Order(rn, phone));
        }

        public List<Order> GO()
        {
            return J.orders;
        }

        public int Phone(string s)
        {
            if (s != "q")
            {
                long a;
                if (IsNum(s, out a))
                {
                    return Re.Phone(a);
                }
                else
                {
                    return 0;
                }
            } else
            {
                return 2;
            }
        }

        public List<Room> GR()
        {
            return Re.Rooms;
        }

        public void DO()
        {
            J.orders.Clear();
        }

        public void BookRoom(int rn)
        {
            Re.BookByNum(rn);
        }

        public void ReadJ()
        {
            J.Read(J_Path);
        }

        bool IsNum(string a)
        {
            return int.TryParse(a, out _);
        }

        bool IsNum(string a, out long r)
        {
            return long.TryParse(a, out r);
        }
    }
}

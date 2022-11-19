using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLib_v1._0
{
    public class Hotel
    {
        private Reception Re;
        private OrderList J;

        public Hotel()
        {
            J = new();
            Re = new();
        }

        public bool CancelBookingByPN(long num)
        {

            if (Re.Unbook(J.orders, num))
            {
                J.RO(num);

                return true;
            }

            return false;
        }

        public int Order(int h)
        {
            return Re.BookByNum(h);
        }

        public void NewOrder(int rn, long phone)
        {
            J.orders.Add(new Order(rn, phone));
        }

        public List<Order> GO()
        {
            return J.orders;
        }

        public List<Room> GR()
        {
            return Re.Rooms;
        }

        public void BookRoom(int rn)
        {
            Re.BookByNum(rn);
        }

        public void ReadJ(List<Order> temp)
        {
            J.Read(temp);
        }

        public void RemRooms(List<Room> list)
        {
            Re.FormRoomList(list);
        }
    }
}

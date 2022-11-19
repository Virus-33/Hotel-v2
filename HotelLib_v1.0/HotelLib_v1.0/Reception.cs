using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLib_v1._0
{
    public class Reception
    {
        public List<Room> Rooms
        {
            get;
            private set;
        }

        public Reception()
        {
            this.Rooms = new();
        }

        public void FormRoomList(List<Room> temp)
        {
            this.Rooms = temp;
        } 

        public bool CheckRoomBook(int num)
        {
            Room r;
            return CheckRoom(num, out r) && r.status == CurStat.booked;
        }

        public bool Unbook(List<Order> Orders, long phone)
        {
            bool flag = false;
            if (Orders.Count > 0)
            {
                foreach (Order order in Orders)
                {
                    if (order.phone == phone)
                    {
                        UnbookByNum(order.rn);
                        flag = true;
                    }
                }
            }

            return flag;
        }

        private void UnbookByNum(int num)
        {
            foreach (Room room in Rooms)
            {
                if (room.Num == num)
                {
                    room.Unbook();
                }
            }
        }

        public int BookByNum(int num)
        {
            foreach (Room room in Rooms)
            {
                if (room.Num == num)
                {
                    if (CheckRoom(num))
                    {
                        room.Book();
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            return 0;
        }

        bool CheckRoom(int num)
        {
            bool res = false;

            foreach (Room room in Rooms)
            {
                if (room.Num == num)
                {
                    if (room.status == 0)
                    {
                        res = true;
                        break;
                    }
                }
            }

            return res;
        }

        bool CheckRoom(int num, out Room OR)
        {
            bool res = false;
            OR = null;
            foreach (Room room in Rooms)
            {
                if (room.Num == num)
                {
                    if (room.status == 0)
                    {
                        OR = room;
                        res = true;
                        break;
                    }
                }
            }

            return res;
        }

    }
}

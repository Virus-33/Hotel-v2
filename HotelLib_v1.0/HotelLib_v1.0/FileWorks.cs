using System;
using System.Collections.Generic;
using System.IO;

namespace HotelLib_v1._0
{
    public static class FileWorks
    {
        public static List<Room> GetRooms(string path)
        {
            List<Room> rooms = new();
            string s;
            using (StreamReader SR = new(path))
            {
                while ((s = SR.ReadLine()) != null)
                {
                    string[] temp = s.Split(' ');

                    rooms.Add(new Room(int.Parse(temp[0]), temp[1], int.Parse(temp[2]), (CurStat) Enum.Parse(typeof(CurStat), temp[3])));
                }
            }

            return rooms;
        }

        public static void WriteRooms(List<Room> rooms, string path)
        {
            using (StreamWriter SW = new StreamWriter(path, false))
            {
                foreach (Room room in rooms)
                {
                    SW.WriteLine("{0} {1} {2} {3}\n", room.Num.ToString(), room.type, room.price.ToString(), room.status);
                }
            }
        }

        public static bool CheckFile(string path)
        {
            return File.Exists(path);
        }

        public static void WJ(string path, List<Order> orders)
        {
            using (StreamWriter SW = new(path, true))
            {
                foreach (Order or in orders)
                {
                    SW.WriteLine("{0}\t{1}\n", or.rn, or.phone);
                }
            }
        }
        public static List<Order> RJ(string path)
        {
            List<Order> orders = new();

            using (StreamReader SR = new StreamReader(path))
            {
                SR.ReadLine();
                string h;
                while ((h = SR.ReadLine()) != null)
                {
                    if (h != "")
                    {
                        string[] j = h.Split('\t');
                        orders.Add(new Order(int.Parse(j[0]), long.Parse(j[1])));
                    }
                }
            }
            return orders;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLib_v1._0
{
    public class Dewitt
    {
        public void BookByNum(List<Room> rooms, int num)
        {
            foreach (Room room in rooms)
            {
                if (room.Num == num)
                {
                    room.Book();
                    break;
                }
            }
        }
        public bool CheckRoom(List<Room> rooms, int num)
        {
            bool res = false;

            foreach (Room room in rooms)
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

        public void Phone(MessageBlock mb)
        {
        pog:
            mb.Phone1();
            Console.ForegroundColor = ConsoleColor.Yellow;
            string g = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;

            if (!Checkphone(g))
            {
                mb.PhoneE();
                Console.ReadKey(true);
                goto pog;

            }
        }

        bool Checkphone(string inputs)
        {
            bool res = long.TryParse(inputs, out _);

            return res && inputs.Length == 11;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLib_v1._0
{
    public class Inputs
    {
        public static char GetChar()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

            return key.KeyChar;
        }

        public static string GetNum()
        {
            string res = Console.ReadLine();

            return res;
        }
    }
}

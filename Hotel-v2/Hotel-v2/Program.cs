using System;
using System.IO;
using HotelLib_v1._0;
using FileAccess;
using System.Collections.Generic;

namespace Hotel_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (args.Length == 2 && FileWorks.CheckFile(args[0]) && FileWorks.CheckFile(args[1]))
            {
                List<Room> temp;
                List<Order> temp1;
                Hotel H = new();
                char key;
                bool c = true;
                
                while (c)
                {
                    MessageBlock.Clear();
                    MessageBlock.MainSCR();
                    while (true)
                    {
                        
                        key = Inputs.GetChar();
                        if ('1' <= key && key <= '4')
                        {
                            break;
                        }
                    }
                    int respond;
                    switch (key)
                    {
                        case '1':
                            temp = FileWorks.GetRooms(args[0]);
                            H.RemRooms(temp);
                            MessageBlock.ShowRooms(H.GR());
                            MessageBlock.Prompt();
                            Inputs.GetChar();
                            break;
                        case '2':
                            temp = FileWorks.GetRooms(args[0]);
                            H.RemRooms(temp);
                            MessageBlock.BookingNum(H.GR());
                            string h = Inputs.GetNum();
                            if (h != "q")
                            {
                                int k;
                                if (int.TryParse(h, out k))
                                {
                                    respond = H.Order(k);
                                    if (respond == 0)
                                    {
                                        MessageBlock.RE();
                                    }
                                    else
                                    {
                                        while (true)
                                        {
                                            MessageBlock.Phone1();
                                            string phone = Inputs.GetNum();
                                            respond = Phone(phone);
                                            if (respond == 0)
                                            {
                                                MessageBlock.PhoneE();
                                            }
                                            else
                                            {
                                                MessageBlock.Phone2();
                                                H.NewOrder(int.Parse(h), long.Parse(phone));
                                                FileWorks.WJ(args[1], H.GO());
                                                H.BookRoom(int.Parse(h));
                                                FileWorks.WriteRooms(H.GR(), args[0]);
                                                Inputs.GetChar();
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                        case '3':
                            while (true)
                            {
                                temp = FileWorks.GetRooms(args[0]);
                                H.RemRooms(temp);
                                MessageBlock.PB();
                                MessageBlock.QI();
                                string Gogi = Inputs.GetNum();
                                if (Gogi != "q")
                                {
                                    respond = Phone(Gogi);
                                    if (respond == 0)
                                    {
                                        MessageBlock.PhoneE();
                                    }
                                    else if (respond == 2)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        temp1 = FileWorks.RJ(args[1]);
                                        H.ReadJ(temp1);
                                        bool resp = H.CancelBookingByPN(long.Parse(Gogi));
                                        if (resp)
                                        {
                                            MessageBlock.BC();
                                            FileWorks.WJ(args[1], H.GO());
                                            FileWorks.WriteRooms(H.GR(), args[0]);
                                        }
                                        else
                                        {
                                            MessageBlock.URE();
                                        }
                                        Inputs.GetChar();
                                        break;
                                    }
                                } else
                                {
                                    break;
                                }
                            }
                            break;
                        case '4':
                            c = false;
                            break;
                    }
                }

            }
            else
            {
                MessageBlock.FE();
                Inputs.GetChar();
            }
        }

        public static int Phone(string num)
        {
            if (long.TryParse(num, out _) && !Checkphone(num))
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        static bool Checkphone(string inputs)
        {
            return inputs.Length == 11;
        }
    }
}

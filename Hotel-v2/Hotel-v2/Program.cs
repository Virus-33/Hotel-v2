using System;
using System.IO;
using HotelLib_v1._0;
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
                Hotel H = new(args[0], args[1]);
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
                            MessageBlock.ShowRooms(H.GR());
                            MessageBlock.Prompt();
                            Inputs.GetChar();
                            break;
                        case '2':
                            MessageBlock.BookingNum(H.GR());
                            string h = Inputs.GetNum();
                            respond = H.Order(h);
                            if (respond == 0)
                            {
                                MessageBlock.RE();
                            }
                            else if (respond == 2)
                            {
                                
                            }
                            else
                            {
                                while (true)
                                {
                                    MessageBlock.Phone1();
                                    string phone = Inputs.GetNum();
                                    respond = H.Phone(phone);
                                    if (respond == 0)
                                    {
                                        MessageBlock.PhoneE();
                                    }
                                    else
                                    {
                                        MessageBlock.Phone2();
                                        H.NewOrder(int.Parse(h), long.Parse(phone));
                                        FileWorks.WJ(args[1], H.GO());
                                        H.DO();
                                        H.BookRoom(int.Parse(h));
                                        FileWorks.WriteRooms(H.GR(), args[0]);
                                        break;
                                    }
                                }
                            }
                            break;
                        case '3':
                            while (true)
                            {
                                MessageBlock.PB();
                                MessageBlock.QI();
                                string Gogi = Inputs.GetNum();
                                respond = H.Phone(Gogi);
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
                                    bool resp = H.CancelBookingByPN(long.Parse(Gogi));
                                    if (resp)
                                    {
                                        MessageBlock.BC();
                                        FileWorks.WJ(args[1], H.GO());
                                    }
                                    else
                                    {
                                        MessageBlock.URE();
                                    }
                                    Inputs.GetChar();
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
    }
}

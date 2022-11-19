using System;
using System.Collections.Generic;


namespace HotelLib_v1._0
{
    public static class MessageBlock
    {
        public static void FE()
        {
            Console.WriteLine("File path not found.\nPress any key to exit");
        }

        public static void MainSCR()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Paradigma Hotel booking program.\nPlease, select menu item you need");
            Console.WriteLine();
            Console.WriteLine("1. Show aviable room list");
            Console.WriteLine("2. Book a room");
            Console.WriteLine("3. Cancel book");
            Console.WriteLine("4. Exit");
        }

        public static void ShowRooms(List<Room> rooms)
        {
            Console.Clear();
            Console.WriteLine("Aviable room list:\n");
            Console.WriteLine("Room\tType\tPrice\tStatus");
            foreach (Room r in rooms)
            {
                Console.WriteLine("{0}:\t{1}\t{2}\t{3}", r.Num, r.type, r.price, r.status);
            }
        }

        public static void Prompt()
        {
            Console.WriteLine("\nPress any key to go to menu");
        }

        public static void BookingNum(List<Room> rooms)
        {
            Console.Clear();
            Console.WriteLine("Please enter a number of a room you want to book");
            Console.WriteLine("Remember that you can book only \"aviable\" and \"empty\" rooms\n");
            ShowRooms(rooms);
            Console.WriteLine();
            Console.WriteLine("You can enter \"q\" key to cancel room booking");
        }

        public static void Phone1()
        {
            Console.WriteLine("Please enter your phone number below to confirm booking. Room will be booked for a while\n");
        }

        public static void Phone2()
        {
            Console.WriteLine("Room temporary booked for you, we will call you soon.\nRemember that if you didn't pick up, the book will be nullified");
        }

        public static void PB()
        {
            Console.WriteLine("Please enter your phone nubmer you used to book room");
        }

        public static void BC()
        {
            Console.WriteLine("All bookings canceled");
        }

        public static void UBE()
        {
            Console.WriteLine("Looks like you havn't booked any rooms yet");
        }

        public static void PhoneE()
        {
            Console.WriteLine("This is not how phone number looks like. Try again.");
        }

        public static void RE()
        {
            Console.WriteLine("\nRoom you wanted to book is not available or not existing");
        }

        public static void II()
        {
            Console.WriteLine("\nInvalid input");
        }

        public static void Clear()
        {
            Console.Clear();
        }

        public static void QI()
        {
            Console.WriteLine("\nYou can enter q to cancel");
        }

        public static void URE()
        {
            Console.WriteLine("\nNo rooms booked by this phone number");
        }

    }
}

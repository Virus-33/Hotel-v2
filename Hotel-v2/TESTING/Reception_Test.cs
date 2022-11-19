using HotelLib_v1._0;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TESTING
{
    [TestClass]
    public class Receptiopn_Test
    {
        [TestMethod]
        public void TestFormRoomList()
        {
            Reception Re = new();

            List<Room> expected = new() { new Room(1, "Stndrt", 500, CurStat.available), 
                new Room(2, "Stndrt", 500, CurStat.available), new Room(3, "Stndrt", 500, CurStat.available), new Room(4, "Stndrt", 500, CurStat.available) };

            Re.FormRoomList(expected);
            List<Room> actual = Re.Rooms;

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckRoomBook1()
        {
            bool expected = false;

            Reception Re = new();

            List<Room> k = new()
            {
                new Room(1, "Stndrt", 500, CurStat.available),
                new Room(2, "Stndrt", 500, CurStat.available),
                new Room(3, "Stndrt", 500, CurStat.available),
                new Room(4, "Stndrt", 500, CurStat.available)
            };

            Re.FormRoomList(k);

            bool actual = Re.CheckRoomBook(1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckRoomBook2()
        {
            bool expected = true;

            Reception Re = new();

            List<Room> k = new()
            {
                new Room(1, "Stndrt", 500, CurStat.booked),
                new Room(2, "Stndrt", 500, CurStat.available),
                new Room(3, "Stndrt", 500, CurStat.available),
                new Room(4, "Stndrt", 500, CurStat.available)
            };

            Re.FormRoomList(k);

            bool actual = Re.CheckRoomBook(1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckRoomBook3()
        {
            bool expected = false;

            Reception Re = new();

            List<Room> k = new()
            {
                new Room(1, "Stndrt", 500, CurStat.booked),
                new Room(2, "Stndrt", 500, CurStat.available),
                new Room(3, "Stndrt", 500, CurStat.available),
                new Room(4, "Stndrt", 500, CurStat.available)
            };

            Re.FormRoomList(k);

            bool actual = Re.CheckRoomBook(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBookByNum()
        {
            List<Room> expected = new()
            {
                new Room(1, "Stndrt", 500, CurStat.booked),
                new Room(2, "Stndrt", 500, CurStat.booked),
                new Room(3, "Stndrt", 500, CurStat.available),
                new Room(4, "Stndrt", 500, CurStat.available)
            };

            Reception Re = new();

            List<Room> k = new()
            {
                new Room(1, "Stndrt", 500, CurStat.booked),
                new Room(2, "Stndrt", 500, CurStat.available),
                new Room(3, "Stndrt", 500, CurStat.available),
                new Room(4, "Stndrt", 500, CurStat.available)
            };

            Re.FormRoomList(k);
            Re.BookByNum(2);

            List<Room> actual = Re.Rooms;

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBookByNum1()
        {
            int expected = 0;

            Reception Re = new();

            List<Room> k = new()
            {
                new Room(1, "Stndrt", 500, CurStat.booked),
                new Room(2, "Stndrt", 500, CurStat.available),
                new Room(3, "Stndrt", 500, CurStat.available),
                new Room(4, "Stndrt", 500, CurStat.available)
            };

            Re.FormRoomList(k);
            int actual = Re.BookByNum(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUbook()
        {
            List<Room> expected = new()
            {
                new Room(1, "Stndrt", 500, CurStat.booked),
                new Room(2, "Stndrt", 500, CurStat.available),
                new Room(3, "Stndrt", 500, CurStat.available),
                new Room(4, "Stndrt", 500, CurStat.available)
            };

            List<Order> ol = new()
            {
                new Order(1, 895),
                new Order(2, 891)
            };

            Reception Re = new();

            List<Room> k = new()
            {
                new Room(1, "Stndrt", 500, CurStat.booked),
                new Room(2, "Stndrt", 500, CurStat.booked),
                new Room(3, "Stndrt", 500, CurStat.available),
                new Room(4, "Stndrt", 500, CurStat.available)
            };

            Re.FormRoomList(k);
            Re.Unbook(ol, 891);
            List<Room> actual = Re.Rooms;

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUbook1()
        {
            bool expected = false;

            List<Order> ol = new()
            {
                new Order(1, 895),
                new Order(2, 891)
            };

            Reception Re = new();

            List<Room> k = new()
            {
                new Room(1, "Stndrt", 500, CurStat.booked),
                new Room(2, "Stndrt", 500, CurStat.booked),
                new Room(3, "Stndrt", 500, CurStat.available),
                new Room(4, "Stndrt", 500, CurStat.available)
            };

            Re.FormRoomList(k);
            bool actual = Re.Unbook(ol, 892);

            Assert.AreEqual(expected, actual);
        }
    }
}
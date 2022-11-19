using HotelLib_v1._0;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TESTING
{
    [TestClass]
    public class Journal_Test
    {
        OrderList jacob = new OrderList();

        List<Order> o = new List<Order>() { new Order(1, 89080980), new Order(2, 89), new Order(2, 89080980), new Order(3, 89080980), new Order(4, 90), new Order(5, 90) };

        [TestMethod]
        public void TestRead()
        {
            List<Order> expected = o;

            jacob.Read(o);
            List<Order> actual = jacob.orders;

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRO()
        {
            List<Order> expected = new List<Order>() { new Order(2, 89), new Order(4, 90), new Order(5, 90) };

            jacob.Read(o);
            jacob.RO(89080980);
            List<Order> actual = jacob.orders;

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRO2()
        {
            List<Order> expected = o;

            jacob.Read(o);
            jacob.RO(89080981);
            List<Order> actual = jacob.orders;

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
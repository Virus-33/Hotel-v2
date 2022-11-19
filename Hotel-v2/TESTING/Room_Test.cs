using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelLib_v1._0;

namespace TESTING
{
    [TestClass]
    public class Room_Test
    {
        Room a = new Room(400, "Stndrt", 5000, CurStat.available);

        [TestMethod]
        public void TestBook()
        {
            CurStat expected = CurStat.booked;

            a.Book();
            CurStat actual = a.status;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUnbook()
        {
            CurStat expected = CurStat.available;

            a.Unbook();
            CurStat actual = a.status;

            Assert.AreEqual(expected, actual);
        }
    }
}
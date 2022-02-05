using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting_Hometask
{
    [TestClass]
    public class RecentlyUsedListTests
    {
        [TestMethod]
        public void AddingItemTest()
        {
            var rul = new RecentlyUsedList();

            rul.AddRecord("First record");
            rul.AddRecord("Second record");

            Assert.AreEqual(rul.ReadRecord(1), "Second record");
            Assert.AreEqual(rul.ReadRecord(0), "First record");
        }

        [TestMethod]
        public void DuplicatePositioningTest()
        {
            var rul = new RecentlyUsedList();

            rul.AddRecord("First record");
            rul.AddRecord("Second record");
            rul.AddRecord("First record");

            Assert.AreEqual(rul.ReadRecord(1), "First record");
        }
    }
}

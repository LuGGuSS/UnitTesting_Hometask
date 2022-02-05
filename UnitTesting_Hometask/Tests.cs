using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting_Hometask
{
    [TestClass]
    public class RecentlyUsedListTests
    {
        public void AddingItemTest()
        {
            var rul = new RecentlyUsedList();

            rul.AddRecord("First record");
            rul.AddRecord("Second record");

            Assert.AreEqual(rul.ReadRecord(1), "Second record");
            Assert.AreEqual(rul.ReadRecord(0), "First record");
        }
    }
}

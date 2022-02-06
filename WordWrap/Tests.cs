using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordWrap
{ 
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void WrappingTest()
        {
            var ww = new WordWrap();

            var st = "Wrap this test";

            Assert.AreEqual(ww.Wrap(st,4), "W\nrap t\nhis t\next");
        }
    }
}

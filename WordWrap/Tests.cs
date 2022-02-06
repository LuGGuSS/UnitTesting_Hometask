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
            var st = "Wrap this text";

            Assert.AreEqual("W\nrap t\nhis t\next", WordWrap.Wrap(st, 1));
        }
    }
}

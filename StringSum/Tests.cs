using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringSum
{
    [TestClass]
    public class StringSumTests
    {
        [TestMethod]
        public void SumTest()
        {
            var strSum = new StringSum();

            Assert.AreEqual(strSum.Sum("10","1"), "11");
        }

    }
}

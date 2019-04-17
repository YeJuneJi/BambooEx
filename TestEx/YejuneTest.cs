using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEx
{
    [TestClass]
    public class YejuneTest
    {
        [TestMethod]
        public void Add()
        {
            Ex.YejuneEx2 ex = new Ex.YejuneEx2();
            Assert.AreEqual(31, ex.Add(20, 11));
        }

        [TestMethod]
        public void Sub()
        {
            Ex.YejuneEx2 ex = new Ex.YejuneEx2();
            Assert.AreEqual(10, ex.Sub(20, 10));
        }
    }
}

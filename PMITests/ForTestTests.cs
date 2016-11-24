using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI.Tests
{
    [TestClass()]
    public class ForTestTests
    {


        [TestMethod()]
        public void addTest()
        {
            ForTest x = new ForTest();
            int result = x.add(1, 1);
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void divTest()
        {
            ForTest x = new ForTest();
            double result = x.div(3, 2);
            Assert.AreEqual(1.5, result);
        }
    }
}
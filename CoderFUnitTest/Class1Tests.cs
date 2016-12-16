using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoderF.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderF.BLL.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void SquareTest()
        {
            Assert.IsTrue(new Class1().Square(2,8)==16);
        }
    }
}
    using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FedotkinNE.Sprint0.Task4.V0.Lib;
namespace Tyuiu.FedotkinNE.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAddictionValid()
        {
            Assert.AreEqual(10, DataService.Addiction(5, 5));
        }
        [TestMethod]
        public void CheckedSubstractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }
        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }
        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}

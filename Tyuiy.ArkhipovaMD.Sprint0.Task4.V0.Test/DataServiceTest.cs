using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiy.ArkhipovaMD.Sprint0.Task4.V0.Lib;

namespace Tyuiy.ArkhipovaMD.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        public void ChekedSubtractionValid()
        {
            Assert.AreEqual(0, DataService.Subtraction(5, 5));
        }
        public void ChekedMultiplicationValid()
        {
            Assert.AreEqual(25, DataService.Multiplication(5, 5));
        }
        public void ChekedDivisionValid()
        {
            Assert.AreEqual(1, DataService.Division(5, 5));
        }
    }
}

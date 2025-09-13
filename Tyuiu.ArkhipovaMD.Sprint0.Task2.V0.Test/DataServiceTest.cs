using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ArkhipovaMD.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ArkhipovaMD.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekGetMessageValid()
        {
            var name = "Meow";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет Meow/", res);
        }
    }
}

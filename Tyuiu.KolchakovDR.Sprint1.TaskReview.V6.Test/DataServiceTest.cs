using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint1.TaskReview.V6.Lib;
namespace Tyuiu.KolchakovDR.Sprint1.TaskReview.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-142.438, res);
        }
    }
}

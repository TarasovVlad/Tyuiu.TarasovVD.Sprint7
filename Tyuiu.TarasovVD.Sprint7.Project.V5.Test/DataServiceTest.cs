using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TarasovVD.Sprint7.Project.V5.Lib;

namespace Tyuiu.TarasovVD.Sprint7.Project.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMatrix()
        {
            DataService ds = new DataService();
            string path = @"C:\Project\ОПТОВАЯ БАЗА.csv";
            var result = ds.GetMatrix(path);


            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.GetLength(0));
            Assert.AreEqual(0, result.GetLength(1));

        }
    }
}

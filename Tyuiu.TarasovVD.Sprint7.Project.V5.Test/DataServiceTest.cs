using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TarasovVD.Sprint7.Project.V5.Lib;
using System.IO;
namespace Tyuiu.TarasovVD.Sprint7.Project.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMatrix()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\User\source\repos\Tyuiu.TarasovVD.Sprint7\Tyuiu.TarasovVD.Sprint7.Project.V5\bin\Debug\testfile.csv";
            string[,] res = ds.GetMatrix(path);
            string[,] wait = { { "1", "Часы", "12", "100", "Крутые", "001", "Антонов Антон Антонович", "30.03.2023" },
                               { "2", "Ноутбук", "10", "99.99", "Легкий и мощный ноутбук", "002", "Алексеев Алексей Алексеевич", "05.09.2023" }};
            CollectionAssert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestValidateFIO()
        {
            DataService ds = new DataService();
            string FIO = "Тарасов Владислав Денисович";
            string FIO1 = "Тарасов Владислав";
            string FIO2 = "Тарасов Владислав Денисович Иванович";
            string FIO3 = "Тарасов";
            bool result = ds.ValidateFIO(FIO);
            bool result1 = ds.ValidateFIO(FIO1);
            bool result2 = ds.ValidateFIO(FIO2);
            bool result3 = ds.ValidateFIO(FIO3);
            Assert.IsTrue(result);
            Assert.IsFalse(result1);
            Assert.IsFalse(result2);
            Assert.IsFalse(result3);
        }
        [TestMethod]
        public void TestValidateData()
        {
            DataService ds = new DataService();
            string Data = "30.03.2023";
            string Data1 = "30.13.2023";
            string Data2 = "32.03.2023";
            string Data3 = "30.03.23";
            string Data4 = "30.03.20233";
            string Data5 = "30032023";
            bool result = ds.ValidateData(Data);
            bool result1 = ds.ValidateData(Data1);
            bool result2 = ds.ValidateData(Data2);
            bool result3 = ds.ValidateData(Data3);
            bool result4 = ds.ValidateData(Data4);
            bool result5 = ds.ValidateData(Data5);     
            Assert.IsTrue(result);
            Assert.IsFalse(result1);
            Assert.IsFalse(result2);
            Assert.IsFalse(result3);
            Assert.IsFalse(result4);
            Assert.IsFalse(result5);
        }
    }
}

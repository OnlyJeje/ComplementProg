using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP2Partie2;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculatriceTest
    {
        [TestMethod]
        public void TestAddition()
        {
            int actual;

            Calculatrice maCalc = new Calculatrice();
            maCalc.Addition(1, 2);
            actual = maCalc.GiResultat;
            Assert.AreEqual(3, actual);
            maCalc.Addition(7, 12);
            actual = maCalc.GiResultat;
            Assert.AreEqual(19, actual);
            maCalc.Addition(56, 44);
            actual = maCalc.GiResultat;
            Assert.AreEqual(100, actual);
            maCalc.Addition(100, 200);
            actual = maCalc.GiResultat;
            Assert.AreEqual(100, actual);
        }

        [TestMethod]
        public void TestSoustraction()
        {
            int actual;

            Calculatrice maCalc = new Calculatrice();
            maCalc.Soustraction(1, 2);
            actual = maCalc.GiResultat;
            Assert.AreEqual(-1, actual);
            maCalc.Soustraction(10, 2);
            actual = maCalc.GiResultat;
            Assert.AreEqual(8, actual);
            maCalc.Soustraction(47, 26);
            actual = maCalc.GiResultat;
            Assert.AreEqual(21, actual);
            maCalc.Soustraction(100, 200);
            actual = maCalc.GiResultat;
            Assert.AreEqual(21, actual);
            maCalc.Soustraction(100, 33);
            Assert.AreEqual(77, actual);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            int actual;

            Calculatrice maCalc = new Calculatrice();
            maCalc.Multiplication(10, 30);
            actual = maCalc.GiResultat;
            Assert.AreEqual(300, actual);
            maCalc.Multiplication(10, 0);
            actual = maCalc.GiResultat;
            Assert.AreEqual(0, actual);
            maCalc.Multiplication(99, 99);
            actual = maCalc.GiResultat;
            Assert.AreEqual(9801, actual);
            maCalc.Multiplication(100, 100);
            actual = maCalc.GiResultat;
            Assert.AreEqual(10000, actual);
            maCalc.Multiplication(200, 600);
            actual = maCalc.GiResultat;
            Assert.AreEqual(120000, actual);
        }

        [TestMethod]
        public void TestDivision()
        {
            int actual;

            Calculatrice maCalc = new Calculatrice();
            maCalc.Division(10, 3);
            actual = maCalc.GiResultat;
            Assert.AreEqual(3, actual);
            maCalc.Division(10, 0);
            actual = maCalc.GiResultat;
            Assert.AreEqual(3, actual);
            maCalc.Division(4, 2);
            actual = maCalc.GiResultat;
            Assert.AreEqual(2, actual);
            maCalc.Division(100, 27);
            actual = maCalc.GiResultat;
            Assert.AreEqual(3, actual);
            maCalc.Division(745, 7);
            actual = maCalc.GiResultat;
            Assert.AreEqual(106, actual);
        }

    }
}

using NUnit.Framework;
using System;
using System.IO;
using CalcLib;
namespace CalcTestPr
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_x_plus_y()
        {
            //arrange
            int x = 10;
            int y = 20;
            int expected = 30;
            //act
            Calc c = new Calc();
            int actual = c.Sum(x, y);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_x_diff_y()
        {
            //arrange
            int x = 10;
            int y = 20;
            int expected = -10;
            //act
            Calc c = new Calc();
            int actual = c.Diff(x,y);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_x_div_y()
        {
            //arrange
            int x = 20;
            int y = 10;
            int expected = 2;
            //act
            Calc c = new Calc();
            double actual = c.Div(x, y);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_x_multi_y()
        {
            //arrange
            int x = 20;
            int y = 10;
            int expected = 200;
            //act
            Calc c = new Calc();
            double actual = c.Mul(x, y);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_x_Pow_y()
        {
            //arrange
            int x = 20;
            int y = 2;
            double expected = 400;
            //act
            Calc c = new Calc();
            double actual = c.Pow_x_y(x, y);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_x_Sqrt()
        {
            //arrange
            int x = 400;
            double expected = 20;
            //act
            Calc c = new Calc();
            double actual = c.Sqrt_x(x);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_S_Tringle()
        {
            //arrange
            int x = 20;
            int y = 30;
            int expected = 300;
            //act
            Calc c = new Calc();
            int actual = c.Tringle(x,y);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Sale()
        {
            //arrange
            int price = 100;
            int sale = 30;
            double expected = 70;
            //act
            Calc c = new Calc();
            double actual = c.Sale(price, sale);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Round_s()
        {
            //arrange
            int r = 100;
            double expected = r * Math.PI * Math.PI ;
            //act
            Calc c = new Calc();
            double actual = c.Round_s(r);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Round_pl()
        {
            //arrange
            int r = 100;
            double expected = 2*r * Math.PI;
            //act
            Calc c = new Calc();
            double actual = c.Round_pl(r);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}

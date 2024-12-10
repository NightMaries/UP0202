using LearnClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;
using System;

namespace LearnClasslibrary.Test
{
    [TestClass]
    public class LearnClassTest
    {
        [TestMethod]
        public void Test_TimeInSeconds()
        {
            //arrange
            int a = 2;
            int b = 3;

            int hr, min;

            int expected = 7380;

            //act
            LearnClass c = new LearnClass();
            int actual = c.TimeInSeconds(a, b);

            //assert
            Assert.AreEqual(expected, actual);

           
        }
        [TestMethod]
        public void Test_SecondsInTime()
        {
            //arrange

            int a = 2;
            int b = 3;

            int hr, min;

            int expected = 7380;

            //act
            LearnClass c = new LearnClass();

            //assert
            
            c.SecondInHoursAndMinuts(expected, out hr, out min);

            Assert.AreEqual(a, hr);

            Assert.AreEqual(b, min);
        }
    }
}

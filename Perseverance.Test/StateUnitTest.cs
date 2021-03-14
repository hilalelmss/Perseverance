using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Perseverance.Test
{
    [TestClass]
    public class StateUnitTest
    {
        [TestMethod]
        public void roverDirection_OK_Test_1()
        {
            Perseverance pers = new Perseverance(5, 5, 3, 3, 'E', "MMRMMRMRRM");
            //pers.xLocation = 3;
            //pers.yLocation = 3;
            //pers.Position = 'E';
            //pers.steps = "MMRMMRMRRM";
            //pers.xMax = 5;
            //pers.yMax = 5;
            pers.Run();
            Assert.AreEqual(pers.xLocation, 5);
            Assert.AreEqual(pers.yLocation, 1);
            Assert.AreEqual(pers.position, 'E');
        }

        [TestMethod]
        public void roverDirection_OK_Test_2()
        {
            Perseverance pers = new Perseverance(5, 5, 1, 2, 'N', "LMLMLMLMM");
            //pers.xLocation = 1;
            //pers.yLocation = 2;
            //pers.position = 'N';
            //pers.steps = "LMLMLMLMM";
            //pers.xMax = 5;
            //pers.yMax = 5;
            pers.Run();
            Assert.AreEqual(pers.xLocation, 1);
            Assert.AreEqual(pers.yLocation, 3);
            Assert.AreEqual(pers.position, 'N');
        }
    }
}
using System;
using BalancingTDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_01()
        {
            // input sin parentesis
            //Assemble
            bool expectedResult = false;

            //Act
            bool actualResult = Program.CheckParentesis("aaaaa");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod_02()
        {
            // input 1 parentesis abierto
            //Assemble
            bool expectedResult = false;

            //Act
            bool actualResult = Program.CheckParentesis("aa(aaa");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod_03()
        {
            // input 1 parentesis cerrado
            //Assemble
            bool expectedResult = false;

            //Act
            bool actualResult = Program.CheckParentesis("aaa)aa");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

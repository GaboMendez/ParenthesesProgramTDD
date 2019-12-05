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

        [TestMethod]
        public void TestMethod_04()
        {
            // input 1 parentesis abierto y 1 parentesis cerrado
            //Assemble
            bool expectedResult = true;

            //Act
            bool actualResult = Program.CheckParentesis("a(aa)aa");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod_05()
        {
            // input vacio
            //Assemble
            bool expectedResult = false;

            //Act
            bool actualResult = Program.CheckParentesis("");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod_06()
        {
            // input sin string
            //Assemble
            bool expectedResult = false;

            //Act
            bool actualResult = Program.CheckParentesis("123123123");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod_07()
        {
            // input con espacios en blanco
            //Assemble
            bool expectedResult = false;

            //Act
            bool actualResult = Program.CheckParentesis("              ");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod_08()
        {
            // input con 2 parentesis abiertos
            //Assemble
            bool expectedResult = false;

            //Act
            bool actualResult = Program.CheckParentesis("aaa(aa(");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod_09()
        {
            // input con 2 parentesis cerrados
            //Assemble
            bool expectedResult = false;

            //Act
            bool actualResult = Program.CheckParentesis("a)aa)aa");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod_10()
        {
            // input con 2 parentesis abiertos y 2 parentesis cerrado
            //Assemble
            bool expectedResult = true;

            //Act
            bool actualResult = Program.CheckParentesis("a(a(a)a)a");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod_11()
        {
            // input con 2 parentesis abiertos y 1 parentesis cerrado
            //Assemble
            bool expectedResult = false;

            //Act
            bool actualResult = Program.CheckParentesis("a(a(a)aa");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestMethod_12()
        {
            // input con 1 parentesis abiertos y 2 parentesis cerrado
            //Assemble
            bool expectedResult = false;

            //Act
            bool actualResult = Program.CheckParentesis("a(a)a)aa");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestMethod_13()
        {
            // input con 3 parentesis abiertos y 1 parentesis cerrado
            //Assemble
            bool expectedResult = false;

            //Act
            bool actualResult = Program.CheckParentesis("a(a(a(aa)");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod_14()
        {
            // input con 1 parentesis abiertos y 4 parentesis cerrado
            //Assemble
            bool expectedResult = false;

            //Act
            bool actualResult = Program.CheckParentesis("a(a)aa)a)a)");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod_15()
        {
            // input con par de parentesis abiertos y par de parentesis cerrado
            //Assemble
            bool expectedResult = true;

            //Act
            bool actualResult = Program.CheckParentesis("a(a)a(a)a(a)a(a)");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod_16()
        {
            // input con N parentesis abiertos
            //Assemble
            bool expectedResult = false;

            //Act
            bool actualResult = Program.CheckParentesis("(((((((a((((aaa((a");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod_17()
        {
            // input con N parentesis cerrados
            //Assemble
            bool expectedResult = false;

            //Act
            bool actualResult = Program.CheckParentesis("))aa))aaa))aa))");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



    }
}

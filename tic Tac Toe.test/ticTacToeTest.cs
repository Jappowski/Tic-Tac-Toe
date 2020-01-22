using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using WpfApp3;

namespace tic_Tac_Toe.test
{
    [TestClass]
    public class UnitTest1
    {
        MainWindow mainwindow = new MainWindow();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, MainWindow.turn, "ruch X");
            Assert.AreEqual(false, MainWindow.turn, "ruch O");
        }
    
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(false, MainWindow.grid1, "przyciski sa wylaczone");
        }
    }
}
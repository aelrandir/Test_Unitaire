using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tp_SystemFile;
using System.Collections.Generic;

namespace Test_Ls
{
    [TestClass]
    public class TestLs
    {
        [TestMethod]
        public void TestMethod1()
        {
            Directory C = new Directory("C:", null);
            File CurrentFile = C;
            Assert.AreEqual(C.file, CurrentFile.ls());
        }

        [TestMethod]
        public void TestMethod2()
        {
            Directory C = new Directory("C:", null);
            File CurrentFile = C;
            File Test = new File("Test", C);
            C.file.Add(Test);
            Assert.AreEqual(C.file, CurrentFile.ls());
        }

        [TestMethod]
        public void TestMethod3()
        {
            Directory C = new Directory("C:", null);
            Directory CurrentFile = C;
            Directory Test = new Directory("Test", C);
            C.file.Add(Test);
            Assert.AreEqual(C.file, CurrentFile.ls());
        }

        [TestMethod]
        public void TestMethod4()
        {
            Directory C = new Directory("C:", null);
            File CurrentFile = C;
            Directory Test = new Directory("Test", C);
            C.file.Add(Test);
            CurrentFile = CurrentFile.cd("Test");
            Assert.AreEqual(0, CurrentFile.ls().Count);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Directory C = new Directory("C:", null);
            File CurrentFile = C;
            File Test = new File("Test", C);
            C.file.Add(Test);
            CurrentFile = CurrentFile.cd("Test");
            Assert.AreEqual(null, CurrentFile.ls());
        }
    }
}

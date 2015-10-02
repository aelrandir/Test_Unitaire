using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tp_SystemFile;

namespace Test_GetPath
{
    [TestClass]
    public class TestGetPath
    {
        [TestMethod]
        public void TestMethod1()
        {
            Directory C = new Directory("C:", null);
            File CurrentFile = C;
            Assert.AreEqual("C:", CurrentFile.getPath());
        }
        [TestMethod]
        public void TestMethod2()
        {
            Directory C = new Directory("C:", null);
            File CurrentFile = C;
            Directory Test = new Directory("Test", C);
            C.file.Add(Test);
            CurrentFile = CurrentFile.cd("Test");
            Assert.AreEqual("C:\\Test", CurrentFile.getPath());
        }
        [TestMethod]
        public void TestMethod3()
        {
            Directory C = new Directory("C:", null);
            File CurrentFile = C;
            File Test = new File("Test", C);
            C.file.Add(Test);
            CurrentFile = CurrentFile.cd("Test");
            Assert.AreEqual("C:\\Test", CurrentFile.getPath());
        }
    }
}

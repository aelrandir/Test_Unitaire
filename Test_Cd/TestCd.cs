using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tp_SystemFile;

namespace Test_Cd
{
    [TestClass]
    public class TestCd
    {
        [TestMethod]
        public void TestMethod1()
        {
            Directory C = new Directory("C:", null);
            File CurrentFile = C;
            File Test = new File("Test", C);
            C.file.Add(Test);
            Assert.AreEqual(Test ,CurrentFile.cd("Test"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Directory C = new Directory("C:", null);
            Directory CurrentFile = C;
            Directory Test = new Directory("Test", C);
            C.file.Add(Test);
            Assert.AreEqual(Test, CurrentFile.cd("Test"));
        }
    }
}

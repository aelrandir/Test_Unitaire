using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tp_SystemFile;

namespace Test_IsDirectory
{
    [TestClass]
    public class TestIsDirectory
    {
        [TestMethod]
        public void TestMethod1()
        {
            Directory CurrentFile = new Directory("C:", null);
            Assert.IsTrue(CurrentFile.isDirectory());
        }

        [TestMethod]
        public void TestMethod2()
        {
            File CurrentFile = new File("C:", null);
            Assert.IsFalse(CurrentFile.isDirectory());
        }
    }
}

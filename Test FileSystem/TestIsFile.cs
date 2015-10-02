using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tp_SystemFile;

namespace Test_FileSystem
{
    [TestClass]
    public class TestIsFile
    {
        [TestMethod]
        public void TestMethod1()
        {
            Directory CurrentFile = new Directory("C:", null);
            Assert.IsFalse(CurrentFile.isFile());
        }

        [TestMethod]
        public void TestMethod2()
        {
            File CurrentFile = new File("C:", null);
            Assert.IsTrue(CurrentFile.isFile());
        }
    }
}

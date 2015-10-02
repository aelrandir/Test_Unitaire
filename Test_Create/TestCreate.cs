using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tp_SystemFile;

namespace Test_Create
{
    [TestClass]
    public class TestCreate
    {
        [TestMethod]
        public void TestMethod1()
        {
            Directory C = new Directory("C:", null);
            File CurrentFile = C;
            Assert.IsTrue(CurrentFile.createNewFile("NewFile"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            File C = new File("C:", null);
            File CurrentFile = C;
            Assert.IsFalse(CurrentFile.createNewFile("NewFile"));
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tp_SystemFile;

namespace Test_Mkdir
{
    [TestClass]
    public class TestMkdir
    {
        [TestMethod]
        public void TestMethod1()
        {
            Directory C = new Directory("C:", null);
            File CurrentFile = C;
            Assert.IsTrue(CurrentFile.mkdir("NewDirectory"));
        }
    }
}

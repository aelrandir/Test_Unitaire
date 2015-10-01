using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tp_SystemFile;
using System.Collections.Generic;

namespace Test_Ls
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<File> file = new List<File>();
            Directory C = new Directory("C:", null);
            File CurrentFile = C;
            Assert.AreEqual(null, CurrentFile.ls());
        }
    }
}

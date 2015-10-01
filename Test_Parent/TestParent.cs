using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tp_SystemFile;

namespace Test_Parent
{
    [TestClass]
    public class TestParent
    {
        [TestMethod]
        public void TestMethod1()
        {
            Directory C = new Directory("C:", null);
            File CurrentFile = C;
            Assert.AreEqual(null, CurrentFile.getParent());
        }
    }
}

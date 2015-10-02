using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tp_SystemFile;

namespace Test_Delete
{
    [TestClass]
    public class TestDelete
    {
        [TestMethod]
        public void TestMethod1()
        {
            Directory C = new Directory("C:", null);
            File CurrentFile = C;
            File Test = new File("test", C);
            C.file.Add(Test);
            Assert.IsTrue(CurrentFile.delete("test"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Directory C = new Directory("C:", null);
            File CurrentFile = C;
            Directory Test = new Directory("test", C);
            C.file.Add(Test);
            Assert.IsTrue(CurrentFile.delete("test"));
        }
    }
}

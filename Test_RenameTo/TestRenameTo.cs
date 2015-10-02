using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tp_SystemFile;

namespace Test_RenameTo
{
    [TestClass]
    public class TestRenameTo
    {
        [TestMethod]
        public void TestMethod1()
        {
            Directory C = new Directory("C:", null);
            File CurrentFile = C;
            File toto = new File("toto", C);
            C.file.Add(toto);
            CurrentFile.renameTo("toto", "titi");
            Assert.AreEqual("titi", C.file[0].name);
        }
    }
}

using Model;
using Model.Assembly;
using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ABtests
    {
        public string pathToDll()
        {
            return System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\dll\\TestAssembly.dll");
        }

        [TestMethod]
        public void TestMethod1()
        {
            AssemblyBrowser ab = AssemblyLoader.Load(pathToDll());
            Assert.IsTrue(ab.Name.StartsWith("TestAssembly"));
            Assert.AreEqual(ab.Namespaces.Count, 1);
            Assert.AreEqual(ab.Namespaces["TestAssembly"].Name, "TestAssembly");
            Assert.AreEqual(ab.Namespaces["TestAssembly"].Types.Count, 1);
            Assert.AreEqual(ab.Namespaces["TestAssembly"].Types[0].Name, "TestAssembly.Class12");
        }
    }
}

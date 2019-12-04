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
            Assert.AreEqual(ab.Namespaces.Count, 2);
            Assert.AreEqual(ab.Namespaces["namespace1"].Name, "namespace1");
            Assert.AreEqual(ab.Namespaces["namespace1"].Types.Count, 1);
            Assert.AreEqual(ab.Namespaces["namespace1"].Types[0].Name, "namespace1.Class1");
        }
    }
}

using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    /// <summary>
    /// Make a trace of the tests methods.
    /// The trace is written to a text file, since Test cannot easily do Console.WriteLine(...)
    /// Inspiration from http://msdn.microsoft.com/en-us/library/microsoft.visualstudio.testtools.unittesting.testinitializeattribute.aspx
    /// </summary>
    [TestClass]
    public class TestTrace
    {
        private static StreamWriter _toFile;
        private const string FileName = @"C:\temp\unittestTrace.txt";

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            _toFile = new StreamWriter(FileName);
            _toFile.WriteLine("AssemblyInit");
        }

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            _toFile.WriteLine("ClassInitialize");
        }

        [TestInitialize]
        public void Initialize()
        {
            _toFile.WriteLine("TestInitialize");
        }

        [TestCleanup]
        public void Cleanup()
        {
            _toFile.WriteLine("TestCleanup");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _toFile.WriteLine("ClassCleanup");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            _toFile.WriteLine("AssemblyCleanup");
            _toFile.Close();
        }

        [TestMethod]
        public void SomeTestMethod()
        {
            _toFile.WriteLine("SomeTestMethod");
        }

        [TestMethod]
        public void AnotherTestMethod()
        {
            _toFile.WriteLine("AnotherTestMethod");
        }
    }
}

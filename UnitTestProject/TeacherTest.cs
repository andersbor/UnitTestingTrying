using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TryingUnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class TeacherTest
    {
        private Teacher _teacher;

        [TestInitialize]
        public void BeforeTest()
        {
            _teacher = new Teacher("Anders", 100.25);
        }

        [TestMethod]
        public void TestName()
        {
            Assert.AreEqual("Anders", _teacher.Name);
            _teacher.Name = "John";
            Assert.AreEqual("John", _teacher.Name);

            Assert.AreEqual(100.25, _teacher.Salary, 0.0001);

            try
            {
                _teacher.Name = null;
                Assert.Fail();
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Name is null or empty", ex.Message);
            }
        }

        [TestMethod]
        public void TestSalary()
        {
            Assert.AreEqual(100.25, _teacher.Salary, 0.0001);
            _teacher.Salary = 200.34;
            Assert.AreEqual(200.34, _teacher.Salary, 0.0001);

            Assert.AreEqual("Anders", _teacher.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSalaryException()
        {
            _teacher.Salary = -100;
        }

        [TestMethod]
        public void TestToString()
        {
            Assert.AreEqual("Teacher(Anders, 100.25)", _teacher.ToString());
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectOrientedDesign.Classes;
using ObjectOrientedDesign.Interfaces;
using StubTest.Class;

namespace StubTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StubGetAgeTest()
        {
            PersonStub stub1 = new PersonStub();

            int age = stub1.GetAge();

            Assert.AreEqual(25, age);
        }

        [TestMethod]
        public void StubGetNameTest()
        {
            PersonStub stub = new PersonStub();

            string name = stub.GetName();

            Assert.AreEqual("Test name", name);
        }
    }
}
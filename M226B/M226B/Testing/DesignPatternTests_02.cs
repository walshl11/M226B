using System;
using DesignPatterns.Composite;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class DesignPatternTests_02
    {
        [TestMethod]
        public void StubClassGetValueTest()
        {
            OperationStub stub1 = new OperationStub();

            Assert.AreEqual(10, stub1.GetValue());
        }
        
        [TestMethod]
        public void StubClassAddTest()
        {
            OperationStub stub1 = new OperationStub();
            OperationStub stub2 = new OperationStub();

            double res = stub1.Add(stub2);

            Assert.AreEqual(15, res);
        }

        [TestMethod]
        public void StubClassSubtractTest()
        {
            OperationStub stub1 = new OperationStub();
            OperationStub stub2 = new OperationStub();

            double res = stub1.Subtract(stub2);

            Assert.AreEqual(5, res);
        }
        
        [TestMethod]
        public void StubClassMultiplyTest()
        {
            OperationStub stub1 = new OperationStub();
            OperationStub stub2 = new OperationStub();

            double res = stub1.Multiply(stub2);

            Assert.AreEqual(100, res);
        }
        
        [TestMethod]
        public void StubClassDivideTest()
        {
            OperationStub stub1 = new OperationStub();
            OperationStub stub2 = new OperationStub();

            double res = stub1.Divide(stub2);

            Assert.AreEqual(2, res);
        }
        
        [TestMethod]
        public void StubClassAddChildTest()
        {
            OperationStub stub1 = new OperationStub();
            OperationStub stub2 = new OperationStub();

            Assert.ThrowsException<InvalidOperationException>(() => stub1.AddChild(stub2));
        }

        //Tests with Composite Operation

        [TestMethod]
        public void CompositeGetValueTest()
        {
            const int value = 6;

            CompositeOperation composite = new CompositeOperation(value);
            OperationStub stub1 = new OperationStub();

            composite.AddChild(stub1);

            double res = composite.GetValue();

            Assert.AreEqual(16, composite.GetValue());
        }

        [TestMethod]
        public void CompositeAddTest()
        {
            const int value = 6;

            CompositeOperation composite = new CompositeOperation(value);
            OperationStub stub1 = new OperationStub();

            double res = composite.Add(stub1);

            Assert.AreEqual(16, res);
        }

        [TestMethod]
        public void CompositeSubtractTest()
        {
            const int value = 16;

            CompositeOperation composite = new CompositeOperation(value);
            OperationStub stub1 = new OperationStub();

            double res = composite.Subtract(stub1);

            Assert.AreEqual(6, res);
        }

        [TestMethod]
        public void CompositeMultiplyTest()
        {
            const int value = 5;

            CompositeOperation composite = new CompositeOperation(value);
            OperationStub stub1 = new OperationStub();

            double res = composite.Multiply(stub1);

            Assert.AreEqual(50, res);
        }

        [TestMethod]
        public void CompositeDivideTest()
        {
            const int value = 100;

            CompositeOperation composite = new CompositeOperation(value);
            OperationStub stub1 = new OperationStub();

            double res = composite.Divide(stub1);

            Assert.AreEqual(10, res);
        }
    }
}
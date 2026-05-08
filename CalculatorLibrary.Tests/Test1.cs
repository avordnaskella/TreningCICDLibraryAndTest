namespace CalculatorLibrary.Tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            CalculatorLogic otvet = new CalculatorLogic();

            int rez = otvet.Add(10, 4);

            Assert.AreEqual(14, rez);
        }

        [TestMethod]
        public void TestMethodSub()
        {
            CalculatorLogic otvet = new CalculatorLogic();

            int rez = otvet.Subtract(10, 4);

            Assert.AreEqual(6, rez);
        }

        [TestMethod]
        public void TestMethodMylty()
        {
            CalculatorLogic otvet = new CalculatorLogic();

            int rez = otvet.Multiply(10, 4);

            Assert.AreEqual(40, rez);
        }

        [TestMethod]
        public void TestMethodDiv()
        {
            CalculatorLogic otvet = new CalculatorLogic();

            double rez = otvet.Divide(6, 2);

            Assert.AreEqual(3, rez);
        }
    }
}

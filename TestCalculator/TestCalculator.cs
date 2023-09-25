using net_calculator_tester;

namespace TestCalculator
{
    public class Tests
    {
        private Calculator newCalculator;
        [SetUp]
        public void Setup()
        {
           newCalculator = new Calculator();
        }

        [Test]
        [TestCase(3.5f,6.9f)]
        public void Test_AddMoreThenZero_Success(float num1, float num2)
        {
            float result = newCalculator.Add(num1, num2);

            Assert.True(result > 0,$"Test per la somma superato: {result}");
        }

        [Test]
        [TestCase(3.5f, 6.9f)]
        public void Test_AddReturnCorretValue_Succes(float num1, float num2)
        {
            float result = newCalculator.Add(num1, num2);

            Assert.AreEqual(result, (num1 + num2));
        }

        [Test]
        [TestCase(23.89f, 45.12f)]
        public void Test_SubstractMoreThenZero_Success(float num1,float num2)
        {
            float result = newCalculator.Substract(num1, num2);

            Assert.True(result > 0, "Il risultato è maggiore di zero");
        }

    }
}
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
        public void Test_AddResultMoreThenZero_Success(float num1, float num2)
        {
            float result = newCalculator.Add(num1, num2);

            Assert.True(result > 0,$"Test per la somma fallito: {result}");
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
        public void Test_SubstractResultMoreThenZero_Success(float num1,float num2)
        {
            float result = newCalculator.Substract(num1, num2);

            Assert.True(result > 0, "Il risultato è maggiore di zero");
        }

        [Test]
        [TestCase(23.89f, 2.5f)]
        public void Test_DivideNotThrowException_Success(float num1, float num2)
        {
            Assert.DoesNotThrow(() => { newCalculator.Divide(num1, num2); });
        }

        [Test]
        [TestCase(1f, 23.5f)]
        public void Test_DivideResultNotEqualsZero_Success(float num1, float num2)
        {
            float result = newCalculator.Divide(num1, num2);

            Assert.True(result < 0 || result > 0, "Il risultato della divisione è zero");
        }


        [Test]
        [TestCase(10f, 23.5f)]
        public void Test_MultiplyResultNotEqualsZero_Success(float num1, float num2)
        {
            float result = newCalculator.Multiply(num1, num2);

            Assert.True(result > 0 || result < 0, "Il risultato della divisione è zero");
        }

        [Test]
        [TestCase(10f, 2f)]
        public void Test_MultiplyNotThrowException(float num1, float num2)
        {
            Assert.DoesNotThrow(() => { newCalculator.Multiply(num1, num2); });
        }
    }
}
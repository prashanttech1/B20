using CalculatorLibarory;

namespace NUnitTestProject
{
    [TestFixture]
    public class CalculatorNUnitTest
    {
        Calculator cal;
        int n1, n2;

        [SetUp]
        public void Setup()
        {
            cal = new Calculator();
            n1 = 10; n2 = 10;
            
        }


        [Test]
        public void AddMethod()
        {
            int exp = 20;
            int act = cal.Add(n1,n2);
            Assert.AreEqual(exp, act);
        }
    }
}
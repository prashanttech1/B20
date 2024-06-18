using CalculatorLibarory;

namespace TestProject1
{
   

    [TestClass]
    public class CalculatorUnitTest
    {
        [TestMethod]
        public void AddTestMethod()
        {
            //A
            Calculator c = new Calculator();
           int n1 = 10; int n2 = 10;
            int expectedres = 20;

            //B

            int actualres = c.Add(n1, n2);

            // C

            Assert.AreEqual(expectedres, actualres);


            
        }
    }
}
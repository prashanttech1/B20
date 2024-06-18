using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Controllers;

namespace UnitTestExample.Test.Controller
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void HomeController_Index_BigValidResult()
        {
            // AAA Arrage, Act, Assert

            HomeController controller  =  new HomeController();

            //string expectres = "I am Batman";

            //string result = controller.Index();

            //Assert.AreEqual(expectres, result);

            //Arrange
            int no = 1000;
            string exp = "Error ! its big no";

            //Act
            string res = controller.Index(no);

            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void HomeController_Index_SmallNoValidResult()
        {
            // AAA Arrage, Act, Assert

            HomeController controller = new HomeController();

            //string expectres = "I am Batman";

            //string result = controller.Index();

            //Assert.AreEqual(expectres, result);

            //Arrange
            int no = 77;
            string exp = "Error ! its small no";

            //Act
            string res = controller.Index(no);

            Assert.AreEqual(exp, res);

        }
        [TestMethod]
        public void HomeController_Index_TrueValidResult()
        {
            // AAA Arrage, Act, Assert

            HomeController controller = new HomeController();

            //string expectres = "I am Batman";

            //string result = controller.Index();

            //Assert.AreEqual(expectres, result);

            //Arrange
            int no = 100;
            string exp = "Correct no";


            //Act
            string res = controller.Index(no);

            Assert.AreEqual(exp, res);

        }
    }
}

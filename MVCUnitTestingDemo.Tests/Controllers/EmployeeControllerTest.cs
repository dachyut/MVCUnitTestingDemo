using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCUnitTestingDemo.Controllers;
using System.Web.Mvc;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;


namespace MVCUnitTestingDemo.Tests.Controllers
{
    [TestClass]
    public class EmployeeControllerTest
    {        
        [TestMethod]
        public void Employees()
        {
            // Arrange
            EmployeeController controller = new EmployeeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Employees1()
        {
            // Arrange
            EmployeeController controller = new EmployeeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Employees2()
        {
            // Arrange
            EmployeeController controller = new EmployeeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Employees3()
        {
            // Arrange
            EmployeeController controller = new EmployeeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Employees4()
        {
            // Arrange
            EmployeeController controller = new EmployeeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Employees5()
        {
            // Arrange
            EmployeeController controller = new EmployeeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Employees6()
        {
            // Arrange
            EmployeeController controller = new EmployeeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Employees7()
        {
            // Arrange
            EmployeeController controller = new EmployeeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Employees8()
        {
            // Arrange
            EmployeeController controller = new EmployeeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Employees9()
        {
            // Arrange
            EmployeeController controller = new EmployeeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Employees10()
        {
            // Arrange
            EmployeeController controller = new EmployeeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result);
        }
        [TestMethod]
        public void test()
        {
            IWebDriver driver;
            driver = new ChromeDriver("D:\\WebDrivers");
            driver.Url = "http://localhost/mvCApp";
            driver.Manage().Window.Maximize();
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'Employees List')]")); element.Click();

            IWebElement link = driver.FindElement(By.XPath("//a[contains(text(),'Create New')]"));
            link.Click();

            driver.Navigate().Back();
            element = driver.FindElement(By.XPath("//a[@class='navbar-brand']")); element.Click();
        }
    }
}

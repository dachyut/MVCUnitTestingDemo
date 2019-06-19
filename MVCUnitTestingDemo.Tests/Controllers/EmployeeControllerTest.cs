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
        public void test()
        {
            IWebDriver driver;
            driver = new ChromeDriver("D:\\WebDrivers");
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("headless");
            // Must maximize Chrome by `start-maximized`
            options.AddArguments("start-maximized");
            driver.Url = "http://localhost/mvCApp";
            //driver.Manage().Window.Maximize();
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'Employees List')]")); element.Click();

            IWebElement link = driver.FindElement(By.XPath("//a[contains(text(),'Create New')]"));
            link.Click();

            driver.Navigate().Back();
            element = driver.FindElement(By.XPath("//a[@class='navbar-brand']")); element.Click();
            driver.Close();
        }               
    }
}

using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Shouldly;
using TechTalk.SpecFlow;
using Protractor;

namespace AutomationTest
{
    [Binding]
    public class AddTwoNumbersSteps: IDisposable
    {

        IWebDriver _driver;
        //NgWebDriver _ngDriver;

        public AddTwoNumbersSteps()
        {
            _driver = new ChromeDriver(Directory.GetCurrentDirectory());
            _driver.Url = "C:\\Project\\TestAutomation\\SeleniumHTML\\Index.html";
            //_ngDriver = new NgWebDriver(_driver);
            //_ngDriver.Url = "http://localhost:4200/calculator/";

            //_ngDriver.Manage().Window.Maximize();
            //_ngDriver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(60);
        }


        [Given(@"first number (.*)")]
        public void GivenFirstNumber(string p0)
        {
            _driver.FindElement(By.Id("Num1")).SendKeys(p0);
        }

        [Given(@"second number (.*)")]
        public void GivenSecondNumber(string p0)
        {
            _driver.FindElement(By.Id("Num2")).SendKeys(p0);
        }

        [When(@"clicked Add")]
        public void WhenClickedAdd()
        {
            _driver.FindElement(By.Id("bAdd")).Click();
        }

        [Then(@"Output should be (.*)")]
        public void ThenOutputShouldBe(string p0)
        {
            _driver.FindElement(By.Id("lResult")).Text.ShouldBe(p0);
        }


        public void Dispose()
        {
            //_ngDriver.Dispose();
            _driver.Dispose();
        }
    }
}

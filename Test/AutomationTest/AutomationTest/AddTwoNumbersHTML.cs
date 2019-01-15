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
    public class AddTwoNumbersHTML : IDisposable
    {

        IWebDriver _driver;

        public AddTwoNumbersHTML()
        {
            _driver = new ChromeDriver(Directory.GetCurrentDirectory());
            _driver.Url = "C:\\Project\\TestAutomation\\SeleniumHTML\\Index.html";
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(60);
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
            _driver.Dispose();
        }
    }
}

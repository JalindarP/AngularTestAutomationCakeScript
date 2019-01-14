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
    public class AddSpecFlowFeatureSteps : IDisposable
    {
        IWebDriver _driver;
        NgWebDriver _ngDriver;

        public AddSpecFlowFeatureSteps()
        {
            _driver = new ChromeDriver(Directory.GetCurrentDirectory());
            _ngDriver = new NgWebDriver(_driver);
            _ngDriver.Url = "http://localhost:4200/calculator/";
            _ngDriver.Manage().Window.Maximize();
            _ngDriver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(60);
        }

      [Given(@"first number (.*)"), Scope(Tag = "Empty-Input")]
        public void GivenFirstNumber(string firstNumber)
        {
            _ngDriver.FindElement(By.Id("Num1")).SendKeys(firstNumber);
        }

        [Given(@"first number (.*)"), Scope(Tag = "Negative-Input")]
        public void GivenNumber1(string firstNumber)
        {
            _ngDriver.FindElement(By.Id("Num1")).SendKeys(firstNumber);
        }

        [Given(@"second number (.*)"), Scope(Tag = "Empty-Input")]
        public void GivenSecondNumber(string secondNumber)
        {
            _ngDriver.FindElement(By.Id("Num2")).SendKeys(secondNumber);
        }

        [Given(@"second number (.*)"), Scope(Tag = "Negative-Input")]
        public void GivenNumber2(string secondNumber)
        {
            _ngDriver.FindElement(By.Id("Num2")).SendKeys(secondNumber);
        }


        [When(@"clicked Add")]
        public void WhenClickedAdd()
        {
            _ngDriver.FindElement(By.Id("bAdd")).Click();
        }

        [Then(@"Output should be (.*)")]
        public void ThenResult(string result)
        {
            _ngDriver.FindElement(By.Id("lResult")).Text.ShouldBe(result);
        }

        public void Dispose()
        {
            _ngDriver.Dispose();
            _driver.Dispose();
        }
    }
}

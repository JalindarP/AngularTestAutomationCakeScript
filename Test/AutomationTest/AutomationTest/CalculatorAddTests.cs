using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Shouldly;
using TechTalk.SpecFlow;

namespace AutomationTest
{
    [Binding]
    public class CalculatorAddTests : IDisposable
    {
        IWebDriver _driver;

        public CalculatorAddTests()
        {
            _driver = new ChromeDriver(Directory.GetCurrentDirectory());
            _driver.Url = "http://localhost:4200/calculator/";
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(60);
        }

      [Given(@"first number (.*)")/*, Scope(Tag = "Empty-Input")*/]
        public void GivenFirstNumber(string firstNumber)
        {
            _driver.FindElement(By.Id("Num1")).SendKeys(firstNumber);
        }

        //[Given(@"first number (.*)"), Scope(Tag = "Negative-Input")]
        //public void GivenNumber1(string firstNumber)
        //{
        //    _driver.FindElement(By.Id("Num1")).SendKeys(firstNumber);
        //}

        [Given(@"second number (.*)")/*, Scope(Tag = "Empty-Input")*/]
        public void GivenSecondNumber(string secondNumber)
        {
            _driver.FindElement(By.Id("Num2")).SendKeys(secondNumber);
        }
               
        //[Given(@"second number (.*)"), Scope(Tag = "Negative-Input")]
        //public void GivenNumber2(string secondNumber)
        //{
        //    _driver.FindElement(By.Id("Num2")).SendKeys(secondNumber);
        //}


        [When(@"clicked Add")]
        public void WhenClickedAdd()
        {
            _driver.FindElement(By.Id("bAdd")).Click();
        }

        [Then(@"Output should be (.*)")]
        public void ThenResult(string result)
        {
            _driver.FindElement(By.Id("lResult")).Text.ShouldBe(result);
        }

        public void Dispose()
        {
            _driver.Dispose();
        }
    }
}

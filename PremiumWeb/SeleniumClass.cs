using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class SoftwareQT1
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.katalon.com/";
            verificationErrors = new StringBuilder();
        }        

        [Test]
        public void test1()
        {
            driver.Navigate().GoToUrl("http://localhost:2389/premiumweb.aspx");
            driver.FindElement(By.Id("TextboxGender")).SendKeys("male");
            driver.FindElement(By.Id("TextboxAge")).SendKeys("35");
            driver.FindElement(By.Id("SubmitButton")).SendKeys(Keys.Enter);
        }

        [Test]
        public void test2()
        {
            driver.Navigate().GoToUrl("http://localhost:2389/premiumweb.aspx");
            driver.FindElement(By.Id("TextboxGender")).SendKeys("male");
            driver.FindElement(By.Id("TextboxAge")).SendKeys("55");
            driver.FindElement(By.Id("SubmitButton")).SendKeys(Keys.Enter);
        }

        [Test]
        public void test3()
        {
            driver.Navigate().GoToUrl("http://localhost:2389/premiumweb.aspx");
            driver.FindElement(By.Id("TextboxGender")).SendKeys("famale");
            driver.FindElement(By.Id("TextboxAge")).SendKeys("16");
            driver.FindElement(By.Id("SubmitButton")).SendKeys(Keys.Enter);
        }

        [Test]
        public void test4()
        {
            driver.Navigate().GoToUrl("http://localhost:2389/premiumweb.aspx");
            driver.FindElement(By.Id("TextboxGender")).SendKeys("female");
            driver.FindElement(By.Id("TextboxAge")).SendKeys("24");
            driver.FindElement(By.Id("SubmitButton")).SendKeys(Keys.Enter);
        }
        

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
       
    }
}

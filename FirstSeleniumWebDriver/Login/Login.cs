using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FirstSeleniumWebDriver.Login
{
    [TestClass]
    public class Login
    {
        IWebDriver driver = new ChromeDriver();
        [TestMethod]
        public void TestMethod1()
        {
            //Data
            String username = "admin1" ;
            String pass = "P@ssw0rd";


            //ChromeMethod();
            driver.Navigate().GoToUrl("http://192.168.8.9:82/offline");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("Username")).SendKeys(username);
            driver.FindElement(By.Id("Password")).SendKeys(pass);
            driver.FindElement(By.Id("submitBtn")).Click();
            //String bodyText = driver.FindElement(By.TagName("body")).getText();
            //Assert.assertTrue("Text not found!", bodyText.contains(text));

            driver.Close();
            driver.Dispose();
        }
    }
    [TestClass]
    public class InValidPassword
    {
        IWebDriver driver = new ChromeDriver();
        [TestMethod]
        public void TestMethod2()
        {
            //Data
            String username = "admin1";
            String pass = "P@ssw0rd123";


            //ChromeMethod();
            driver.Navigate().GoToUrl("http://192.168.8.9:82/offline");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("Username")).SendKeys(username);
            driver.FindElement(By.Id("Password")).SendKeys(pass);
            driver.FindElement(By.Id("submitBtn")).Click();
            //String bodyText = driver.FindElement(By.TagName("body")).getText();
            //Assert.assertTrue("Text not found!", bodyText.contains(text));

            driver.Close();
            driver.Dispose();
        }
    }

    [TestClass]
    public class LoginNoDispose
    {
        IWebDriver driver = new ChromeDriver();
        [TestMethod]
        public void TestMethod3()
        {
            //Data
            String username = "admin1";
            String pass = "P@ssw0rd";


            //ChromeMethod();
            driver.Navigate().GoToUrl("http://192.168.8.9:82/offline");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("Username")).SendKeys(username);
            driver.FindElement(By.Id("Password")).SendKeys(pass);
            driver.FindElement(By.Id("submitBtn")).Click();
            
        }
    }
}

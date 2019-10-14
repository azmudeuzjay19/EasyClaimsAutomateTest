using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FirstSeleniumWebDriver.File_Claim
{
    [TestClass]
    public class CheckEligibility
    {
        IWebDriver driver = new ChromeDriver();
        IWebElement element;
        [TestMethod]
        public void VerifyPatientPIN()
        {
            //Data 
            //**Login
            String username = "admin1";
            String pass = "P@ssw0rd";
            String username_con = "jperada";
            String pass_con = "P@ssw0rd";

            //Member Info
            string Last, First, Middle, Suffix, DOB;
            Last = "Quinto";
            First = "Jay Boy";
            Middle = "Cobilla";
            Suffix = "";
            DOB = "1/31/1996";

            //ChromeMethod();
            driver.Navigate().GoToUrl("http://192.168.8.9:82/offline");
            driver.Manage().Window.Maximize();

            //first Login
            driver.FindElement(By.Id("Username")).SendKeys(username);
            driver.FindElement(By.Id("Password")).SendKeys(pass);
            driver.FindElement(By.Id("submitBtn")).Click();

            //Second Login
            driver.FindElement(By.Id("ConnectUsername")).SendKeys(username_con);
            driver.FindElement(By.Id("ConnectPassword")).SendKeys(pass_con);
            //Click Connect Btn
            driver.FindElement(By.XPath("//div[@class='form-group']//input[@class='k-button k-primary']")).Click();

            //Wait other element to be loaded
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
            //Click File Claim
            driver.FindElement(By.XPath("//a[@id='addClaimBtn']")).Click();

            //enter Member Info
            driver.FindElement(By.XPath("//input[@id='MemberLastName']")).SendKeys(Last);
            driver.FindElement(By.XPath("//input[@id='MemberFirstName']")).SendKeys(First);
            driver.FindElement(By.XPath("//input[@id='MemberMiddleName']")).SendKeys(Middle);
            driver.FindElement(By.XPath("//input[@id='MemberSuffix']")).SendKeys(Suffix);
            driver.FindElement(By.XPath("//input[@id='MemberBirthDate']")).SendKeys(DOB);
            driver.FindElement(By.XPath("//*[@id='memberInfo']/div[3]/div/label[2]")).Click();
            driver.FindElement(By.XPath("//input[@id='memberPINBtn']")).Click();

            //Wait other element to be loaded
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.FindElement(By.XPath("//input[@id='MemberPIN']")).GetAttribute("01-052211914-3");
            element = driver.FindElement(By.XPath("//input[@id='MemberPIN']"));
            String text = element.Text;
        }
    }
}

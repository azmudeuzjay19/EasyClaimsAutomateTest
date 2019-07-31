using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using NUnit.Framework;

namespace EasyClaimsAutomateTest 
{
    public static class LogIn
    {
        //[Test]
        public static void ValidLogin(IWebDriver driver)
        {

            //driver.FindElement(By.Id("submitBtn")).Click();

            //string submitBtn;
            driver.FindElement(By.XPath("//*[@id='Username']")).SendKeys("admin1");
            driver.FindElement(By.XPath("//*[@id='Password']")).SendKeys("P@ssw0rd");
            driver.FindElement(By.XPath("//*[@id='submitBtn']")).Click();

            //Console.Write("Success");
            //driver.Close();
        }
       
    }
}

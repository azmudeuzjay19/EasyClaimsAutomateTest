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

          
          
            IWebElement Username =  driver.FindElement(By.XPath("//*[@id='Username']"));
                Username.SendKeys("admin1");
            IWebElement Password = driver.FindElement(By.XPath("//*[@id='Password']"));
                Password.SendKeys("P@ssw0rd");
            IWebElement Submit = driver.FindElement(By.XPath("//*[@id='submitBtn']"));
                Submit.Click();
            //driver.FindElements.Equals(By.XPath()).Verify();

            IWebElement VerifyPresent = driver.FindElement(By.XPath("//*[@id='ConnectUsername']"));
            //Console.Write(VerifyPresent.Displayed);
            string VP = VerifyPresent.Displayed.ToString();
            //VerifyPresent.Displayed VP = new VerifyPresent.Displayed;

            if (VP == "True")
            {
                Console.Write("Log In: PASSED");
            }
            else
            {
                Console.Write("Log In: Failed");

            }
            
            //driver.Close();
        }
       
    }
}

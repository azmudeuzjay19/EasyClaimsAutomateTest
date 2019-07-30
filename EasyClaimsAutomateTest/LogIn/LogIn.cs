using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using NUnit.Framework;

namespace EasyClaimsAutomateTest
{
    public static class LogIn
    {
        public static void ValidLogin()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://192.168.8.9:82/offline";
            string Url = driver.Url;
            //Console.Write(Url);
            Console.Write("URL of the page is " + Url + " \r\n");

            if (Url == "http://192.168.8.9:82/offline/Account/Login?ReturnUrl=%2Foffline%2F")
            {
                Console.Write("Open Browser: Success! \r\n");
            }
            else
            {
                Console.Write("Open Browser: Failed!");
            }

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

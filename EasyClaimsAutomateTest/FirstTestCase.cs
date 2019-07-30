using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EasyClaimsAutomateTest
{
    class FirstTestCase
         
        
    {
        static void Main(string[] args)
        {
            
            //open browser and open 192.168.8.9:82/offline
            //OpenBrowser.Open();

            LogIn.ValidLogin();

            
        }
    }
    //public class WDriver
    //{
       
    //}

    //open borwser EasyClaims
    class OpenBrowser
    {
        public static void Open()
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
            //driver.FindElement(By.XPath("//*[@id="submitBtn"]")).Click();
            driver.FindElement(By.Id("submitBtn")).Click();
        }
    }
}

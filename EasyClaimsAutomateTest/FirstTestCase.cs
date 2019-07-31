using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EasyClaimsAutomateTest
{
    class FirstTestCase 
    {

        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
        //IWebDriver driver = new ChromeDriver();
        //open browser and open 192.168.8.9:82/offline
        //OpenBrowser.Open();

        //Initialize();

        }

        [SetUp]
        public void Initialize()
        {
        driver.Url = "http://192.168.8.9:82/offline";
        string Url = driver.Url;
        Console.Write("URL of the page is " + Url + " \r\n");

             if (Url == "http://192.168.8.9:82/offline/Account/Login?ReturnUrl=%2Foffline%2F")
            {
                Console.Write("Open Browser: PASSED! \r\n");
            }
            else
            {
                Console.Write("Open Browser: Failed!");
            }

        }

        [Test]
        public void ExecuteTest()
        {
            //log in 
            LogIn.ValidLogin(driver);
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}

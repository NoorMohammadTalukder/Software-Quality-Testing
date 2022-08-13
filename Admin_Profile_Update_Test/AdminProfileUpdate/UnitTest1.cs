using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;


namespace AdminProfileUpdate
{
    [TestClass]
    public class AdminProfileUpdate
    {
        static IWebDriver driverGC;

        [AssemblyInitialize]
        public static void SetUp(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext context)
        {
            driverGC = new ChromeDriver("C:/Users/sadim/Downloads/chromedriver_win32 (2)");
            // driverGC = new ChromeDriver();
        }
        [TestMethod]
        public void ExecuteTest()
        {
            driverGC.Navigate().GoToUrl("https://localhost:44394");
            //Maximize the browser window  
            driverGC.Manage().Window.Maximize();
            Thread.Sleep(2000);

            IWebElement element1 = driverGC.FindElement(By.Name("drop-down"));
            element1.Click();
            Thread.Sleep(2000);

            IWebElement element2 = driverGC.FindElement(By.Name("admin"));
            element2.Click();
            Thread.Sleep(2000);

            IWebElement element3 = driverGC.FindElement(By.Name("Email"));
            element3.SendKeys("noor@gmail.com");
            Thread.Sleep(2000);


            IWebElement element4 = driverGC.FindElement(By.Name("Password"));
            element4.SendKeys("123456");
            Thread.Sleep(2000);


            IWebElement element5 = driverGC.FindElement(By.Name("Submit"));
            element5.Click();
            Thread.Sleep(3000);

            IWebElement element6 = driverGC.FindElement(By.Name("Update"));
            element6.Click();
            Thread.Sleep(3000);

            IWebElement element7 = driverGC.FindElement(By.Name("Name"));
            element7.Clear();
            element7.SendKeys("Noor Mohammad");
            Thread.Sleep(3000);

            IWebElement element8 = driverGC.FindElement(By.Name("Submit"));
            element8.Click();
            Thread.Sleep(3000);

           

            //close the browser  
            driverGC.Close();

       
        }

    }
}

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
            driverGC.Navigate().GoToUrl("http://127.0.0.1:5500/Index.html");
            //Maximize the browser window  
            driverGC.Manage().Window.Maximize();
            Thread.Sleep(2000);





            IWebElement element3 = driverGC.FindElement(By.Name("email"));
            element3.SendKeys("noor@gmail.com");
            Thread.Sleep(2000);


            IWebElement element4 = driverGC.FindElement(By.Name("pass"));
            element4.SendKeys("123");
            Thread.Sleep(2000);


            IWebElement element5 = driverGC.FindElement(By.Name("submit"));
            element5.Click();
            Thread.Sleep(3000);




            //close the browser  
            driverGC.Close();


        }

    }
}

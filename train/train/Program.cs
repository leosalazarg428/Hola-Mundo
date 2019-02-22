using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace train
{
    class Program
    {
        static void Main(string[] args)
        {
            Flow1();
        }

        public static void Flow1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.seleniumhq.org/");
            var element = driver.FindElement(By.LinkText("Download"));
            element.Click();
            var searchBox = driver.FindElement(By.Id("q"));
            searchBox.SendKeys("Andres");
        }

        public static void Flow2()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.seleniumhq.org/");
            var element = driver.FindElement(By.LinkText("Download"));
            element.Click();
            var searchBox = driver.FindElement(By.Id("q"));
            searchBox.SendKeys("Andres");
        }
    }
}

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Vjezba
{
    internal class Program
    {
        // Pisanje reference za browsera
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
       
        }
        [SetUp]
        public void Initilaze() 
        {
            // Putanja za Google
            driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine("Otvorio se URL!");
        }
        [Test]
        public void ExecuteTest()
        {
            IWebElement btnAgreeCookie = driver.FindElement(By.XPath("//*[@id='L2AGLb']/div"));
            btnAgreeCookie.Click();

            IWebElement searhBox = driver.FindElement(By.Name("q"));
            searhBox.SendKeys("Audi A4");

            Thread.Sleep(2000);

            IWebElement searchButton = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]"));
            searchButton.Click();              

        }
        [TearDown]
        public void CleanUp() 
        {
            driver.Close();
            Console.WriteLine("Browser se zatvorio!");
        }
    }
}

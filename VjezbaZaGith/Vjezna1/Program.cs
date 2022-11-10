using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vjezba1;

namespace Vjezba1
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
            driver.Navigate().GoToUrl("https://demosite.executeautomation.com/index.html?UserName=&amp&Password=&amp&Login=Login");
            Console.WriteLine("Otvorio se URL!");
        }
        [Test]
        public void ExecuteTest() 
        {
            //EnterText(element,value,type) - Glavne vrijednosti koje moram poslati u Metodu EnterText

            //Title
            MetodeZaVjezbu.SelectDropdown(driver, "TitleId", "Mr.", "Id");

            //Initial
            MetodeZaVjezbu.EnterText(driver, "Initial", "Vladan", "Name");

            //Click
            MetodeZaVjezbu.Click(driver, "Save", "Name");

            Thread.Sleep(2000);
        }
        [TearDown]
        public void CleanUp() 
        {
            driver.Close();

            Console.WriteLine("Browser se zatvorio!");
        }
    }
}

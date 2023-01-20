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
    public class Vjezba 
    {
        //// Pisanje reference za browsera
        //IWebKolekcijaSvojstava.driver KolekcijaSvojstava.driver = new ChromeKolekcijaSvojstava.driver();
        static void Main(string[] args)
        {

        }
        [SetUp]
        public void Initilaze()
        {
            KolekcijaSvojstava.driver = new ChromeDriver();
            // Putanja za Google
            KolekcijaSvojstava.driver.Navigate().GoToUrl("https://demosite.executeautomation.com/Login.html");
            Console.WriteLine("Otvorio se URL!");
        }
        [Test]
        public void ExecuteTest()
        {
            // Login u aplikaciju
            LoginPageObject pageLogin = new LoginPageObject();
            LoginPageObject pageEA = pageLogin.Login("Vladan", "Malbasa");

            //// Iniocijalizacija pozivanjem referenci/svojstava
            //EAPageObject page = new EAPageObject(); - da ne pišem ovako direktno mogu prebaciti instancu u login 
            //pageEA.txtInitial.SendKeys("Vladan");
            //pageEA.btnSave.Click();             

            //EnterText(element,value,type) - Glavne vrijednosti koje moram poslati u Metodu EnterText
            //Title
            //MetodeZaVjezbu.SelectDropdown("TitleId", "Mr.", PropertyType.Id);
            ////Initial
            //MetodeZaVjezbu.EnterText("Initial", "Vladan", PropertyType.Name); - ovo gore je isto ovoem sma oje puno kraće ("Vladan")
            //Console.WriteLine("Vrijednost iz Titla je: " + GetMetode.GetTextDDL( "TitleId", PropertyType.Id));
            //Console.WriteLine("Vrijendost od Initiala je: " + GetMetode.GetText( "Initial", PropertyType.Name));
            ////Click
            //MetodeZaVjezbu.Click("Save", PropertyType.Name);
            Thread.Sleep(2000);
        }
        [TearDown]
        public void CleanUp()
        {
            KolekcijaSvojstava.driver.Close();
            Console.WriteLine("Browser se zatvorio!");
        }
    }
}

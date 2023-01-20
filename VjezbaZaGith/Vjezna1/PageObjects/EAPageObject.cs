using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vjezba1;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support;

namespace Vjezba1
{
    class EAPageObject
    {
        public EAPageObject() 
        {
            PageFactory.InitElements(KolekcijaSvojstava.driver, this);        
        }
        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement ddlTiteleId { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        public void FillUserForm(string initial, string middleName, string firstName) 
        {
            txtInitial.SendKeys(initial);
            txtFirstName.SendKeys(firstName);
            txtMiddleName.SendKeys(middleName);
            btnSave.Click();
        
        }
    }
}

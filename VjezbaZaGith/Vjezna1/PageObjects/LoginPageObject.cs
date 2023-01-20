using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba1
{
    public class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(KolekcijaSvojstava.driver, this);
        }
        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        public LoginPageObject Login(string userName, string password) 
        {
            //UserName
            txtUserName.SendKeys(userName);

            //Password
            txtPassword.SendKeys(password);

            //Click
            btnLogin.Submit ();

            //Return PageObject
            return new LoginPageObject();
        }
    }
}

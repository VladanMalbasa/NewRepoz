using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vjezba1;

namespace Vjezba1
{
    class MainPageBO
    {
        public MainPageBO()
        {
          PageFactory.InitElements(KolekcijaSvojstava.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='menu']/div/div[2]/div[1]/div[2]/a[2]")]
        public IWebElement btnRegister { get; set; }

        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement txtEmail { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "password-repeat")]
        public IWebElement txtPasswordRepeat { get; set; }

        [FindsBy(How = How.Name, Using = "firstname")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "lastname")]
        public IWebElement txtLastName { get; set; }

        [FindsBy(How = How.Name, Using = "telephone")]
        public IWebElement txtTelephone { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/main/div[1]/section/div/footer/button")]
        public IWebElement btnCreateAccount { get; set; }


        public MainPageBO Registracija(string sEmail, string sPassword, string sPasswordRepeat, string sFirstName, string sLastName, string sTelephone)
        {
            btnRegister.IsDisplayed();
            btnRegister.IsEnabled();

            btnRegister.Click();

            txtEmail.IsDisplayed();
            txtEmail.IsEnabled();
            txtEmail.VerifyText("");

            txtPassword.IsDisplayed();
            txtPassword.IsEnabled();
            txtPassword.VerifyText("");

            txtPasswordRepeat.IsDisplayed();
            txtPasswordRepeat.IsEnabled();
            txtPasswordRepeat.VerifyText("");

            txtFirstName.IsDisplayed();
            txtFirstName.IsEnabled();
            txtFirstName.VerifyText("");

            txtLastName.IsDisplayed();
            txtLastName.IsEnabled();
            txtLastName.VerifyText("");

            txtTelephone.IsDisplayed();
            txtTelephone.IsEnabled();
            txtTelephone.VerifyText("");

            btnCreateAccount.IsDisplayed();
            btnCreateAccount.IsEnabled();


            txtEmail.EnterText(sEmail);
            txtEmail.VerifyText(sEmail);

            txtPassword.EnterText(sPassword);
            txtPassword.VerifyText(sPassword);

            txtPasswordRepeat.EnterText(sPasswordRepeat);
            txtPasswordRepeat.VerifyText(sPasswordRepeat);

            txtFirstName.EnterText(sFirstName);
            txtFirstName.VerifyText(sFirstName);

            txtLastName.EnterText(sLastName);
            txtLastName.VerifyText(sLastName);

            txtTelephone.EnterText(sTelephone);
            txtTelephone.VerifyText(sTelephone);

            btnCreateAccount.Click();

            return new MainPageBO();
        }
    }
}

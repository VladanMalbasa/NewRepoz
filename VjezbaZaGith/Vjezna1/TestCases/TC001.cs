using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vjezba1.BaseClass;
using OpenQA.Selenium;

namespace Vjezba1
{
    public class TC001 : BaseTest
    {
        [Test]
        [Author("Vladan Malbaša")]
        [Description("BakerOnline Registracija")]

        public void TC_001() 
        {
            string date = DateTime.Now.ToString("ddMMyyyy-HHmmss");
            string sEmail = "zednail" + date + "@gmail.com";
            string sPassword = "333333";
            string sPasswordRepeat = "333333";
            string sFirstName = "Dragutin";
            string sLastName = "Bratić";
            string sTelephone = "+385911231234";
            try
            {
               MainPageBO mainPage = new MainPageBO();
                mainPage.Registracija(sEmail, sPassword, sPasswordRepeat, sFirstName, sLastName, sTelephone);
            }
            catch (Exception e)
            {
                throw;
            }        
        }
    }
}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Vjezba1
{
    public class MetodeZaVjezbu
    {
        //EnterText
        public static void EnterText(IWebDriver driver, string element, string value, string elementtype) 
        {
            if (elementtype == "Id")
            {
                driver.FindElement(By.Id(element)).SendKeys(value);
            }
            if (elementtype == "Name")
            {
                driver.FindElement(By.Name(element)).SendKeys(value);
            }                 
        }
        //Click za dugme, Chechbox.....
        public static void Click(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "Id")
            {
                driver.FindElement(By.Id(element)).Click();
            }
            if (elementtype == "Name")
            {
                driver.FindElement(By.Name(element)).Click();
            }
        }
        // Odabir Dropdown kontrole
        public static void SelectDropdown(IWebDriver driver, string element, string value, string elementtype) 
        {            
            if (elementtype == "Id")
            {
                new SelectElement (driver.FindElement(By.Id(element))).SelectByText(value);
            }
            if (elementtype == "Name")
            {
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
            }
        }
    }
}

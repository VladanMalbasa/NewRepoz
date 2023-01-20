using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba1
{
    public static class GetMetode
    {
        //Ova klasa sadrži sve metode za dohvaćanje - GET METHODS

        public static string VerifyText(this IWebElement element, string value)
        {
            try
            {
                string elementValue = element.GetAttribute("value");
                if (elementValue == value)
                {
                    return element.GetAttribute("value");
                }
                else
                {
                    throw new Exception(String.Format("Text doesn't match", value, elementValue));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

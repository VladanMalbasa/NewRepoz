using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba1
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }
    class KolekcijaSvojstava
    {    
        // Automatski - implementirana vrijednost
        public static IWebDriver driver { get; set; }
    }
}

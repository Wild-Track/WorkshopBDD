using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopBDD.ComponentHelper
{
    public class LinkHelper
    {
        private static IWebElement Element;

        public static void ClickLink(By locator)
        {
            Element = GenericHelper.GetElement(locator);
            Element.Click();
        }
    }
}

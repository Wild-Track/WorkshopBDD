using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using WorkshopBDD.ComponentHelper;

namespace WorkshopBDD.Tests.LinkTests
{
    [TestClass]
    public class HyperLinkTests
    {
        [TestInitialize]
        public void Init()
        {
            NavigationHelper.NavigateToHomePage();
        }

        [TestMethod]
        public void ClickHyperLinkTest()
        {
            IWebElement element = GenericHelper.GetElement(By.LinkText("Contact"));
            element.Click();
        }

        [TestMethod]
        public void ClickHyperLinkTestFromLinkHelper()
        {
            LinkHelper.ClickLink(By.LinkText("Contact"));
        }
    }
}

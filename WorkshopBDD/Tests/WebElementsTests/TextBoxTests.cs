using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using WorkshopBDD.BaseClasses;
using WorkshopBDD.ComponentHelper;

namespace WorkshopBDD.Tests.WebElementsTests
{
    [TestClass]
    public class TextBoxTests
    {
        [TestInitialize]
        public void Init()
        {
            NavigationHelper.NavigateToHomePage();
        }

        [TestMethod]
        public void TextBoxTest()
        {
            IWebElement element = GenericHelper.GetElement(By.Id("p1"));
            element.SendKeys(ObjectRepository.Config.GetPlayerOne());
            element = GenericHelper.GetElement(By.Id("p2"));
            element.SendKeys(ObjectRepository.Config.GetPlayerTwo());
        }

        [TestMethod]
        public void TextBoxFromHelperTest()
        {
            TextBoxHelper.TypeInTextBox(By.Id("p1"), ObjectRepository.Config.GetPlayerOne());
            TextBoxHelper.TypeInTextBox(By.Id("p2"), ObjectRepository.Config.GetPlayerTwo());
        }

        [TestMethod]
        public void ClearTextBoxTest()
        {
            TextBoxHelper.TypeInTextBox(By.Id("p1"), ObjectRepository.Config.GetPlayerOne());
            TextBoxHelper.ClearTextBox(By.Id("p1"));
        }
    }
}

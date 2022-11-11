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
    public class ButtonTests
    {
        [TestInitialize]
        public void Init()
        {
            NavigationHelper.NavigateToHomePage();
            TextBoxHelper.TypeInTextBox(By.Id("p1"), ObjectRepository.Config.GetPlayerOne());
            TextBoxHelper.TypeInTextBox(By.Id("p2"), ObjectRepository.Config.GetPlayerTwo());
        }

        [TestMethod]
        public void IsButtonEnabledTest()
        {
            ButtonHelper.IsButtonEnabled(By.Id("submitPlayers"));
        }

        [TestMethod]
        public void GetButtonTextTest()
        {
            ButtonHelper.IsButtonEnabled(By.Id("submitPlayers"));
            Console.WriteLine(ButtonHelper.GetButtonText(By.Id("submitPlayers")));
        }


        [TestMethod]
        public void ClickOnPlayFromButtonHelperTest()
        {
            ButtonHelper.ClickButton(By.Id("submitPlayers"));
            Assert.AreEqual(PageHelper.GetPageTitle(), "Jeu Seprent Cédric BRASSEUR");
        }
    }
}

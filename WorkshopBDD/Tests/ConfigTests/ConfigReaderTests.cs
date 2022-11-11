using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkshopBDD.BaseClasses;
using WorkshopBDD.Configuration;
using WorkshopBDD.Interfaces;

namespace WorkshopBDD.Tests.ConfigTests
{
    [TestClass]
    public class ConfigReaderTests
    {
        [TestMethod]
        public void GetConfigKeysFromConfigReader()
        {
            IConfig config = new ConfigReader();
            Console.WriteLine("Browser : " + config.GetBrowser());
            Console.WriteLine("PlayerOne : " + config.GetPlayerOne());
            Console.WriteLine("PlayerTwo : " + config.GetPlayerTwo());
            Console.WriteLine("Website : " + config.GetWebsite());
        }

        [TestMethod]
        public void GetConfigKeysFromObjectRepository()
        {
            Console.WriteLine("Browser : " + ObjectRepository.Config.GetBrowser());
            Console.WriteLine("PlayerOne : " + ObjectRepository.Config.GetPlayerOne());
            Console.WriteLine("PlayerTwo : " + ObjectRepository.Config.GetPlayerTwo());
            Console.WriteLine("Website : " + ObjectRepository.Config.GetWebsite());
        }
    }
}

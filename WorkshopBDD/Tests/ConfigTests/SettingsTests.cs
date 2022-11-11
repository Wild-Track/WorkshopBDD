using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WorkshopBDD.Configuration;

namespace WorkshopBDD.Tests.ConfigTests
{
    [TestClass]
    public class SettingsTests
    {
        private GameSettings settings;

        [TestInitialize]
        public void Init()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("C:/Users/stagiaire/Documents/Cours/1ere a/BDD/WorkshopBDD_save/WorkshopBDD/appsetings.json")
                .AddEnvironmentVariables()
                .Build();

            settings = config.GetRequiredSection(nameof(GameSettings)).Get<GameSettings>();
        }

        [TestMethod]
        public void GetBrowserFromConfig()
        {
            Console.WriteLine($"Browser = { settings.Browser }");
        }

        [TestMethod]
        public void GetPlayerOneFromConfig()
        {
            Console.WriteLine($"PlayerOne = { settings.PlayerOne }");
        }

        [TestMethod]
        public void GetPlayerTwoFromConfig()
        {
            Console.WriteLine($"PlayerTwo = { settings.PlayerTwo }");
        }

        [TestMethod]
        public void GetWebsiteFromConfig()
        {
            Console.WriteLine($"Website = { settings.Website }");
        }
    }
}

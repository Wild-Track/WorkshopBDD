using System;
using System.Collections.Generic;
using System.Text;
using WorkshopBDD.Settings;

namespace WorkshopBDD.Interfaces
{
    public interface IConfig
    {
        public BrowserType GetBrowser();
        public string GetPlayerOne();
        public string GetPlayerTwo();
        public string GetWebsite();
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using WorkshopBDD.BaseClasses;

namespace WorkshopBDD.ComponentHelper
{
    public class PageHelper
    {
        public static string GetPageTitle()
        {
            return ObjectRepository.Driver.Title;
        }

        public static string GetPageUrl()
        {
            return ObjectRepository.Driver.Url;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Multiple_select
{
    internal class Multiple_select : LIBRARY
    {
        public void multipleselect()
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(" https://courses.letskodeit.com/practice");
            Driver.Manage().Window.Maximize();
            time(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
        }
    }
}

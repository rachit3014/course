using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Switch_Alert
{
    internal class SwitchAlert : LIBRARY
    {
      public void switch_Alert()
        {
            chrome(" https://courses.letskodeit.com/practice");
            
            time(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Findxpath("//input[@id='name']").SendKeys("Rachit");
            time(2000);
            Findxpath("//input[@id='alertbtn']").Click();
            time(2000);
            Driver.SwitchTo().Alert().Accept();
            Findxpath("//input[@id='confirmbtn']").Click();
            time(2000);
            Driver.SwitchTo().Alert().Accept();
            time(2000);
            quit();
        }
    }
}

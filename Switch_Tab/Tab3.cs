using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Switch_Tab
{
    internal class Tab3 : LIBRARY
    {
     public void tab()
        {
            chrome(" https://courses.letskodeit.com/practice");
            
            time(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Findxpath("//a[@id='opentab']").Click();
            time(2000);
            string p = Driver.WindowHandles[1];
            string g = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(p);
            time(2000);
            Driver.Close();

            time(2000);
            Driver.SwitchTo().Window(g);
            time(5000);
            quit();
            
        }
    }
}

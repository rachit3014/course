using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Switch_window
{
    internal class Window : LIBRARY
    {
    public void window()
        {
            chrome(" https://courses.letskodeit.com/practice");
            
            time(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Findxpath("//button[@id='openwindow']").Click();
            time(2000);
            string h = Driver.WindowHandles[1];
            string k = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(h);
            Driver.Manage().Window.Maximize();
            time(2000);
            Driver.Close();
            Driver.SwitchTo().Window(k);
            time(2000);
            quit();

        }
    }
}

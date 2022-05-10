using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Raddio_Button
{
    internal class Radiobutton : LIBRARY
    {
        public void radio_button()
        {


            chrome(" https://courses.letskodeit.com/practice");
            time(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Findxpath("//input[@id='bmwradio']").Click();
            time(2000);
            Findxpath("//input[@id='benzradio']").Click();
            time(2000);
            Findxpath("//input[@id='hondaradio']").Click();
            time(2000);
            quit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Check_box
{
    internal class Checkbox : LIBRARY
    {
        public void check_box()
        {
           
            chrome(" https://courses.letskodeit.com/practice");
         
            time(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Findxpath("//input[@id='bmwcheck']").Click();
            time(2000);
            Findxpath("//input[@id='benzcheck']").Click();
            time(2000);
            Findxpath("//input[@id='hondacheck']").Click();
            time(2000);
            quit();;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Select_Class
{
    internal class SelectClass1 : LIBRARY
    {
        public void select_class()
        {
            
            chrome(" https://courses.letskodeit.com/practice");
            
            time(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Findxpath("//select[@id='carselect']").Click();
            time(2000);
            Actions actio = new Actions(Driver);
            actio.MoveToElement(Findxpath("//select[@id='carselect']"))
                .KeyDown(Keys.Down)
            .KeyDown(Keys.Down)
            .Click()
                .Perform();
            time(2000);
            quit();
        }
    }
}

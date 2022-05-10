using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace House_However
{
    internal class Mouse : LIBRARY
    {
       public void mouse_however()
        {
            
            chrome(" https://courses.letskodeit.com/practice");
            
            time(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0,500)");
            IWebElement top = Findxpath("//button[@id='mousehover']");
            top.Click();
            time(2000);
            Actions act = new Actions(Driver);

            act.MoveToElement(Findxpath("//button[@id='mousehover']"))
                .KeyDown(Keys.Down)
                .Click()
            .Perform();
            time(2000);
            js.ExecuteScript("window.scrollBy(0,500)");
            Findxpath("//button[@id='mousehover']")
               .Click();
            time(2000);
            Actions action = new Actions(Driver);
            action.MoveToElement(Findxpath("//button[@id='mousehover']"))

                .KeyDown(Keys.Down)
                .KeyDown(Keys.Down)
                .Click()
                .Perform();
            quit();
        }
    }
}

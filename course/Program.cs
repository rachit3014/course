//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Interactions;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using Library;

//namespace course
//{
//    internal class Program :LIBRARY
//    {
//        public void fj()
//        {
//            IWebDriver Driver = new ChromeDriver();
//            Driver.Navigate().GoToUrl(" https://courses.letskodeit.com/practice");
//            Driver.Manage().Window.Maximize();
//            time(2000);
//            IJavaScriptExecutor js = (IJavaScriptExecutor) Driver;
//            Findxpath("//input[@id='bmwradio']")).Click();
//            time(2000);
//            Findxpath("//input[@id='benzradio']")).Click();
//            time(2000);
//            Findxpath("//input[@id='hondaradio']")).Click();
//            time(2000);
//            Findxpath("//select[@id='carselect']")).Click();
//            time(2000);
//            Findxpath("//select[@id='carselect']")).Click();
//            time(2000);
//            Actions actio = new Actions(Driver);
//            actio.MoveToElement(Findxpath("//select[@id='carselect']")))
//                .KeyDown(Keys.Down)
//            .KeyDown(Keys.Down)
//            .Click()
//                .Perform();
//            time(2000);
//            Findxpath("//input[@id='bmwcheck']")).Click();
//            time(2000);
//            Findxpath("//input[@id='benzcheck']")).Click();
//            time(2000);
//            Findxpath("//input[@id='hondacheck']")).Click();
//            time(2000);
//            Findxpath("//a[@id='opentab']")).Click();
//            time(2000);
//            string p = Driver.WindowHandles[1];
//            string g = Driver.WindowHandles[0];
//            Driver.SwitchTo().Window(p);         
//            time(2000);
//            Driver.Close();
            
//            time(2000);
//            Driver.SwitchTo().Window(g);
//            time(2000);
//            Findxpath("//button[@id='openwindow']")).Click();
//            time(2000);
//            string h = Driver.WindowHandles[1];
//            string k=Driver.WindowHandles[0];   
//            Driver.SwitchTo().Window(h);
//            Driver.Manage().Window.Maximize();
//            time(2000);
//            Driver.Close();
//            Driver.SwitchTo().Window(k);
//            time(2000);
//            Findxpath("//input[@id='name']")).SendKeys("Rachit");
//            time(2000);
//            Findxpath("//input[@id='alertbtn']")).Click();
//            time(2000);
//            Driver.SwitchTo().Alert().Accept();
//            Findxpath("//input[@id='confirmbtn']")).Click();
//            time(2000);
//            Driver.SwitchTo().Alert().Accept();
//            time(2000);
            
//            js.ExecuteScript("window.scrollBy(0,500)");
//            IWebElement top = Findxpath("//button[@id='mousehover']"));
//            top.Click();
//            time(2000);
//            Actions act = new Actions(Driver);

//            act.MoveToElement(Findxpath("//button[@id='mousehover']")))
//                .KeyDown(Keys.Down)
//                .Click()
//            .Perform();
//            time(2000);
//            js.ExecuteScript("window.scrollBy(0,500)");
//            Findxpath("//button[@id='mousehover']"))
//               .Click();
//            time(2000);
//            Actions action = new Actions(Driver); 
//            action.MoveToElement(Findxpath("//button[@id='mousehover']")))
                  
//                .KeyDown(Keys.Down)
//                .KeyDown(Keys.Down)
//                .Click()
//                .Perform();







//        }
//    }
//}

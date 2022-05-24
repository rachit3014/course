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
            chrome(" https://courses.letskodeit.com/practice");
            time(2000);
         
            Findxpath("//select[@id='multiple-select-example']//option[@value='apple']").Click();
            time(2000);
            Findxpath("//select[@id='multiple-select-example']//option[@value='orange']").Click();

            time(2000);
            
        }
    }
}

using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Description
    {

        private object driver;
        public Description()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        #region  Initialize Web Elements 

        //Click on WriteIcon
        [FindsBy(How = How.XPath, Using = "//h3/span/i")]
        public IWebElement WriteIcon { get; set; }

        //Write i Description Box
        [FindsBy(How = How.Name, Using = "value")]
        public IWebElement DescriptionBox { get; set; }

            //Click Save
            [FindsBy(How = How.XPath, Using = "//div[@class='ui twelve wide column']//button[@class='ui teal button'][contains(text(),'Save')]")]
            public IWebElement Save { get; set; }

            #endregion

        }
}

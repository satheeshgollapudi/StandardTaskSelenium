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
    class Requests
    {
        private object driver;

        public Requests()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        #region  Initialize Web Elements 

        //Click on Requests Tab
        [FindsBy(How = How.XPath, Using = "//div[@class='ui dropdown link item']")]
        public IWebElement RequestsDropdown { get; set; }

        //Click on Received Requests Tab
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Received Requests')]")]
        public IWebElement ReceivedRequests{ get; set; }

        //Click on Sent Tab
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sent Requests')]")]
        public IWebElement SentRequests { get; set; }



        #endregion
    }
}

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
    class ManageListings
    {

        public ManageListings()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        public IWebElement manageListingsLink { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "//table[@class='ui striped table']/tbody/tr[1]/td[8]/div/button[1]/i")]
        public IWebElement view { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//table[1]/tbody[1]/tr[1]/td[8]/div/button[3]/i")]
        public IWebElement delete { get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        public IWebElement edit { get; set; }

        //Click on Yes 
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']/button[2]")]
        public IWebElement clickYesButton { get; set; }

        //Click on  No
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']/button[1]")]
        public IWebElement clickNoButton { get; set; }


        internal void Listings()
        {
          

        }
    }
}


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
    class Search
    {

        private object driver;
        public Search()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        #region  Initialize Web Elements 

        //Click on Category
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Business')]")]
        public IWebElement Category{ get; set; }

        //Click on SubCategory
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Other')")]
        public IWebElement Subategory { get; set; }

        //Click on SearchButton
        [FindsBy(How = How.XPath, Using = "//i[@class='search link icon']")]
        public IWebElement SearchButton { get; set; }

        //Click on OnlineButton
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Online')]")]
        public IWebElement OnlineButton { get; set; }

        //Click on OnsiteButton
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Onsite')]")]
        public IWebElement OnsiteButton { get; set; }

        //Click on ShowAllButton
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'ShowAll')]")]
        public IWebElement ShowAllButton { get; set; }


        #endregion
    }
}

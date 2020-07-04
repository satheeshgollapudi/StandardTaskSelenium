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
    class Chat
    {

        private object driver;
        public Chat()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        #region  Initialize Web Elements 
        //Click on Chat
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Chat')]")]
        public IWebElement ChatTab { get; set; }

        //Enter Message
        [FindsBy(How = How.XPath, Using = "//input[@id='chatTextBox']")]
        public IWebElement EnterChatMessage{ get; set; }

        //Send Message
        [FindsBy(How = How.XPath, Using = "//div[@id='input-message-container']/button[1]")]
        public IWebElement Send { get; set; }

        //Search
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search']")]
        public IWebElement Search { get; set; }

        //Click Search
        [FindsBy(How = How.XPath, Using = "//div[@class='ui icon input']//i[@class='search link icon']")]
        public IWebElement ClickSearch{ get; set; }


        #endregion

        internal void Chating() { 
      }
    }
}

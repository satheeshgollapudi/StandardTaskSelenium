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
    class Registration
    {

        private object driver;
        public Registration()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        #region  Initialize Web Elements 

        //Enter First Name
        [FindsBy(How = How.Name, Using = "firstName")]
        public IWebElement FirstName{ get; set; }

        //Enter Last Name
        [FindsBy(How = How.Name, Using = "lastName")]
        public IWebElement LastName { get; set; }

        //Enter email
        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement email { get; set; }

        //Enter password
        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement password { get; set; }

        //Enter confirmPassword
        [FindsBy(How = How.Name, Using = "confirmPassword")]
        public IWebElement confirmPassword { get; set; }

        //Click on Terms
        [FindsBy(How = How.Name, Using = "terms")]
        public IWebElement terms { get; set; }

        //Click on submit button
        [FindsBy(How = How.Id, Using = "submit-btn")]
        public IWebElement submitbtn { get; set; }





        #endregion

    }
}

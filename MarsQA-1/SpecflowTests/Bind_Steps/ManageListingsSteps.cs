using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowTests.Bind_Steps
{
    [Binding]
    public class ManageListingsSteps
    {
        ManageListings obj = new ManageListings();
        ShareSkill obj1 = new ShareSkill();

        [Given(@"I clicked on  Manage Listings page")]
        public void GivenIClickedOnManageListingsPage()
        {

            //Click on Manage Listings
         obj.manageListingsLink.Click();
        }
        
        [When(@"I click on edit  and go to service listings page enter all details and click on save button")]
        public void WhenIClickOnEditAndGoToServiceListingsPageEnterAllDetailsAndClickOnSaveButton()
        {
            //Click on Edit
          obj.edit.Click();


            //Enter the Title
            obj1.Title.SendKeys("Mr");


            //Clear the description box
            obj1.Description.Clear();

            //Enter the description
            obj1.Description.SendKeys("i am a tester");


            //Select the Category option

            SelectElement choosecategory = new SelectElement(Driver.driver.FindElement(By.Name("categoryId")));
            choosecategory.SelectByText("Business");


            //Select the subcategory
            //Choose the language level
            SelectElement choosesubcategory = new SelectElement(Driver.driver.FindElement(By.Name("subcategoryId")));
            choosesubcategory.SelectByText("Other");


            //Enter Tag name

            obj1.Tags.SendKeys("Testing");
            obj1.Tags.SendKeys(Keys.Enter);

            //Service Type Option
            obj1.ServiceTypeOptions.Click();

            //Location Type Option
            obj1.LocationTypeOption.Click();

            //Entering start date
            var startDate = "07/07/2020";
            IWebElement StartDateDropDown = Driver.driver.FindElement(By.Name("startDate"));

            DateTime parsedStartDate = DateTime.Parse(startDate);
            var startDateonly = parsedStartDate.ToShortDateString();
            StartDateDropDown.SendKeys(startDateonly);

            StartDateDropDown.SendKeys(Keys.Tab);

            //Entering End date

            var endDate = "07/08/2021";
            IWebElement EndDateDropDown = Driver.driver.FindElement(By.Name("endDate"));
            DateTime parsedEndDate = DateTime.Parse(endDate);
            var endDateonly = parsedEndDate.ToShortDateString();
            EndDateDropDown.SendKeys(endDateonly);

            EndDateDropDown.SendKeys(Keys.Tab);

            //Selecting the day

            Driver.driver.FindElement(By.XPath("//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]/div[3]/div/div/input")).Click();

            //Entering the starttime
            var startTime = "18:00:00";
            IWebElement StartTimeDropDown = Driver.driver.FindElement(By.XPath("//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]/div[3]/div[2]/input"));
            DateTime parsedStartTime = DateTime.Parse(startTime);
            var startTimeString = parsedStartTime.ToString("hh:mmtt");
            //var startTimeString = parsedStartTime.ToShortTimeString();
            Console.WriteLine("Start Time String is : " + startTimeString);

            StartTimeDropDown.SendKeys(startTimeString);
            StartTimeDropDown.SendKeys(Keys.Tab);

            //Entering the endtime

            var endTime = "20:00:00";
            IWebElement EndTimeDropDown = Driver.driver.FindElement(By.XPath("//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]/div[3]/div[3]/input"));
            DateTime parsedEndTime = DateTime.Parse(endTime);
            var endTimeString = parsedEndTime.ToString("hh:mmtt");
            Console.WriteLine("End Time String is : " + endTimeString);

            EndTimeDropDown.SendKeys(endTimeString);

            //Skill Trade Option

            IWebElement RadioButSTrade = Driver.driver.FindElement(By.XPath("//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']"));
            RadioButSTrade.Click();

            //Enter Skill-Exchange Tag name
            IWebElement SETag = Driver.driver.FindElement(By.XPath("//div[@class='form-wrapper']//input[@placeholder='Add new tag']"));
            SETag.SendKeys("Testing");
            SETag.SendKeys(Keys.Enter);
          
           
            //Active Option
            IWebElement RadioButActiv = Driver.driver.FindElement(By.XPath("//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field'][2]"));
            RadioButActiv.Click();

            //Save the page
            obj1.Save.Click();
        }

        [Then(@"I navigate to manage  Listings page")]
        public void ThenINavigateToManageListingsPage()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Edit Manage Listings Page");

                Thread.Sleep(1000);
                string ExpectedValue = "ListingManagement";
                string ActualValue = Driver.driver.Title;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed,Navigated to Manage Listings Page");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Navigated to Manage Listings Page");
                    Console.WriteLine("Navigated to Manage Listings Page");
                }

                else
                {
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                    Console.WriteLine("Test Failed");
                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
                Console.WriteLine("Test Failed due to exception", e.Message);


            }

        }

        [When(@"I click on delete in Manage Listings and clicked on No on alert")]
        public void WhenIClickOnDeleteInManageListingsAndClickedOnNoOnAlert()
        {
            //Click on Delete
          obj.delete.Click();

            //Click on No
           obj.clickNoButton.Click();
        }


        [Then(@"the datails should not be deleted on manage listings page")]
        public void ThenTheDatailsShouldNotBeDeletedOnManageListingsPage()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Cancel delete Manage Listings ");

                Thread.Sleep(1000);
                string ExpectedValue = "Mr";
                string ActualValue = Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[3]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed,Cancelled delete Manage Listings ");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Cancelled delete Manage Listings ");
                    Console.WriteLine("Cancelled delete Manage Listings");
                }

                else
                {
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                    Console.WriteLine("Test Failed");
                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
                Console.WriteLine("Test Failed due to exception", e.Message);


            }

        }

        [When(@"I click on delete button and clicked on Yes on alert")]
        public void WhenIClickOnDeleteButtonAndClickedOnYesOnAlert()
        {
            //Click on Delete
            obj.delete.Click();

            //Click on Yes
            obj.clickNoButton.Click();
        }
        
       
      
        
        [Then(@"that skill should not be shown on manage listings page")]
        public void ThenThatSkillShouldNotBeShownOnManageListingsPage()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Deleted Manage Listings");

                Thread.Sleep(1000);
                string beforeXpath = "//tbody/tr[";
                string afterXpath = "]/td[3]";
                string ExpectedValue = "Mr";
                bool languageFound = true;

             

                //1st Method

                IList<IWebElement> Title= Driver.driver.FindElements(By.XPath("//tbody/tr"));
                int TitleCount = Title.Count;
                //1st Method
                for (int i = 1; i <= TitleCount; i++)
                {

                    string ActualValue = Driver.driver.FindElement(By.XPath(beforeXpath + i + afterXpath)).Text;


                    Thread.Sleep(500);
                    if (ActualValue.Contains("Mr"))
                    {
                        if (ExpectedValue == ActualValue)
                        {
                            languageFound = true;
                            CommonMethods.test.Log(LogStatus.Pass, "Test Failed, Deleting Manage Listings is unsuccessful");
                            SaveScreenShotClass.SaveScreenshot(Driver.driver, "Deleting a Manage Listings is unsuccessful");
                            Console.WriteLine(" delete Manage Listings unsuccessful");
                        }
                        else
                            CommonMethods.test.Log(LogStatus.Fail, "Test Passed");
                        Console.WriteLine(" deleted Manage Listings");
                        break;
                    }
                    else
                    {
                        languageFound = false;
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Deleted Manage Listing");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "Deleted Manage Listing");
                        Console.WriteLine(" deleted Manage Listings");
                        break;
                    }

                }

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
                Console.WriteLine(" Failed due to exception");
            }
        }
    }
}

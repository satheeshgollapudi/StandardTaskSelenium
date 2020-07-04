using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowTests.Bind_Steps
{
    [Binding]
    public class ShareSkillSteps
    {
      ShareSkill obj = new ShareSkill();

        [Given(@"I clicked on  Profile page")]
        public void GivenIClickedOnProfilePage()
        {

            // Click on Profile tab
            obj.ProfileTab.Click();

        }

        [When(@"I click on ShareSkill button")]
        public void WhenIClickOnShareSkillButton()
        {
            // Click on ShareSkill button
          obj.ShareSkillButton.Click();
        }


        [Then(@"I navigate to ShareSkill page")]
        public void ThenINavigateToShareSkillPage()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Navigated to share skill page");

                Thread.Sleep(1000);
                string ExpectedValue = "Mars Logo";
                string ActualValue = Driver.driver.FindElement(By.XPath("//a[contains(text(),'Mars Logo')]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Navigated to share skill page");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Navigated to share skill page");
                    Console.WriteLine("TestPassed,Navigated to share skill page");
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

        [When(@"I enter all details and click on save button")]
        public void WhenIEnterAllDetailsAndClickOnSaveButton()
        {
            // Click on ShareSkill button
            obj.ShareSkillButton.Click();

            //Enter the Title
           obj.Title.SendKeys("Mr");

       
            //Clear the description box
           obj.Description.Clear();

            //Enter the description
         obj.Description.SendKeys("i am a tester");


            //Select the Category option
           
            SelectElement choosecategory = new SelectElement(Driver.driver.FindElement(By.Name("categoryId")));
            choosecategory.SelectByText("Business");


            //Select the subcategory
            //Choose the language level
            SelectElement choosesubcategory = new SelectElement(Driver.driver.FindElement(By.Name("subcategoryId")));
            choosesubcategory.SelectByText("Other");


            //Enter Tag name
           
            obj.Tags.SendKeys("Testing");
            obj.Tags.SendKeys(Keys.Enter);

            //Service Type Option
           obj.ServiceTypeOptions.Click();

            //Location Type Option
            obj.LocationTypeOption.Click();

            //Entering start date
            var startDate = "06/07/2020";
            IWebElement StartDateDropDown= Driver.driver.FindElement(By.Name("startDate"));

           DateTime parsedStartDate = DateTime.Parse(startDate);
            var startDateonly = parsedStartDate.ToShortDateString();
            StartDateDropDown.SendKeys(startDateonly);

            StartDateDropDown.SendKeys(Keys.Tab);

            //Entering End date
         
            var endDate = "05/08/2021";
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
            //Enter credit
            //Driver.driver.FindElement(By.XPath("//input[@name='charge']")).SendKeys("5");
            //Active Option
            IWebElement RadioButActiv = Driver.driver.FindElement(By.XPath("//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field'][2]"));
            RadioButActiv.Click();

            //Save the page
         obj.Save.Click();
        }


        [Then(@"I navigate to manage listings page")]
        public void ThenINavigateToManageListingsPage()
        {

            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Save Manage Listings Page");

                Thread.Sleep(1000);
                string ExpectedValue = "ListingManagement";
                string ActualValue = Driver.driver.Title;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed,Navigated to Manage Listings Page");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Navigated to Manage Listings Page");
                    Console.WriteLine("TestPassed,Navigated to Manage Listings Page");
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


        [When(@"I enter all details and click on cancel button")]
        public void WhenIEnterAllDetailsAndClickOnCancelButton()
        {
            // Click on ShareSkill button
            obj.ShareSkillButton.Click();
           
            // Click on Cancel Button
         obj.Cancel.Click();
        }


        [Then(@"the datails should not be saved and I navigate to profile page")]
        public void ThenTheDatailsShouldNotBeSavedAndINavigateToProfilePage()
        {

            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Cancel Saveing Manage Service Listings");

                Thread.Sleep(1000);
                string ExpectedValue = "Profile";
                string ActualValue = Driver.driver.Title;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed,Navigated to Profile Page");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Navigated to Profile Page");
                    Console.WriteLine("TestPassed,Navigated to Profile Page");
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
    }
}

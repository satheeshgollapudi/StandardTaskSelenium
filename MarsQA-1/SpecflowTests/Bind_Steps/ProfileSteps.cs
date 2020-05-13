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
    public class ProfileSteps
    {
        Profile obj = new Profile();

        [Given(@"I clicked on location under Profile page")]
        public void GivenIClickedOnLocationUnderProfilePage()
        {
            ScenarioContext.Current.Pending();
        }


        [When(@"I enter city")]
        public void WhenIEnterCity()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"entered city should be selected")]
        public void ThenEnteredCityShouldBeSelected()
        {
            ScenarioContext.Current.Pending();
        }


        [When(@"I enter country")]
        public void WhenIEnterCountry()
        {
            ScenarioContext.Current.Pending();
        }


        [Then(@"entered country should be selected")]
        public void ThenEnteredCountryShouldBeSelected()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I clicked on edit availability type under Profile page")]
        public void GivenIClickedOnEditAvailabilityTypeUnderProfilePage()
        {

            //Click on Availability
       obj.AvailabilityTimeEdit.Click();
        }

        [When(@"I enter availability type")]
        public void WhenIEnterAvailabilityType()
        {
          

            //Select
            obj.AvailabilityTime.Click();

            //Availability option Full Time
            obj.AvailabilityTimeOpt.Click();
          
            Console.WriteLine("Availability updated");


        }


        [Then(@"that availability type should be selected")]
        public void ThenThatAvailabilityTypeShouldBeSelected()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("AvailabilityType");

                Thread.Sleep(1000);
                string ExpectedValue = "Full Time";
                string ActualValue = Driver.driver.FindElement(By.XPath("//i[@class='large calendar icon']/parent::span/following-sibling::div/span")).Text;
                Console.WriteLine(ActualValue);
                Thread.Sleep(2000);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, AvailabilityType selected");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "AvailabilityType selected");
                    Console.WriteLine("AvailabilityType selected");
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


        [Given(@"I clicked on edit availability hour under Profile page")]
        public void GivenIClickedOnEditAvailabilityHourUnderProfilePage()
        {
            //Click on Hours
            obj.AvailabilityHoursEdit.Click();
           // Driver.driver.FindElement(By.XPath("//i[@class='large clock outline check icon']/parent::span/following-sibling::div/span/i")).Click();
        }


        [When(@"I enter availability hour")]
        public void WhenIEnterAvailabilityHour()
        {
            //Select
            obj.AvailabilityHoursDropDown.Click();

            //Choose the Availability Hour
            obj.AvailabilityHours.Click();

        }


        [Then(@"that availability hour should be selected")]
        public void ThenThatAvailabilityHourShouldBeSelected()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Availability Hour");

                Thread.Sleep(1000);
                string ExpectedValue = "As needed";
                string ActualValue = Driver.driver.FindElement(By.XPath("//i[@class='large clock outline check icon']/parent::span/following-sibling::div/span")).Text;
                Console.WriteLine(ActualValue);
                Thread.Sleep(2000);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, AvailabilityHour selected");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "AvailabilityHour selected");
                    Console.WriteLine("AvailabilityHour selected");
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


        [Given(@"I clicked on edit EarnTarget under Profile page")]
        public void GivenIClickedOnEditEarnTargetUnderProfilePage()
        {
            obj.SalaryEdit.Click();
        }
     
      
        [When(@"I enter availabilitytarget")]
        public void WhenIEnterAvailabilitytarget() //select[@name='availabiltyTarget']
        {
            //Choose theEarn Target
            obj.SalaryDropdown.Click();
            obj.SalaryOpt.Click();
        }
        
       [Then(@"that availability target should be selected")]
        public void ThenThatAvailabilityTargetShouldBeSelected()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Earn Target");

                Thread.Sleep(1000);
                string ExpectedValue = "More than $1000 per month";
                string ActualValue = Driver.driver.FindElement(By.XPath("//i[@class='large dollar icon']/parent::span/following-sibling::div/span")).Text;
                Console.WriteLine(ActualValue);
                Thread.Sleep(2000);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Earn Target selected");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Earn Target selected");
                    Console.WriteLine("Earn Target selected");
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

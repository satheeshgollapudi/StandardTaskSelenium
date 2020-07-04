using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowTests.Bind_Steps
{
    [Binding]
    public class RequestsSteps
    {
        Requests obj = new Requests();

        [Given(@"I clicked on Manage Requests under Profile page")]
        public void GivenIClickedOnManageRequestsUnderProfilePage()
        {
            obj.RequestsDropdown.Click();
         
        }
       

        [When(@"I select Received Requests dropdown")]
        public void WhenISelectReceivedRequestsDropdown()
        {
            obj.ReceivedRequests.Click();
         

        }

        [Then(@"I should be able to navigate to ReceivedRequest page")]
        public void ThenIShouldBeAbleToNavigateToReceivedRequestPage()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Receivd Requests");

                Thread.Sleep(1000);
                string ExpectedValue = "ReceivedRequest";
                string ActualValue = Driver.driver.Title;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Navigated to Receivd Requests Page");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Navigated to Receivd Requests Page");
                    Console.WriteLine("Navigated to Receivd Requests Page");
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

        [When(@"I select Sent Requests dropdown")]
        public void WhenISelectSentRequestsDropdown()
        {
            obj.SentRequests.Click();
          
        }
        
      
        
        [Then(@"I should be able to navigate to SentRequest page")]
        public void ThenIShouldBeAbleToNavigateToSentRequestPage()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Sent Requests");

                Thread.Sleep(1000);
                string ExpectedValue = "SentRequest";
                string ActualValue = Driver.driver.Title;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Navigated to Sent Requests Page");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Navigated to Sent Requests Page");
                    Console.WriteLine("Navigated to Sent Requests Page");
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

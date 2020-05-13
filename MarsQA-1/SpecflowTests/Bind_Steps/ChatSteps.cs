using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowTests.Bind_Steps
{
    [Binding]
    public class ChatSteps
    {
        Chat obj = new Chat();

        [Given(@"I clicked on chat under Profile page")]
        public void GivenIClickedOnChatUnderProfilePage()
        {
            //Click on Chat
           obj.ChatTab.Click();
        }

        [When(@"I enter message in message page")]
        public void WhenIEnterMessageInMessagePage()
        {
            //Enter Message
            obj.EnterChatMessage.SendKeys("Hello siddu");


            //Click on Send
            obj.Send.Click();
        }
           


        [Then(@"that message should be displayed on the window")]
        public void ThenThatMessageShouldBeDisplayedOnTheWindow() 
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(3000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Chat");

                Thread.Sleep(1000);
                string ExpectedValue = "Hello siddu";
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[17]//div[1]//div")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Chat Success");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Chat Success");
                    Console.WriteLine("Chat Success");
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

        [When(@"I enter user in search box in message page")]
        public void WhenIEnterUserInSearchBoxInMessagePage() 
        {
          obj.Search.SendKeys("satheesh");

            //Click in Search
          obj.ClickSearch.Click();
        }


        [Then(@"the history should be displayed on the window")]//div[@class='chatRoom']//div[1]//div[2]//div[1]
        public void ThenTheHistoryShouldBeDisplayedOnTheWindow()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Chat History");

                Thread.Sleep(1000);
                string ExpectedValue = "satheesh";
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='chatRoom']//div[1]//div[2]//div[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Chat History Retrived Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Chat History");
                    Console.WriteLine("Test Passed, Chat History Retrived Successfully");
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

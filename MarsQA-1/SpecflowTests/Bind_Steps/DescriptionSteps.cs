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
    public class DescriptionSteps
    {
        Description obj = new Description();
        Profile obj1 = new Profile();


        [Given(@"I clicked on description under Profile page")]
        public void GivenIClickedOnDescriptionUnderProfilePage()
        { 
            
            // Click on Profile tab
            obj1.ProfileTab.Click();


            //Click on Write icon
             obj.WriteIcon.Click();
        }
        
        [When(@"I enter a brief decription about myself")]
        public void WhenIEnterABriefDecriptionAboutMyself()
        {

         

            //Clear the description box
          obj.DescriptionBox.Clear();

            //Enter the description
         obj.DescriptionBox.SendKeys("i am a tester ");

            //Click Save
            obj.Save.Click();
        }
   

    [Then(@"the description should be displayed")]
    public void ThenTheDescriptionShouldBeDisplayed()
    {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Add Description");

                Thread.Sleep(1000);
                string ExpectedValue = "i am a tester";
                string ActualValue = Driver.driver.FindElement(By.XPath("//span[contains(text(),'tester')]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added Description Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "DescriptionAdded");
                    Console.WriteLine("Description Added");

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
                Console.WriteLine("Test Failed due to exception,e.Message");
            }
        }
   


    [When(@"I edit decription about myself")]
        public void WhenIEditDecriptionAboutMyself()
        {
          

            //Clear the description box
        obj.DescriptionBox.Clear();

            //Enter the description
        obj.DescriptionBox.SendKeys("i am a automation tester");

            //Click Save
           obj.Save.Click();
        }
        
       
        
        [Then(@"the edited description should be displayed")]
        public void ThenTheEditedDescriptionShouldBeDisplayed()
        {

            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Edit Description");

                Thread.Sleep(1000);
                string ExpectedValue = "i am a automation tester";
                string ActualValue = Driver.driver.FindElement(By.XPath("//span[contains(text(),'i am a automation tester')]")).Text;
                Thread.Sleep(500);
                //if (ExpectedValue == ActualValue)
                if (ActualValue.Contains(ExpectedValue))
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Edited Description Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Description Edited");
                    Console.WriteLine("Description Edited");
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
                Console.WriteLine("Test Failed due to exception,e.Message");
            }
        }
    }
}

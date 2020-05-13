using MarsQA_1.Helpers;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowTests.Bind_Steps
{
    [Binding]
    public class SanitySteps
    {
        [Then(@"Language text should be displayed")]
        public void ThenLanguageTextShouldBeDisplayed()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Language Add Button Clicked");
                string ExpectedValue = "Language";
                string ActualValue = Driver.driver.FindElement(By.XPath("//th[contains(text(),'Language')]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)


                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Add button Clicked Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Add Button Clicked");
                    Console.WriteLine("Test Passed,Language Add Button Clicked");
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

      
       

        [Then(@"Add new button of Skill tab should be displayed")]
        public void ThenAddNewButtonOfSkillTabShouldBeDisplayed()
        {

            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Skill Button Clicked");
                IWebElement add = Driver.driver.FindElement(By.XPath("//th[contains(text(),'Skill')]/following-sibling::th[2]/div"));
                if (add.Displayed)


                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Skill Button Clicked Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Add Button Displayed");
                    Console.WriteLine("Skill Button Clicked");
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
        [Then(@"Add new button of education tab should be displayed")]
        public void ThenAddNewButtonOfEducationTabShouldBeDisplayed()
        {

            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Education Button Clicked");
                IWebElement add = Driver.driver.FindElement(By.XPath("//th[contains(text(),'Country')]/following-sibling::th[5]/div"));
                if (add.Displayed)


                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Education Button Clicked Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Education Button Clicked Successfully");
                    Console.WriteLine("Education Button Clicked Successfully");
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
        [Then(@"Add new button of certification tab should be displayed")]
        public void ThenAddNewButtonOfCertificationTabShouldBeDisplayed()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("certification Button Clicked Successfully");
                IWebElement add = Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(text(),'Add New')]"));
                if (add.Displayed)


                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, certification Button Clicked Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "certification Button Clicked Successfully");
                    Console.WriteLine("certification Button Clicked Successfully");
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
        [Then(@"I should navigate to message page")]
        public void ThenIShouldNavigateToMessagePage()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("chat Button navigates to message page");
                String ActualValue=Driver.driver.Title;
                String ExpectedValue = "Message";
                if (ActualValue == ExpectedValue)


                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, message page displayed Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "message page displayed");
                    Console.WriteLine("Test Passed, message page displayed Successfully");
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





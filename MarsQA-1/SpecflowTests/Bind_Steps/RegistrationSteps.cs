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
    public class RegistrationSteps
    {
        Registration obj = new Registration();

        [Given(@"I clicked on Join under Home page")]
        public void GivenIClickedOnJoinUnderHomePage()
        {
            //Click Join
            Driver.driver.FindElement(By.XPath("//button[contains(text(),'Join')]")).Click();
        }

        [When(@"I enter details")]
        public void WhenIEnterDetails()
        {

         obj.FirstName.SendKeys("abc");
         obj.LastName.SendKeys("def");
         obj.email.SendKeys("abcdef12@gmail.com");
         obj.password.SendKeys("123456");
         obj.confirmPassword.SendKeys("123456");
         obj.terms.Click();
         obj.submitbtn.Click();

        }


        [Then(@"I should be able to register")]
        public void ThenIShouldBeAbleToRegister()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Registration");

                Thread.Sleep(1000);
                string ExpectedValue = "Home";
                string ActualValue = Driver.driver.Title;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Registration Done Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Registration Done");
                    Console.WriteLine("Registration Done Successfully");
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
        [When(@"I enter details with already registered email")]
        public void WhenIEnterDetailsWithAlreadyRegisteredEmail()
        {
            obj.FirstName.SendKeys("abc");
            obj.LastName.SendKeys("def");
            obj.email.SendKeys("abcdef11@gmail.com");
            obj.password.SendKeys("123456");
            obj.confirmPassword.SendKeys("123456");
            obj.terms.Click();
            obj.submitbtn.Click();

        }


        [Then(@"I should get error message")]
        public void ThenIShouldGetErrorMessage()
        {
           try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Registration Denied");

                Thread.Sleep(1000);
                string ExpectedValue = "This email has already been used to register an account.";
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ui basic red pointing prompt label transition visible']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Registration Denied Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Registration Denied");
                    Console.WriteLine("Registration Denied Successfully");
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

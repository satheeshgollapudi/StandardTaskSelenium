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
    public class SearchSteps
    {
        Search obj = new Search();
        Profile obj1 = new Profile();

        [Given(@"I clicked on the Profile page")]
        public void GivenIClickedOnTheProfilePage()
        {

            // Click on Profile tab
            obj1.ProfileTab.Click();

        }

        [When(@"I click on category and subcategory")]
        public void WhenIClickOnCategoryAndSubcategory()
        {
            // Click on Business under categories 
            obj.Category.Click();

            // Click on Other under subcategorie
            Driver.driver.FindElement(By.XPath("//a[contains(text(),'Other')]")).Click();
        }

        [Then(@"that skills should be displayed")]
        public void ThenThatSkillsShouldBeDisplayed()
        {

            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Category and subcategory");

                Thread.Sleep(1000);
                string ExpectedValue = "satheesh gollapudi";
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ui stackable three cards']/div[4]/div[1]/a[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Category and subcategory selected");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Category and subcategory selected");
                    Console.WriteLine("Category and subcategory selected");
                }

                else
                {
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failede.Message");
                    Console.WriteLine("Test Failed due to exception,e.Message");
                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
                Console.WriteLine("Test Failed due to exception", e.Message);
            }
        }
        [When(@"I click on Online filter")]
        public void WhenIClickOnOnlineFilter()
        {
            //Click on search button
            obj.SearchButton.Click();



            //Click on online button
            obj.OnlineButton.Click();
        }

        [Then(@"Online skills should be displayed")]
        public void ThenOnlineSkillsShouldBeDisplayed()
        {

            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Online Search");

                Thread.Sleep(3000);
                string ExpectedValue = "Priyanka Singh";
                string ActualValue = Driver.driver.FindElement(By.XPath("//a[contains(text(),'Priyanka Singh')]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Online Search selected");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Online Search selected");
                    Console.WriteLine("Online Search selected");
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


        [When(@"I clicked on Onsite filter")]
        public void WhenIClickedOnOnsiteFilter()
        {
            //Click on search button
           obj.SearchButton.Click();

           
            //Click on onsite button
           obj.OnsiteButton.Click();
           
        }


        [Then(@"Onsite skills should be displayed")]
        public void ThenOnsiteSkillsShouldBeDisplayed()
        {

            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("OnSite Search");

                Thread.Sleep(3000);
                string ExpectedValue = "Jignesh Patel";
                string ActualValue = Driver.driver.FindElement(By.XPath("//a[contains(text(),'Jignesh Patel')]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Onsite Search selected");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Onsite Search selected");
                    Console.WriteLine("Onsite Search selected");
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

        [When(@"I clicked on All filter")]
        public void WhenIClickedOnAllFilter()
        {

            //Click on search button
           obj.SearchButton.Click();

            //Click on ShowAll button
          obj.ShowAllButton.Click();

        }

           [Then(@"All skills should be displayed")]
        public void ThenAllSkillsShouldBeDisplayed()
        {

            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("ShowAll Search");

                Thread.Sleep(3000);
                string ExpectedValue = "Priyanka Singh";
                string ActualValue = Driver.driver.FindElement(By.XPath("//a[contains(text(),'Priyanka Singh')]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, ShowAll Search selected");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "ShowAll Search selected");
                    Console.WriteLine("ShowAll Search selected");
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

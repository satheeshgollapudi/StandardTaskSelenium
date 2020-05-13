using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowTests.Bind_Steps
{
    [Binding]
    public class EducationSteps
    {
        Profile obj = new Profile();

        [Given(@"I clicked on the Education tab under Profile page")]
        public void GivenIClickedOnTheEducationTabUnderProfilePage()
        {
            // Click on Profile tab
            obj.ProfileTab.Click();

            //Click on Education tab
            obj.EduBtn.Click();
          
        }

        [When(@"I add a new Education")]
        public void WhenIAddANewEducation()
        {
           

            //Click on Add New button
            obj.AddNewEducation.Click();
           

            //Add University
            obj.EnterUniversity.SendKeys("lfvm");
           

            //Choose the Country
            SelectElement choosecountry = new SelectElement(Driver.driver.FindElement(By.Name("country")));
            choosecountry.SelectByText("India");

            Thread.Sleep(2000);
            //Choose the Title
            SelectElement chooseTitle = new SelectElement(Driver.driver.FindElement(By.Name("title")));
            chooseTitle.SelectByValue("M.A");

            //Choose the Degree
            obj.Degree.SendKeys("bsc");
            

            //Choose the Year of Graduation
            SelectElement chooseYearofGraduation = new SelectElement(Driver.driver.FindElement(By.Name("yearOfGraduation")));
            chooseYearofGraduation.SelectByIndex(7);

           //Click on Add button
            obj.AddEdu.Click();
            

        }


        [Then(@"that Education should be displayed on my listings")]
        public void ThenThatEducationShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Add Education");

                Thread.Sleep(1000);
                string ExpectedValue = "lfvm";
                string ActualValue = Driver.driver.FindElement(By.XPath("//td[contains(text(),'lfvm')]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Education Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Education Added");
                    Console.WriteLine("Test Passed,Education Added");
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
        [When(@"I cancel adding a new Education")]
        public void WhenICancelAddingANewEducation()
        {
           
            //Click on Add New button
            obj.AddNewEducation.Click();


            //Add College
            obj.EnterUniversity.SendKeys("alphonsus");

            //Choose the Country
            SelectElement choosecountry = new SelectElement(Driver.driver.FindElement(By.Name("country")));
            choosecountry.SelectByText("India");

            Thread.Sleep(2000);
            //Choose the Title
            SelectElement chooseTitle = new SelectElement(Driver.driver.FindElement(By.Name("title")));
            chooseTitle.SelectByValue("M.A");

            //Choose the Degree
            obj.Degree.SendKeys("bsc");

            //Choose the Year of Graduation
            SelectElement chooseYearofGraduation = new SelectElement(Driver.driver.FindElement(By.Name("yearOfGraduation")));
            chooseYearofGraduation.SelectByIndex(7);

            //Click Cancel
            obj.CancelAddingEduTab.Click();

        }


        [Then(@"cancelled Education should not be displayed on my listings")]
        public void ThenCancelledEducationShouldNotBeDisplayedOnMyListings()
        {

            try
            {
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("cancel adding Education");
                //Start the Reports

                IList<IWebElement> Languages = Driver.driver.FindElements(By.XPath("//th[contains(text(),'Education')]/ancestor::thead/following-sibling::tbody"));


                int count = Languages.Count();
                String beforeXPath = "//th[contains(text(),'Education')]/ancestor::thead/following-sibling::tbody[";
                String AfterXPath = "]/tr/td[1]";
                bool LangFound;

                for (int i = 1; i <= count; i++)
                {

                    if (Driver.driver.FindElement(By.XPath(beforeXPath + i + AfterXPath)).Text == "alphonsus")
                    {
                        LangFound = true;
                        CommonMethods.test.Log(LogStatus.Fail, "Test Failed Education found");
                        Console.WriteLine("Test Failed");
                    }

                    else
                    {
                        LangFound = false;
                        Console.WriteLine("Test Passed,Adding Education cancelled successfully");
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Cancelled a Education Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "Education Cancelled");
                        break;

                    }

                }

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
                Console.WriteLine("Test Failed");
            }
        }

        [When(@"I delete a Education")]
        public void WhenIDeleteAEducation()
        {
            //Delete Education
            obj.DeleteEdu.Click();
           
        }

        [Then(@"that Education should be removed from the listings")]
        public void ThenThatEducationShouldBeRemovedFromTheListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Delete Education");

                Thread.Sleep(1000);
                string beforeXpath = "//th[contains(text(),'Education')]/ancestor::thead/following-sibling::tbody[";
                string afterXpath = "]/tr/td[1]";
                string ExpectedValue = "lfvm";
                bool languageFound = true;

                IList<IWebElement> EducationList = Driver.driver.FindElements(By.XPath("//th[contains(text(),'Education')]/ancestor::thead/following-sibling::tbody"));
                int EducationCount = EducationList.Count;
                //1st Method
                for (int i = 1; i <= EducationCount; i++)
                {

                    string ActualValue = Driver.driver.FindElement(By.XPath(beforeXpath + i + afterXpath)).Text;


                    Thread.Sleep(500);
                    if (ActualValue.Contains("istqb"))
                    {
                        if (ExpectedValue == ActualValue)
                        {
                            languageFound = true;
                            CommonMethods.test.Log(LogStatus.Pass, "Test Failed, Deleting a Education is unsuccessful");
                            SaveScreenShotClass.SaveScreenshot(Driver.driver, "EducationIsNotDeleted");
                            Console.WriteLine("Education IsNot Deleted");
                        }
                        else
                            CommonMethods.test.Log(LogStatus.Fail, "Test Passed");
                        Console.WriteLine("Test Passed,Education Deleted");
                    }
                    else
                    {
                        languageFound = false;
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Education not found");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "Education Not Found");
                        Console.WriteLine("Test Passed, Certificate not found");
                        break;
                    }

                }

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed due to exception", e.Message);
                Console.WriteLine("Test Failed due to exception");
            }
        }
       
        [When(@"I update a Education")]
        public void WhenIUpdateAEducation()
        {

            //Click on Update Education Icon
           obj.UpdateEduIcon.Click();
           

            //Choose the Graduation Year
            SelectElement GraduationYear = new SelectElement(Driver.driver.FindElement(By.Name("yearOfGraduation")));
            GraduationYear.SelectByValue("2011");


            //Click on Update Education Tab
            obj.UpdateEduTab.Click();
        }

        [Then(@"that Education should be updated in the listings")]
        public void ThenThatEducationShouldBeUpdatedInTheListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Update Education");

                Thread.Sleep(1000);
                string ExpectedValue = "2011";
                string ActualValue = Driver.driver.FindElement(By.XPath("//td[contains(text(),'2011')] ")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Updated a Education Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Education Updated");
                    Console.WriteLine("Test Passed, Updated a Education Successfully");
                }

                else
                {
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                    Console.WriteLine("Test Failed");
                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed due to exception", e.Message);
                Console.WriteLine("Test Failed due to exception");
            }
        }

        [When(@"I click on Edit Education and click on cancel button")]
        public void WhenIClickOnEditEducationAndClickOnCancelButton()
        {
            //Update Education
           obj.UpdateEduIcon.Click();

            //Update Degree
            Driver.driver.FindElement(By.Name("degree")).SendKeys("Msc");


            //Cancel Update 
         obj.CancelUpdate.Click();



        }

        [Then(@"that same Education details should be displayed on my listing")]
        public void ThenThatSameEducationDetailsShouldBeDisplayedOnMyListing()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Cancel Update Education");

                Thread.Sleep(1000);
                string ExpectedValue = "bsc";
                string ActualValue = Driver.driver.FindElement(By.XPath("//td[contains(text(),'bsc')] ")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Cancelled Updating Education Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Education Update Cancelled");
                    Console.WriteLine("Test Passed, Cancelled Updating a Education Successfully");
                }

                else
                {
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                    Console.WriteLine("Test Failed");
                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed due to exception", e.Message);
                Console.WriteLine("Test Failed due to exception");
            }
        }
    }
}

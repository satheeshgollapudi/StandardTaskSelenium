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
    public class SkillsSteps
    {
        Profile obj = new Profile();

        [Given(@"I clicked on the Skills tab under Profile page")]
        public void GivenIClickedOnTheSkillsTabUnderProfilePage()
        {

            // Click on Profile tab
            obj.ProfileTab.Click();

            //Click on Skills tab
            obj.SkillBtn.Click();

        }

        [When(@"I add a new skill")]
        public void WhenIAddANewSkill()
        {
            //Click on Add Skills Button 
            obj.AddNewSkillBtn.Click();

            //Add Skill
            obj.AddSkillText.SendKeys("MS Office");

            //Choose the language level
            SelectElement chooseLanguageLevel = new SelectElement(Driver.driver.FindElement(By.Name("level")));
            chooseLanguageLevel.SelectByText("Expert");

            //Click on Add button
             obj.AddSkill.Click();

        }


        [Then(@"that skill should be displayed on my listings")]
        public void ThenThatSkillShouldBeDisplayedOnMyListings()
        {

            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Add a Skill");

                Thread.Sleep(1000);
                string ExpectedValue = "MS Office";
                string ActualValue = Driver.driver.FindElement(By.XPath("//td[contains(text(),'MS Office')]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Skill Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Skill Added");
                    Console.WriteLine("TestPassed,Skill Added");
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

        [When(@"I cancel adding a new skill")]
        public void WhenICancelAddingANewSkill()
        {
            //Click on Add Skills Button 
            obj.AddNewSkillBtn.Click();

            //Add Skill
            obj.AddSkillText.SendKeys("testing");

            //Choose the language level
            SelectElement chooseLanguageLevel = new SelectElement(Driver.driver.FindElement(By.Name("level")));
            chooseLanguageLevel.SelectByText("Expert");



            //Click on Cancel Button
            obj.SkillCancelBtn.Click();
            
        }

        [Then(@"cancelled skill should not be displayed on my listings")]
        public void ThenCancelledSkillShouldNotBeDisplayedOnMyListings()
        {
            try
            {
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("cancel addind a Skill");
                //Start the Reports

                IList<IWebElement> Skills = Driver.driver.FindElements(By.XPath("//table[@class='ui fixed table']//tbody"));
                int count = Skills.Count();


                String beforeXPath = "//table[@class='ui fixed table']//tbody[";
                String AfterXPath = "]//tr//td[1]";
                bool SkillFound;

                for (int i = 1; i <= count; i++)
                {

                    if (Driver.driver.FindElement(By.XPath(beforeXPath + i + AfterXPath)).Text == "testing")
                    {
                        SkillFound = true;
                        CommonMethods.test.Log(LogStatus.Fail, "Test Failed Skill found");
                        Console.WriteLine("Test Failed");
                       // break;
                    }

                    else
                    {
                        SkillFound = false;
                        Console.WriteLine("TestPassed,Adding Skill cancelled successfully");
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Cancelled a Skill Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillCancelled");
                        break;


                    }

                }

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
                Console.WriteLine("Test Failed due to exception");
            }
        }

        [When(@"I delete a skill")]
        public void WhenIDeleteASkill()
        {
            //Delete Skill
            obj.SkillDeleteBtn.Click();
            //Driver.driver.FindElement(By.XPath("//tbody/tr/td[contains(text(),'MS Office')]//ancestor::tr//child::i[@class='remove icon']")).Click();
        }

        [Then(@"that skill should be removed from the listings")]
        public void ThenThatSkillShouldBeRemovedFromTheListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Deleted  Skill not shown");

                String beforeXPath = "//table[@class='ui fixed table']//tbody[";
                String AfterXPath = "]//tr//td[1]";
                bool SkillFound;
                string ExpectedValue = "MS Office";
                bool languageFound = true;

               

                IList<IWebElement> SkillList = Driver.driver.FindElements(By.XPath("//table[@class='ui fixed table']/tbody/tr/td[1]"));
                int SkillCount = SkillList.Count;
                //1st Method
                for (int i = 1; i <= SkillCount; i++)
                {

                    string ActualValue = Driver.driver.FindElement(By.XPath(beforeXPath + i + AfterXPath)).Text;


                    Thread.Sleep(500);
                    if (ActualValue.Contains("MS Office"))
                    {
                        if (ExpectedValue == ActualValue)
                        {
                            languageFound = true;
                            CommonMethods.test.Log(LogStatus.Pass, "Test Failed, Deleting a Skill  is unsuccessful");
                            SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageIsNotDeleted");
                            Console.WriteLine("Test Failed");
                        }
                        else
                            CommonMethods.test.Log(LogStatus.Fail, "Test Passed");
                        Console.WriteLine("Test Passed");
                    }
                    else
                    {
                        languageFound = false;
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Skill  not found");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "Skill DeletedAndNotFound");
                        Console.WriteLine("Test Passed, Skill DeletedAndNotFound");
                        break;
                    }

                }

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
                Console.WriteLine("Test Failed due to exception");
            }
        }

        [When(@"I update a skill")]
        public void WhenIUpdateASkill()
        {
            //click on Update Icon
          
           obj.SkillUpdateIcon.Click();

            //Select the new Skill level
            SelectElement chooseSkillLevel = new SelectElement(Driver.driver.FindElement(By.Name("level")));
            chooseSkillLevel.SelectByText("Expert");

            //Click on update
           obj.SkillUpdateBtn.Click();
        }


        [Then(@"that skill should be updated in the listings")]
        public void ThenThatSkillShouldBeUpdatedInTheListings()
        {

            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Update a Skill");

                Thread.Sleep(1000);
                string ExpectedValue = "Expert";
                string ActualValue = Driver.driver.FindElement(By.XPath("//tbody/tr/td[contains(text(),'Automation Testing')]//following-sibling::td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Updated a Skill Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Skill LevelUpdated");
                    Console.WriteLine("Test Passed");
                }

                else { 
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                    Console.WriteLine("Test Failed ");
                    
                }

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed due to exception", e.Message);
                Console.WriteLine("Test Failed due to exception");
            }
        }


        [When(@"I tried to click on Edit and click on cancel button")]
        public void ItriedtoclickonEditandclickoncancelbutton()
        {
            //click on Update Icon

            obj.SkillUpdateIcon.Click();

            //Select the new language level
            SelectElement chooseLanguageLevel = new SelectElement(Driver.driver.FindElement(By.Name("level")));
            chooseLanguageLevel.SelectByText("Beginner");

            //Click on Cancel 
          obj.SkillCancelBtn.Click();
        }


        [Then(@"that same skill details should be displayed on my listing")]
        public void ThenThatSameSkillDetailsShouldBeDisplayedOnMyListing()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Cancel Edit Skill");

                Thread.Sleep(1000);
                string ExpectedValue = "Expert";
                string ActualValue = Driver.driver.FindElement(By.XPath("//tbody/tr/td[contains(text(),'Automation Testing')]//following-sibling::td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Cancel Edit Skill Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Cancel Edit Skill Successfully");
                    Console.WriteLine("Test Passed, Cancel Edit Skill Successfully");
                }

                else
                {
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                    Console.WriteLine("Test Failed ");

                }

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed due to exception", e.Message);
                Console.WriteLine("Test Failed due to exception");
            }
        }

        [When(@"I add a skill that already exists with different level")]
        public void WhenIAddASkillThatAlreadyExistsWithDifferentLevel()
        {

            Thread.Sleep(2000);
            //Click on Add Skills Button 
            obj.AddNewSkillBtn.Click();

            //Add Skill
            obj.AddSkillText.SendKeys("Automation Testing");

            //Choose the language level
            SelectElement chooseLanguageLevel = new SelectElement(Driver.driver.FindElement(By.Name("level")));
            chooseLanguageLevel.SelectByText("Beginner");

            //Click on Add button
            obj.AddSkill.Click();
        }

        [Then(@"it should throw an error message for different level")]
        public void ThenItShouldThrowAnErrorMessageForDifferentLevel()
        {

            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Add same Skill with different level ");
                Thread.Sleep(1000);
                string ExpectedValue = "Expert";
                string ActualValue = Driver.driver.FindElement(By.XPath("//td[contains(text(),'Automation Testing')]/following-sibling::td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Error message pops up");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageNotAdded");
                    Console.WriteLine("Test Passed,Same Language not Added");

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
                Console.WriteLine("Test Failed due to exceptionn", e.Message);

            }
        }

        [When(@"I add a skill that already exists with same level")]
        public void WhenIAddASkillThatAlreadyExistsWithSameLevel()
        {
            //Wait
            Thread.Sleep(2000);

            //Click on Add Skills Button 
            obj.AddNewSkillBtn.Click();

            //Add Skill
            obj.AddSkillText.SendKeys("Automation Testing");

            //Choose the language level
            SelectElement chooseLanguageLevel = new SelectElement(Driver.driver.FindElement(By.Name("level")));
            chooseLanguageLevel.SelectByText("Expert");

            //Click on Add button
            obj.AddSkill.Click();

        }
    

       

        [Then(@"it should throw an error message for same level")]
        public void ThenItShouldThrowAnErrorMessageForSameLevel()
     
        {
        try
        {
            //Start the Reports
            CommonMethods.ExtentReports();
            Thread.Sleep(1000);
            CommonMethods.test = CommonMethods.Extent.StartTest("Add same Skill with same level ");
            Thread.Sleep(1000);
            string ExpectedValue = "Expert";
            string ActualValue = Driver.driver.FindElement(By.XPath("//td[contains(text(),'Automation Testing')]/following-sibling::td[1]")).Text;
            Thread.Sleep(500);
            if (ExpectedValue == ActualValue)
            {
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Error message pops up");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageNotAdded");
                Console.WriteLine("Test Passed,Same Language not Added");

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
            Console.WriteLine("Test Failed due to exceptionn", e.Message);

        }
    }
}
    }

    


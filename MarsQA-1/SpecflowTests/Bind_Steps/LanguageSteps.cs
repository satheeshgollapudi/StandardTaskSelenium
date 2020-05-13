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
    public class LanguageSteps
    {
        Profile obj = new Profile();

        [Given(@"I clicked on the Language tab under Profile page")]
        public void GivenIClickedOnTheLanguageTabUnderProfilePage()
        {
           

            // Click on Profile tab
            obj.ProfileTab.Click();
           

            //Click on Languages tab
         obj.LanBtn.Click();
          

          

        }

        [When(@"I add a new language")]
        public void WhenIAddANewLanguage()
        {


            //Click on Add New button
            obj.AddNewLangBtn.Click();
            //Driver.driver.FindElement(By.XPath("(//div[contains(text(),'Add New')])[1]")).Click();


            //Add Language
            obj.AddLangText.SendKeys("English");
           
            //Choose the language level
            obj.ChooseLang.Click();
            // SelectElement chooseLanguageLevel = new SelectElement(Driver.driver.FindElement(By.Name("level")));
            //chooseLanguageLevel.SelectByText("Fluent");


            //Click on Add button
            obj.AddLang.Click();
           

        }

        [Then(@"that language should be displayed on my listings")]
        public void ThenThatLanguageShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Add a Language");

                Thread.Sleep(1000);
                string ExpectedValue = "English";
                string ActualValue = Driver.driver.FindElement(By.XPath("//td[contains(text(),'English')]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageAdded");
                    Console.WriteLine("Test Passed,LanguageAdded");
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

        [When(@"I cancel adding a new language")]
        public void WhenICancelAddingANewLanguage()
        {
            //Click on Add New button
            obj.AddNewLangBtn.Click();


            //Add Language
            obj.AddLangText.SendKeys("french");

            //Choose the language level
            obj.ChooseLang.Click();

            //Click on Cancel Button
            obj.CancelBtn.Click();
            


        }


        [Then(@"cancelled language should not be displayed on my listings")]
        public void ThenCancelledLanguageShouldNotBeDisplayedOnMyListings()
        {
            try
            {
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("cancel addind a Language");
                //Start the Reports

                IList<IWebElement> Languages = Driver.driver.FindElements(By.XPath("//th[text()='Language']//ancestor::thead//following-sibling::tbody"));


                int count = Languages.Count();
                String beforeXPath = "//th[text()='Language']//ancestor::thead//following-sibling::tbody[";
                String AfterXPath = "]/tr/td[1]";
                bool LangFound;

                for (int i = 1; i <= count; i++)
                {

                    if (Driver.driver.FindElement(By.XPath(beforeXPath + i + AfterXPath)).Text == "french")
                    {
                        LangFound = true;
                        CommonMethods.test.Log(LogStatus.Fail, "Test Failed lan found");
                        Console.WriteLine("Test Failed");
                    }

                    else
                    {
                        LangFound = false;
                        Console.WriteLine("Test Passed,Adding language cancelled successfully");
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Cancelled a Language Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageCancelled");
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
        [When(@"I delete a language")]
        public void WhenIDeleteALanguage()
        {
            //Click on Delete
            obj.DeleteBtn.Click();
           

        }

 [Then(@"that language should be removed from the listings")]
        public void ThenThatLanguageShouldBeRemovedFromTheListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Deleted  Language not shown");

                Thread.Sleep(1000);
                string beforeXpath = "//tbody[";
                string afterXpath = "]/tr/td[1]";
                string ExpectedValue = "English";
                bool languageFound = true;

                /*2nd Method*/

                //IWebElement tableElement = Driver.driver.FindElement(By.XPath("//table[@class='ui fixed table']"));
                //IList<IWebElement> languageList = tableElement.FindElements(By.TagName("tbody"));

                //1st Method

                IList<IWebElement> languageList = Driver.driver.FindElements(By.XPath("//table[@class='ui fixed table']/tbody/tr/td[1]"));
                int languageCount = languageList.Count;
                //1st Method
                for (int i = 1; i <= languageCount; i++)
                {

                    string ActualValue = Driver.driver.FindElement(By.XPath(beforeXpath + i + afterXpath)).Text;


                    Thread.Sleep(500);
                    if (ActualValue.Contains("English"))
                    {
                        if (ExpectedValue == ActualValue)
                        {
                            languageFound = true;
                            CommonMethods.test.Log(LogStatus.Pass, "Test Failed, Deleting a language is unsuccessful");
                            SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageIsNotDeleted");
                            Console.WriteLine("Language IsNot Deleted");
                        }
                        else
                            CommonMethods.test.Log(LogStatus.Fail, "Test Passed");
                        Console.WriteLine("Test Passed,Language Deleted");
                    }
                    else
                    {
                        languageFound = false;
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Languag not found");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "Language Not Found");
                        Console.WriteLine("Language not found");
                        break;
                    }

                }

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }


        [When(@"I add a language that already exists with different level")]
        public void WhenIAddALanguageThatAlreadyExistsWithDifferentLevel()
        {


            //Click on Add New button
            obj.AddNewLangBtn.Click();
            //Driver.driver.FindElement(By.XPath("(//div[contains(text(),'Add New')])[1]")).Click();


            //Add Language
            obj.AddLangText.SendKeys("Tamil");

            //Choose the language level
            //obj.ChooseLang.Click();
            SelectElement chooseLanguageLevel = new SelectElement(Driver.driver.FindElement(By.Name("level")));
            chooseLanguageLevel.SelectByText("Fluent");


            //Click on Add button
            obj.AddLang.Click();
        }

        [Then(@"it should throw an error message of duplicated data")]
        public void ThenItShouldThrowAnErrorMessageofduplicteddata()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Add same Language ");
                Thread.Sleep(1000);
                string ExpectedValue = "Tamil";
                string ActualValue = Driver.driver.FindElement(By.XPath("//td[contains(text(),'Tamil')]")).Text;
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


        [When(@"I add a language that already exists with same level")]
        public void WhenIAddALanguageThatAlreadyExistsWithSameLevel()
        {
            //Click on Add New button
            obj.AddNewLangBtn.Click();
           


            //Add Language
            obj.AddLangText.SendKeys("Tamil");

            //Choose the language level
            //obj.ChooseLang.Click();
        SelectElement chooseLanguageLevel = new SelectElement(Driver.driver.FindElement(By.Name("level")));
            chooseLanguageLevel.SelectByText("Basic");


            //Click on Add button
            obj.AddLang.Click();
        }

        [Then(@"it should throw an error message of language exists")]
        public void ThenItShouldThrowAnErrorMessageoflanguageexists()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Add same Language ");




                Thread.Sleep(1000);
                string ExpectedValue = "Tamil";
                string ActualValue = Driver.driver.FindElement(By.XPath("//td[contains(text(),'Tamil')]")).Text;
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



        [When(@"I add a four new language with (.*) and (.*)")]
        public void WhenIAddAFourNewLanguageWithAnd(string language, string level)
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Add four Languages");
                IList<IWebElement> rows = Driver.driver.FindElements(By.XPath("(//table[@class='ui fixed table'])[1]"));
                int rowCount = rows.Count;
                //CommonMethods.isElementPresent(By.XPath("(//div[contains(text(),'Add New')])[1]"));

                IWebElement addNewButton = Driver.driver.FindElement(By.XPath("(//div[contains(text(),'Add New')])[1]"));
                if (addNewButton.Displayed)
                {

                    //Click on Add New button
                    obj.AddNewLangBtn.Click();
                    //Driver.driver.FindElement(By.XPath("(//div[contains(text(),'Add New')])[1]")).Click();


                    //Add Language
                    obj.AddLangText.SendKeys(language);

                    //Choose the language level
                    obj.ChooseLang.Click();
                    // SelectElement chooseLanguageLevel = new SelectElement(Driver.driver.FindElement(By.Name("level")));
                    //chooseLanguageLevel.SelectByText(level);


                    //Click on Add button
                    obj.AddLang.Click();
                    
                }
                else
                {
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed - Adding more than 4 languages is not possible");
                    Console.WriteLine("Test Failed -Adding more than 4 is not possible");
                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }
        [Then(@"those (.*) should be displayed on my listings")]
        public void ThenThoseEnglishShouldBeDisplayedOnMyListings(string language)
        {

            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Add a Language");

                Thread.Sleep(1000);
                IList<IWebElement> rows = Driver.driver.FindElements(By.XPath("//th[text()='Language']//ancestor::thead//following-sibling::tbody"));
                int rowCount = rows.Count;
                string beforeXpath = "//th[text()='Language']//ancestor::thead//following-sibling::tbody[";
                string afterXpath = "]/tr/td[1]";
                string ExpectedValue = language;
                // foreach(IWebElement row in rows)
                for (int i = 1; i <= rowCount; i++)
                {
                    // string ActualValue = Driver.driver.FindElement(By.XPath("//tbody[1]/tr/td[1]")).Text;
                    string ActualValue = Driver.driver.FindElement(By.XPath(beforeXpath + i + afterXpath)).Text;
                    Thread.Sleep(500);
                    if (ActualValue.Contains(language))
                    {
                        if (ExpectedValue == ActualValue)
                        {
                            CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");
                            SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageAdded");
                            Console.WriteLine("Test Passed", language + "LanguageAdded");
                        }
                        else
                        {
                            CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                            Console.WriteLine("Test Failed");
                        }
                    }

                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed due to exception", e.Message);
                Console.WriteLine("Test Failed due to exception");
            }

        }


        [When(@"I update a language")]
        public void WhenIUpdateALanguage()
        {
            //Update a language,click the Icon
            obj.UpdateIcon.Click();
          

            //Select the new language level
            SelectElement chooseLanguageLevel = new SelectElement(Driver.driver.FindElement(By.Name("level")));
            chooseLanguageLevel.SelectByText("Fluent");

            //Click on update
            obj.UpdateBtn.Click();
          
        }

        [Then(@"that language should be updated in the listings")]
        public void ThenThatLanguageShouldBeUpdatedInTheListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Update a Language");

                Thread.Sleep(1000);
                string ExpectedValue = "Fluent";
                string ActualValue = Driver.driver.FindElement(By.XPath("//tbody/tr/td[contains(text(),'Malayalam')]//..//following-sibling::td[1] ")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Updated a Language Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageLevelUpdated");
                    Console.WriteLine("Test Passed, Updated a Language Successfully");
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


        [When(@"I click on Edit and click on cancel button")]
        public void WhenIClickOnEditAndClickOnCancelButton()
        {


            //Update a language,click the level

            Driver.driver.FindElement(By.XPath("//tbody/tr/td[contains(text(),'Malayalam')]//..//following-sibling::td[2]/span[1]/i[@class='outline write icon']")).Click();

            //Select the new language level
            SelectElement chooseLanguageLevel = new SelectElement(Driver.driver.FindElement(By.Name("level")));
            chooseLanguageLevel.SelectByText("Basic");

            //Click on Cancel
            obj.CancelBtn.Click();
            //Driver.driver.FindElement(By.XPath("//input[@value='Cancel']")).Click();


        }


        [Then(@"that same language details should be displayed on my listing")]
        public void ThenThatSameLanguageDetailsShouldBeDisplayedOnMyListing()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("verified Cancel Edit Language");

                Thread.Sleep(1000);
                string ExpectedValue = "Malayalam";

                string ActualValue = Driver.driver.FindElement(By.XPath("//td[text()='Malayalam']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, verified Cancel Edit Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "verified Cancelled Edit");
                    Console.WriteLine("Test Passed, verified Cancel Edit Successfully");
                }

                else
                {
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed because expected notequal");
                    Console.WriteLine("Test Failed");

                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
                Console.WriteLine( "Test Failed due to exception", e.Message);
            }

        }







        [When(@"I try to add a language when there are already four language existing")]
        public void WhenITryToAddALanguageWhenThereAreAlreadyFourLanguageExisting()
        {
            //IWebElement addNewButton = Driver.driver.FindElement(By.XPath("(//div[contains(text(),'Add New')])[1]"));
            //if (addNewButton.Displayed)
            // if(isElementPresent(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")))
            //if (isElementPresent(By.XPath("//div[2]/div/div[2]/div/table/thead/tr/th[3]/div[contains(text(),'Add New')]")))
            IWebElement addNewButton = Driver.driver.FindElement(By.XPath("(//div[contains(text(),'Add New')])[1]"));
            if (addNewButton.Displayed)

            {
                //Click on Add New button
                Driver.driver.FindElement(By.XPath("(//div[contains(text(),'Add New')])[1]")).Click();

                //Add Language
                Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).SendKeys("Hindi");

                //Choose the language level
                SelectElement chooseLanguageLevel = new SelectElement(Driver.driver.FindElement(By.Name("level")));
                chooseLanguageLevel.SelectByText("Basic");

                //Click on Add button
                Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();

                //Wait
                Thread.Sleep(500);
            }

            else
            {
                //CommonMethods.test.Log(LogStatus.Fail, "Test Failed - Adding more than 4 languages is not possible");
                Console.WriteLine("Test Failed -Adding more than 4 is not possible");
            }
        }
        [Then(@"it should not be added to the listing")]
        public void ThenItShouldNotBeAddedToTheListing()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Language not added");

                Thread.Sleep(1000);
                string beforeXpath = "//tbody[";
                string afterXpath = "]/tr/td[1]";
                string ExpectedValue = "Hindi";
                bool languageFound = false;

                /*2nd Method*/
                //===============
                //IWebElement tableElement = Driver.driver.FindElement(By.XPath("//table[@class='ui fixed table']"));
                //IList<IWebElement> languageList = tableElement.FindElements(By.TagName("tbody"));

                //1st Method
                //=================
                IList<IWebElement> languageList = Driver.driver.FindElements(By.XPath("//table[@class='ui fixed table']/tbody/tr/td[1]"));
                int languageCount = languageList.Count;
                //1st Method
                for (int i = 1; i <= languageCount; i++)
                {

                    string ActualValue = Driver.driver.FindElement(By.XPath(beforeXpath + i + afterXpath)).Text;

                    //2nd Method
                    /*foreach (IWebElement language in languageList)
                    {
                        Thread.Sleep(500);
                        string ActualValue = language.Text;
                        if (ActualValue.Contains("English"))
                        {
                            if (ExpectedValue == ActualValue)
                            {
                                languageFound = true;
                                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Deleting a language is unsuccessful");
                                SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageIsNotDeleted");
                                break;
                            }
                            else
                                CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                        }
                        else
                        {
                            languageFound = false;
                            CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Deleted a Language Successfully");
                            SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageDeletedAndNotFound");
                            break;
                        }
                    }*/
                    Thread.Sleep(500);
                    if (ActualValue.Contains("Hindi"))
                    {
                        if (ExpectedValue == ActualValue)
                        {
                            languageFound = true;
                            CommonMethods.test.Log(LogStatus.Pass, "Test failed, Language has been added");
                            SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageIsAdded");
                            Console.WriteLine("Test failed,Language Is Added");
                        }
                        else
                            CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                    }
                    else
                    {
                        languageFound = false;
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Language is not added successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageIsNotAdded");
                        Console.WriteLine("Test Passed,LanguageIsNotAdded");
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

    }
}

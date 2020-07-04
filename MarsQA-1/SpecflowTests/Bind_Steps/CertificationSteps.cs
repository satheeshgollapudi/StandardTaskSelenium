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
    public class CertificationSteps
    {
        Profile obj = new Profile();

        [Given(@"I clicked on the Certification tab under Profile page")]
        public void GivenIClickedOnTheCertificationTabUnderProfilePage()
        {

            // Click on Profile tab
            obj.ProfileTab.Click();

            //Click on Certification  tab
            obj.CertiBtn.Click();
          

         }

        [When(@"I add a new Certification")]
        public void WhenIAddANewCertification()
        {

            //Click on Add New button
            obj.AddNewCerti.Click();
           

            //Add Certificate
            obj.EnterCerti.SendKeys("istqb");
           
           //Add From
           obj.CertiFrom.SendKeys("computia");
           

            //Choose the CertificationYear
            SelectElement chooseYear= new SelectElement(Driver.driver.FindElement(By.Name("certificationYear")));
           chooseYear.SelectByValue("2009");


            //Click on Add button
            obj.AddCerti.Click();
           
        }


        [Then(@"that Certification should be displayed on my listings")]
        public void ThenThatCertificationShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Add Certification");

                Thread.Sleep(1000);
                string ExpectedValue = "istqb";
                string ActualValue = Driver.driver.FindElement(By.XPath("//td[contains(text(),'istqb')]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Certificate Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Certificate Added");
                    Console.WriteLine("Certificate Added");
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
                Console.WriteLine("Test Failed due to exception", e.Message);


            }
        }

        [When(@"I cancel adding a new Certification")]
        public void WhenICancelAddingANewCertification()
        {

            //Click on Add New button
            obj.AddNewCerti.Click();

            //Add Certificate
            obj.EnterCerti.SendKeys("toefl");


            //Add From
            obj.CertiFrom.SendKeys("uni");

            //Choose the CertificationYear
            SelectElement chooseYear = new SelectElement(Driver.driver.FindElement(By.Name("certificationYear")));
            chooseYear.SelectByValue("2005");

            //Cancel Adding Certification
           obj.CancelAddCerti.Click();
        }


        [Then(@"cancelled Certification should not be displayed on my listings")]
        public void ThenCancelledCertificationShouldNotBeDisplayedOnMyListings()
        {

            try
            {
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("cancel addind a Certificate");
                //Start the Reports

                IList<IWebElement> Languages = Driver.driver.FindElements(By.XPath("//th[contains(text(),'Certificate')]/ancestor::thead/following-sibling::tbody"));


                int count = Languages.Count();
                String beforeXPath = "//th[contains(text(),'Certificate')]/ancestor::thead/following-sibling::tbody[";
                String AfterXPath = "]/tr/td[1]";
                bool LangFound;

                for (int i = 1; i <= count; i++)
                {

                    if (Driver.driver.FindElement(By.XPath(beforeXPath + i + AfterXPath)).Text == "toefl")
                    {
                        LangFound = true;
                        CommonMethods.test.Log(LogStatus.Fail, "Test Failed Certificate found");
                        Console.WriteLine("Test Failed");
                    }

                    else
                    {
                        LangFound = false;
                        Console.WriteLine("Adding Certificate cancelled successfully");
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Cancelled a CertificateSuccessfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "Certificate Cancelled");
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

        [When(@"I delete a Certification")]
        public void WhenIDeleteACertification()
        {
            Thread.Sleep(3000);
          obj.DeleteCerti.Click();
        }

        [Then(@"that Certification should be removed from the listings")]
        public void ThenThatCertificationShouldBeRemovedFromTheListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Delete Certification");

                Thread.Sleep(1000);
                string beforeXpath = "//th[contains(text(),'Certificate')]/ancestor::thead/following-sibling::tbody[";
                string afterXpath = "]/tr/td[1]";
                string ExpectedValue = "istqb";
                bool languageFound = true;

                IList<IWebElement> CertificateList = Driver.driver.FindElements(By.XPath("//th[contains(text(),'Certificate')]/ancestor::thead/following-sibling::tbody"));
                int CertificateCount = CertificateList.Count;
                //1st Method
                for (int i = 1; i <= CertificateCount; i++)
                {

                    string ActualValue = Driver.driver.FindElement(By.XPath(beforeXpath + i + afterXpath)).Text;


                    Thread.Sleep(500);
                    if (ActualValue.Contains("istqb"))
                    {
                        if (ExpectedValue == ActualValue)
                        {
                            languageFound = true;
                            CommonMethods.test.Log(LogStatus.Pass, "Test Failed, Deleting a Certificate is unsuccessful");
                            SaveScreenShotClass.SaveScreenshot(Driver.driver, "CertificateIsNotDeleted");
                            Console.WriteLine("Certificate IsNot Deleted");
                        }
                        else
                            CommonMethods.test.Log(LogStatus.Fail, "Test Passed");
                        Console.WriteLine("Certificate Deleted");
                    }
                    else
                    {
                        languageFound = false;
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Certificate not found");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "Certificate Not Found");
                        Console.WriteLine("Certificate not found");
                        break;
                    }

                }

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }


        [When(@"I update a Certification")] 
        public void WhenIUpdateACertification()
        {

            //Update a Certificate
           obj.UpdateCertiIcon.Click();

            //Choose the CertificationYear
            SelectElement chooseYear = new SelectElement(Driver.driver.FindElement(By.Name("certificationYear")));
            chooseYear.SelectByValue("2005");


            //Click on update Tab
            obj.UpdateCertiTab.Click();
        }


        [Then(@"that Certification should be updated in the listings")]
        public void ThenThatCertificationShouldBeUpdatedInTheListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Update a Certificate");

                Thread.Sleep(1000);
                string ExpectedValue = "2005";
                string ActualValue = Driver.driver.FindElement(By.XPath("//td[contains(text(),'2005')] ")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Updated a Certificate Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Certificate Updated");
                    Console.WriteLine("Test Passed, Updated a CertificateSuccessfully");
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

        [When(@"I click on Edit Certification and click on cancel button")]
        public void WhenIClickOnEditCertificationAndClickOnCancelButton()
        {
            //Update a Certificate
            obj.UpdateCertiIcon.Click();

            //Choose the CertificationYear
            SelectElement chooseYear = new SelectElement(Driver.driver.FindElement(By.Name("certificationYear")));
            chooseYear.SelectByValue("2000");


            //Cancel Update a Certificate
         obj.CancelUpdateCertiTab.Click();
        }
       
     
        
      
        
        [Then(@"that same Certification details should be displayed on my listing")]
        public void ThenThatSameCertificationDetailsShouldBeDisplayedOnMyListing()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Cancel Update a Certificate");

                Thread.Sleep(1000);
                string ExpectedValue = "2005";
                string ActualValue = Driver.driver.FindElement(By.XPath("//td[contains(text(),'2005')] ")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Cancelled Updating a Certificate Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Certificate Update Cancelled");
                    Console.WriteLine("Test Passed, Cancelled Updating a CertificateSuccessfully");
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

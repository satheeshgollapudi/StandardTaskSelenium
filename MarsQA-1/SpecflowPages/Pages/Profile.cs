using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Profile
    {

        private object driver;
        public Profile()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        #region  Initialize Web Elements 
        //Click on Profile Tab
        [FindsBy(How = How.XPath, Using = "//div[@class='ui eight item menu']//a[@class='item'][contains(text(),'Profile')]")]
        public IWebElement ProfileTab{ get; set; }

        //Click on Edit button
        [FindsBy(How = How.XPath, Using = "//i[@class='large calendar icon']/parent::span/following-sibling::div/span/i")]
        public  IWebElement AvailabilityTimeEdit { get; set; }

        //Click on Availability Time dropdown
        [FindsBy(How = How.Name, Using = "availabiltyType")]
        public IWebElement AvailabilityTime { get; set; }

        //Click on Availability Time option
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyType']/option[3]")]
        public IWebElement AvailabilityTimeOpt { get; set; }

        //Click on Availability Hour Edit
        [FindsBy(How = How.XPath, Using = "//i[@class='large clock outline check icon']/parent::span/following-sibling::div/span/i")]
        public IWebElement AvailabilityHoursEdit { get; set; }

        //Click on Availability Hour dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyHour']")]
        public IWebElement AvailabilityHoursDropDown { get; set; }

        //Click on Availability Hour 
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyHour']/option[4]")]
        public IWebElement AvailabilityHours { get; set; }



        //Click on salary Edit
        [FindsBy(How = How.XPath, Using = "//i[@class='large dollar icon']/parent::span/following-sibling::div/span/i")]
        public IWebElement SalaryEdit { get; set; }

        //Click on salary Dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyTarget']")]
        public IWebElement SalaryDropdown { get; set; }

        //Click on salary option
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyTarget']/option[4]")]
        public IWebElement SalaryOpt { get; set; }

        //Click on Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div")]
        public IWebElement Location { get; set; }

        //Choose Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div/div[2]")]
        public IWebElement LocationOpt { get; set; }

        //Click on City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div")]
        private IWebElement City { get; set; }

        //Choose City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div/div[2]")]
        public IWebElement CityOpt { get; set; }

        //Click on Language Tab
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Languages')]")]
        public IWebElement LanBtn { get; set; }


        //Click on Add new to add new Language
        [FindsBy(How = How.XPath, Using = "//table[@class='ui fixed table']/thead/tr/th[contains(text(),'Language')]/following-sibling::th[2]/div")]
        public IWebElement AddNewLangBtn { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//input[@name='name']")]
        public IWebElement AddLangText { get; set; }

        //Click the ChooseLanguageLevel on text box
        [FindsBy(How = How.XPath, Using = "//select[@name='level']/option[2]")]
        public IWebElement ChooseLang { get; set; }

        //Enter the Level on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]")]
        public IWebElement ChooseLangOpt { get; set; }

        //Add Language
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        public IWebElement AddLang { get; set; }

        //Click on Cancel Button
        [FindsBy(How = How.XPath, Using = "//input[@value='Cancel']")]
        public IWebElement CancelBtn { get; set; }

        //Click on DeleteButton
        [FindsBy(How = How.XPath, Using = "//tbody/tr/td[contains(text(),'English')]//../following-sibling::td[2]/span[2]/i[@class='remove icon']")]
        public IWebElement DeleteBtn { get; set; }

        //Click on UpdateIcon
        [FindsBy(How = How.XPath, Using = "//tbody/tr/td[contains(text(),'Malayalam')]//..//following-sibling::td[2]/span[1]/i[@class='outline write icon']")]
        public IWebElement UpdateIcon { get; set; }

        //Click on UpdateButton
        [FindsBy(How = How.XPath, Using = "//input[@value='Update']")]
        public IWebElement UpdateBtn{ get; set; }


        //Click on Skills Tab
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Skills')]")]
        public IWebElement SkillBtn { get; set; }

        //Click on Add new to add new skill
        [FindsBy(How = How.XPath, Using = "//div[@class='ui teal button']")]
        public IWebElement AddNewSkillBtn { get; set; }

        //Enter the Skill on text box
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add Skill']")]
        public IWebElement AddSkillText { get; set; }

        //Click on skill level dropdown
        [FindsBy(How = How.XPath, Using = "//select[@class='ui fluid dropdown']")]
        public IWebElement ChooseSkill { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//select[@class='ui fluid dropdown']/option[3]")]
        public IWebElement ChooseSkilllevel { get; set; }

        //Add Skill
        [FindsBy(How = How.XPath, Using = "//span[@class='buttons-wrapper']/input[@value='Add']")]
        public IWebElement AddSkill { get; set; }

        //Click on Cancel Button
        [FindsBy(How = How.XPath, Using = "//input[@value='Cancel']")]
        public IWebElement SkillCancelBtn{ get; set; }

        //Click on Delete Button
        [FindsBy(How = How.XPath, Using = "//tbody/tr/td[contains(text(),'MS Office')]//ancestor::tr//child::i[@class='remove icon']")]
        public IWebElement SkillDeleteBtn { get; set; }

        //Click on Update Icon
        [FindsBy(How = How.XPath, Using = "//td[contains(text(),'Automation Testing')]//following-sibling::td[2]/span[1]")]
        public IWebElement SkillUpdateIcon { get; set; }

        //Click on update Button
        [FindsBy(How = How.XPath, Using = "//input[@value='Update']")]
        public IWebElement SkillUpdateBtn { get; set; }

        //Click on Education Tab
        [FindsBy(How = How.XPath, Using = "//form[@class='ui form']/div//a[contains(text(),'Education')]")]
        public IWebElement EduBtn { get; set; }

        //Click on Add new to Educaiton
        [FindsBy(How = How.XPath, Using = "//th[text()='Graduation Year']/following-sibling::th/div")]
        public IWebElement AddNewEducation { get; set; }

        //Enter university in the text box
        [FindsBy(How = How.XPath, Using = "//input[@name='instituteName']")]
        public IWebElement EnterUniversity { get; set; }

        //Choose the country
        [FindsBy(How = How.XPath, Using = "//input[@name='instituteName']/parent::div/following-sibling::div/select")]
        public IWebElement ChooseCountry { get; set; }

        //Choose the country level option
        [FindsBy(How = How.XPath, Using = "//input[@name='instituteName']/parent::div/following-sibling::div/select/option[6]")]
        private IWebElement ChooseCountryOpt { get; set; }

        //Click on Title dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='title']")]
        public IWebElement ChooseTitle { get; set; }

        //Choose title
        [FindsBy(How = How.XPath, Using = "//select[@name='title']/option[7]")]
        public IWebElement ChooseTitleOpt { get; set; }

        //Degree
        [FindsBy(How = How.XPath, Using = "//input[@name='degree']")]
        public IWebElement Degree { get; set; }

        //Year of graduation
        [FindsBy(How = How.XPath, Using = "//select[@name='yearOfGraduation']")]
        public IWebElement DegreeYear { get; set; }

        //Choose Year
        [FindsBy(How = How.XPath, Using = "//select[@name='yearOfGraduation']/option[8]")]
        public IWebElement DegreeYearOpt { get; set; }

        //Click on Add
        [FindsBy(How = How.XPath, Using = "//select[@name='yearOfGraduation']/parent::div/parent::div/following-sibling::div/div/input")]
        public IWebElement AddEdu { get; set; }

        //Click on Delete
        [FindsBy(How = How.XPath, Using = "//td[contains(text(),'lfvm')]")]
        public IWebElement DeleteEdu { get; set; }

        //Click on Update Icon
        [FindsBy(How = How.XPath, Using = "//td[contains(text(),'govt')]/following-sibling::td[4]/span[1]")]
        public IWebElement UpdateEduIcon { get; set; }

        //Click on Update Tab
        [FindsBy(How = How.XPath, Using = "//input[@class='ui teal button']")]
        public IWebElement UpdateEduTab { get; set; }

        //Cancel Update 
        [FindsBy(How = How.XPath, Using = "//input[@value='Cancel']")]
        public IWebElement CancelUpdate { get; set; }

        //Cancel adding education
        [FindsBy(How = How.XPath, Using = "//input[@value='Cancel']")]
        public IWebElement CancelAddingEduTab { get; set; }

        //Click on Cetificates Tab
        [FindsBy(How = How.XPath, Using = "//a[text()='Certifications']")]
        public IWebElement CertiBtn { get; set; }

        //Add new Certificate
        [FindsBy(How = How.XPath, Using = "//th[text()='Certificate']/following-sibling::th[3]/div")]
        public IWebElement AddNewCerti { get; set; }

        //Enter Certification Name
        [FindsBy(How = How.XPath, Using = "//input[@name='certificationName']")]
        public IWebElement EnterCerti { get; set; }

        //Certified from
        [FindsBy(How = How.XPath, Using = "//input[@name='certificationFrom']")]
        public IWebElement CertiFrom { get; set; }

        //Year
        [FindsBy(How = How.XPath, Using = "//select[@name='certificationYear']")]
        public IWebElement CertiYear { get; set; }

        //Choose Opt from Year
        [FindsBy(How = How.XPath, Using = "//select[@name='certificationYear']/option[5]")]
        public IWebElement CertiYearOpt { get; set; }

        //Add Ceritification
        [FindsBy(How = How.XPath, Using = "//input[@name='certificationFrom']/parent::div/parent::div/following-sibling::div/input[@value='Add']")]
        public IWebElement AddCerti { get; set; }

        //Cancel Add Ceritification
        [FindsBy(How = How.XPath, Using = "//input[@class='ui button']")]
        public IWebElement CancelAddCerti { get; set; }

        //Delete Ceritification
        [FindsBy(How = How.XPath, Using = "//td[contains(text(),'istqb')]/parent::tr/td[4]/span[2]/i")]
        public IWebElement DeleteCerti { get; set; }

        //Click on Update Ceritification Icon
        [FindsBy(How = How.XPath, Using = "//td[contains(text(),'networking')]/parent::tr/td[4]/span[1]")]
        public IWebElement UpdateCertiIcon { get; set; }

        //Click on Update Ceritification Tab
        [FindsBy(How = How.XPath, Using = "//input[@class='ui teal button']")]
        public IWebElement UpdateCertiTab { get; set; }

        //Cancel Update Ceritification Tab
        [FindsBy(How = How.XPath, Using = "//input[@value='Cancel']")]
        public IWebElement CancelUpdateCertiTab { get; set; }



        //Add Desctiption
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[2]/div[1]/textarea")]
        private IWebElement Description { get; set; }

        //Click on Save Button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[4]/span/button[1]")]
        public IWebElement Save { get; set; }

        #endregion

        internal void EditProfile()
        {
            //Global.GlobalDefinitions.wait(20000);
            //Populate the Excel Sheet
            //GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");


            //Click on Edit button
            AvailabilityTimeEdit.Click();
            //Select
            AvailabilityTime.Click();
            //Availability option Full Time
            AvailabilityTimeOpt.Click();
            CommonMethods.test.Log(LogStatus.Info, "Availability updated");
            Console.WriteLine("Availability updated");



            /* // Actions action = new Actions(GlobalDefinitions.driver);
             // action.MoveToElement(AvailabilityTime).Build().Perform();
              Thread.Sleep(1000);
              //IList<IWebElement> AvailableTime = AvailabilityTimeOpt.FindElements(By.TagName("div"));
              IList<IWebElement> AvailableTime = GlobalDefinitions.driver.FindElements(By.XPath("//select[@name='availabiltyType']/option"));
             int count = AvailableTime.Count;
              for (int i = 0; i < count; i++)
              {
                  if (AvailableTime[i].Text == GlobalDefinitions.ExcelLib.ReadData(2, "AvailableTime"))
                  {
                      AvailableTime[i].Click();
                      CommonMethods.test.Log(LogStatus.Info, "Select the available time");
                      Console.WriteLine(AvailableTime[i].Text);
                      Console.WriteLine(count);

                  }
              }*/
            Thread.Sleep(2000);
            //Availability Edit
            AvailabilityHoursEdit.Click();
            // Availability Hours option
            AvailabilityHoursDropDown.Click();
            //AvailabilityHours ASNeeded
            AvailabilityHours.Click();
            CommonMethods.test.Log(LogStatus.Info, "Hours updated");
            Console.WriteLine("Hours updated");

            //Salary 
            SalaryEdit.Click();
            //Choose the option from salary dropdown
            SalaryDropdown.Click();
            //SalaryOpt-More than 1000 per month
            SalaryOpt.Click();
            CommonMethods.test.Log(LogStatus.Info, "Earn Target updated");
            Console.WriteLine("Earn Target updated");




            //---------------------------------------------------------
            //Click on Add New Language button
            AddNewLangBtn.Click();

            //Enter the Language
            //AddLangText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Language"));

            //Choose Lang
            ChooseLang.Click();

            ChooseLangOpt.Click();

            AddLang.Click();
            CommonMethods.test.Log(LogStatus.Info, "Added Language successfully");
            Console.WriteLine("Added Language successfully");

            //-----------------------------------------------------------

            //Click on Skill Button
            SkillBtn.Click();

            //Click on Add New Skill Button
            AddNewSkillBtn.Click();

            //Enter the skill 
            //AddSkillText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill"));

            //Click the skill dropdown
            ChooseSkill.Click();

            ChooseSkilllevel.Click();

            AddSkill.Click();

            CommonMethods.test.Log(LogStatus.Info, "Added Skills successfully");
            Console.WriteLine("Added Skills successfully");
            //---------------------------------------------------------
            //Click on Education Tab
            EduBtn.Click();
            //Add Education
            AddNewEducation.Click();
            //Enter the University
            //EnterUniversity.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "University"));

            //Choose Country
            ChooseCountry.Click();

            //Choose Country Level
            ChooseCountryOpt.Click();

            //Choose Title
            ChooseTitle.Click();

            ChooseTitleOpt.Click();

            //Enter Degree
            //Degree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Degree"));

            //Year of Graduation
            DegreeYear.Click();

            DegreeYearOpt.Click();
            AddEdu.Click();

            CommonMethods.test.Log(LogStatus.Info, "Added Education successfully");
            Console.WriteLine("Added Education successfully");

            //-------------------------------------------------
            //Click on Certificates Tab
            CertiBtn.Click();
            //Add new Certificate
            AddNewCerti.Click();

            //Enter Certificate Name
            //EnterCerti.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Certificate"));

            //Enter Certified from
            //CertiFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "CertifiedFrom"));

            //Enter the Year
            CertiYear.Click();

            CertiYearOpt.Click();
            AddCerti.Click();

            CommonMethods.test.Log(LogStatus.Info, "Added Certificate successfully");
            Console.WriteLine("Added Certificate successfully");

            //-----------------------------------------------------



        }
    }
}

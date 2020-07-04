using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Bind_Steps
{
    [Binding]
    public class NotificationSteps
    {
        [Given(@"I clicked on the Notification")]
        public void GivenIClickedOnTheNotification()
        {
            // Click on Notification
            Driver.driver.FindElement(By.LinkText("//i[@class='icon list']/following-sibling::i")).Click();
        }

        [When(@"I select show less")]
        public void WhenISelectShowLess()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I select load more")]
        public void WhenISelectLoadMore()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I select delete")]
        public void WhenISelectDelete()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I select Mark as Read")]
        public void WhenISelectMarkAsRead()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I select Select &Unselect")]
        public void WhenISelectSelectUnselect()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user should be able to get less notifications")]
        public void ThenUserShouldBeAbleToGetLessNotifications()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user should be able to load more notifications")]
        public void ThenUserShouldBeAbleToLoadMoreNotifications()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user should be able to delete notifications")]
        public void ThenUserShouldBeAbleToDeleteNotifications()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user should be able to mark notifications as read")]
        public void ThenUserShouldBeAbleToMarkNotificationsAsRead()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user should be able to  Select &Unselect notifications")]
        public void ThenUserShouldBeAbleToSelectUnselectNotifications()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

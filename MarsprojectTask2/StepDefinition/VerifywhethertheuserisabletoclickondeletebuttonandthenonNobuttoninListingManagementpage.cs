using MarsprojectTask2.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsprojectTask2.StepDefinition
{
    [Binding]
    public  class VerifywhethertheuserisabletoclickondeletebuttonandthenonNobuttoninListingManagementpage
    {
        
        IWebDriver driver;
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

        }
        [Given(@"I login to the Mars portal")]
        public void GivenILoginToTheMarsPortal()
        {
            var LoginPage = new HomePage(driver);
            LoginPage.login();
        }
        [When(@"I enter Profile page and share page details and save them successfully,")]
        public void WhenIEnterProfilePageAndSharePageDetailsAndSaveThemSuccessfully()
        {
            var languagedetails = new ProfilePage(driver);
            languagedetails.Languagedetails();

            var skilldetails = new ProfilePage(driver);
            skilldetails.Skillsdetails();

            var educatondetials = new ProfilePage(driver);
            educatondetials.Educationdetails();

            var Certificationdetails = new ProfilePage(driver);
            Certificationdetails.Certificationdetails();

            var ServiceListingPage = new ServiceListingPage(driver);
            ServiceListingPage.ServiceListing();
        }
        [When(@"When i clicked on delete button and no from the pop up,")]
        public void WhenWhenIClickedOnDeleteButtonAndNoFromThePopUp()
        {
            var Listingmanagementclickingno = new ListingManagementPage(driver);
            Listingmanagementclickingno.ListingManagement_ClickingNo();
        }
        [Then(@"The user should see the saved details under manage listing\.")]
        public void ThenTheUserShouldSeeTheSavedDetailsUnderManageListing_()
        {
            var title = driver.FindElement(By.XPath("//*[text()='Title']"));
          
            Assert.AreEqual(title, "Title");
        }
        [AfterScenario]
        public void close()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}

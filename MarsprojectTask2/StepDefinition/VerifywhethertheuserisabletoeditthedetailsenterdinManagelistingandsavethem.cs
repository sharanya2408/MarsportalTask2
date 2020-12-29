using MarsprojectTask2.PageObject;
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
    public class VerifywhethertheuserisabletoeditthedetailsenterdinManagelistingandsavethem
    {
        IWebDriver driver;
        [BeforeScenario]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [Given(@"I login to the Mars Portal")]
        public void GivenILoginToTheMarsPortal()
        {
            var LoginPage = new HomePage(driver);
            LoginPage.login();
        }
        [When(@"I enter profile page and share page details and save them successfully")]
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
        [Then(@"The user should be able to edit the saves details under managing list in Manage listing page\.")]
        public void ThenTheUserShouldBeAbleToEditTheSavesDetailsUnderManagingListInManageListingPage_()
        {
            var ListingManagementeditandsave = new ListingManagementPage(driver);
            ListingManagementeditandsave.ListingManagement_Editing();
        }
        [AfterScenario]
        public void close()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}

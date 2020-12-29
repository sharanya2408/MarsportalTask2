
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
    public  class Verifywhethertheuserisabletosavetheservicelistingpagedetails
    {
        IWebDriver driver;
        [BeforeScenario]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [Given(@"I loginto the mars portal")]
        public void GivenILogintoTheMarsPortal()
        {
            var LoginPage = new HomePage(driver);
            LoginPage.login();
        }
        [When(@"I enter all the details in profile page and click on Share Skills button")]
        public void WhenIEnterAllTheDetailsInProfilePageAndClickOnShareSkillsButton()
        {
            var languagedetails = new ProfilePage(driver);
            languagedetails.Languagedetails();

            var skilldetails = new ProfilePage(driver);
            skilldetails.Skillsdetails();

            var educatondetials = new ProfilePage(driver);
            educatondetials.Educationdetails();

            var Certificationdetails = new ProfilePage(driver);
            Certificationdetails.Certificationdetails();

            

        }
        [Then(@"The user should be able to enter details in Share skill page and save them successfully\.")]
        public void ThenTheUserShouldBeAbleToEnterDetailsInShareSkillPageAndSaveThemSuccessfully_()
        {
            var ServiceListingPage = new ServiceListingPage(driver);
            ServiceListingPage.ServiceListing();

            
        }
[AfterScenario]
public void close()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}

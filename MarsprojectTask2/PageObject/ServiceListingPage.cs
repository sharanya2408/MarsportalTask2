using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarsprojectTask2.PageObject
{
    public class ServiceListingPage
    {
        IWebDriver driver;

        public ServiceListingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ServiceListing()
        {
            
            
            driver.FindElement(By.CssSelector("input[name=title]")).SendKeys("Iam a Test analyst");
            driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")).SendKeys("Test analyst with 3 yrs of experience.Worked on Agile and on automation scripting");
            driver.FindElement(By.CssSelector("select.ui.fluid.dropdown")).Click();
            driver.FindElement(By.XPath("//*[text()='Programming & Tech']")).Click();
            driver.FindElement(By.CssSelector("select[name='subcategoryId']")).Click();
            driver.FindElement(By.XPath("//*[text()='QA']")).Click();

            var wait = new WebDriverWait(driver, TimeSpan.FromMinutes(3));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            var tags = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            tags.SendKeys("Automation");
            tags.SendKeys(Keys.Enter);
            var skillexchange = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
            skillexchange.SendKeys("manal testing");
            skillexchange.SendKeys(Keys.Enter);
            driver.FindElement(By.CssSelector("input.ui.teal.button")).Click();
           
        }
    }
}

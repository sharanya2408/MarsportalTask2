using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsprojectTask2.PageObject
{
    public class HomePage
    {
        IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void login()
        {
            //navigating to Marsportal
            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            //log into the mars portal
            driver.FindElement(By.CssSelector("a[class='item']")).Click();
            driver.FindElement(By.XPath("//*[@placeholder='Email address']")).SendKeys("katam.sharanya@gmail.com");
            driver.FindElement(By.XPath("//*[@placeholder='Password']")).SendKeys("sharanya24");
            driver.FindElement(By.CssSelector("button.fluid.ui.teal.button")).Click();


            //var profilename = driver.FindElement(By.XPath("//*[text()='Hi sharanya']"));

            // Assert.AreEqual(profilename, "Hi sharanya");


        }

    }
}

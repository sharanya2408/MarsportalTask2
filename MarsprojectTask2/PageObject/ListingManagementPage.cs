using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarsprojectTask2.PageObject
{
    public class ListingManagementPage
    {
        IWebDriver driver;

        public ListingManagementPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ListingManagement_ClickingNo()
        {
            //var wait = new WebDriverWait(driver, TimeSpan.FromMinutes(5));
            //wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            Thread.Sleep(3000);
            //clicking on delete button
            driver.FindElement(By.CssSelector("i.remove.icon")).Click();
            //clicking on No button
            driver.FindElement(By.CssSelector("button[class='ui negative button']")).Click();
      

        }
        public void ListingManagement_Editing()
        {
            //clicking on edit 
            driver.FindElement(By.CssSelector("i.outline.write.icon")).Click();
            //editing and saving
            driver.FindElement(By.CssSelector("input[name=title]")).SendKeys("Iam an experienced Test analyst");
            driver.FindElement(By.CssSelector("input.ui.teal.button")).Click();

        }


    }
}

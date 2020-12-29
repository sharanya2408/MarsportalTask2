using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarsprojectTask2.PageObject
{
    public class ProfilePage
    {
        IWebDriver driver;
     

        public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Languagedetails()
        {

            //entering language details
            //var wait = new webdriverwait(driver, timespan.fromminutes(2));
            //wait.ignoreexceptiontypes(typeof(nosuchelementexception));
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[text()='Add New']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@name='name']")).SendKeys("Telugu");
            driver.FindElement(By.CssSelector("select.ui.dropdown")).Click();
            driver.FindElement(By.XPath("//*[@value='Native/Bilingual']")).Click();
            driver.FindElement(By.XPath("//*[@value='Add']")).Click();
            //var isTeluguPresent = driver.FindElement(By.XPath("//*[text()='Telugu']"));
        }
        public void Skillsdetails()
        {

            //adding skills details
            driver.FindElement(By.XPath("//*[text()='Skills']")).Click();
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
            
            driver.FindElement(By.CssSelector("input[placeholder='Add Skill']")).SendKeys("Selenium");
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")).Click();
            driver.FindElement(By.XPath("//*[@value= 'Intermediate']")).Click();
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();
        }
        public void Educationdetails()
        {

            //adding education details
            driver.FindElement(By.CssSelector("a[data-tab='third']")).Click();
            
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")).Click();
            
            driver.FindElement(By.CssSelector("input[placeholder='College/University Name']")).SendKeys("Vardhaman College Of Engineering");
            driver.FindElement(By.XPath("//select[@name='country']")).Click();
            driver.FindElement(By.XPath("//*[@value='India']")).Click();
            driver.FindElement(By.XPath("//select[@name='title']")).Click();
            driver.FindElement(By.CssSelector("option[value='B.Tech']")).Click();
            driver.FindElement(By.CssSelector("input[placeholder='Degree']")).SendKeys("Mechanical");
            driver.FindElement(By.XPath("//*[@name='yearOfGraduation']")).Click();
            driver.FindElement(By.XPath("//*[@value='2016']")).Click();
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")).Click();
        }
        public void Certificationdetails()
        {
            //adding certifications details
            driver.FindElement(By.CssSelector("a[data-tab='fourth']")).Click();
          
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")).Click();
            
            driver.FindElement(By.CssSelector("input.certification-award.capitalize")).SendKeys("ISTQB");
            driver.FindElement(By.CssSelector("input.received-from.capitalize")).SendKeys("India");
            driver.FindElement(By.XPath("//*[@name='certificationYear']")).Click();
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[6]")).Click();
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("a[class*='ui basic green button']")).SendKeys(Keys.Enter);
        }
    }
}


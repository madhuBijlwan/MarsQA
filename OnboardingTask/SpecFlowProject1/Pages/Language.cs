using NUnit.Framework;
using OpenQA.Selenium;
using OnboardingMars.Pages;
using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace OnboardingMars.Pages
{
    public class Language : Drivers.CommonDrivers
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
        public void addLanguage()
        {
               
            //Add a new language
            IWebElement addNewLanguageBtn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewLanguageBtn.Click();

            //Enter the language you speak
            IWebElement languageTxtbx = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            languageTxtbx.SendKeys("Hindi");
       
            // Add level of language
            IWebElement levelDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            levelDropdown.Click();                             
            turnOnWait();

            //Select native/bilingual option
            IWebElement selectOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[5]"));
            selectOption.Click();
            
            //Click on Add button
            IWebElement addBtn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addBtn.Click();                                     
            turnOnWait();
        }



        //Edit a language
        public void updateLanguage()
        {
            IWebElement editLanguageBtn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            editLanguageBtn.Click();                                    

            //update language
            IWebElement languageTxtbx = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            languageTxtbx.Clear();
            languageTxtbx.SendKeys("English");

            //click on update button to save changes
            IWebElement updateBtn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updateBtn.Click();
        }

        //Delete a language
        public void deleteLanguage()
        {
            IWebElement deleteLanguageBtn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            deleteLanguageBtn.Click();

        }
      
        public string alertWindow()
        {
            WaitForELementToExist(driver, "CssSelector", "[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]", 5);
            IWebElement confirmationAlert = driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
            return confirmationAlert.Text;
        }

    }
}

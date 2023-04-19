using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingMars.Pages
{
    public class Skills : Drivers.CommonDrivers
    {
        public void navigateSkillTab()
        {
            //Navigate to the skill page
            IWebElement skillBtn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillBtn.Click();
        }
        //Add a new skill
        public void addSkills()
        {            
            //Click on Add new skill
            IWebElement addNewBtn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewBtn.Click();

            //Enter the skill
            IWebElement addSkillTxtBx = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            addSkillTxtBx.SendKeys("C++");

            //click on the skill level dropdown 
            IWebElement skillLevelDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            skillLevelDropdown.Click();
            turnOnWait();
            //Select the level
            IWebElement levelOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
            levelOption.Click();

            //Click on Add button to add a skill
            IWebElement addBtn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addBtn.Click();
            turnOnWait();
        }

        //Update skill
        public void updateSkills()
        {
            //Click on the Edit Icon button
            IWebElement editSkillBtn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]"));
            editSkillBtn.Click();
            
            
            //Edit the skill 
            IWebElement editSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            editSkill.Clear();
            editSkill.SendKeys("Java");
            turnOnWait();

                       
            //Update the skill 
            IWebElement updateSkillBtn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updateSkillBtn.Click();
            
        }

        //Delete skill
        public void deleteSkills()
        {
           
            //Click on delete icon to delete a skill
            IWebElement deleteSkillBtn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]"));
            deleteSkillBtn.Click();                                     
        }

        //validate the skill is added
        //validate the skill is updated
        //validate the skill is deleted
        public string alertWindow()
        {
            WaitForELementToExist(driver, "CssSelector", "[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]", 5);
            IWebElement confirmationAlert = driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
            return confirmationAlert.Text;
        }
        



    }
}


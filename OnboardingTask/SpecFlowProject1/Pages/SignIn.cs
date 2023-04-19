using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingMars.Pages
{
    public class SignIn : Drivers.CommonDrivers
    {
              
        public void signIn()
            {
              
                //click on signIn button
                IWebElement signInBtn = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
                signInBtn.Click();                                  
                Thread.Sleep(1000);
               
                //Enter Email 
                IWebElement enterEmail = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                enterEmail.SendKeys("sharma.madhu113@gmail.com");

                 //Enter Password
                IWebElement enterPassword = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                enterPassword.SendKeys("Mad123*");
                turnOnWait();
                
           
                //Click on LogIn Button
                IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                loginButton.Click();

                 //navigate to home page
                IWebElement profileTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
                profileTab.Click();
                }
            public void signOut()
            {
               //Click the sign Out button
                IWebElement signOutBtn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button"));
                signOutBtn.Click();
            }
    }
}


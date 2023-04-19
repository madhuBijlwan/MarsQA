using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingMars.Pages
{
    public class Join : Drivers.CommonDrivers
    {
           SignIn signInPageObj = new SignIn();
            public void signUp()
            {
                // Sign up for new user
                IWebElement joinButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/button"));
                joinButton.Click();

                //Navigate to sign Up page

                IWebElement firstNameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/input"));
                firstNameTextbox.SendKeys("Madhu");

                IWebElement lastNameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[2]/input"));
                lastNameTextbox.SendKeys("Bijlwan");

                IWebElement emailTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[3]/input"));
                emailTextbox.SendKeys("sharma.madhu113@gmail.com");

                IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/input"));
                passwordTextbox.SendKeys("Mad123*");

                IWebElement confirmPasswordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[5]/input"));
                confirmPasswordTextbox.SendKeys("Mad123*");

                IWebElement iAgreeCheckBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[6]/div/div/input"));
                iAgreeCheckBox.Click();

                IWebElement joinSubmitButton = driver.FindElement(By.Id("submit-btn"));
                joinSubmitButton.Click();

                // User has already have an account


                IWebElement logInButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/a"));
                logInButton.Click();


                //Navigate to Sing In page

                signInPageObj.signIn();

            }
    }
}


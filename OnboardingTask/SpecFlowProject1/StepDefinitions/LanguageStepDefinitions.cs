using NUnit.Framework;
using OnboardingMars.Drivers;
using OnboardingMars.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V109.Browser;
using System;
using TechTalk.SpecFlow;


namespace OnboardingMars.StepDefinitions
{
    [Binding]
    public class LanguageStepDefinitions 
    {
        // creating instance of SignIn page
        SignIn signInObj = new SignIn();

        //creating instance of Language page
        Language languageObj = new Language();

     
        [Given(@"I launch the mars web portal and logged in successfully")]
        public void GivenILaunchTheMarsWebPortalAndLoggedInSuccessfully()
        {
           //calling signIn method of SIgnIn class
            signInObj.signIn();
        }

        [When(@"I add a new language")]
        public void WhenIAddANewLanguage()
        {
            //calling addLaguage method of Language class
            languageObj.addLanguage();
            
            
        }

        [Then(@"I should view the new laguage I added")]
        public void ThenIShouldViewTheNewLaguageIAdded()
        {
            var newLanguageAlert = languageObj.alertWindow();
            Assert.That(newLanguageAlert == "Hindi has been added to your languages", "Failed to add a language");
                       
        }

        [Given(@"I launch the mars web portab and logged in successfully")]
        public void GivenILaunchTheMarsWebPortabAndLoggedInSuccessfully()
        {
            //Calling signIn() method of signIn class
            signInObj.signIn();
        }

        
        [When(@"I edit existing language")]
        public void WhenIEditExistingLanguage()
        {
            //Calling updateLanguage() method of Language class
            languageObj.updateLanguage();
        }
        
        [Then(@"I should view the updated language")]
        public void ThenIShouldViewTheUpdatedLanguage()
        {
            string updatedLanguageAlert= languageObj.alertWindow();
            Assert.That(updatedLanguageAlert == "English has been updated to your languages", "Failed to update language");
        }

        [When(@"I delete existing language")]
        public void WhenIDeleteExistingLanguage()
        {
            //Calling deleteLanguage() method of Language class
            languageObj.deleteLanguage();
        }

        [Then(@"I should view the delete successfull message")]
        public void ThenIShouldViewTheDeleteSuccessfullMessage()
        {
            var delLanguageAlert = languageObj.alertWindow();
            Assert.That(delLanguageAlert != "language is deleted successfully", "Failed to delete a language"); ;
        }
    }
}

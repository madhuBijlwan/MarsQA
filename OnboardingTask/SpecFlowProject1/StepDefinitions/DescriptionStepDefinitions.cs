using NUnit.Framework;
using OnboardingMars.Pages;
using System;
using TechTalk.SpecFlow;

namespace OnboardingMars.StepDefinitions
{
    [Binding]
    public class DescriptionStepDefinitions
    {
        //create instance of Description page
        Description descriptionObj = new Description();

        [When(@"I add description in the description textbox")]
        public void WhenIAddDescriptionInTheDescriptionTextbox()
        {
            descriptionObj.addDescription();    
        }

        [Then(@"I should view discription I added")]
        public void ThenIShouldViewDiscriptionIAdded()
        {
            var descriptionAlert = descriptionObj.alertWindow();
            Assert.That(descriptionAlert == "Description has been saved successfully", "Failed to add Description");
        }
    }
}

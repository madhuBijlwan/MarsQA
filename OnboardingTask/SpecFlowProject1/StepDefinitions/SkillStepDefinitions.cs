using NUnit.Framework;
using OnboardingMars.Pages;
using System;
using TechTalk.SpecFlow;

namespace OnboardingMars.StepDefinitions
{
    [Binding]
    public class SkillStepDefinitions
    {
        //Create instance of Skills Page
        Skills skillObj = new Skills();
        
        [When(@"I add a new skill")]
        public void WhenIAddANewSkill()
        {
            //navigate to the skill page
            skillObj.navigateSkillTab();
            
            //Add a new skill
            skillObj.addSkills();
            
        }

        [Then(@"I should view the new skill I added")]
        public void ThenIShouldViewTheNewSkillIAdded()
        {
            skillObj.navigateSkillTab();
            var addSkillAlert = skillObj.alertWindow();
            Assert.That(addSkillAlert == "C++ has been added to your skills", "Failed to add a skill");
        }

        [When(@"I edit existing skill")]
        public void WhenIEditExistingSkill()
        {
            //Navigate to the skill tab page
            skillObj.navigateSkillTab();

            //calling updateSkills() method of Skills class
            skillObj.updateSkills();
        }

        [Then(@"I should view the updated skill")]
        public void ThenIShouldViewTheUpdatedSkill()
        {
            skillObj.navigateSkillTab();
           
            var updatedSkillAlert = skillObj.alertWindow();
            Assert.That(updatedSkillAlert=="Java has been updated to your skills", "failed to update skill");
        }

        [When(@"I delete existing skill")]
        public void WhenIDeleteExistingSkill()
        {
            //navigating to the skills tab page
            skillObj.navigateSkillTab();
           
            //calling deleteSkills() method of Skills class
            skillObj.deleteSkills();
        }

        [Then(@"I should successfully deleted the skill")]
        public void ThenIShouldSuccessfullyDeletedTheSkill()
        {
            skillObj.navigateSkillTab();
            var delSkillAlert = skillObj.alertWindow();
            Assert.That(delSkillAlert == "Java has been deleted", "Failed to delete a skill");
        }
    }

    
}

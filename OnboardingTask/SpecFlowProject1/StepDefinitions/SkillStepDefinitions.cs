using NUnit.Framework;
using OnboardingMars.Pages;
using OpenQA.Selenium.DevTools.V109.Page;
using System;
using TechTalk.SpecFlow;

namespace OnboardingMars.StepDefinitions
{
    [Binding]
    public class SkillStepDefinitions
    {
        //Create instance of Skills Page
        Skills skillObj = new Skills();

        

        [When(@"I add '([^']*)' and '([^']*)'")]
        public void WhenIAddAnd(string skillName, string skillLevel)
        {
            // Navigate to Skill tab page
            skillObj.navigateSkillTab();

         
            // Add skill name and level
            skillObj.addSkills(skillName,skillLevel);

        }

        
        [Then(@"I should view the '([^']*)' that I added")]
        public void ThenIShouldViewTheThatIAdded(string skillName)
        {
            skillObj.navigateSkillTab();
            var addedSkillText = skillObj.addedSkill(skillName);
            Assert.That(addedSkillText ==skillName, "failed to add a skill");
        }

        [When(@"I edit '([^']*)' skill")]
        public void WhenIEditSkill(string editSkillName)
        {
            //Navigate to the skill tab page
            skillObj.navigateSkillTab();

            //calling updateSkills() method of Skills class
            skillObj.updateSkills(editSkillName);
        }

       
        [Then(@"I should view the updated '([^']*)' skill")]
        public void ThenIShouldViewTheUpdatedSkill(string editSkillName)
        {
            skillObj.navigateSkillTab();
            var updatedSkillText = skillObj.alertWindow();
            Assert.That(updatedSkillText == "html has been updated to your skills", "Failed to update skill");
        }
           
        

        [When(@"I delete existing skill")]
        public void WhenIDeleteExistingSkill()
        {
            //navigating to the skills tab page
            skillObj.navigateSkillTab();
           
            //calling deleteSkills() method of Skills class
            skillObj.deleteSkills();
        }
       

        [Then(@"I should successfully deleted '([^']*)' skill")]
        public void ThenIShouldSuccessfullyDeletedSkill(string skillName)
        {
            skillObj.navigateSkillTab();
            var deletedSkillText = skillObj.deletedSkill(skillName);
            Assert.That(deletedSkillText!= skillName,"Failed to delete skill");
        }

    }


}

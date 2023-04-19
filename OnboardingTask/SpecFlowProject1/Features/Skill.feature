Feature: Skill

As a seller, I want to add a new skill
so that I am able to update an existing skill and delete an existing skill
//Background: 
Given I launch the mars web portal and logged in successfully

Scenario: Add a new skill
	Given I launch the mars web portal and logged in successfully
	When I add a new skill
	Then I should view the new skill I added

Scenario: Edit existing skill
	Given I launch the mars web portab and logged in successfully
	When I edit existing skill
	Then I should view the updated skill

Scenario: Delete existing skill
	Given I launch the mars web portal and logged in successfully
	When I delete existing skill
	Then I should successfully deleted the skill

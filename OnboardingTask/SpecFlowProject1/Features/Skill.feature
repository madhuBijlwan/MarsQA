Feature: Skill

As a seller, I want to add a new skill
so that I am able to update an existing skill and delete an existing skill
//Background: 
Given I launch the mars web portal and logged in successfully

Scenario Outline:01. Add a new skill
	Given I launch the mars web portal and logged in successfully
	When I add '<skillName>' and '<skillLevel>'
	Then I should view the '<skillName>' that I added
	Examples: 
	| skillName | skillLevel   |
	| Java      | Intermediate |
	

Scenario Outline: 02. Edit existing skill
	Given I launch the mars web portab and logged in successfully
	When I edit '<editSkillName>' skill
	Then I should view the updated '<editSkillName>' skill
	Examples: 
	| editSkillName |
	|  html		    |

Scenario: 03.  Delete existing skill
	Given I launch the mars web portal and logged in successfully
	When I delete existing skill
	Then I should successfully deleted '<skillName>' skill

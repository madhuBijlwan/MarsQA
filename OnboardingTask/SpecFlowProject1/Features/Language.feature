Feature: Language

As a seller, I want to add a language 
so that I can edit and delete language from my Profile 


Scenario: 01 Add a new language
	Given I launch the mars web portal and logged in successfully
	When I add a new language
	Then I should view the new laguage I added

Scenario: 02 Edit existing language
	Given I launch the mars web portab and logged in successfully
	When I edit existing language
	Then I should view the updated language

Scenario: 03 Delete existing language
	Given I launch the mars web portal and logged in successfully
	When I delete existing language
	Then I should view the delete successfull message
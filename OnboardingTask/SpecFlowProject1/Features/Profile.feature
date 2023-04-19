Feature: Seller_Profile

As  seller I need to create an account 
so that I can add my profile details after I logged into Mars Web Portal

@tag1
Scenario:01 login to the mars web portal with valid credentials
	Given I sign in to the mars web portal
	When  I launch the mars web portal
	And   I input valid credentials
	Then  I  should see the logged in successfull message
	
Scenario:02 Add discription 
	Given I launch the mars web portal and logged in successfully
	When  I add description in the description textbox
	Then  I should view discription I added

Scenario:03 Add a laguage 
	Given I launch the mars web portal and logged in successfully
	When I add a new language
	Then I should view the new laguage I added
	
Scenario:04 Edit existing language 
	Given I launch the mars web portab and logged in successfully
	When I edit existing language
	Then I should view the updated language

Scenario:05 Delete existing language
	Given I launch the mars web portal and logged in successfully
	When I delete existing language
	Then I should view the delete successfull message
	
Scenario:06 Add a new skill
	Given I launch the mars web portal and logged in successfully
	When I add a new skill
	Then I should view the new skill I added

Scenario:07 Edit existing skill
	Given I launch the mars web portab and logged in successfully
	When I edit existing skill
	Then I should view the updated skill

Scenario:08 Delete existing skill
	Given I launch the mars web portal and logged in successfully
	When I delete existing skill
	Then I should view the delete successfull message

Scenario:09 Add a new education
	Given I launch the mars web portal and logged in successfully
	When I add a new education
	Then I should view the new education I added

Scenario:10 Edit existing education
	Given I launch the mars web portab and logged in successfully
	When I edit existing education
	Then I should view the updated education

Scenario:11 Delete existing education
	Given I launch the mars web portal and logged in successfully
	When I delete existing education
	Then I should view the delete successfull message

Scenario:12 Add a new certification
	Given I launch the mars web portal and logged in successfully
	When I add a new certification
	Then I should view the new certification I added

Scenario:13 Edit existing certification
	Given I launch the mars web portab and logged in successfully
	When I edit existing certification
	Then I should view the updated certification

Scenario:14 Delete existing certification
	Given I launch the mars web portal and logged in successfully
	When I delete existing certification
	Then I should view the delete successfull message
	
Scenario:15 Add avialability, hours and earn target 
	Given I launch the mars web portal and logged in successfully
	When I add availability type
	And  I add hours
	And I add earn target
	Then I should view availability type, estimated hours and earn target that I added
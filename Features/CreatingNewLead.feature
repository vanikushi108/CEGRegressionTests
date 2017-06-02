@mytag
Feature: CreatingNewLead
	As an Admissions  or sales user i must able to create a new lead

Scenario: CreatingnewLead
	Given I am on the Connect home page
    And I enter user name as
    And I enter Password as
    When I click on signIn
    Then I should see logged in user as
	Given I am on navigate page
	And I click On services
	Then I select Lead from services
	When I click On +New icon
	Then I should see Student Application Form
	Given I Enter Prefix as "MR"
	And I Enter First name of the Student as "John"
	And I Enter Last name of the Student as "Smith"
	And I Enter Preferred name of the Student as "Jack"
    And I Enter Date Of Birth of the Student as "01/01/1980"





	
	

@login
Feature: log in to connect as an user and perform Borderline Academic case
  
As an user i must able to login to connect home page
And perform my jobs

  Scenario: As an user i must be able to login to connect home page
	Given I am on the Connect home page
    And I enter user name as
    And I enter Password as
    When I click on signIn
    Then I should see logged in user as
	Given I am on navigate page
	
	
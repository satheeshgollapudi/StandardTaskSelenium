Feature: Registration
	
Scenario: Check if user is able to register
Given I clicked on Join under Home page
When I enter details
Then I should be able to register

Scenario: Check if user is not able to register if same email is entered
Given I clicked on Join under Home page
When I enter details with already registered email
Then I should get error message
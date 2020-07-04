Feature: ShareSkill


Scenario: 1 Check if the user is able to Click on Share Skill button
Given I clicked on  Profile page
When I click on ShareSkill button
Then I navigate to ShareSkill page

Scenario: 2 Check if the user is able to Click on save button
Given I clicked on  Profile page
When I enter all details and click on save button
Then I navigate to manage listings page

Scenario: 3 Check if the user is able to Cancel save button
Given I clicked on  Profile page
When I enter all details and click on cancel button
Then the datails should not be saved and I navigate to profile page 
	



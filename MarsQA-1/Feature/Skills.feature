Feature: Skills
	
	Scenario: 1 Check if user could able to add a Skill
Given I clicked on the Skills tab under Profile page
When I add a new skill
Then that skill should be displayed on my listings

Scenario: 2 Check if the user could able to cancel adding a skill
        Given I clicked on the Skills tab under Profile page
        When I cancel adding a new skill
        Then cancelled skill should not be displayed on my listings
	
Scenario: 3 Check if user is able to delete a skill
Given I clicked on the Skills tab under Profile page
When I delete a skill
Then that skill should be removed from the listings

Scenario: 4 Check if user is able to update a skill
Given  I clicked on the Skills tab under Profile page
When I update a skill
Then that skill should be updated in the listings

 Scenario: 5 Check if the user could able to cancel editing a skill
        Given I clicked on the Skills tab under Profile page
        When I tried to click on Edit and click on cancel button
        Then that same skill details should be displayed on my listing

Scenario: 6 Add a skill which already exists with different level
Given I clicked on the Skills tab under Profile page
When I add a skill that already exists with different level
Then it should throw an error message for different level

Scenario: 7 Add a skill which already exists with same level
Given I clicked on the Skills tab under Profile page
When I add a skill that already exists with same level
Then it should throw an error message for same level


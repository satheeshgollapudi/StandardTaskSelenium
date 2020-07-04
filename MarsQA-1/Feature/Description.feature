Feature: Description


Scenario: Check if user is able to add their description 
Given I clicked on description under Profile page
When I enter a brief decription about myself
Then the description should be displayed

Scenario: Check if user is able to edit their description 
Given I clicked on description under Profile page
When I edit decription about myself
Then the edited description should be displayed

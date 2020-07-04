Feature: Search
	
Scenario: Check if the user is able to search by category and sub category
Given I clicked on the Profile page
When I click on category and subcategory
Then that skills should be displayed

Scenario:Check if the user is able to search by filter Online
Given I clicked on the Profile page
When I click on Online filter
Then Online skills should be displayed

Scenario: Check if the user is able to search by filter Onsite
Given I clicked on the Profile page
When I clicked on Onsite filter
Then  Onsite skills should be displayed

Scenario: Check if the user is able to search by filter ShowAll
Given I clicked on the Profile page
When I clicked on All filter
Then All skills should be displayed


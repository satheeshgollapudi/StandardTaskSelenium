Feature: Education
	Scenario: 1 Check if user could able to add a Education 
Given I clicked on the Education tab under Profile page
When I add a new Education
Then that Education should be displayed on my listings

Scenario: 2 Check if the user could able to cancel adding a Education
        Given I clicked on the Education tab under Profile page
        When I cancel adding a new Education
        Then cancelled Education should not be displayed on my listings
	
Scenario: 3 Check if user is able to delete a Education
Given I clicked on the Education tab under Profile page
When I delete a Education
Then that Education should be removed from the listings

Scenario: 4 Check if user is able to update a Education
Given  I clicked on the Education tab under Profile page
When I update a Education
Then that Education should be updated in the listings

 Scenario: 5 Check if the user could able to cancel editing Education
        Given I clicked on the Education tab under Profile page
         When  I click on Edit Education and click on cancel button
       Then that same Education details should be displayed on my listing





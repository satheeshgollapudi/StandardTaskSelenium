Feature: Certification

Scenario: 1 Check if user could able to add a Certification
Given I clicked on the Certification tab under Profile page
When I add a new Certification
Then that Certification should be displayed on my listings

Scenario: 2 Check if the user could able to cancel adding a Certification
        Given I clicked on the Certification tab under Profile page
        When I cancel adding a new Certification
        Then cancelled Certification should not be displayed on my listings
	
Scenario: 3 Check if user is able to delete a Certification
Given I clicked on the Certification tab under Profile page
When I delete a Certification
Then that Certification should be removed from the listings

Scenario: 4 Check if user is able to update a Certification
Given  I clicked on the Certification tab under Profile page
When I update a Certification
Then that Certification should be updated in the listings

 Scenario: 5 Check if the user could able to cancel editing Certification
        Given I clicked on the Certification tab under Profile page
         When  I click on Edit Certification and click on cancel button
       Then that same Certification details should be displayed on my listing




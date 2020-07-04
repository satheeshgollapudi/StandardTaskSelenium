Feature: Requests
	
Scenario: 1 Check If the user is able to view "Received Request" on ReceivedRequest page
Given I clicked on Manage Requests under Profile page
When I select Received Requests dropdown
Then I should be able to navigate to ReceivedRequest page

Scenario: 2 Check If the user is able to view "Sent Request" on SentRequest page
Given I clicked on Manage Requests under Profile page
When I select Sent Requests dropdown
Then I should be able to navigate to SentRequest page


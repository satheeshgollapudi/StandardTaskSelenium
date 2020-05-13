Feature: Sanity
	
Scenario:  Check if user could able click on language tab
Given I clicked on the Language tab under Profile page
Then Language text should be displayed

Scenario:  Check if user could able click on skill tab
Given I clicked on the Skills tab under Profile page
Then Add new button of Skill tab should be displayed

Scenario:  Check if user could able click on education tab
Given I clicked on the Education tab under Profile page
Then Add new button of education tab should be displayed

Scenario:  Check if user could able click on certification tab
Given I clicked on the Certification tab under Profile page
Then Add new button of certification tab should be displayed

Scenario:  Check if user could able click on chat tab
Given I clicked on chat under Profile page
Then I should navigate to message page

Scenario: Check if the user is able to Click on Share Skill button
Given I clicked on  Profile page
When I click on ShareSkill button
Then I navigate to ShareSkill page

Scenario: Check if the user is able Click on Manage Listings tab
Given I clicked on  Manage Listings page
Then I navigate to manage  Listings page

Scenario: Check If the user is able to view "Received Request" on ReceivedRequest page
Given I clicked on Manage Requests under Profile page
When I select Received Requests dropdown
Then I should be able to navigate to ReceivedRequest page


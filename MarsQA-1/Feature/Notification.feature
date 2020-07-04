Feature: Notification
	
Scenario: Check if the user is able to "Select Show Less
Given I clicked on the Notification
When I select show less
Then user should be able to get less notifications

Scenario: Check if the user is able to "Select Load more
Given I clicked on the Notification
When I select load more
Then user should be able to load more notifications

Scenario: Check if the user is able to "Select Delete
Given I clicked on the Notification
When I select delete
Then  user should be able to delete notifications

Scenario: Check if the user is able to "Select Mark as Read
Given I clicked on the Notification
When I select Mark as Read
Then  user should be able to mark notifications as read

Scenario: Check if the user is able to "Select  Select &Unselect
Given I clicked on the Notification
When I select Select &Unselect
Then user should be able to  Select &Unselect notifications
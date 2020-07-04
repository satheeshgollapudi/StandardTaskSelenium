Feature: Chat
	
Scenario: 1 Check if user could able to chat
Given I clicked on chat under Profile page
When I enter message in message page
Then that message should be displayed on the window

Scenario: Check if the user is able to See chat history
Given I clicked on chat under Profile page
When I enter user in search box in message page
Then the history should be displayed on the window




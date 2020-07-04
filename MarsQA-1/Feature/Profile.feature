Feature: Profile

Scenario: 1 Check if user could able edit location
Given I clicked on location under Profile page
When I enter city
And I enter country
Then entered city should be selected
And entered country should be selected

Scenario: 1 Check if user could able to edit availability type
Given I clicked on edit availability type under Profile page
When I enter availability type
Then that availability type should be selected

Scenario: 1 Check if user could able to edit availability hour
Given I clicked on edit availability hour under Profile page
When I enter availability hour
Then that availability hour should be selected

Scenario: 1 Check if user could able to edit EarnTarget
Given I clicked on edit EarnTarget under Profile page
When I enter availabilitytarget
Then that availability target should be selected




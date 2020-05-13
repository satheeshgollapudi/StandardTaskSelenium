Feature: ManageListings
	

@mytag

Scenario: 1Check if the user is able to edit Manage Listings
Given I clicked on  Manage Listings page
When I click on edit  and go to service listings page enter all details and click on save button
Then I navigate to manage  Listings page

Scenario: 2 Check if the user is able to Cancel delete Manage Listings
Given I clicked on  Manage Listings page
When I click on delete in Manage Listings and clicked on No on alert
Then the datails should not be deleted on manage listings page

Scenario: 3 Check if the user is able to  delete button Manage Listings
Given I clicked on  Manage Listings page
When I click on delete button and clicked on Yes on alert
Then that skill should not be shown on manage listings page
Feature: Language
	


Scenario: 1 Check if user could able to add a language 
Given I clicked on the Language tab under Profile page
When I add a new language
Then that language should be displayed on my listings

Scenario: 2 Check if the user could able to cancel adding a language
        Given I clicked on the Language tab under Profile page
        When I cancel adding a new language
        Then cancelled language should not be displayed on my listings
	
Scenario: 3 Check if user is able to delete a language
Given I clicked on the Language tab under Profile page
When I delete a language
Then that language should be removed from the listings

Scenario: 4 Add a language which already exists with different level
Given I clicked on the Language tab under Profile page
When I add a language that already exists with different level
Then it should throw an error message of duplicated data

Scenario: 5 Add a language which already exists with same level
Given I clicked on the Language tab under Profile page
When I add a language that already exists with same level
Then it should throw an error message of language exists

Scenario Outline: 6 Check if user is able to add more than four languages
Given I clicked on the Language tab under Profile page
When I add a four new language with <language> and <level>
Then those <language> should be displayed on my listings
Examples: 
| language  | level          |
| English   | Fluent         |
| Tamil     | Conversational |
| Telugu    | Conversational |
| Malayalam | Basic          |


Scenario: 7 Check if user is able to update a language
Given  I clicked on the Language tab under Profile page
When I update a language
Then that language should be updated in the listings

 Scenario: 8 Check if the user could able to cancel editing a language
        Given I clicked on the Language tab under Profile page
         When  I click on Edit and click on cancel button
       Then that same language details should be displayed on my listing


Scenario: 9 Add a language if there are more than four languages
Given I clicked on the Language tab under Profile page
When I try to add a language when there are already four language existing
Then it should not be added to the listing 



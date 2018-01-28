Feature: GoogleSearch

@GoogleTest
Scenario: Search Google
	Given I am on the Google search page
	When I search for 'cookies'
	Then the page title should include the word 'cookies'


Feature: Account Creation
	In order to validate user account creation
	As a new user
	I want to be able to login

@accountCreation
Scenario: Create a new account
	Given I am not logged in
	When I complete the sign up form
	Then I am logged in
	And my username is displayed


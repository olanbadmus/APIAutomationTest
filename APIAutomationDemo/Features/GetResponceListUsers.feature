Feature: GetResponseListUser
	I want to be able to validate the response details of a GET call made to a resorce
	on reqres website

@mytag
Scenario: Validate Response status for list users
	Given I am on reqres url and on "/api/users" endpoint
	When I make a GET request on resource page "2"
	Then response status should be "completed"

@mytag
Scenario: Validate Status Description for list users
	Given I am on reqres url and on "/api/users" endpoint
	When I make a GET request on resource page "2"
	Then status description should be "Ok"

@mytag
Scenario: Validate Response Uri for list users
	Given I am on reqres url and on "/api/users" endpoint
	When I make a GET request on resource page "2"
	Then response Uri should be "https://reqres.in/api/users?page=2"

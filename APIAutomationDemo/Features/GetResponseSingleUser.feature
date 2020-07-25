Feature: GetResponseSingleUser
	Get responses for single user

@mytag
Scenario: Validate Response status for list users
	Given I am on reqres url and on "/api/users" endpoint
	When I make a GET request on the endpoint with resource "2"
	Then response status should be "completed"

@mytag
Scenario: Validate Status Description for list users
	Given I am on reqres url and on "/api/users" endpoint
	When I make a GET request on the endpoint with resource "2"
	Then status description should be "Ok"

@mytag
Scenario: Validate Response Uri for list users
	Given I am on reqres url and on "/api/users" endpoint
	When I make a GET request on the endpoint with resource "2"
	Then response Uri should be "https://reqres.in/api/users/2"
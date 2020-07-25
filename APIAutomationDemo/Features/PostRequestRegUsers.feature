Feature: PostRequestRegUsers
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: PostRegUsers
	Given I am on reqres url and on "/api/users" endpoint
	When I register a user by making a GET request on the endpoint with "<name>" and "<job>" 
	Then response status should be "completed"
	Then status description should be "Created"
	Then response Uri should be "https://reqres.in/api/users"

	Examples: 
	| name   | job        |
	| James  | Accountant |
	| Sam    | Larry      |
	| Murphy | Jones      |


@mytag
Scenario: PostRegUsersWithFakeData
	Given I am on reqres url and on "/api/users" endpoint
	When I register a user by making a GET request on the endpoint with fake and random name and job
	Then response status should be "completed"
	Then status description should be "Created"
	Then response Uri should be "https://reqres.in/api/users"

@mytag
Scenario: PostRegUsersWithFakeData2
	Given I am on reqres url and on "/api/users" endpoint
	When I register a user by making a GET request on the endpoint with fake and random name and job
	Then response status should be "completed"
	Then status description should be "Created"
	Then response Uri should be "https://reqres.in/api/users"


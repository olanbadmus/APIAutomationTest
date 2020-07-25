Feature: GetResponseValidation
	This is to validate the Json response for GET request

@mytag
Scenario: Validate Response Content for id 7
	Given I am on reqres url and on "/api/users?page=2" endpoint
	When I make a GET request on the endpoint
	Then I should get the following response contents
	| id | email                    | first_name | last_name |
	| 7  | michael.lawson@reqres.in | Michael    | Lawson    |
	
	@mytag
Scenario: Validate Response Content for id 8
	Given I am on reqres url and on "/api/users?page=2" endpoint
	When I make a GET request on the endpoint
	Then I should get the following response contents
	| id | email                      | first_name | last_name |
	| 8  | lindsay.ferguson@reqres.in | Lindsay    | Ferguson  |
	
	
	@mytag
Scenario: Validate Response Content for id 9
	Given I am on reqres url and on "/api/users?page=2" endpoint
	When I make a GET request on the endpoint
	Then I should get the following response contents
	| id | email                  | first_name | last_name |
	| 9  | tobias.funke@reqres.in | Tobias     | Funke     |
	
	
	@mytag
Scenario: Validate Response Content for id 10
	Given I am on reqres url and on "/api/users?page=2" endpoint
	When I make a GET request on the endpoint
	Then I should get the following response contents
	| id | email                  | first_name | last_name |
	| 10 | byron.fields@reqres.in | George     | Fields    |
	
	
	@mytag
Scenario: Validate Response Content for id 11
	Given I am on reqres url and on "/api/users?page=2" endpoint
	When I make a GET request on the endpoint
	Then I should get the following response contents
	| id | email                    | first_name | last_name |
	| 11 | george.edwards@reqres.in | Michael    | Edwards   |
	
	
	@mytag
Scenario: Validate Response Content for id 12
	Given I am on reqres url and on "/api/users?page=2" endpoint
	When I make a GET request on the endpoint
	Then I should get the following response contents
	| id | email                   | first_name | last_name |
	| 12 | rachel.howell@reqres.in | Rachel     | Howell    |
	
	
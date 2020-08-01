Feature: GetResponseValidation
	This is to validate the Json response for GET request

@mytag
Scenario: Validate Response Content for id 7
	Given I am on reqres url and on "/api/users" endpoint
	When I make a GET request on resource page "2"
	Then I should get the following response contents for id 7
	| id | email                    | first_name | last_name |
	| 7  | michael.lawson@reqres.in | Michael    | Lawson    |
	
	@mytag
Scenario: Validate Response Content for id 8
	Given I am on reqres url and on "/api/users" endpoint
	When I make a GET request on resource page "2"
	Then I should get the following response contents for id 8
	| id | email                      | first_name | last_name |
	| 8  | lindsay.ferguson@reqres.in | Lindsay    | Ferguson  |
	
	
	@mytag
Scenario: Validate Response Content for id 9
	Given I am on reqres url and on "/api/users" endpoint
	When I make a GET request on resource page "2"
	Then I should get the following response contents for id 9
	| id | email                  | first_name | last_name |
	| 9  | tobias.funke@reqres.in | Tobias     | Funke     |
	
	
	@mytag
Scenario: Validate Response Content for id 10
	Given I am on reqres url and on "/api/users" endpoint
	When I make a GET request on resource page "2"
	Then I should get the following response contents for id 10
	| id | email                  | first_name | last_name |
	| 10 | byron.fields@reqres.in | Byron      | Fields    |
	
	
	@mytag
Scenario: Validate Response Content for id 11
	Given I am on reqres url and on "/api/users" endpoint
	When I make a GET request on resource page "2"
	Then I should get the following response contents for id 11
	| id | email                    | first_name | last_name |
	| 11 | george.edwards@reqres.in | George     | Edwards   |
	
	
	@mytag
Scenario: Validate Response Content for id 12
	Given I am on reqres url and on "/api/users" endpoint
	When I make a GET request on resource page "2"
	Then I should get the following response contents for id 12
	| id | email                   | first_name | last_name |
	| 12 | rachel.howell@reqres.in | Rachel     | Howell    |
	
	
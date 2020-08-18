Feature: GetResponseUsersById
	This is to validate the Json response for GET request for users by ID

@mytag
Scenario: Get Response for user 1
	Given I am on reqres url and on "/api/users" endpoint
	When I make a GET request on resource id "1"
	Then I should get the following response for user id 1
	| id | email                  | first_name | last_name | company           | url                    | text                |
	| 1  | george.bluth@reqres.in | George     | Bluth     | StatusCode Weekly | http://statuscode.org/ | A weekly newsletter |


@mytag
Scenario: Get Response for user 2
	Given I am on reqres url and on "/api/users" endpoint
	When I make a GET request on resource id "2"
	Then I should get the following response for user id 2
	| id | email                  | first_name | last_name | company           | url                    | text                |
	| 2  | janet.weaver@reqres.in | Janet     | Weaver     | StatusCode Weekly | http://statuscode.org/ | A weekly newsletter |

@mytag
Scenario: Get Response for user 3
	Given I am on reqres url and on "/api/users" endpoint
	When I make a GET request on resource id "3"
	Then I should get the following response for user id 3
	| id | email               | first_name | last_name | company           | url                    | text                |
	| 3  | emma.wong@reqres.in | Emma       | Wong      | StatusCode Weekly | http://statuscode.org/ | A weekly newsletter |
	

@mytag
Scenario: Get Response for user 4
	Given I am on reqres url and on "/api/users" endpoint
	When I make a GET request on resource id "4"
	Then I should get the following response for user id 4
	| id | email              | first_name | last_name | company           | url                    | text                |
	| 4  | eve.holt@reqres.in | Eve        | Holt      | StatusCode Weekly | http://statuscode.org/ | A weekly newsletter |
	

@mytag
Scenario: Get Response for user 5
	Given I am on reqres url and on "/api/users" endpoint
	When I make a GET request on resource id "5"
	Then I should get the following response for user id 5
	| id | email                    | first_name | last_name | company           | url                    | text                |
	| 5  | charles.morris@reqres.in | Charles    | Morris    | StatusCode Weekly | http://statuscode.org/ | A weekly newsletter |
	

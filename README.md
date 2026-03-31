ReqRes API Automation Tests
Overview

This project contains automated tests for a public REST API using .NET and xUnit.
The purpose of the project is to demonstrate API testing practices such as validating HTTP responses, verifying JSON payloads, and ensuring expected behavior across multiple endpoints.

The tests target the ReqRes API, a public service designed for practicing REST API testing.

This project is part of a QA Automation portfolio and focuses on validating user-related endpoints through automated integration tests.

Project Goals

The primary objectives of this project are:

Validate the behavior of REST API endpoints
Verify correct HTTP status codes
Validate JSON response structure and content
Demonstrate maintainable automated testing practices
Showcase API testing skills using .NET tools
Scope of Testing

The automated tests cover core User API operations.

HTTP Method	Endpoint	Description
GET	/api/users?page=2	Retrieve a list of users
GET	/api/users/{id}	Retrieve a specific user
POST	/api/users	Create a new user
PUT	/api/users/{id}	Update an existing user
DELETE	/api/users/{id}	Delete a user
Test Validations

Each automated test verifies several aspects of the API response.

1. HTTP Status Codes

The tests ensure that the API returns the expected status codes.

Operation	Expected Status
Retrieve users	200 OK
Retrieve user by ID	200 OK
Create user	201 Created
Update user	200 OK
Delete user	204 No Content
2. Response Structure Validation

The tests verify that the API responses contain the expected JSON fields.

Example response:

{
  "data": {
    "id": 2,
    "email": "janet.weaver@reqres.in",
    "first_name": "Janet",
    "last_name": "Weaver"
  }
}

Validated fields include:

id
email
first_name
last_name
3. Data Validation

The tests also confirm that:

Requested resources return the correct id
Required fields are present and not empty
Data sent in POST/PUT requests appears correctly in the response
Technology Stack

This project uses the following technologies:

.NET
xUnit (Test framework)
HttpClient (HTTP requests)
System.Text.Json (JSON serialization)
FluentAssertions (Readable assertions)
Project Structure
ReqResApiTests
│
├── Clients
│   └── ApiClient.cs
│
├── Models
│   └── User.cs
│
├── Tests
│   └── UserTests.cs
│
└── Utils
    └── JsonHelper.cs

Clients

Handles HTTP communication with the API.

Models

Represents the JSON structures returned by the API.

Tests

Contains the automated test cases for API endpoints.

Utils

Utility classes used across the project.

Running the Tests
Prerequisites
.NET SDK installed
Internet connection to access the public API
Run tests using CLI
dotnet test

All tests should execute automatically and validate the API responses.

Expected Results

When the test suite runs successfully:

All endpoints respond with the correct HTTP status codes
JSON responses match the expected structure
Data integrity checks pass
The test suite completes without failures
Purpose in QA Automation Portfolio

This project demonstrates skills in:

REST API testing
Automated validation of HTTP responses
JSON response verification
Test automation using .NET
Writing maintainable and structured automated tests
Author

Automation QA Portfolio Project
Built using .NET and xUnit for practicing API test automation.

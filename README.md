INTRODUCTION:
Welcome to the presentation of the Technical Interview Exercise V2. In this exercise, we'll be developing a simple web application using .NET C#, ASP.NET MVC, Web API, and a relational database. Our focus will be on adhering to Clean Architecture principles and utilizing Test-Driven Development (TDD) methodologies.

EXERCISE OVERVIEW:
Our task is to create a web application that allows users to perform CRUD operations on a database through API endpoints. We'll also implement user authentication and ensure user information is securely stored. Let's break down the components and steps we'll be following.

SUMMARY:
Through this exercise, we'll demonstrate our proficiency in .NET C#, ASP.NET MVC, Web API, and Clean Architecture. We'll apply Test-Driven Development to ensure quality and showcase our understanding of user stories, design, and coding practices. This exercise represents a holistic approach to building a functional and maintainable web application.

USER STORY:
Title: Manage Customer Records with API and Database

As a system administrator,
I want a web application that allows me to manage customer records,
So that I can easily create, read, update, and delete customer information.

Acceptance Criteria:
Given I am an authenticated user,
When I create a new customer record with valid information,
Then the record is stored in the database, and I receive a success response.
Given I want to view customer records,
When I access the API endpoint to retrieve customer information,
Then I receive a list of customer records as a response.
Given I have a customer record that needs updating,
When I send an update request with valid changes,
Then the record in the database is updated, and I receive a success response.
Given I want to remove a customer record,
When I send a delete request for a specific customer,
Then the record is removed from the database, and I receive a success response.

Additionally:
Given I am a new user,
When I register with a valid username and password,
Then my user information is stored securely, and I receive a success response.
Given I am a registered user,
When I login with correct credentials,
Then I receive an authentication token and can access authorized endpoints.
Given I am a registered user,
When I login with incorrect credentials,
Then I receive an unauthorized response.
Given I am an authenticated user,
When I access non-authorized endpoints,
Then I receive a forbidden response.
Given I am an authenticated user,
When I access authorized endpoints without proper authentication,
Then I receive an unauthorized response.


INSTRUCTIONS
------------

# CleanArchitecture
Clean Architecture implementation example in ASP .NET Core Web API
# Dapper for ORM and SQL Server

Script to create table
---------------------------------------------------------------------------------
CREATE TABLE [dbo].[User](

	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL, 

 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED  
(
[ID] ASC
)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, 

OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

) ON [PRIMARY]

GO

----------------------------------------------------------------------------------------


# JWT for Authentification
Example Admin USER

        User: admin
        Pass: admin
        
Example Basic USER

        User: user
        Pass: user

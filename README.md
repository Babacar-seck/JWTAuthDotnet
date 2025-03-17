# Authentication and User Management API with JWT and Entity Framework

## Description

This project is a RESTful API for managing user authentication with JWT (JSON Web Tokens) and Entity Framework Core for database management. It includes the creation of a user model, handling authentication, generating JWT tokens for secure access, and implementing token refresh functionality.

The project is structured around several key steps, ranging from creating the user entity to implementing role management and refresh tokens. It is designed for developers looking to learn how to implement secure authentication in a web application.

## Table of Contents

- [Introduction](#introduction)
- [Creating the User Entity](#creating-the-user-entity)
- [Adding a Data Transfer Object (DTO)](#adding-a-data-transfer-object-dto)
- [Authentication Controller](#authentication-controller)
- [Password Hashing](#password-hashing)
- [API Testing with Scalar](#api-testing-with-scalar)
- [Implementing the Login Endpoint](#implementing-the-login-endpoint)
- [Generating JWT Tokens](#generating-jwt-tokens)
- [Adding Entity Framework Core and Database Context](#adding-entity-framework-core-and-database-context)
- [Adding Code-First Migrations](#adding-code-first-migrations)
- [Refactoring with a Service Layer](#refactoring-with-a-service-layer)
- [Securing Endpoints with [Authorize]](#securing-endpoints-with-authorize)
- [Adding Roles to the User Model](#adding-roles-to-the-user-model)
- [Implementing Refresh Tokens](#implementing-refresh-tokens)
- [Creating the Refresh Token Endpoint](#creating-the-refresh-token-endpoint)

## Introduction

The goal of this project is to develop a secure API that handles user authentication via JWT and allows for role management and security with Entity Framework Core. The project uses modern and secure practices to ensure authentication and session management are robust.

## Creating the User Entity

The `User` entity is the base model for user authentication. It contains necessary information such as username, password (hashed), and assigned roles for the user.

## Adding a Data Transfer Object (DTO)

A DTO (Data Transfer Object) is used to securely transfer data between the client and the API. It simplifies interactions and ensures that only necessary data is sent or received.

## Authentication Controller

The authentication controller handles various actions related to user authentication, such as login and registration.

## Password Hashing

User passwords are hashed before being stored in the database to ensure their security. A secure hashing algorithm like BCrypt or Argon2 is used to protect sensitive information.

## API Testing with Scalar

Scalar is used for quickly and easily testing the API, ensuring that API endpoints are functioning properly before deployment.

## Implementing the Login Endpoint

The login endpoint allows users to authenticate using their credentials and generates a JWT token if they are successfully authenticated.

## Generating JWT Tokens

JWT tokens are generated and used to provide secure, stateless authentication between the client and the API.

## Adding Entity Framework Core and Database Context

Entity Framework Core is integrated for database management. The `DbContext` handles communication with the database and interaction with entities like `User`.

## Adding Code-First Migrations

Code-First migrations are used to update the database schema based on changes made to the code entities. This ensures the database stays in sync with the data model.

## Refactoring with a Service Layer

A service layer is added to separate business logic from controllers. This improves code maintainability and allows for better reuse of functionality across the application.

## Securing Endpoints with [Authorize]

The `[Authorize]` attribute is used to secure API endpoints. Only authenticated users with the appropriate roles can access certain protected resources.

## Adding Roles to the User Model

The user model is extended to include a role management system, allowing the assignment of specific permissions to different user types (e.g., administrator, standard user, etc.).

## Implementing Refresh Tokens

Refresh tokens are implemented to allow users to renew their JWT token without having to log in again. This enhances the user experience and session security.

## Creating the Refresh Token Endpoint

An endpoint is created to handle refresh token requests, allowing users to obtain a new JWT token when they provide a valid refresh token.

## Installation and Running the Project

1. Clone this repository:  
   `git clone https://github.com/your-username/project-name.git`

2. Install dependencies:  
   `dotnet restore`

3. Apply migrations to update the database:  
   `dotnet ef database update`

4. Run the API:  
   `dotnet run`

5. Test the endpoints using an HTTP client (such as Scalar or Swagger).

---

This project provides a solid foundation for building secure applications with robust user management.

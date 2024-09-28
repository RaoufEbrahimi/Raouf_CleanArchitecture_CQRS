# .NET 8 Clean Architecture with CQRS, Repository Pattern, Generic Repository & Result Pattern

This project demonstrates the implementation of **Clean Architecture** in a .NET 8 application, using **CQRS (Command Query Responsibility Segregation)**, the **Repository Pattern**, a **Generic Repository**, and the **Result Pattern** via **ErrorOr\<T\>**. The project is designed with scalability, maintainability, and testability in mind, leveraging modern development practices and a modular structure.

## Table of Contents
- [Technologies and Frameworks](#technologies-and-frameworks)
- [Architecture Overview](#architecture-overview)
  - [Clean Architecture](#clean-architecture)
  - [CQRS (Command Query Responsibility Segregation)](#cqrs-command-query-responsibility-segregation)
  - [Repository Pattern & Generic Repository](#repository-pattern--generic-repository)
  - [ErrorOr\<T\> Result Pattern](#errorort-result-pattern)
  - [Separate Application Layers](#separate-application-layers)
  - [Unit of Work Pattern](#unit-of-work-pattern)
- [Validation](#validation)
- [Security](#security)
- [Logging](#logging)
- [Testing](#testing)
- [Documentation & API Testing](#documentation--api-testing)
- [Conclusion](#conclusion)

---

## Technologies and Frameworks
- **.NET 8.0**: The latest version of the .NET framework for building scalable and efficient applications.
- **Entity Framework Core**: Used for database interactions, with support for SQL Server.
- **MediatR**: Implements CQRS, providing decoupled and maintainable messaging between components.
- **FluentValidation**: Used for enforcing validation rules in a clean and reusable manner.
- **JWT Authentication**: Secures APIs using JWT tokens.
- **Swagger (Swashbuckle)**: API documentation generation and testing.

## Architecture Overview

### Clean Architecture
This project adheres to **Clean Architecture** principles, which separate concerns into distinct layers:
- **Domain Layer**: Contains core business logic, domain models, and interfaces that define the system.
- **Application Layer**: Manages the application’s use cases, implementing the CQRS pattern to separate write and read operations.
- **Infrastructure Layer**: Handles external concerns like database access, file systems, or third-party services.
- **Presentation Layer**: Responsible for interacting with the client, including APIs and web interfaces.

**Benefits**:
- **Separation of Concerns**: Enhances code clarity and maintainability by organizing the system into distinct layers.
- **Testability**: Easier to unit test each layer independently due to clear boundaries.

### CQRS (Command Query Responsibility Segregation)
The project employs the **CQRS pattern** by separating commands (write operations) and queries (read operations). This improves scalability and performance, especially in complex systems.

- **Commands**: Found under `Features\*\Commands`, these handle creating, updating, or deleting data.
- **Queries**: Found under `Features\*\Queries`, these handle data retrieval and ensure that read and write operations are not mixed.

**Benefits**:
- **Performance**: Optimized read and write operations.
- **Scalability**: Read and write models can evolve independently.
- **Maintainability**: Clear separation leads to easier understanding and debugging of operations.

### Repository Pattern & Generic Repositories

This project employs a **Repository Pattern** to enhance the separation of concerns and maintainability of the codebase. The repositories are structured as follows:

1. **Command and Query Separation**: The project features distinct repositories for handling commands and queries, which aligns with the **CQRS (Command Query Responsibility Segregation)** pattern. This separation not only allows for optimized performance and scalability but also enables the use of different ORMs or databases for commands and queries, providing flexibility in data storage and retrieval.

2. **Generic Repositories**: Generic repositories are utilized for basic command and query operations. They do not have interfaces, as they are designed to serve fundamental CRUD operations across multiple entities. This approach helps reduce code duplication and fosters consistency in data access.

3. **Specific Repository Interfaces**: Additional repository classes are defined for specific entities or aggregations of entities. These repository classes inherit from both the generic repositories and the interfaces for the specific entities or aggregations. This structure allows for the implementation of specialized methods while leveraging the common functionality provided by the generic repositories.

**Benefits**:
- **Reduced Code Duplication**: By using generic repositories, common operations are centralized, minimizing repetitive code and enhancing maintainability.
- **Clear Separation of Responsibilities**: The separation between command and query repositories promotes clearer architectural boundaries, making it easier to manage changes.
- **Improved Flexibility**: The ability to use different ORMs or databases for commands and queries increases adaptability to various project requirements.
- **Improved Testability**: The interface-based approach allows for easier mocking and unit testing, improving the overall quality of the application.

### ErrorOr\<T\> Result Pattern
In the **Domain Layer**, the project employs the **ErrorOr\<T\>** feature as a **Result Pattern** to handle operation outcomes in a clean and consistent manner. This pattern allows methods to return either a successful result of type **T** or an error, encapsulating both success and failure scenarios in a single, predictable return type.

- **Success Case**: Returns a valid result (e.g., domain entity or value).
- **Error Case**: Returns a defined error or set of errors when the operation fails.

**Benefits**:
- **Unified Handling**: Provides a clear and unified approach to handling success and failure, reducing the complexity of error handling across the system.
- **Type Safety**: Enforces compile-time checking of errors, ensuring that all possible outcomes are handled.
- **Improved Code Quality**: Reduces reliance on exceptions and makes the code more readable and maintainable.

### Separate Application Layers
This project considers two separate **Application Layers**:
- **Admin Application Layer**: Manages the business logic specific to administrative functionalities.
- **Web Application Layer**: Handles the logic for public-facing web functionalities.

By separating these layers, the project maintains clean boundaries between the logic intended for different types of users.

**Benefits**:
- **Isolation of Concerns**: Ensures that logic specific to admin and public users are kept separate.
- **Scalability**: Allows for each layer to evolve independently without affecting the other.
- **Maintainability**: Improves clarity and organization by separating business rules for different roles.

### Unit of Work Pattern
The project implements a **Unit of Work** pattern alongside the repository pattern. This allows for the grouping of multiple operations into a single transaction, ensuring that changes are only saved once all modifications are complete. This approach enhances data integrity and consistency.

**Benefits**:
- **Enhanced Data Integrity**: Ensures that all changes are saved in a single transaction, preventing partial updates and maintaining consistency.
- **Simplified Transaction Management**: Encapsulates transaction logic, making it easier to manage changes across multiple repositories.

## Validation
Validation is handled using **FluentValidation**, which ensures that the application data is valid before processing it.

- **Validation Rules**: Placed in the application layer, alongside the business logic for commands and queries.

**Benefits**:
- **Separation of Validation Logic**: Clear and maintainable validation rules.
- **Reusability**: Validation logic can be reused across different parts of the application.

## Security
The application uses **JWT Bearer Authentication** for securing API endpoints.

- **JWT**: Ensures secure access control by validating tokens in API requests.

**Benefits**:
- **Security**: Protects API resources from unauthorized access.
- **Scalability**: Lightweight and scalable authentication mechanism.

## Logging
Logging is implemented using **Serilog**, with sinks configured for **SQL Server**.

- **Serilog**: Provides structured logging capabilities to monitor application performance and errors.

**Benefits**:
- **Visibility**: Provides insights into system behavior and errors.
- **Flexibility**: Logs can be sent to various outputs (e.g., console, SQL Server).

## Testing
The project includes unit tests, employing **xUnit** as the testing framework. It follows best practices in unit testing to ensure the integrity of each component.

- **Test Project**: Contains unit tests for commands, queries, and domain logic.

**Benefits**:
- **Quality Assurance**: Ensures that each component behaves as expected.
- **Maintainability**: Helps prevent regressions when making changes.

## Documentation & API Testing
- **Swagger**: Integrated using **Swashbuckle**, provides interactive API documentation and allows for easy testing of API endpoints.

**Benefits**:
- **Ease of Use**: Developers can interact with and test API endpoints easily.
- **Clarity**: Clear API documentation for consumers.

## Conclusion
This .NET 8 project showcases how to implement **Clean Architecture**, **CQRS**, the **Repository Pattern**, the **ErrorOr\<T\>** Result Pattern, and separate application layers for the **Admin** and **Web Audience** projects. By leveraging modern technologies and patterns, it ensures maintainability, testability, and ease of expansion.

Please note that this project is still a **work in progress**, and I will continue to improve and enhance it with additional features and refinements. I'm eager to receive **feedback** and **contributions** from the community to help further its development.

Feel free to explore the code, provide feedback, or contribute!

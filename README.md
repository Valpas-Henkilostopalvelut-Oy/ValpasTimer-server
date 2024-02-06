# ValpasTimer-server Project Structure

The ValpasTimer-server is organized into several projects, each serving a distinct role within the Clean Architecture framework. Here's a detailed breakdown:

### **ValpasTimer.Domain**
This project houses the core business logic and domain entities. It forms the heart of the application, with no dependencies on the other layers.

- **Entities**: Fundamental objects within the system.
  - `User.cs`
  - `Product.cs`
- **Interfaces**: Abstractions for the data access layer, ensuring decoupling from infrastructure concerns.
  - `IUserRepository.cs`
  - `IProductRepository.cs`
- **Exceptions**: Custom exception types for domain-specific errors.
  - `DomainNotFoundException.cs`
- **ValueObjects**: Objects that represent descriptive aspects of the domain with no conceptual identity.
  - `Money.cs`
  - `EmailAddress.cs`
- **Enums**: Enumeration types representing sets of named constants.
  - `UserType.cs`

### **ValpasTimer.Application**
Focused on application logic, this layer orchestrates domain entities and executes business rules. It acts as a mediator between the web interface and domain layer.

- **Interfaces**: Contracts for services provided by this layer.
  - `IApplicationDbContext.cs`
- **Services**: Implementations of application logic.
  - `UserService.cs`
  - `ProductService.cs`
- **DTOs**: Data Transfer Objects for transferring data between layers.
  - `UserDto.cs`
  - `ProductDto.cs`
- **Mappings**: Automapper profiles for object-object mapping.
  - `AutoMapperProfile.cs`
- **Validators**: FluentValidation validators for input validation.
  - `CreateUserValidator.cs`

### **ValpasTimer.Infrastructure**
Implements external concerns such as database access, file storage, and third-party service integrations.

- **Persistence**
  - **Contexts**: Entity Framework Core DbContext for database operations.
    - `ApplicationDbContext.cs`
  - **Repositories**: Concrete implementations of repository interfaces.
    - `UserRepository.cs`
    - `ProductRepository.cs`
- **Services**: Infrastructure services like date/time and email sending.
  - `DateTimeService.cs`
  - `EmailService.cs`

### **ValpasTimer.WebApi**
The entry point for HTTP requests, exposing the application's functionalities over the web.

- **Controllers**: API controllers that handle incoming HTTP requests.
  - `UsersController.cs`
  - `ProductsController.cs`
- **Filters**: ASP.NET Core action filters for handling exceptions and other cross-cutting concerns.
  - `ApiExceptionFilter.cs`
- **Middlewares**: Custom middleware components for request processing.
  - `ErrorHandlingMiddleware.cs`
- **Models**: View models for API responses.
  - `ApiResponse.cs`
- Configuration files and startup classes.
  - `appsettings.json`
  - `Program.cs`
  - `Startup.cs`

### **Tests**
Contains all unit and integration tests for the application, ensuring correctness and stability.

- **UnitTests**: Tests for application logic and domain services.
  - `/Application`
    - `UserServiceTests.cs`
    - `ProductServiceTests.cs`
- **IntegrationTests**: Tests that verify the application's behavior from end to end.
  - `ApiApplicationFactory.cs`
  - `UserControllerTests.cs`

This structure ensures that each component of the ValpasTimer-server is clearly defined, easily testable, and loosely coupled, adhering to the principles of Clean Architecture.
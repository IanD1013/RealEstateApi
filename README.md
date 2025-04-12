# Real Estate API

A modern RESTful API built with ASP.NET Core 8.0 for managing real estate properties and related operations.

## Features

- RESTful API endpoints for real estate operations
- JWT-based authentication and authorization
- Entity Framework Core for data access
- SQL Server database integration
- Swagger/OpenAPI documentation
- XML response format support

## Prerequisites

- .NET 8.0 SDK
- SQL Server
- Visual Studio 2022 or Visual Studio Code

## Getting Started

1. Clone the repository:
```bash
git clone [your-repository-url]
cd RealEstateApi
```

2. Update the database connection string in `appsettings.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Your-Connection-String-Here"
  }
}
```

3. Run the database migrations:
```bash
dotnet ef database update
```

4. Run the application:
```bash
dotnet run
```

The API will be available at `https://localhost:5001` (or the port specified in your configuration).

## API Documentation

Once the application is running, you can access the Swagger documentation at:
```
https://localhost:5001/swagger
```

## Authentication

The API uses JWT (JSON Web Tokens) for authentication. To access protected endpoints:

1. Obtain a JWT token through the authentication endpoint
2. Include the token in the Authorization header of your requests:
```
Authorization: Bearer your-token-here
```

## Project Structure

- `Controllers/` - API endpoints
- `Models/` - Data models and DTOs
- `Data/` - Database context and configurations
- `Migrations/` - Database migrations

## Dependencies

- Microsoft.AspNetCore.Authentication.JwtBearer (6.0.7)
- Microsoft.EntityFrameworkCore (9.0.3)
- Microsoft.EntityFrameworkCore.SqlServer (9.0.3)
- Microsoft.EntityFrameworkCore.Tools (9.0.3)
- Microsoft.IdentityModel.Tokens (8.8.0)
- Swashbuckle.AspNetCore (6.6.2)
- System.IdentityModel.Tokens.Jwt (8.8.0)
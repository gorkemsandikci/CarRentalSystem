
# Vehicle Rental Management System

This is a Vehicle Rental Management System API built using ASP.NET Core 7.0 and SQLite. The application allows you to manage vehicles, customers, and rental operations through basic CRUD operations. It is built with RESTful APIs to handle requests for vehicle rental services.

## Features

- Manage vehicles (add, update, delete, retrieve)
- Manage customers (add, update, delete, retrieve)
- Manage rental records (create new rentals, return vehicles, check availability)
- SQLite Database Integration
- Entity Framework Core for database management

## Technologies Used

- **ASP.NET Core 7.0**: Web framework for building APIs
- **Entity Framework Core**: ORM for database management
- **SQLite**: Lightweight relational database for development
- **Swagger UI**: Integrated API documentation and testing
- **C#**: Programming language

## Getting Started

### Prerequisites

- .NET SDK 7.0
- SQLite installed
- A tool to send API requests (e.g., Postman or Swagger)

### Setup

1. Clone the repository:

   ```bash
   git clone https://github.com/your-repo/vehicle-rental-management.git
   cd vehicle-rental-management
   ```

2. Install dependencies:

   ```bash
   dotnet restore
   ```

3. Apply migrations to create the database:

   ```bash
   dotnet ef database update
   ```

4. Run the application:

   ```bash
   dotnet run
   ```

5. Open your browser and navigate to `https://localhost:{port}/swagger` to explore the API using Swagger.

### API Endpoints

- **Vehicles**
  - GET `/api/vehicles` - Get all vehicles
  - GET `/api/vehicles/{id}` - Get vehicle by ID
  - POST `/api/vehicles` - Create a new vehicle
  - PUT `/api/vehicles/{id}` - Update an existing vehicle
  - DELETE `/api/vehicles/{id}` - Delete a vehicle

- **Customers**
  - GET `/api/customers` - Get all customers
  - GET `/api/customers/{id}` - Get customer by ID
  - POST `/api/customers` - Create a new customer
  - PUT `/api/customers/{id}` - Update an existing customer
  - DELETE `/api/customers/{id}` - Delete a customer

- **Rentals**
  - GET `/api/rentals` - Get all rentals
  - GET `/api/rentals/{id}` - Get rental by ID
  - POST `/api/rentals` - Create a new rental
  - PUT `/api/rentals/{id}/return` - Return a rented vehicle

### License

This project is licensed under the MIT License - see the LICENSE file for details.
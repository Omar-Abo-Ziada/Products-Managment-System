# Products Management System

> A comprehensive ASP.NET Core Web API implementing CQRS pattern with Clean Architecture for efficient product catalog management.

[![.NET](https://img.shields.io/badge/.NET-8.0-purple.svg)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-12.0-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Entity Framework](https://img.shields.io/badge/Entity%20Framework-8.0-green.svg)](https://docs.microsoft.com/en-us/ef/)
[![MediatR](https://img.shields.io/badge/MediatR-12.4-orange.svg)](https://github.com/jbogard/MediatR)

## 🎯 Overview

This project demonstrates a modern, enterprise-grade **Products Management System** built with **.NET 8** and **C# 12**. It showcases advanced architectural patterns including **CQRS (Command Query Responsibility Segregation)**, **Vertical Slice Architecture**, and **Clean Architecture** principles.

The system provides a robust foundation for managing products, categories, and user authentication with comprehensive logging, validation, and error handling mechanisms.

---

## ✨ Key Features

### 🛍️ **Product Management**

- Complete CRUD operations for products
- Category-based product organization
- Advanced product filtering and search
- Pagination support for large datasets

### 🔐 **Authentication & Authorization**

- JWT-based authentication system
- Role-based access control
- Secure user registration and login
- Token-based API security

### 🏗️ **Architecture Excellence**

- **CQRS Pattern** with MediatR implementation
- **Vertical Slice Architecture** for feature organization
- **Repository Pattern** for data access abstraction
- **Event-driven architecture** with domain events

### 📊 **Monitoring & Logging**

- Structured logging with **Serilog**
- Database and Seq logging sinks
- Comprehensive error tracking
- Performance monitoring capabilities

### 🔧 **Developer Experience**

- **Swagger/OpenAPI** documentation
- **FluentValidation** for input validation
- **AutoMapper** for object mapping
- Global exception handling middleware

---

## 🏛️ Architecture Overview

```text
┌─────────────────────────────────────────────────────────────┐
│                        API Layer                            │
│              (Controllers, Middleware)                      │
└─────────────────────────────────────────────────────────────┘
                                │
┌─────────────────────────────────────────────────────────────┐
│                    Features Layer                           │
│        ┌─────────────┐  ┌─────────────┐  ┌─────────────┐    │
│        │  Products   │  │    Auth     │  │   Common    │    │
│        │   - Add     │  │  - Login    │  │ - Events    │    │
│        │   - Edit    │  │  - Register │  │ - Handlers  │    │
│        │   - Delete  │  │             │  │ - DTOs      │    │
│        │   - Get     │  │             │  │             │    │
│        └─────────────┘  └─────────────┘  └─────────────┘    │
└─────────────────────────────────────────────────────────────┘
                                │
┌─────────────────────────────────────────────────────────────┐
│                     Data Layer                              │
│           (Entity Framework, Repositories)                  │
└─────────────────────────────────────────────────────────────┘
```

### 🎯 **Core Patterns**

- **CQRS**: Separates read and write operations for optimal performance
- **Mediator Pattern**: Decouples request/response handling
- **Repository Pattern**: Abstracts data access logic
- **Event Sourcing**: Tracks domain events for audit and notifications

---

## 🛠️ Technology Stack

| Category | Technologies |
|----------|-------------|
| **Framework** | .NET 8, ASP.NET Core Web API |
| **Language** | C# 12 with nullable reference types |
| **Database** | SQL Server with Entity Framework Core 8.0 |
| **Architecture** | MediatR, CQRS, Clean Architecture |
| **Authentication** | JWT Bearer tokens |
| **Validation** | FluentValidation |
| **Logging** | Serilog with SQL Server & Seq sinks |
| **Documentation** | Swagger/OpenAPI |
| **Mapping** | AutoMapper |

---

## 🚀 Getting Started

### 📋 Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (LocalDB or full instance)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

### ⚡ Quick Setup

1. **Clone the repository**

   ```bash
   git clone https://github.com/Omar-Abo-Ziada/Products-Managment-System.git
   cd "Products Management System"
   ```

2. **Configure Database**

   ```bash
   # Update connection string in appsettings.json
   # Then apply migrations
   dotnet ef database update
   ```

3. **Run the Application**

   ```bash
   dotnet run --project "ProductsManagmentSystem"
   ```

4. **Access the API**

   - **Swagger UI**: `https://localhost:7001/swagger`
   - **API Base**: `https://localhost:7001/api`

### 🔧 Configuration

Update `appsettings.json` with your settings:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=ProductsManagementDB;Trusted_Connection=true;"
  },
  "JwtSettings": {
    "SecretKey": "your-secret-key-here",
    "Issuer": "ProductsManagementAPI",
    "Audience": "ProductsManagementClient"
  }
}
```

---

## 📚 API Documentation

### 🛍️ Products Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| `GET` | `/api/products` | Get all products (paginated) |
| `GET` | `/api/products/{id}` | Get product by ID |
| `GET` | `/api/products/category/{categoryId}` | Get products by category |
| `POST` | `/api/products` | Create new product |
| `PUT` | `/api/products/{id}` | Update existing product |
| `DELETE` | `/api/products/{id}` | Delete product |

### 🔐 Authentication Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| `POST` | `/api/auth/register` | Register new user |
| `POST` | `/api/auth/login` | User login |

---

## 📁 Project Structure

```text
ProductsManagmentSystem/
├── 📁 Common/                 # Shared utilities and base classes
├── 📁 Configurations/         # Dependency injection configurations
├── 📁 Data/                   # Database context and configurations
├── 📁 Entities/               # Domain entities
│   ├── BaseEntity.cs
│   ├── Product.cs
│   ├── Category.cs
│   ├── User.cs
│   └── Role.cs
├── 📁 Features/               # Feature-based organization
│   ├── 📁 Products/           # Product management features
│   │   ├── AddProduct/
│   │   ├── EditProduct/
│   │   ├── DeleteProduct/
│   │   ├── GetProduct/
│   │   ├── GetAllProducts/
│   │   └── GetProductsByCategory/
│   ├── 📁 Auth/               # Authentication features
│   │   ├── Login/
│   │   └── Register/
│   └── 📁 Common/             # Shared feature components
├── 📁 Migrations/             # EF Core migrations
├── Program.cs                 # Application entry point
└── appsettings.json          # Configuration settings
```

---

## 🧪 Testing

```bash
# Run all tests
dotnet test

# Run with coverage
dotnet test --collect:"XPlat Code Coverage"
```

---

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. **Fork** the repository
2. **Create** a feature branch (`git checkout -b feature/AmazingFeature`)
3. **Commit** your changes (`git commit -m 'Add some AmazingFeature'`)
4. **Push** to the branch (`git push origin feature/AmazingFeature`)
5. **Open** a Pull Request

---

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

## 👨‍💻 Author

**Omar Abo Ziada**

- GitHub: [@Omar-Abo-Ziada](https://github.com/Omar-Abo-Ziada)

---

## 🙏 Acknowledgments

- Built with ❤️ using .NET 8 and Clean Architecture principles
- Inspired by modern software development best practices
- Special thanks to the .NET community for excellent resources and patterns

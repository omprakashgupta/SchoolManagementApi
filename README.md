# School Management API

.NET 8 Web API scaffold for a School Management System with layered architecture, Dapper repositories, AutoMapper, FluentValidation, JWT auth, rate limiting, caching, and API versioning.

## Features
- CRUD endpoints for students, teachers, classes, fees, library, transport, attendance, timetable, grades, homework, exams, announcements, inventory, health records
- Messaging and analytics endpoints
- JWT auth with role-based authorization
- Global exception handling with correlation IDs
- Pagination and filtering for GET endpoints
- Swagger UI with JWT support and API versioning

## Getting Started
1. Update connection strings and JWT settings in appsettings.json.
2. Ensure SQL Server and Redis are available if you want caching enabled.

### Run
```bash
cd src/SchoolManagementApi.Api
dotnet run
```

### Tests
```bash
cd tests/SchoolManagementApi.Tests
dotnet test
```

## API Versioning
- URL format: /api/v1.0/...
- Header format: X-Api-Version: 1.0

## Auth
- Use the Authorization header: Bearer {token}
- Roles used in policies: Admin, Teacher, Student, Parent

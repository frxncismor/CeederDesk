# CeederDesk

A Windows desktop application (C# / WinForms) built as the management interface for the Ceeder automated pet feeder system. Connects to a SQL Server database via stored procedures to handle user authentication, registration and data management.

## Features

- User login and registration via SQL Server stored procedures
- ADO.NET data access layer
- Multiple typed DataSet views for reporting
- RDLC report generation and printing

## Tech Stack

![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET_Framework-512BD4?style=flat&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=flat&logo=microsoftsqlserver&logoColor=white)
![WinForms](https://img.shields.io/badge/Windows_Forms-0078D6?style=flat&logo=windows&logoColor=white)

## Getting Started

### Prerequisites

- Visual Studio 2017 or later
- SQL Server (local instance)
- .NET Framework 4.x

### Database setup

1. Create a database named `CEEDER` in your local SQL Server instance
2. Create the required stored procedures:
   - `sp_UsuariosAlta` — User registration
   - `sp_UsuariosLogin` — User authentication
   - `sp_UsuariosTodoss` — User update

### Run locally

1. Open `Proyecto.sln` in Visual Studio
2. Update the connection string in `Proyecto/Conexion.cs` if needed:
   ```
   Data Source=.;Initial Catalog=CEEDER;Integrated Security=True
   ```
3. Press **F5** to build and run

## Project Structure

```
Proyecto/
├── Form1.cs           # Main application form (login screen)
├── Conexion.cs        # SQL Server connection and stored procedure calls
├── Program.cs         # Application entry point
├── *DataSet*.xsd      # Typed DataSet definitions for reports
└── *.rdlc             # RDLC report templates
```

## Preview

![Preview](./assets/preview.png)

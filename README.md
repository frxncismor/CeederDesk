# 🐾 CeederDesk — Smart Pet Feeder Management App

> **A Windows desktop application for managing the Ceeder smart pet feeder — configure feeding schedules, monitor device status, and manage pet profiles from your PC.**

[![C#](https://img.shields.io/badge/C%23-239120?logo=csharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-WinForms-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?logo=microsoftsqlserver&logoColor=white)](https://www.microsoft.com/en-us/sql-server)
[![WinForms](https://img.shields.io/badge/Windows%20Forms-0078D6?logo=windows&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/)

---

## 📋 Table of Contents

- [Overview](#-overview)
- [Key Features](#-key-features)
- [Technology Stack](#-technology-stack)
- [Architecture](#-architecture)
- [Getting Started](#-getting-started)
- [Project Context](#-project-context)

---

## 🎯 Overview

**CeederDesk** is a Windows desktop application built in **C# (WinForms)** for the **Ceeder** smart pet feeder ecosystem. It allows pet owners to configure and monitor their automated feeder device directly from their PC, with full data persistence via SQL Server.

The companion project **[Ceeder](https://github.com/frxncismor/ceeder)** is the product marketing website (HTML, CSS, ASP.NET) for the same ecosystem.

---

## ✨ Key Features

### 🗓️ Feeding Schedule Management
- Configure automated feeding times for each pet
- Set portion sizes per meal
- Recurring daily and weekly schedule support
- Visual schedule overview to quickly review the feeding plan

### 👤 Pet Profile Management
- Register multiple pets with individual profiles
- Store pet details: name, species, breed, and weight
- Assign dedicated feeding schedules per pet
- Track historical feeding records per pet

### 📊 Device Monitoring
- Real-time connection status indicator for the physical feeder device
- Feeding event log (successful feeds, missed feeds, errors)
- Low food level alerts
- Last sync timestamp display

### 🔐 User Authentication
- Secure user login and registration
- Stored procedure-based authentication via SQL Server
- Multi-user support for shared households

### 📄 Reporting
- Typed DataSet views for structured data reporting
- RDLC report generation and printing
- Feeding history export

---

## 🚀 Technology Stack

| Technology | Purpose |
|------------|---------|
| **C#** | Application logic and event handling |
| **WinForms (.NET Framework)** | Desktop UI — forms, controls, and dialogs |
| **SQL Server** | Local relational database for all app data |
| **ADO.NET** | Data access layer (stored procedures, DataSets) |
| **RDLC Reports** | Structured report generation and printing |

---

## 🏗️ Architecture

```
┌──────────────────────────────┐
│    WinForms UI Layer         │
│  (Forms, Controls, Events)   │
└──────────────┬───────────────┘
               │
┌──────────────▼───────────────┐
│    Business Logic Layer      │
│  (Schedule, Pet, Auth mgmt)  │
└──────────────┬───────────────┘
               │
┌──────────────▼───────────────┐
│    Data Access Layer         │
│  (ADO.NET + SQL Server SPs)  │
└──────────────────────────────┘
```

### Key Design Decisions
- **Stored Procedures** for all database operations — cleaner SQL separation and security
- **Typed DataSets** for structured report data binding
- **3-layer architecture** — UI, business logic, and data access are cleanly separated

---

## 🚀 Getting Started

### Prerequisites

- Windows 10 or later
- Visual Studio 2017 or later
- SQL Server (LocalDB or full instance)
- .NET Framework 4.x

### Setup

1. **Clone the repository**
   ```bash
   git clone https://github.com/frxncismor/CeederDesk.git
   ```

2. **Open the solution**
   - Open `Proyecto.sln` in Visual Studio

3. **Configure the database**
   - Create a database named `CEEDER` in your SQL Server instance
   - Create the required stored procedures:
     - `sp_UsuariosAlta` — User registration
     - `sp_UsuariosLogin` — User authentication
     - `sp_UsuariosTodoss` — User data retrieval
   - Update the connection string in `Proyecto/Conexion.cs` if needed:
     ```
     Data Source=.;Initial Catalog=CEEDER;Integrated Security=True
     ```

4. **Build and run**
   - Press **F5** or go to `Build → Start Debugging`

---

## 📁 Project Structure

```
Proyecto/
├── Form1.cs              # Main application form (login screen)
├── Conexion.cs           # SQL Server connection and stored procedure calls
├── Program.cs            # Application entry point
├── *DataSet*.xsd         # Typed DataSet definitions for reports
└── *.rdlc                # RDLC report templates
```

---

## 📚 Project Context

CeederDesk was developed as a **university capstone project** in 2019 as part of the **Ceeder ecosystem** — a concept for an IoT smart pet feeder designed to automate pet care for busy owners.

This project demonstrates:

- **Desktop application development** with C# and WinForms
- **Relational database design** with SQL Server and stored procedures
- **ADO.NET data access** with typed DataSets and parameterized queries
- **3-layer architecture** separating UI, business logic, and data concerns
- **Report generation** with RDLC and DataSet binding
- **Real-world problem solving** — automating routine pet care tasks

The companion **[Ceeder website](https://github.com/frxncismor/ceeder)** (ASP.NET, HTML, CSS) served as the product marketing page for the same capstone project.

---

## 🤝 Contact

Built by [Francisco Morales](https://frxncismor.dev) · [GitHub](https://github.com/frxncismor)

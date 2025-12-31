# 🔧 Maintenance Management System – ASP.NET Core Web API

## 📌 Overview
Maintenance Management System is a backend Web API built with **ASP.NET Core** to simulate a real-world maintenance workflow, not just basic CRUD operations.

The system manages:
- Customers and their equipments
- Maintenance requests lifecycle
- Technician assignments
- Role-based secured APIs

---

## 🧠 Business Flow
Customers → Equipments → Maintenance Requests → Technician Assignments

---

## 🏗️ Architecture & Design
- Layered architecture (Controllers / Services / DTOs)
- Thin Controllers
- Business logic handled in Services
- DTO-based communication (Request / Response)

---

## 🔐 Authentication & Authorization
- JWT-based authentication
- Claims-based identity
- Role-based authorization (`Admin / User`)
- Secured endpoints using `[Authorize]`

---

## 🗄️ Data & Persistence
- Entity Framework Core
- Code First + Migrations
- Real One-to-Many relationships

---

## 🧩 Core Modules
- Customers
- Equipment
- Technicians
- Maintenance Requests
- Assignments
- Authentication

---

## 🛠️ Tech Stack
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- JWT
- LINQ & Dependency Injection

---

## 🚀 Future Improvements
- Policy-based authorization
- Better validation & error handling
- Unified API responses


# 📚 Smart Library Management System (Console-Based | C# .NET)

[![C#](https://img.shields.io/badge/C%23-239120?logo=csharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![License](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)
[![Platform](https://img.shields.io/badge/Platform-Console-blue.svg)](https://dotnet.microsoft.com/en-us/apps/aspnet)

A clean, fully functional **console-based Library Management System** built with **C# and .NET**. It automates book management, member registration, book issuance/returns, fine calculation, and generates insightful reports — all with persistent JSON storage.

Perfect for **small to medium libraries** and an excellent academic/project showcase for **Visual Programming, .NET, or OOP courses**.

---

## 📌 Project Overview

This project replaces traditional manual record-keeping with a modern, menu-driven digital system. It demonstrates real-world implementation of:

- **Object-Oriented Programming (OOP)** principles
- **File Handling** with JSON persistence
- **Data Validation** and robust error handling
- **Modular & Clean Architecture**

Data is automatically saved and loaded between sessions using three JSON files:
- `books.json`
- `members.json`
- `issues.json`

---

## 🚀 Features

### 📖 Book Management
- Add, view, update, and delete books
- Search by **title**, **author**, **ISBN**, or **category**
- Track total copies and available copies

### 👤 Member Management
- Register new members
- Update and delete member records
- Search members by **ID** or **name**

### 🔄 Issue & Return System
- Issue books with automatic **due date** calculation
- Prevent issuing unavailable or already issued books
- Return books with **automatic fine calculation**
- Maintain complete borrowing history

### 💰 Fine Calculation
- Configurable daily fine rate
- Automatic overdue detection and fine computation

### 📊 Reports & Analytics
- Total books vs. available books
- Currently issued and overdue books
- Total registered members
- Active borrowings summary

### 💾 Data Persistence
- Fully persistent using **JSON** storage
- No database required — works instantly on any machine

---

## 🏗️ Project Structure

```bash
Smart-Library-Management-System/
├── Program.cs                  # Main entry point & menu system
├── Models/
│   ├── Book.cs
│   ├── Member.cs
│   └── IssueRecord.cs
├── Services/
│   ├── BookService.cs
│   ├── MemberService.cs
│   ├── IssueService.cs
│   └── ReportService.cs
├── Data/
│   ├── JsonDataStore.cs        # JSON read/write helper
│   └── Data/                   # Auto-created folder
│       ├── books.json
│       ├── members.json
│       └── issues.json
├── Utils/
│   ├── ConsoleHelper.cs        # UI formatting & input validation
│   └── Validator.cs
├── LibraryApp.csproj
└── README.md

# LHFD.CleanArch.Infrastructure

A unified, lightweight Infrastructure and Core SDK for .NET 10 applications following Clean Architecture principles.

This package bundles essential Domain base entities, Generic Repository patterns, Unit of Work, and EF Core 10 integration into a single library to eliminate inter-package versioning overhead and accelerate project setup.

## 🚀 Features

- **Domain Core**: Lightweight base contracts (`BaseEntity<TKey>`, `ISoftDelete`).
- **Generic Repository**: Fully asynchronous base repository (`IRepository<TEntity, TKey>`) with built-in soft delete handling.
- **Unit of Work**: Generic Unit of Work pattern tied directly to your `DbContext`.
- **Easy Dependency Injection**: Simple extension method to register infrastructure services in one line.

---

## 📦 Installation

Install via the .NET CLI:

```bash
dotnet add package LHFD.CleanArch.Infrastructure
# 🚴‍♂️ SmartBikePOS Backend

SmartBikePOS-Backend is a lightweight, secure, and scalable backend API built with **ASP.NET Core** and **SQLite**, designed to power a modern point-of-sale (POS) system for bike spare parts stores. It supports **JWT authentication**, **offline data syncing**, and **CORS**-enabled access from a React-based frontend.

---

## 🧰 Tech Stack

- ASP.NET Core Web API (.NET 7/8)
- Entity Framework Core with SQLite
- JWT Authentication
- CORS for cross-origin frontend support
- Docker (optional for deployment)
- RESTful API structure

---

## 🔐 Features

- 🔑 User registration and login with JWT
- 📦 Product and category management (CRUD)
- 🛒 Order and table-based billing support
- 📊 Admin features: sales reporting and inventory tracking
- 🛰️ IndexedDB + API sync-friendly design for offline scenarios

---

## 🚀 Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download)
- [SQLite](https://www.sqlite.org/index.html) or a DB viewer like DB Browser for SQLite

### Setup

1. **Clone the repository**
   ```bash
   git clone https://github.com/Milinda55/SmartBikePOS-Backend.git
   cd SmartBikePOS-Backend
   ```
2. **Restore packages**
    ```bash
    dotnet restore
    ```
3. **Update DB & run migrations**
    ```bash
    dotnet ef database update
    ```
4. **Run the server**
    ```bash
    dotnet run
    ```

## 🤝 Frontend Integration

Use this backend with the companion frontend:  
👉 **SmartBikePOS Frontend (React + PWA)**

---

## 📃 License

This project is licensed under the **MIT License** – see the [LICENSE](LICENSE.txt) file for details.

---

## 💬 Contact

Created by **Harshana wijerathne & Milinda Karunaratne**  
For questions or collaboration: [Harshana](harshanawijerathne08@gmail.com), [Milinda](milindakarunaratna55@gmail.com)

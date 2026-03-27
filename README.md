# 📝 Task Manager App (ASP.NET Core MVC)

A simple and efficient task management web application built using **ASP.NET Core MVC (.NET 8)**. This app allows users to create, view, update, and delete tasks, making it ideal for learning CRUD operations and strengthening backend development skills.

---

## 🚀 Features

* ✅ Add new tasks
* 📋 View all tasks
* ✏️ Update existing tasks
* ❌ Delete tasks
* ⏰ Assign a due date to each task
* 📝 Include task name and description
* 🎨 Clean UI with Font Awesome icons

---

## 🛠️ Technologies Used

* **ASP.NET Core MVC (.NET 8)**
* **Entity Framework Core (EF Core)**
* **SQL Database (via EF Core)**
* **HTML5, CSS3**
* **Font Awesome**

---

## 🧱 Project Structure

```
TaskManagerApp/
│
├── Attributes/	        # Handles model validation
├── Controllers/        # Handles user requests
├── Models/             # Application data models (TaskModel)
├── Views/              # Razor views (UI)
├── Data/               # Database context (EF Core)
├── wwwroot/            # Static files (CSS, icons)
└── Migrations/         # EF Core migrations
```

---

## 🗃️ Database

This application uses **Entity Framework Core** to manage the database.

* Database is created using **Code First approach**
* Migrations are used to update the database schema

### Example Model:

```csharp
public class TaskModel
{
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
}
```

---

## ⚙️ Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/SnowyParis/task-manager-app.git
cd task-manager-app
```

---

### 2. Restore dependencies

```bash
dotnet restore
```

---

### 3. Update the database

```bash
dotnet ef database update
```

---

### 4. Run the application

```bash
dotnet run
```

Then open your browser and go to:

```
https://localhost:5001
```

---

## ✨ How It Works

* Users interact with the UI through Razor views
* Requests are handled by MVC controllers
* Data is processed and stored using EF Core
* The database stores all task-related information

---

## 📌 Learning Goals

This project was built to help me:

* Practice **CRUD operations** in ASP.NET Core MVC
* Understand **model binding and validation**
* Learn how to use **Entity Framework Core**
* Work with **relational databases**
* Improve **frontend + backend integration**

---

## 🔮 Future Improvements

* Add user authentication (login/register)
* Implement task status (Completed / Pending)
* Add search and filtering
* Improve UI/UX design
* Add API support

---

## 🤝 Contributing

Contributions, issues, and suggestions are welcome!

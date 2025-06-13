# Student Management System (Console Application)

A console-based application built with C# and .NET for managing students, courses, and enrollments. This project serves as a practical demonstration of core Object-Oriented Programming (OOP) principles and clean software architecture.

This application was developed as a key component of my personal study plan and professional development portfolio.

---

## 🎇Key Features

* **Student Management:** Add new students and view a complete list of all registered students.
* **Course Management:** Create new courses and view all available courses.
* **Enrollment System:** Enroll students into courses, creating a many-to-many relationship.
* **Clean Architecture:** Built using a Model-Service architecture to enforce Separation of Concerns.
* **Interactive UI:** A simple, menu-driven user interface for easy navigation within the console.

---

## 🎇Core Concepts

This project was a focused exercise in applying fundamental software design principles:

* **Object-Oriented Programming (OOP):**
    * **Encapsulation:** Data (e.g., `Student` properties) is protected and bundled with the logic that manipulates it.
    * **Abstraction:** The `StudentService` class provides a simple interface to perform complex actions without exposing the underlying implementation details.

* **Software Architecture:**
    * **Separation of Concerns (SoC):** The application is distinctly divided into three layers:
        1.  **Models (`Student`, `Course`, `Enrollment`):** Pure data classes.
        2.  **Services (`StudentService`):** Contains all business logic.
        3.  **Presentation (`Program.cs`):** The user interface.
    * **Single Responsibility Principle (SRP):** Each class has one clear purpose. For example, the `Student` class is only responsible for holding student data, not for saving itself to a database.

---

## 🎇Technologies Used

* **Language:** C#
* **Framework:** .NET 8 (or your specific version)
* **Development Environment:** Visual Studio Code / Visual Studio 2022

---

## 🎇Starting the project

To get a local copy up and running, please follow these simple steps.

### Prerequisites

You will need the [.NET SDK](https://dotnet.microsoft.com/en-us/download) installed on your machine.

### Installation & Running

1.  **Clone the repository to your local machine:**
    ```sh
    git clone [https://github.com/your-username/project-student-management-system.git](https://github.com/your-username/project-student-management-system.git)
    ```

2.  **Navigate to the project's source directory:**
    ```sh
    cd project-student-management-system/src/StudentManagement
    ```
    *Note: The main `Program.cs` file is located in the `src/StudentManagement` directory.*

3.  **Run the application from the command line:**
    ```sh
    dotnet run
    ```
    The application menu will appear in your console.

---

<p align="center">
  <img src="assets\plink-cat-plink.gif" alt="Kitty" width="250"/>
</p>
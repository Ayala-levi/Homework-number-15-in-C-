# Project Name - WebShop

## Project Description

This project is a web application for managing a product list, with a user-friendly interface and options to add, update, and delete products.

## Key Features

* Displaying a product list with details such as name, price, and stock.
* Ability to add new products to the system.
* Ability to update details of existing products.
* Ability to delete products from the system.
* Intuitive and easy-to-use user interface.
* User login system.
* RESTful API for managing products.

## Technologies Used

* **Client Side:** Visual Studio Code
* **Server Side:** C# (Visual Studio)
* **Database:** SQL

## System Requirements

* **Visual Studio Code (Recommended version:** 1.85.1)
* **Visual Studio (Recommended version:** Visual Studio 2022)
* **SQL Server (Recommended version:** SQL Server 2019)
* **.NET Framework (Recommended version:** .NET Framework 4.8)
* **ORM:** Entity Framework Core (EF Core)

## Installation Instructions

1. Clone the repository to a local directory:

```bash
git clone https://github.com/Ayala-levi/Homework-number-15-in-C-
```
2. Open the Visual Studio solution (`.sln`) in Visual Studio.
3. **Database Configuration:**
   * Update the database connection string in the `ShopDBContext.cs` file.
   * Make sure your SQL Server database is running.
   * **Migrations:**
     * Open the Package Manager Console in Visual Studio.
     * Run the `Update-Database` command to create or update the database.

4. Build the project (Build -> Build Solution) in Visual Studio.
5. Run the project (Debug -> Start Debugging) in Visual Studio.

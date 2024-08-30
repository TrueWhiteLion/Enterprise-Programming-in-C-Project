## Readme:
This project is divided into two main branches.
- Prototype
- IntegratedAPI

The Indev branch has a functional prototype of the web page with the ability to manage a cart, manage items in an admin page and process the order. This page does not have the databases set up as it is there to show functionality and provide a view of how the project works and looks.

IntegratedAPI has its API set up as well as the details for the database and other pushes and calls. Because it is not attached to a database it is not currently functioning and does not work well as a display prototype. This is however closer to what the program would represent when in its final form.
Please make sure to use the Prototype branch for functionality review and the IntegratedAPI for code.

During the development of the IntegratedAPI there were a few issues present. These will still be resolved with more development and time. Given the time scope of the project these could not be addressed.

# SA Online Mart

SA Online Mart is an e-commerce platform built using ASP.NET Core with Razor Pages. This project serves as a prototype for an online shopping site that allows users to browse products, add items to a cart, and place orders. The admin panel provides functionality for managing products, including adding, updating, and deleting products.

## Table of Contents

- [Features](#features)
- [Architecture](#architecture)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Database Setup](#database-setup)
- [Running the Application](#running-the-application)
- [License](#license)

## Features

- User registration and authentication.
- Product browsing and detailed view.
- Shopping cart management (add, update, and remove items).
- Checkout process with order summary.
- Admin panel for product management (CRUD operations).
- Responsive design with an African aesthetic.

## Architecture

The project follows a layered architecture with the following components:

- **Frontend**: ASP.NET Core Razor Pages for rendering the UI.
- **Backend**: .NET Core API for handling business logic and data access.
- **Database**: SQL Server for data storage, including tables for users, products, orders, and order items.

## Technologies Used

- **ASP.NET Core**: For building the web application and API.
- **Entity Framework Core**: For data access and ORM.
- **SQL Server**: For relational database management.
- **C#**: The primary programming language for backend and business logic.

## Installation

Clone the repository
    - Prototype - To view functionality
    - IntegratedAPI - For API and database

Update the connection string in appsettings.json to point to your SQL Server instance:
"ConnectionStrings": {
    "DefaultConnection": ""
}

Run the program
dotnet run --project Enterprise-Programming-in-C-Project

## Lisence
This project is licensed under the MIT License

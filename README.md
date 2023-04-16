# TastyTreats

#### By Dani Steely

#### _Application for creating and viewing a database of products and product categories for a fictional bakery, using many-to-many relationships in .Net and MySQL databasewith EF Core. Utilizes Identity Core for creating user account and handling view authorization._

## Technologies Used
* _C#_
* _ASP.NET Identity Core_
* _ASP.NET Core MVC_
* _Entity Framework Core_
* _MySQL_

## Setup/Installation Requirements
#### Setting up directories
* clone this repo to your desktop
* navigate to project directory in your terminal
* follow the next steps for creating an appsettings file and setting up a database

#### Creating an appsettings file
* navigate to "TastyTreats" directory (production directory)
* create a new file called appsettings.json
* the following code should go in the appsettings.json file:
```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE-NAME];uid=[USERNAME];pwd={PASSWORD};"
  }
}
```
* within the appsettings.json file, you will need to replace `[DATABASE-NAME]` with the name of the database, `[USERNAME]` with your username, and `[PASSWORD]` with your password

#### Database setup
* this project uses ["Code-First Development with Migrations"][Code-First Dev]
* navigate to the TastyTreats directory (the production directory) and use the command:

```
$ dotnet ef database update
```

* use the following command to then build the database and get the app running:

```
$ dotnet run
```

## Description

This application is a self-contained project developed as part of [Epicodus][Epicodus] coursework in [C# with .Net][C# course main]. It was completed following the ["Authentication with Identity"][C# chapter] module in the curriculum. The application utilizes the capabilities of ASP.NET Core MVC framework for routing and handling user requests, along with Entity Framework Core for communicating with a MySQL database through .NET objects. It can store and retrieve data related to products and categories of a fictitious bakery, and supports user account functionalities such as registration, login, and management. The project showcases proficiency in implementing many-to-many relationships in MySQL databases and integrating ASP.NET Identity Core for managing user authentication and authorization.

## Objectives
* Does at least one of your classes have all CRUD methods implemented in your app?
* Are you able to view both sides of the many-many relationship? For a particular instance of a class, are you able to view all of the instances of the other class that are related to it?
* Are users able to register, log in and log out with Identity?
* Is Create, Update and Delete functionality limited to authenticated users?
* Build files and sensitive information are included in .gitignore file and is not to be tracked by Git, and includes instructions on how to create the appsettings.json and set up the project.
* There should be a many-to-many relationship between Engineers and Machines.
* The factory manager should be able to add a list of engineers, a list of machines, and specify which engineers are licensed to repair which machines.

## Known Bugs
* No known bugs

## License

_MIT License_

Copyright (c) _4/8/23_ _Dani Steely_

[Epicodus]: https://www.epicodus.com/
[C# course main]: https://www.learnhowtoprogram.com/c-and-net-part-time
[C# chapter]: https://www.learnhowtoprogram.com/c-and-net-part-time/authentication-with-identity
[Code-First Dev]: https://www.learnhowtoprogram.com/c-and-net-part-time/many-to-many-relationships/code-first-development-and-migrations



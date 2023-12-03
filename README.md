<h1> Movies Project</h1>

---

<h2>Overview</h2>

This Application repository contains:

- **Database:**
  - SQL Server
- **Backend:**
  - .Net Core 8.0
  - C#
  - Entity Framework
  - LinQ
- **Frontend:**
  - React
  - Bootstrap
  - Axios

Tools you will need:

- Visual Studio
- .Net Core 8
- SQL Server or SQL Express
- Visual Studio Code
- Node
- Github

<h2>Setup</h2>

This Project runs with Entity Framework, the db structure and initial data is in the migration folder, in order to populate the db with the scripts you must following the next steps:

- Create a database in MSSQL.
- Open the Project in Visual Studio
- According to your server, replace the connection string (_DefaultConnection_) in the [appsettings.Development.json](https://github.com/frankrogerrm/MoviesProject/blob/main/MoviesProject.Api/appsettings.Development.json) file located in the API project.

```js
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": {
    "DefaultConnection": "<<STRING TO CHANGE>>"
  }
}
```

- Open the **_Package Manager Console_** using the tool menu.
- In the Console Section select **_MoviesProject.Service_** in the **_Default Project_** rropdown.
- Run the command **_update-database_** in the console

```js
PM > update - database;
```

- Run the API Project in **_Visual Studio_**

The frontend project is **_MoviesProject. web_** it is perfomed in React, in order to run it and consume the api configured in the previous steps, you should:

- Open MoviesProject.Web in VSCode
- Change the api url that MoviesProject.API is using, in [.env](https://github.com/frankrogerrm/MoviesProject/blob/main/MoviesProject.Web/movies-project-web/.env) file

```js
REACT_APP_BASE_URL = "<<API URL TO CHANGE>>"; //ex. "http://localhost:9999"
```

- Run **_npm install_** under the folder movies-project-web

```js
PS C:\Projects\MoviesProject\MoviesProject.Web\movies-project-web> npm install
```

- Run **_npm run start_** under the folder movies-project-web

```js
PS C:\Projects\MoviesProject\MoviesProject.Web\movies-project-web> npm run start
```

- The frontend project will be shown in the browser

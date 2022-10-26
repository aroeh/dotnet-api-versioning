# Introduction
This project is a demonstration of api versioning techniques using the Dotnet framework

## Goals
1. Learn about API versioning capabilities
2. Implement versioning on a Dotnet minimal api and expanded apis with controllers
3. Integrate versioning with Swagger

## References
- [ASPNET Versioning Wiki](https://github.com/dotnet/aspnet-api-versioning/wiki)
- [How to use API versioning in ASP.NET Core Web API and integrate it with Swagger using .NET 6](https://blog.christian-schou.dk/how-to-use-api-versioning-in-net-core-web-api/)

# Tools
- IDE
    - Visual Studio 2022 version 17.0.2 or higher - Any edition (I used Community)
- Postman
    - [Postman Main Site](https://www.postman.com/)
- Optional
    - Visual Studio Code version 1.62.3 or higher

# Key Libraries and Downloads
- .Net 6.0
- Microsoft.AspNetCore.Mvc.Versioning v5.0.0
- Microsoft.AspNetCore.Mvc.Versioning.ApiExplorer v5.0.0
- Swashbuckle.AspNetCore v6.4.0

# Getting Started
1.	Ensure that you have all required tools installed
2.	Install optional tools if desired
3.	Install .Net 6.0 framework if it is not already installed on the workstation
4.  Download and install Postman or other tool that can make API requests
5.  Build the solution and all projects
6.  Run the project of choice and begin sending API requests


# Build
The solution will build and compile after restoring packages.  Use the menu to build or the keyboard shortcut (often F6).  You can also build the project via the command line using the command `dotnet build`

# Run
There are 2 projects in the solution:
- Api_Versioning
- coming soon

Each project can be run through the IDE or via command line using the command `dotnet run`

## Sample Requests

### Query Parameter Versioning
GET /api/Weathernoversion?api-version=1.0 HTTP/1.1
Host: localhost:5107
```
http://localhost:5107/api/Weathernoversion?api-version=1.0
```

GET /api/Weather?api-version=1.0 HTTP/1.1
Host: localhost:5107
```
http://localhost:5107/api/Weather?api-version=1.0
```

GET /api/Weather?api-version=2.0 HTTP/1.1
Host: localhost:5107
```
http://localhost:5107/api/Weather?api-version=2.0
```

### URL Route Versioning
GET /api/v1.0/values HTTP/1.1
Host: localhost:5107
```
http://localhost:5107/api/v1.0/values
```

GET /api/v2.0/values HTTP/1.1
Host: localhost:5107
```
http://localhost:5107/api/v2.0/values
```
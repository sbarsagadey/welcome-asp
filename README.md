# Welcome ASP.NET Core Project

This is a sample ASP.NET Core MVC application with a welcome page.

## Features

- ASP.NET Core 8.0 MVC
- Welcome page with dynamic content
- Bootstrap styling
- Responsive design
- ViewBag data passing
- Clean project structure

## Prerequisites

- .NET 8.0 SDK or later
- Visual Studio 2022, Visual Studio Code, or any compatible IDE

## How to Run

1. Open a terminal/command prompt in the project directory
2. Restore the packages:
   ```bash
   dotnet restore
   ```
3. Build the project:
   ```bash
   dotnet build
   ```
4. Run the application:
   ```bash
   dotnet run
   ```
5. Open your browser and navigate to:
   - HTTP: `http://localhost:5000`
   - HTTPS: `https://localhost:7000`

## Project Structure

```
WelcomeAsp/
├── Controllers/
│   └── HomeController.cs          # Main controller with welcome action
├── Views/
│   ├── Home/
│   │   └── Welcome.cshtml         # Welcome page view
│   ├── Shared/
│   │   └── _Layout.cshtml         # Main layout template
│   ├── _ViewStart.cshtml          # View start configuration
│   └── _ViewImports.cshtml        # View imports
├── wwwroot/
│   ├── css/
│   │   └── site.css               # Custom styles
│   └── js/
│       └── site.js                # JavaScript files
├── Properties/
│   └── launchSettings.json        # Launch configuration
├── Program.cs                     # Application entry point
├── WelcomeAsp.csproj             # Project file
└── README.md                     # This file
```

## What You'll See

The welcome page displays:
- A welcome message
- Current date and time
- A feature list showing what's demonstrated
- Clean, responsive design with Bootstrap

## Next Steps

You can extend this project by:
- Adding more controllers and actions
- Creating additional views
- Adding models and data
- Implementing authentication
- Adding database connectivity
- Creating API endpoints

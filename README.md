Installation

1. Dotnet SDK
2. Nodejs
3. VS code - Code Editor

Extensions

1. C#
2. C# Entensions
3. Nuget Package Manager

Steps:

1. Create a webapi project through dotnet cli

- mkdir demoapplication
- cd demoapplication
- dotnet new webapi -o demoapplication.api -n demoapplication.api

2. Properties lauchsettings.json

- // "applicationUrl": "https://localhost:5001;http://localhost:5000",
- "launchBrowser": true,

API Steps

1. Create a model
2. Create a datacontext class
3. Add Packakge Microsoft.EntityFrameworkCore.Sqlite
4. Specify Connectionstrings in appsettings.json
5. dotnet ef migrations add InitialCreate which creates a Migrations folder with some .cs files
6. dotnet ef database update

##Create Angular Application
Installation

1.  Angular CLI - npm install -g @angular/cli or yarn add global @angular/cli

extensions

1. Angular V7 snippets - John papa
2. Angular Files - Alexander Ivanichev
3. Angular Language Service - angular
4. Angular2-switcher
5. Auto Rename Tag
6. Bracket Pair Colorizer
7. Debugger for Chrome
8. Material Icon Theme
9. Path Intellisense
10. Prettier
11. TSLint

steps

1. ng new demoapplication-spa
2. run the application ng serve

##Enable CORS in demoapplication.api project

1. Add services.AddCors()
2. Configure method above UseMVC() add app.UseCors(c => c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

##Add Bootstrap and fontawesome to spa project

1. npm install bootstrap font-awesome
2. Bootstrap depends on jquery instead of jquery the alternative is

##Add Both API and SPA projects to Git

1. Install Git from git-scm.com
2. run cmd git --version
3. Delete the hidden folder .git from demoapplication.spa folder
4. Go to root folder demoapplication and run git init
5. create a .gitignore file in API project and ignore bin, obj, vscode items.
6. Stage Changes
7. Commit to local
8. Login to github account
   create a new repository DemoApplication
9. git remote add origin https://github.com/NaveenChittimalla/DemoApplication.git
10. Push to

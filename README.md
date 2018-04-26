# DependencyInjection
This tutorial project teaches the concepts of dependency injection by creating an application that processes data dynamically and in parallel. Any language should be able to implement the concepts that we will describe here. We will use depency injection to simulate **three** common design patterns: Factory, Service Locator and Singleton. For **Java** developers, we will essentially be building the internals of Spring Framework - You should be familiar with some concepts here. We will also include a basic unit test project so you brush up on some of those concepts, also creating a policy based exception framework and logging and email alerting. DB will not be in the table for now, but we can include it in the future. 

We will be using vanilla C# and .Net Core and the only external we will bring in is a .NetCore port of the classic Microsoft Practices Enterprise Library. This is not a framework, but rather an SDK or class library that allows one to build enterprise components from scratch. This library allows for Robust Logging, Exception Handling, Dependency Injection, and many more. Few libraries out there are as complete as this one. **NOTE** : Enterprise library is NOT a framework. This is a well structured class library that allows one to build enterprise features from scratch. I'm not a big fan of loading my project with tons of 3rd party tools... this can create a dependency nightmare as well as crazy version controlling of these externals that can sooner or later break your system.

So on to our tasks to accomplish as we move along with this tutorial project.

- [x] NuGet Enterprise Library Components (Unity Dependency Injection and Exception Handling).
- [x] Create our Dependency Injection classes. **DI.Common** folder.
- [ ] Create TestClasses for our DI Components.
- [ ] Create Unit Test Project.
- [ ] Create Exception Policy Framework.
- [ ] Create Logging Framework.
- [ ] Integrate full parallel processing.
- [ ] Create thread monitoring and managing. 

This project is also **C#** based using **DotNet Core**.
There have been many changes to .NET. Mind you, I have been a C++, Python and C#.Net Developer. People were thrown away by .Net since it was not free. However, since I dont freelance I have never had to worry about paying. Recently though, Microsoft opened sourced .Net to a brand new version designated as **Core**. 

The important part here is that AspNet and .Net have completely been reworked, trimmed out and improved. The multithreading and parallel libraries outperform java libraries and microservice creation has never been easier. On another note, not only is .NetCore an open source initiative bringing bright minds to extend and improve it, it also has Microsoft backing it. Which means you have a user base with financial backing. This will always strengthen any initiative. 

### How to set up .Net Core
First of all, go to the [DotNet Quickstart Guide](https://www.microsoft.com/net/learn/get-started/windows)
Choose the appropriate OS (Windows, Linux, OS) and follow the **VERY EASY INSTRUCTIONS**

You can use VSCode which is free and just install the C# Extension.
Building this project is quite simple.
Navigate to the directory **DI.DataProcessor** where the .cproj file is located and execute:

`dotnet build`
You should see the build results. If you have build errors, let me know as you might not have your system configured properly.
This command will find the .csproj file and will build the project and create the following directory structure where the compiled binaries are located with Debug object files.
- root
  - bin
    - Debug
      - netcoreapp2.0

You can then execute `dotnet run` from the same dirctory and it will run the compiled project.
After building, you can also drill down to the **netcoreapp2.0** directory and execute `dotnet nameOfCompiledProj.dll` in windows and *.so* for linux I believe. 

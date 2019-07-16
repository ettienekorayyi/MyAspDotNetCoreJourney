# MyAspDotNetCoreJourney
This is a repository that will contain my coding exercises in preparation to learn an ASP.NET Core using the Roadmap created by MoienTajik as a reference.

#How To Create Unit Test using .NET CORE
1.Create the Unit Test Directory
  - Go to Unit Test directory
  - type this at the vscode terminal: dotnet new xunit
  - dotnet add reference ../<DirectoryName>/<FileName>.csproj
2.Navigate back to root directory then add the project to be tested on the test project
  - dotnet sln add ./PrimeService.Tests/PrimeService.Tests.csproj
3. Run dotnet test
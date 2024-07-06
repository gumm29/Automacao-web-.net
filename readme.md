### Para instalar as libs, rodar os comandos
```
dotnet add package Microsoft.NET.Test.Sdk
dotnet add package NUnit
dotnet add package NUnit3TestAdapter
dotnet add package Selenium.WebDriver
dotnet add package SpecFlow
dotnet add package SpecFlow.NUnit
dotnet add package SpecFlow.Tools.MsBuild.Generation
dotnet add package Xunit.Gherkin.Quick
```

### Para rodar o projeto, rodar
```
dotnet clean
dotnet build
dotnet test
```

#### obs: ter o chomedriver na pasta padrao (ou no PATH)
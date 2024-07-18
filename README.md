
# My Code + Notes for [C# Testing in Visual Studio](https://learn.microsoft.com/en-us/training/modules/visual-studio-test-tools/) Module

Using VS Code with the [C# Dev Kit](https://code.visualstudio.com/docs/csharp/testing) extension instead of Visual Studio


https://learn.microsoft.com/en-us/dotnet/core/tutorials/testing-library-with-visual-studio-code?pivots=dotnet-8-0

### Unit 3: Exercise - Write a test

1. Open the Command Palette and select **.NET:New Project**.. then select **Console Application**
2. Name it LearnMyCalculatorApp
3. Add Calculator.cs file
4. Open the Command Palette and select **.NET:New Project**.. then select **MSTest Project**
5. Name it LearnMyCalculatorApp.Tests
6. Add project reference 

```bash
cd LearnMyCalculatorApp.Tests
dotnet add ../LearnMyCalculatorApp.Tests reference ../LearnMyCalculatorApp
```

7. Click green button next to test method or use the test explorer to run tests

Skipped Unit 4 since it was about Visual Studio

### Unit 5: Exercise - Create a test suite

### Unit 6 - Sharpen your test skills

Example data driven test

```
[DataTestMethod]
[DataRow(1, 1, 2)]
[DataRow(2, 2, 4)]
[DataRow(3, 3, 6)]
[DataRow(0, 0, 1)] // The test run with this row fails
public void AddDataTests(int x, int y, int expected)
{
    var calculator = new Calculator();
    var actual = calculator.Add(x, y);
    Assert.AreEqual(expected, actual);
}
```

## Additional materials

https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test
https://github.com/devlooped/moq/wiki/Quickstart
https://learn.microsoft.com/en-us/aspnet/core/mvc/controllers/testing?view=aspnetcore-8.0



## [Unit testing C# in .NET using dotnet test and xUnit](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test)

### Create an xUnit project

```
dotnet new xunit -o PrimeService.Tests
```

All commands

```
dotnet new sln -o unit-testing-using-dotnet-test
cd unit-testing-using-dotnet-test
dotnet new classlib -o PrimeService
ren .\PrimeService\Class1.cs PrimeService.cs
dotnet sln add ./PrimeService/PrimeService.csproj
dotnet new xunit -o PrimeService.Tests
dotnet add ./PrimeService.Tests/PrimeService.Tests.csproj reference ./PrimeService/PrimeService.csproj
dotnet sln add ./PrimeService.Tests/PrimeService.Tests.csproj
```


Finished product:

https://github.com/dotnet/samples/blob/main/core/getting-started/unit-testing-using-dotnet-test/PrimeService.Tests/PrimeService_IsPrimeShould.cs

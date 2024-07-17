
# My Code + Notes for [C# Testing in Visual Studio](https://learn.microsoft.com/en-us/training/modules/visual-studio-test-tools/) Module

Using VS Code with the [C# Dev Kit](https://code.visualstudio.com/docs/csharp/testing) extension instead of Visual Studio

### Followup

https://learn.microsoft.com/en-us/dotnet/core/tutorials/testing-library-with-visual-studio-code?pivots=dotnet-8-0


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


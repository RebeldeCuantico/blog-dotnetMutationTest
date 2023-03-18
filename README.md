## How to do mutation testing in .NET and C#?

The following code is related to the [blog article](https://medium.com/@RebeldeCuantico/c%C3%B3mo-hacer-test-de-mutaci%C3%B3n-en-net-y-c-b356a24d890e "blog article") on how to perform mutation testing in .NET and C# using Stryker.NET on Ubuntu and terminal with dotnet cli. Mutation testing is a software testing technique that involves changing the code of an application in a controlled way and then running tests to see if the code and tests are able to detect the mutation. Stryker.NET is a mutation testing tool for C# that can help detect weaknesses in test suites and improve code quality.

The article walks through creating a project, generating test code, and using Stryker.NET to identify weak points in the test suite. The author also discusses the results of the testing process and how it can help improve code quality. Finally, instructions are given on using Stryker.NET on the terminal with dotnet cli.

To run Stryker.NET and see the result, use the following instructions:

```bash
# This step only needs to be done if you have not already installed it.
dotnet tool install -g dotnet-stryker

dotnet new tool-manifest

dotnet tool install dotnet-stryker

dotnet tool restore

# Finally, we run Stryker.
dotnet stryker

```
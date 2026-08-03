# Payment Engine

## Getting Started

### Option 1: GitHub Codespaces

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/clearbank/tech-test-dotnet-pairing?devcontainer_path=.devcontainer/payment-engine/devcontainer.json)

### Option 2: Run locally

Requires the [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0).

```
cd PaymentEngine
dotnet build
dotnet test
```

## Testing

You are free to use any test assertion or mocking libraries you are comfortable with. A few are already installed including FluentAssertions, Shouldly, Moq, FakeItEasy, and NSubstitute.

To generate a code coverage report:

```
dotnet test --collect:"XPlat Code Coverage"
```

## Before the Session

Please familiarise yourself with the codebase and make sure you can build and run the tests successfully.

You are welcome to explore the solution, run the application, and experiment locally to understand how it works. However, please do not make or submit any code changes before the session.

The pairing session will be guided, and we will work together through a series of exercises based on the existing codebase.

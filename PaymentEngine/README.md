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

Please read through the codebase and make sure you can build and run the tests. The pairing session will be guided - we will work together to extend and improve the existing code.

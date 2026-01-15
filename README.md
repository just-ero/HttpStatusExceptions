# HttpStatusExceptions

[![HttpStatusExceptions](https://img.shields.io/nuget/v/HttpStatusExceptions.svg?label=HttpStatusExceptions)](https://nuget.org/packages/HttpStatusExceptions)
[![HttpStatusExceptions.AspNetCore](https://img.shields.io/nuget/v/HttpStatusExceptions.AspNetCore.svg?label=HttpStatusExceptions.AspNetCore)](https://nuget.org/packages/HttpStatusExceptions.AspNetCore)
[![License](https://img.shields.io/github/license/just-ero/HttpStatusExceptions)](LICENSE.md)

A lightweight library for throwing HTTP status code exceptions using clean, expressive static helper methods.

## Installation

```shell
# Base library
dotnet add package HttpStatusExceptions

# ASP.NET Core integration (includes ProblemDetails support)
dotnet add package HttpStatusExceptions.AspNetCore
```

## Usage

### Throwing Exceptions

```csharp
using HttpStatusExceptions;

// Using static throw helpers
HttpStatusException.Throw404NotFound();
HttpStatusException.Throw401Unauthorized("Invalid API key.");

// Or throw directly
throw new HttpStatusException(404, "Resource not found.");
```

### Generic Variants

Generic overloads let you throw in expression contexts—useful for null-coalescing and conditional expressions:

```csharp
var item = await db.Items.FirstOrDefaultAsync(item => item.Id == id)
    ?? HttpStatusException.Throw404NotFound<Item>("Item not found.");

var result = isValid
    ? ProcessData()
    : HttpStatusException.Throw400BadRequest<Result>();
```

### ProblemDetails Support (ASP.NET Core)

The `HttpStatusExceptions.AspNetCore` package adds a `ToProblemDetails()` extension method:

```csharp
using HttpStatusExceptions.AspNetCore;

// In Program.cs
builder.Services.AddProblemDetails(options =>
{
    options.Map<HttpStatusException>((ctx, ex) => ex.ToProblemDetails());
});
```

## Supported Status Codes

All standard 4xx and 5xx status codes are supported:

| Category | Status Codes |
|----------|--------------|
| **4xx Client Errors** | 400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 421, 422, 423, 424, 426, 428, 429, 431, 451 |
| **5xx Server Errors** | 500, 501, 502, 503, 504, 505, 506, 507, 508, 510, 511 |

Additionally, `405 Method Not Allowed` has method-specific helpers: `Throw405GetNotAllowed()`, `Throw405PostNotAllowed()`, `Throw405PutNotAllowed()`, `Throw405DeleteNotAllowed()`, etc.

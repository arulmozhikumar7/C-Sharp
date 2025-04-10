# Concepts Used in ASP.NET Core Web API - Product CRUD Microservice

| Concept                      | Description                                                                 | ASP.NET Core Example / File                         |
|------------------------------|-----------------------------------------------------------------------------|------------------------------------------------------|
| **ASP.NET Core Web API**     | Framework for building RESTful APIs                                        | Entire project scaffold                              |
| **Routing**                  | Maps incoming HTTP requests to controller actions                          | `[Route("api/[controller]")]` in `ProductController.cs` |
| **Controllers**              | Define API endpoints and actions                                           | `Controllers/ProductController.cs`                   |
| **Model Class**              | Represents the structure of Product data                                   | `Models/Product.cs`                                  |
| **Data Annotations**         | Attribute-based validation and metadata                                    | `[Required]`, `[Range]`, etc. in `Product.cs`        |
| **DbContext**                | Manages database access using EF Core                                      | `Data/AppDbContext.cs`                               |
| **Entity Framework Core**    | ORM to interact with databases                                              | Registered via `builder.Services.AddDbContext()`     |
| **In-Memory Database**       | Lightweight temp DB useful for prototyping/testing                         | `UseInMemoryDatabase("ProductsDb")`                  |
| **Dependency Injection (DI)**| Injecting services instead of hardcoding dependencies                      | `builder.Services.AddScoped<IProductService>()`      |
| **Service Layer**            | Business logic abstraction from controllers                                | `Services/ProductService.cs`                         |
| **Interfaces**               | Abstraction for services to ensure testability and loose coupling          | `Interfaces/IProductService.cs`                      |
| **Async/Await**              | Asynchronous handling of DB operations                                     | `async Task<ActionResult<Product>>`                  |
| **Logging**                  | Capture logs or request information                                        | `ILogger<ProductController>`                         |
| **Custom Middleware**        | Custom logic for requests like logging                                     | `Middlewares/RequestResponseLoggingMiddleware.cs`    |
| **Middleware Configuration** | Add middleware to HTTP request pipeline                                    | `app.UseMiddleware<>()` in `Program.cs`              |
| **HTTP Status Codes**        | Response codes like 200, 404, 201                                           | `return NotFound()`, `return CreatedAtAction()`      |
| **Global Error Handling**    | Catch unhandled exceptions                                                  | (Optional) Can use custom exception middleware        |
| **Swagger / Swashbuckle**    | Auto-generates interactive API documentation                               | `builder.Services.AddSwaggerGen()`                   |
| **HTTP Testing (.http)**     | Local request testing using VS Code REST Client                            | `Product.http`                                       |
| **.gitignore**               | Prevents unwanted files from being committed                               | `.gitignore` at root                                 |
| **Folder Structure**         | Organized codebase into layers: Controllers, Models, Services, Data, etc.  | Project structure                                     |

---
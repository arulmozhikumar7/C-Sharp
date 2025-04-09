| Concept                        | Description                                                                 |
|--------------------------------|-----------------------------------------------------------------------------|
| Interface                      | `IEntity` ensures all entities have an `Id` property.                      |
| Sample Entity                  | `Student` class implements `IEntity` and represents the domain model.      |
| Generics                       | `IRepository<T>` and `InMemoryRepository<T>` allow reuse for any entity.   |
| Type Constraints               | `where T : IEntity` ensures that T has an Id property for consistency.     |
| CRUD Methods                   | Interface and implementation provide `Add`, `Get`, `Update`, and `Delete`. |
| In-Memory Storage              | Uses `Dictionary<int, T>` to simulate a database.                          |
| Console UI                     | Provides a basic text interface to interact with the repository.           |
| Exception Handling             | Handles common issues like duplicate ID or missing records gracefully.     |
| Decoupling                     | UI is separated from repository logic via the interface abstraction.       |
| ToString Override              | Custom `ToString()` on `Student` for clean console output.                 |

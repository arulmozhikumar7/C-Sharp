# Asynchronous Programming and Multi-threading - Key Concepts


| Concept                  | Description                                                                                      | Example in Code                                  |
|--------------------------|--------------------------------------------------------------------------------------------------|--------------------------------------------------|
| `async` / `await`        | Used to define and wait for asynchronous methods.                                                | `async Task<string> FetchFromSourceAsync(...)`   |
| `Task`                   | Represents an asynchronous operation that can return a result or void.                          | `Task<string>`                                   |
| `Task.Delay`             | Simulates delay (like a fake API call) to mimic async behavior.                                 | `await Task.Delay(delayMs);`                     |
| Concurrent Execution     | Multiple tasks are initiated at once to run in parallel.                                        | List of tasks in `FetchAllDataAsync()`           |
| Exception Handling       | Try-catch blocks handle errors gracefully in individual async operations.                       | `try { await task; } catch { ... }`              |
| Aggregating Results      | Collecting results from multiple asynchronous tasks.                                             | `results.Add(await task);`                       |
| `List<Task<T>>`          | Holds multiple asynchronous tasks to execute concurrently.                                       | `var tasks = new List<Task<string>> {...}`       |
| Simulated API Calls      | Mimicked using delays and optional exception throwing.                                           | `throw new Exception(...)`                       |
| Robust Error Reporting   | Errors from individual sources are caught and included in final output.                         | `results.Add($"Error from one source: ...")`     |
| Main Entry Point         | `Main` method marked as `async Task` to use `await` directly.                                   | `static async Task Main(string[] args)`          |


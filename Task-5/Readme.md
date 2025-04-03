# File I/O and Exception Handling Methods in C#

| **Category**       | **Method**                   | **Description** |
|--------------------|----------------------------|----------------|
| **File Reading**   | `File.ReadAllText(path)`    | Reads all text from a file. |
|                    | `File.ReadAllLines(path)`   | Reads all lines from a file into a string array. |
|                    | `File.ReadLines(path)`      | Reads lines from a file lazily (efficient for large files). |
|                    | `StreamReader.ReadToEnd()`  | Reads all text from a file using `StreamReader`. |
|                    | `StreamReader.ReadLine()`   | Reads a single line from a file. |
| **File Writing**   | `File.WriteAllText(path, text)` | Writes text to a file (overwrites if exists). |
|                    | `File.WriteAllLines(path, lines)` | Writes an array of lines to a file. |
|                    | `File.AppendAllText(path, text)` | Appends text to a file. |
|                    | `File.AppendAllLines(path, lines)` | Appends lines to a file. |
|                    | `StreamWriter.Write(text)` | Writes text to a file using `StreamWriter`. |
|                    | `StreamWriter.WriteLine(text)` | Writes a line of text to a file. |
| **File Existence** | `File.Exists(path)`         | Checks if a file exists. |
|                    | `Directory.Exists(path)`    | Checks if a directory exists. |
| **File Operations**| `File.Copy(source, destination)` | Copies a file. |
|                    | `File.Move(source, destination)` | Moves a file. |
|                    | `File.Delete(path)`         | Deletes a file. |
|                    | `Directory.CreateDirectory(path)` | Creates a directory. |
| **File Streams**   | `File.OpenRead(path)`       | Opens a file for reading as a stream. |
|                    | `File.OpenWrite(path)`      | Opens a file for writing as a stream. |
| **Exception Handling** | `try { ... } catch (Exception e) { ... }` | Handles exceptions with a `try-catch` block. |
|                    | `catch (FileNotFoundException e)` | Handles cases where the file does not exist. |
|                    | `catch (IOException e)`     | Handles general I/O errors (e.g., file locked). |
|                    | `catch (UnauthorizedAccessException e)` | Handles permission-related errors. |
|                    | `finally { ... }`          | Executes cleanup code regardless of exceptions. |

![alt text](image.png)
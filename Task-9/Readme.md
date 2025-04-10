##  Overview

- Define a custom attribute `[Runnable]`.
- Annotate methods in different classes.
- Use reflection to scan the assembly and invoke all methods marked with `[Runnable]`.

---

## Concepts Used

| Concept | Description | Code Example | Use Case |
|--------|-------------|--------------|----------|
| `AttributeUsage` | Specifies how a custom attribute can be applied (e.g., to methods only). | `[AttributeUsage(AttributeTargets.Method)]` | Prevents misuse of attributes on invalid targets. |
| Custom Attribute | User-defined metadata attached to code elements. | `public class RunnableAttribute : Attribute {}` | Mark methods that should be dynamically invoked. |
| Reflection | Allows inspection of assemblies, types, methods, etc., at runtime. | `type.GetMethods(...)` | Used to discover and invoke `[Runnable]` methods. |
| `Assembly.GetExecutingAssembly()` | Returns the currently executing assembly. | `var assembly = Assembly.GetExecutingAssembly();` | Needed to find all types and methods in the current project. |
| `Type.GetMethods()` | Returns all methods defined in a type. | `type.GetMethods(BindingFlags...)` | Enumerates methods to check for attributes. |
| `BindingFlags` | Used to control visibility and scope in reflection. | `BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly` | Ensures only intended methods are considered. |
| `GetCustomAttributes()` | Checks if a method has a specific attribute. | `method.GetCustomAttributes(typeof(RunnableAttribute), false)` | Filters methods marked with `[Runnable]`. |
| `Activator.CreateInstance()` | Dynamically creates an instance of a type. | `Activator.CreateInstance(type)` | Allows invoking instance methods without knowing the type. |
| `MethodInfo.Invoke()` | Invokes a method dynamically at runtime. | `method.Invoke(instance, null)` | Executes discovered `[Runnable]` methods. |

---

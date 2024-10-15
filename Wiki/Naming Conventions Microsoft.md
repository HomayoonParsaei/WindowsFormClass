# Naming Conventions Microsoft

In addition to the rules, conventions for identifier names are used throughout the .NET APIs. These conventions provide consistency for names, but the compiler doesn't enforce them. You're free to use different conventions in your projects.

By convention, C# programs use **PascalCase** for type names, namespaces, and all public members. In addition, the dotnet/docs team uses the following conventions, adopted from the .NET Runtime team's coding style:

- **Interface names** start with a capital `I`.
- **Attribute types** end with the word `Attribute`.
- **Enum types** use:
  - A **singular noun** for non-flags.
  - A **plural noun** for flags.
- Identifiers shouldn't contain **two consecutive underscore (`_`) characters**. Those names are reserved for compiler-generated identifiers.
- Use meaningful and descriptive names for **variables, methods, and classes**.
- Prefer **clarity** over **brevity**.
- Use **PascalCase** for class names and method names.
- Use **camelCase** for method parameters and local variables.
- Use **PascalCase** for constant names, both fields and local constants.
- Private instance fields start with an **underscore (`_`)** and the remaining text is camelCased.
- Static fields start with `s_`. This convention isn't the default Visual Studio behavior, nor part of the Framework design guidelines, but is configurable in editorconfig.
- Avoid using **abbreviations or acronyms** in names, except for widely known and accepted abbreviations.
- Use meaningful and descriptive **namespaces** that follow the reverse domain name notation.
- Choose **assembly names** that represent the primary purpose of the assembly.
- Avoid using **single-letter names**, except for simple loop counters. Syntax examples that describe the syntax of C# constructs often use the following single-letter names that match the convention used in the C# language specification. Syntax examples are an exception to the rule.
  
  - Use `S` for structs, `C` for classes.
  - Use `M` for methods.
  - Use `v` for variables, `p` for parameters.
  - Use `r` for `ref` parameters.


# <h3 style="color:purple;">Interface Naming Convention</h3>

Interface names start with a capital `I` followed by **PascalCase** (each word starts with a capital letter, no underscores or spaces).

Example:

```csharp
public interface IMyInterface
{
    void MyMethod();
}
```

# <h3 style="color:purple;">Enum Naming Conventions</h3>

1. **Singular noun for non-flags:**
   - When an enum represents a single value or option from a set of predefined constants, it makes sense to use a singular noun. For example, if you're defining an enum for colors:
     ```csharp
     enum Color
     {
         Red,
         Blue,
         Green
     }
     ```
   - Each instance of the `Color` enum can only hold one value at a time, like `Color.Red`.

2. **Plural noun for flags (bitwise flags):**
   - When the enum represents a set of bitwise flags, where multiple values can be combined using bitwise operations, a plural name makes sense. For example, consider a `Permissions` enum:
     ```csharp
     [Flags]
     enum Permissions
     {
         Read = 1,
         Write = 2,
         Execute = 4
     }
     ```
   - In this case, you can combine values like `Permissions.Read | Permissions.Write` to represent multiple flags, so the plural form is appropriate.

Using this convention helps make the intent of the enum clearer.

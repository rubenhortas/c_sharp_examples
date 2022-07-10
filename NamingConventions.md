# Public elements

| Public element | Notation                     | Example        | Notes                                                                                                             |
|----------------|------------------------------|----------------|-------------------------------------------------------------------------------------------------------------------|
| Class          | PascalCase (UpperCamelCase)  | ClassName      |                                                                                                                   |
| Event          | PascalCase (UpperCamelCase)  | EventName      |                                                                                                                   |
| Function       | PascalCase (UpperCamelCase)  | FunctionName   |                                                                                                                   |
| Interface      | PascalCase (UpperCamelCase)  | IInterfaceName | Prefixing the name with an I                                                                                      |
| Method         | PascalCase (UpperCamelCase)  | MethodName     |                                                                                                                   |
| Parameter      | cameCase lowerCamelCase)     | parameter      |                                                                                                                   |
| Property       | PascalCase (UpperCamelCase)  | PropertyName   |                                                                                                                   |
| Record         | PascalCase (UpperCamelCase)  | RecordName     | When writing positional records, use pascal casing for parameters as they're the public properties of the record. |
| Struct         | PascalCase (UpperCamelCase)  | StructName     |                                                                                                                   |

# Private elements

| Private element     | Notation                    | Example                                    | Notes           |
|---------------------|-----------------------------|--------------------------------------------|-----------------|
| *                   | cameCase (lowerCamelCase)   | private IWorkerQueue **\_workerQueue**;    | Prefix with \_  |
| static field        | cameCase (lowerCamelCase)   | private static IWorkerQueue s_workerQueue; | Prefix with s\_ |
| thread static field | PascalCase (lowerCamelCase) | private static TimeSpan t_timeSpan;        | Prefix with t\_ |

# Layout conventions

- Only one statement per line
- Only one declaration per line
- Add at least one blank line between method definitions and property definitions
- Use parentheses to make clauses in an expression apparent
  ```csharp
  if ((val1 > val2) && (val1 > val3)) {}
  ```
  
# Commenting conventions

- Place the comment on a separate line, not at the end of a line of code
- Begin comment text with an uppercase letter
- End comment text with a period
- Insert one space between the comment delimiter (//) and the comment text
- Don't create formatted blocks of asterisks around comments
- nsure all public members have the necessary XML comments providing appropriate descriptions about their behavior



# Sources
[Microsoft C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)

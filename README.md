# Example Rule Engine

An example of dynamically loading rule classes and applying them within a rule engine.

The magic sauce is the below code that finds classes that implement a specific interface - IRule in this case - and creates a list of them so they can be iterated over to apply the rules.

```csharp
var currentAssembly = GetType().GetTypeInfo().Assembly;
var rules = currentAssembly
        .DefinedTypes
        .Where(type => type.ImplementedInterfaces.Any(i => i == typeof(IRule)))
        .Select(type => (IRule)Activator.CreateInstance(type))
        .ToList();
```

See [this blog by John Reese](https://reese.dev/the-rules-pattern/) for more details.
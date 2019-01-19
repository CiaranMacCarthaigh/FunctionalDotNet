#FunctionalDotNet
 
A functional-first wrapper around many built-in .NET methods, to support functional composition and coding.

## Purpose and goals
The purpose of this project is add more natural functional support for native .NET methods, so that developers can better use native .NET types in a functional context, such as using the function composition operator `>>`.

This project will provide a functional-first wrapper around native .NET methods.

### Example

Take for example a method to trim a string, and then find a substring inside that trimmed string.

In C# this could be implemented as:

    static bool TrimmedStringContains(string item, string substring)
    {
        var trimmedItem = item.Trim();
        return trimmedItem.Contains(substring);
    }

Implementing an equivalent function in F# would have to be similar to the C# implementation, because of the object-oriented nature of .NET:

    let trimmedStringContains substring (item:string) =
        let trimmedItem = item.Trim()
        trimmedItem.Contains(substring)

The goal of this project would be to enable developers to implement more functional-orientated forms of this, utilising native features of F#:

    let trimmedStringContains substring item = String.trim item |> String.contains substring

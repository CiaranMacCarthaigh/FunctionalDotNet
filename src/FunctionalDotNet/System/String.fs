module FunctionalDotNet.System.String

open System
open System.Globalization

/// <summary>Removes all leading and trailing occurrences of a set of characters specified in an array from the <c>System.String</c> object.</summary>
/// <param name="trimChars">An array of Unicode characters to remove, or <c>None</c>.</param>
/// <param name="string">The string to perform the operation on.</param>
/// <returns>The string that remains after all occurrences of the characters in the <paramref name="trimChars">trimChars</paramref> parameter are removed from the start and end of the string. If <paramref name="trimChars">trimChars</paramref> is null, Nonem or an empty array, white-space characters are removed instead. If no characters can be trimmed from the string instance, the method returns the string instance unchanged.</returns>
let trim (trimChars : char array option) (string:String) : string =
    match trimChars with
    | Some trimChars -> string.Trim trimChars
    | None -> string.Trim()

/// <summary>Removes all leading occurrences of a set of characters specified in an array from the <c>System.String</c> object.</summary>
/// <param name="trimChars">An array of Unicode characters to remove, or <c>None</c>.</param>
/// <param name="string">The string to perform the operation on.</param>
/// <returns>The string that remains after all occurrences of characters in the <paramref name="trimChars">trimChars</paramref> parameter are removed from the start of the current string. If <paramref name="trimChars">trimChars</paramref> is null, Nonem or an empty array, white-space characters are removed instead.</returns>
let trimStart (trimChars : char array option) (string:String) : string =
    match trimChars with
    | Some trimChars -> string.TrimStart trimChars
    | None -> string.TrimStart()

/// <summary>Removes all trailing occurrences of a set of characters specified in an array from the <c>System.String</c> object.</summary>
/// <param name="trimChars">An array of Unicode characters to remove, or <c>None</c>.</param>
/// <param name="string">The string to perform the operation on.</param>
/// <returns>The string that remains after all occurrences of the characters in the <paramref name="trimChars">trimChars</paramref> parameter are removed from the end of the current string. If <paramref name="trimChars">trimChars</paramref> is null, None, or an empty array, Unicode white-space characters are removed instead. If no characters can be trimmed from the string instance, the method returns the string instance unchanged.</returns>
let trimEnd (trimChars : char array option) (string:String) : string =
    match trimChars with
    | Some trimChars -> string.TrimEnd trimChars
    | None -> string.TrimEnd()
    
/// <summary>Returns a value indicating whether a specified substring occurs within the provided string.</summary>
/// <param name="value">The string to seek.</param>
/// <param name="string">The string to search through.</param>
/// <returns>true if the <paramref name="value">value</paramref> parameter occurs within <paramref name="string">string</paramref>, or if <paramref name="value">value</paramref> is the empty string (""); otherwise, false.</returns>
/// <exception cref="T:System.ArgumentNullException"><paramref name="value">value</paramref> is null.</exception>
let contains (value:String) (string:String) =
    string.Contains value

/// <summary>Retrieves a substring from the provided string. The substring starts at a specified character position and may have an optional specified length.</summary>
/// <param name="startIndex">The zero-based starting character position of a substring in the provided string.</param>
/// <param name="length">The number of characters in the substring, or <c>None</c> to continue to the end of the string.</param>
/// <param name="string">The string to perform the operation on.</param>
/// <returns>A string that is equivalent to the substring of length <paramref name="length">length</paramref> that begins at <paramref name="startIndex">startIndex</paramref> in this instance, or <see cref="F:System.String.Empty"></see> if <paramref name="startIndex">startIndex</paramref> is equal to the length of this instance and <paramref name="length">length</paramref> is zero.</returns>
/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex">startIndex</paramref> plus <paramref name="length">length</paramref> indicates a position not within this instance.   -or-  <paramref name="startIndex">startIndex</paramref> or <paramref name="length">length</paramref> is less than zero.</exception>
let substring (startIndex:int) (length:int option) (string:String) =
    match length with
    | Some length -> string.Substring(startIndex, length)
    | None -> string.Substring(startIndex)
    
let toLower (culture:CultureInfo option) (string:String) =
    match culture with
    | Some culture -> string.ToLower culture
    | None -> string.ToLower()
    
let toLowerInvariant (string:String) =
    string.ToLowerInvariant()
    
let toUpper (culture:CultureInfo option) (string:String) =
    match culture with
    | Some culture -> string.ToUpper culture
    | None -> string.ToUpper()
    
let toUpperInvariant (string:String) =
    string.ToUpperInvariant()
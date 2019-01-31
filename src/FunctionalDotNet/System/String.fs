module FunctionalDotNet.System.String

open System
open System.Globalization

let trim (trimChars : char array option) (string:String) : string =
    match trimChars with
    | Some trimChars -> string.Trim trimChars
    | None -> string.Trim()
    
let trimStart (trimChars : char array option) (string:String) : string =
    match trimChars with
    | Some trimChars -> string.TrimStart trimChars
    | None -> string.TrimStart()
    
let trimEnd (trimChars : char array option) (string:String) : string =
    match trimChars with
    | Some trimChars -> string.TrimEnd trimChars
    | None -> string.TrimEnd()
    
let contains (value:String) (string:String) =
    string.Contains value
    
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
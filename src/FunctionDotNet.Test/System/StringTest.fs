module FunctionDotNet.Test.System.StringTest

open System.Globalization
open NUnit.Framework

[<Test>]
let ``Trim - trimChars parameter is None`` () =
    let testString = "\t This is  atest string   "
    let expectedResult = "This is  atest string"
    let trimChars = None
    
    let actualResult = FunctionalDotNet.System.String.trim trimChars expectedResult
    
    Assert.That(actualResult, Is.EqualTo(expectedResult))

[<Test>]
let ``Trim - trimChars parameter is Some`` () =
    let testString = "\t This is  atest string   "
    let expectedResult = "This is  atest strin"
    let trimChars = [| '\t'; ' '; 'g'; |] |> Some
    
    let actualResult = FunctionalDotNet.System.String.trim trimChars expectedResult
    
    Assert.That(actualResult, Is.EqualTo(expectedResult))

[<Test>]
let ``TrimStart - trimChars parameter is None`` () =
    let testString = "\t This is  atest string   "
    let expectedResult = "This is  atest string   "
    let trimChars = None
    
    let actualResult = FunctionalDotNet.System.String.trimStart trimChars expectedResult
    
    Assert.That(actualResult, Is.EqualTo(expectedResult))

[<Test>]
let ``TrimStart - trimChars parameter is Some`` () =
    let testString = "\t This is  atest string   "
    let expectedResult = "his is  atest string   "
    let trimChars = [| '\t'; ' '; 'T'; 'g'; |] |> Some
    
    let actualResult = FunctionalDotNet.System.String.trimStart trimChars expectedResult
    
    Assert.That(actualResult, Is.EqualTo(expectedResult))

[<Test>]
let ``TrimEnd - trimChars parameter is None`` () =
    let testString = "\t This is  atest string   "
    let expectedResult = "\t This is  atest string"
    let trimChars = None
    
    let actualResult = FunctionalDotNet.System.String.trimEnd trimChars expectedResult
    
    Assert.That(actualResult, Is.EqualTo(expectedResult))

[<Test>]
let ``TrimEnd - trimChars parameter is Some`` () =
    let testString = "\t This is  atest string   "
    let expectedResult = "\t This is  atest strin"
    let trimChars = [| '\t'; ' '; 'T'; 'g'; |] |> Some
    
    let actualResult = FunctionalDotNet.System.String.trimEnd trimChars expectedResult
    
    Assert.That(actualResult, Is.EqualTo(expectedResult))
    
[<Test>]
let ``Contains - string contains value`` () =
    let testString = "This string from Navan contains a palindrome"
    let testValue = "Navan"
    
    let actualResult = FunctionalDotNet.System.String.contains testValue testString
    
    Assert.That(actualResult, Is.True)
    
[<Test>]
let ``Contains - string does not contain value`` () =
    let testString = "This string from Navan contains a palindrome"
    let testValue = "Cavan"
    
    let actualResult = FunctionalDotNet.System.String.contains testValue testString
    
    Assert.That(actualResult, Is.False)
    
[<Test>]
let ``Substring - length is None`` () =
    let testString = "We will take a substring from this string."
    let startIndex = 10
    let expectedResult = "ke a substring from this string."
    
    let actualResult = FunctionalDotNet.System.String.substring startIndex None testString
    
    Assert.That(actualResult, Is.EqualTo(expectedResult))
    
[<Test>]
let ``Substring - length is Some`` () =
    let testString = "We will take a substring from this string."
    let startIndex = 10
    let length = 8 |> Some
    let expectedResult = "ke a sub"
    
    let actualResult = FunctionalDotNet.System.String.substring startIndex length testString
    
    Assert.That(actualResult, Is.EqualTo(expectedResult))
    
// The example for this test case is taken from:
// https://docs.microsoft.com/en-us/dotnet/api/system.string.toupper?view=netstandard-2.0#System_String_ToUpper_System_Globalization_CultureInfo_
[<Test>]
let ``ToUpper - culture is not specified`` () =
    let testString = "indigo"
    let culture = None
    let expectedResult = "INDIGO"
    
    let actualResult = FunctionalDotNet.System.String.toUpper culture testString
    
    Assert.That(actualResult, Is.EqualTo(expectedResult))
    
// The example for this test case is taken from:
// https://docs.microsoft.com/en-us/dotnet/api/system.string.toupper?view=netstandard-2.0#System_String_ToUpper_System_Globalization_CultureInfo_
[<Test>]
let ``ToUpper - culture is specified`` () =
    let testString = "indigo"
    let culture = new CultureInfo("tr-TR",false) |> Some
    let expectedResult = "İNDİGO"
    
    let actualResult = FunctionalDotNet.System.String.toUpper culture testString
    
    Assert.That(actualResult, Is.EqualTo(expectedResult))
    
[<Test>]
let ``ToUpperInvariant - returned string matches expected`` () =
    let testString = "indigo"
    let expectedResult = "INDIGO"
    
    let actualResult = FunctionalDotNet.System.String.toUpperInvariant testString
    
    Assert.That(actualResult, Is.EqualTo(expectedResult))
    
// The example for this test case is taken from:
// https://docs.microsoft.com/en-us/dotnet/api/system.string.tolower?view=netstandard-2.0
[<Test>]
let ``ToLower - culture is not specified`` () =
    let testString = "INDIGO"
    let culture = None
    let expectedResult = "indigo"
    
    let actualResult = FunctionalDotNet.System.String.toLower culture testString
    
    Assert.That(actualResult, Is.EqualTo(expectedResult))
    
// The example for this test case is taken from:
// https://docs.microsoft.com/en-us/dotnet/api/system.string.tolower?view=netstandard-2.0
[<Test>]
let ``ToLower - culture is specified`` () =
    let testString = "İNDİGO"
    let culture = new CultureInfo("tr-TR",false) |> Some
    let expectedResult = "indigo"
    
    let actualResult = FunctionalDotNet.System.String.toLower culture testString
    
    Assert.That(actualResult, Is.EqualTo(expectedResult))

[<Test>]
let ``ToLowerInvariant - returned string matches expected`` () =
    let testString = "INDIGO"
    let expectedResult = "indigo"
    
    let actualResult = FunctionalDotNet.System.String.toLowerInvariant testString
    
    Assert.That(actualResult, Is.EqualTo(expectedResult))
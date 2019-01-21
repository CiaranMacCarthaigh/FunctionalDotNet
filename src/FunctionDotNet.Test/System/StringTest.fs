module FunctionDotNet.Test.System.StringTest

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
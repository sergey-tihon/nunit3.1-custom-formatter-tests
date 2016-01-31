module FSharpOnly.Tests

open NUnit.Framework

type Fruit =
    | Apple
    | Orange

[<Test>]
let ``Default Formatter: Apple should not equal Orange`` () =
    Assert.AreEqual(Apple, Orange)
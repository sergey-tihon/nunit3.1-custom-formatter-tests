module FSharpOnlyTests

open NUnit.Framework
open NUnit.Framework.Constraints

type Fruit =
    | Apple
    | Orange

[<Test>]
let ``Default Formatter`` () =
    Assert.AreEqual(Apple, Orange)

[<Test>]
let ``Custom Formatter: Set using TestContext``() =
    TestContext.AddFormatter(
        ValueFormatterFactory(fun _ -> ValueFormatter(sprintf "%A")))
    Assert.AreEqual(Apple, Orange)
module FSharpWithFormatter.Tests

open NUnit.Framework
open NUnit.Framework.Constraints

GlobalSettings.AddFormatter(
     ValueFormatterFactory(fun _ -> ValueFormatter(sprintf "[V]=%A")))

type Fruit =
    | Apple
    | Orange

[<Test>]
let ``Custom Formatter: Apple should not equal Orange`` () =
    Assert.AreEqual(Apple, Orange)
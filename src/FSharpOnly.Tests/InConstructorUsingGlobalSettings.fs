module FSharpWithFormatterInTestFixture

open NUnit.Framework
open NUnit.Framework.Constraints

type Fruit =
    | Apple
    | Orange

[<TestFixture>]
type MyTests() =
    do GlobalSettings.AddFormatter(
         ValueFormatterFactory(fun _ -> ValueFormatter(sprintf "%A")))

    [<Test>]
    member __.``Custom Formatter: In construstor using GlobalSettings``() =
        Assert.AreEqual(Apple, Orange)

[<TestFixture>]
type MyTests2() =
    do TestContext.AddFormatter(
         ValueFormatterFactory(fun _ -> ValueFormatter(sprintf "%A")))

    [<Test>]
    member __.``Custom Formatter: In construstor using TestContext``() =
        Assert.AreEqual(Apple, Orange)

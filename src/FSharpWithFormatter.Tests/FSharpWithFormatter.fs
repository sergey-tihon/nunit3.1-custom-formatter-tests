module FSharpWithFormatterTests

open NUnit.Framework
open NUnit.Framework.Constraints

do
    printfn "!!!!! Call AddFormatter !!!!!!"
    GlobalSettings.AddFormatter(
       ValueFormatterFactory(
        fun _ ->
            printfn "!!!!! Call ValueFormatterFactory !!!!!!"
            ValueFormatter(sprintf "[V]=%A")))

type Fruit =
    | Apple
    | Orange

[<Test>]
let ``Custom Formatter: Set globally`` () =
    Assert.AreEqual(Apple, Orange)
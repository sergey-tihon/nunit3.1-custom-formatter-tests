module FsharpWithFsUnitLight

open NUnit.Framework
open NUnit.Framework.Constraints
open FsUnit

type Fruit =
    | Apple
    | Orange

[<Test>]
let ``Custom Formatter from FsUnit`` () =
    Apple |> should equal Orange

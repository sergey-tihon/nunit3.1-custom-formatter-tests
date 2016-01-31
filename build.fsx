// --------------------------------------------------------------------------------------
// FAKE build script
// --------------------------------------------------------------------------------------

// Added to allow building the script from F# interactive. If the build fails F#
// interactive allows you to review the full log, unlike the Windows Command Prompt.
#if INTERACTIVE
System.IO.Directory.SetCurrentDirectory(__SOURCE_DIRECTORY__)
#endif

#r @"packages/FAKE/tools/FakeLib.dll"
open Fake
open Fake.Testing
open System

// --------------------------------------------------------------------------------------
// START TODO: Provide project-specific details below
// --------------------------------------------------------------------------------------

// File system information
let solutionFile  = "NUnit3.1-CustomFormatters-Tests.sln"

// Pattern specifying assemblies to be tested using NUnit
let testAssemblies = "src/**/bin/Release/*Tests*.dll"

// --------------------------------------------------------------------------------------
// Build library & test project

Target "Build" (fun _ ->
    !! solutionFile
    |> MSBuildRelease "" "Rebuild"
    |> ignore
)

// --------------------------------------------------------------------------------------
// Run the unit tests using test runner

Target "ExecuteTests" (fun _ ->
    !! testAssemblies
    |> NUnit3 (fun p ->
        { p with
            TimeOut = TimeSpan.FromMinutes 20. })
)

// --------------------------------------------------------------------------------------
// Run all targets by default. Invoke 'build <Target>' to override

Target "All" DoNothing

"Build"
  ==> "ExecuteTests"
  ==> "All"

RunTargetOrDefault "All"
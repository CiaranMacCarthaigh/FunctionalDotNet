#r "paket:
nuget Fake.IO.FileSystem
nuget Fake.DotNet.MSBuild
nuget Fake.Core.Target //"
#load "./.fake/build.fsx/intellisense.fsx"

open Fake.Core
open Fake.IO
open Fake.IO.Globbing.Operators
open Fake.DotNet

let buildDir = "./build"

// Targets
Target.create "Clean" (fun _ ->
    Shell.cleanDir buildDir
)

Target.create "BuildApp" (fun _ ->
    !! "src/FunctionalDotNet/*.fsproj"
    |> MSBuild.runRelease id buildDir "Build"
    |> Trace.logItems "AppBuild-Output: "
)

Target.create "Default" |> ignore

// Dependencies
open Fake.Core.TargetOperators

"Clean"
==> "BuildApp"

// Start build
Target.runOrDefault "BuildApp"

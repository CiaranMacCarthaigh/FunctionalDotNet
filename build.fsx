#r "paket:
nuget Fake.DotNet.NuGet
nuget Fake.IO.FileSystem
nuget Fake.DotNet.MSBuild
nuget Fake.Core.Target
nuget FSharp.Core 4.5.0.0 //"
#load "./.fake/build.fsx/intellisense.fsx"

open Fake.Core
open Fake.IO
open Fake.IO.Globbing.Operators
open Fake.Core.TargetOperators
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

Target.create "All" ignore


"Clean"
==> "BuildApp"
==> "All"

// Start build
Target.runOrDefault "All"
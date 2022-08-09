- [FatBassStats Solution](#fatbassstatssol)
  * [Building](#building)
  * [Running](#running)
  * [FatBassStats](#fatbassstats)
    + [Dependencies](#dependencies)
    + [Apis](#apis)
    + [Converters](#converters)
    + [Extensions](#extensions)
    + [Interface](#interface)
    + [Models](#models)
    + [Services](#services)
  * [FatBassStatsTests](#fatbassstatstests)
    + [Dependencies](#testdependencies)
    + [Data](#data)
    + [Stubs](#stubs)  


  # FatBassStats Solution

  ## Building

  To build open the solution in Visual Studio (I've used 2022) and build the solution, or use the CLI to build the solution using the following command: dotnet msbuild in the root of the solution.

  To run the unit tests ether run via VIsual Studio test explorer, or use this CLI command from the solution root: dotnet test FatBassStatsTests/FatBassStatsTests.csproj

  ### Running

  The solutions creates a console application in the following location: <solution_root>/FatBassStats/bin/Debug/netcoreapp3.1/FatBassStats.exe

  You can run that executable wihout any arguments and it will provide help.  Current the application accepts the follwing argument(s):

  /artistname      Pass the artists name

  Example: <solution_root>/FatBassStats/bin/Debug/netcoreapp3.1/FatBassStats.exe /artistname paolo nutini


  ## FatBassStats

  Main project that will communicate with the external APIs (MusicBrainz and LyricsOVH) to calculate the Mean words in the artits songs.

  ### Dependencies

  .Net Core 3.1 

  ### Apis

  The Api class for each of the external Apis.

  ### Converters

  The XMl and Json converters used for converting the API data to the relevent models used in the application.

  ### Extensions

  Some simple string extentions for calculating the words in a given string, and Uri encoding for data being sent to the Apis.

  ### Interface

  All the interfaces used by the application.

  ### Models

  The internal models used by the application.

  ### Services

  The main services entry point for the command line console to extract the required data.

  ## FatBassStatsTests

  The test application containg all the unit tests for the solution.

  ### Test Dependencies

  Microsoft.NET.Test.Sdk
  NUnit

  These should automatically restore when the solution is opened in Visual Studio.  If they do not then either restore them via Package Manager, or CLI witht he following command in the solution root: dotnet restore
  
  ### Data

  Xml Data for the Artits and Works.  These are limited to a single artist Paolo Nutini for the sakes of testing
  
  ### Stubs

  Stubs for the two Apis to allow for unit tests to run without live data calls
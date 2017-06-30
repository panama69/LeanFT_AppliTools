This is a very simple AppliTools test using the C# implementation of HPE LeanFT.
The main source of this came from the [AppliTools](https://applitools.com/resources/tutorial/leanft/dotnet) website.

There were some setup steps that were implied or assumed one would know how to address on the AppliTools page so below are the things I had to do to have things work.

### Install the AppliTools SDK

* In Visual Studio 2015 select Tools -> NuGet Package Manager -> Package Manager Console.  Reference [Microsoft](https://docs.microsoft.com/en-us/nuget/tools/package-manager-console) if you need more help.
* In the Package Manager Console window type the following (as show from [AppliTools](https://applitools.com/resources/tutorial/leanft/dotnet)) website.
> Install-Package Eyes.LeanFT
* Create Console Application
  * File -> New -> Project
  * Templates -> Visual C# -> Console Application
* Make sure the following References are part of the project.  You may have others in your project but is what I found is the minimum for this example.
  * HP.LFT.SDK
  * System
  * System.Drawing

This is a very simple AppliTools test using the C# implementation of HPE LeanFT.
The main source of this came from the [AppliTools](https://applitools.com/resources/tutorial/leanft/dotnet) website.

There were some setup steps that were implied or assumed one would know how to address on the AppliTools page so below are the things I had to do to have things work.  The steps below were what I did to make the exmple from AppliTools work.  If you are just going to clone this project, you will need to make sure the AppliTools package is installed.

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

This example is for the C# implementation of LeanFT.  I will try out a Java implementation of LeanFT when I have time.  I would imagine they would be ver similar to the Selenium.

# DansStoreSln
This is a build of the demo MVC app from Adam Freeman's ASP.NET Core 3 textbook. This is for demonstration purpose.

## link
[https://www.apress.com/gp/book/9781484254394.](https://www.apress.com/gp/book/9781484254394.)

## Build Script

    dotnet new globaljson --sdk-version 5.0.201 --output DansStoreSln/OutdoorProducts
    dotnet new web --no-https --output DansStoreSln/OutdoorProducts --framework net5.0
    dotnet new sln -o DansStoreSln
    dotnet sln DansStoreSln add DansStoreSln/OutdoorProducts
    dotnet new xunit -o DansStoreSln/OutdoorProducts.Tests --framework net5.0
    dotnet sln DansStoreSln add DansStoreSln/OutdoorProducts.Tests 
    dotnet add DansStoreSln/OutdoorProducts.Tests reference DansStoreSln/OutdoorProducts
    

---
title: C# SDK for l10n
layout: api
---

# C# SDK

Qordoba’s C# SDK offers platform-specific features that make the Qordoba API implementation much simpler. The SDK allows you to integrate our API with your application without worrying about low-level API details. Our C# SDK is open-source and can be forked at the link below. Once forked and configured, you will be able to easily integrate our API into your application.

### Get the SDK:

Download the Objective-C API SDK from [GitHub](https://github.com/Qordobacode/api-sdk-c).

To clone the repo: `git clone git@github.com:Qordobacode/api-sdk-c.git`.


### How to configure the SDK:

The SDK code reads configuration values from the `Configuration.cs` file, so you will have to add the following to that file:

`BasicAuthPassword`: Your Qordoba password to use with basic authentication

`BasicAuthUserName`: Your Qordoba username to use with basic authentication

###How to install:

The SDK has dependencies to NuGet packages (e.g., [Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json), [UniRest](https://github.com/Mashape/unirest-net). The references for these packages are already added in the packages.config file in the SDK. If the automatic NuGet package restore is enabled, these dependencies will be installed automatically. 

* Unarchive the downloaded zip file
* Open the solution (*.sln) file
* Invoke the build process using `"F6"` key or `"CTL+LSHIFT+B"` shortcut

**How to use the SDK:**

The build process generates a portable class library, which can be used like a normal class library. The  library is compatible with Windows Forms, Windows RT, Windows Phone 8, Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use portable class libraries is [here](https://msdn.microsoft.com/library/gg597391(v=vs.100).aspx). 


### Bug reports
Have a bug? Please create an issue [here](https://github.com/Qordobacode/api-sdk-c/issues) on GitHub! 


### License
The MIT License (MIT)


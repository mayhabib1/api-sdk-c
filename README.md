QordobaPCL
=================
Qordoba’s Java SDK offers platform-specific features that make the Qordoba implementation much simpler. The SDKs are open-source, and can be forked at the links below. Once forked, you can integrate our API into your application.

How To Configure:
=================
The code might need to be configured with your API credentials. To do that,
open the file "Configuration.cs" and edit it's contents.

How To Build: 
=============
The code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest.
The reference to these packages is already added as in the packages.config file.
If the automatic NuGet package restore is enabled, these dependencies will be 
installed automatically. Therefore, you will need internet access for build.

    1. Unarchive the downloaded zip file.
    2. Open the solution (*.sln) file.
    3. Invoke the build process using "F6" key or "CTL+LSHIFT+B" shortcut.

How To Use:
===========
The build process generates a portable class library, which can be used like
a normal class library. The  library is compatible with Windows Forms,
Windows RT, Windows Phone 8, Silverlight 5, Xamarin iOS, Xamarin Android and
Mono. More information on how to use can be found at the following link.

http://msdn.microsoft.com/en-us/library/vstudio/gg597391(v=vs.100).aspx
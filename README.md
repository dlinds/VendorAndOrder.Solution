# _Pierre's Bakery Website_

#### By _Daniel Lindsey_

#### _Website for Pierre's bakery that sells bread and pastries toa list of vendors_

## Technologies Used

- _C#_
- _MSTest_
- _.NET Framework_
- _HTML_
- _CSS_

## Description

_This is a C# web application for a bakery. Once run, the site will allow the baker to manage vendor and order relationships._

## Setup/Installation Requirements

- ### Cloning the repository
  To view this application, you must clone it to your computer. To do so,

1. First, you will need to access a terminal. The easiest way to do so on either OS X (Mac) or Windows is to install Visual Studio (VS) Code.
   - [Windows](https://code.visualstudio.com/docs/?dv=win64user)
   - [OS X](https://code.visualstudio.com/docs/?dv=osx)
2. Once VS Code and Node.js are installed, navigate back to [this project](https://github.com/dlinds/VendorAndOrder.Solution)
3. Locate and click the green Code button at the top of the page, and choose the option to _Download ZIP_.
4. Once downloaded, navigate to your Downloads folder and extract the contents to a location of your choosing.
5. Right click in the root directory of the folder, and choose _Open With Code_. This should open the repository in VS Code.

- ### Installing C# and .NET
  Once the project is downloaded to your computer, you will need to download and install C# and the .NET SDK.

1. First, download and install the .NET 5 SDK

- Mac: https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.401-macos-x64-installer
- Windows: https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.401-windows-x64-installer

2. Once installed, open the project in VS Code (if it is not already open)
   and access a new terminal via the menu at top of VS Code.
3. Type the following command: **_dotnet tool install -g dotnet-script_**
4. Next, configure your terminal environment with the following command

- Mac: **_echo 'export PATH=$PATH:~/.dotnet/tools' >> ~/.zshrc_**
- Windows: **_echo 'export PATH=$PATH:~/.dotnet/tools' >> ~/.bash_profile_**
  <br>
  <br>

- ### Run the project
  Now that everything is install, you may run the project.

1. Open up a new terminal and navigate to the Bakery Folder
2. Type in the following command: **_dotnet run_**
3. An interface with the Bakery banner and picture of a loaf of bread should appear, allowing you to then interface with the application.

- ### Run tests with MS Test
  Should you wish to make any changes to the code, you will need to run tests in order to confirm the code is still functioning as expected.

1. Open up a new terminal and navigate to the Bakery.Tests Folder
2. Type in the following command: **_dotnet test_**
3. If there are any errors, please correct them before submitting a pull request.

## Known Bugs

- _No known issues at this time_

## License

_MIT_

Copyright (c) _3-4-2022_ _Daniel Lindsey_

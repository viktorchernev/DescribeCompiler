---
layout: page
title: Describe Compiler CLI
permalink: /technical/cli/
exclude: true
---
The Describe Compiler CLI is the command line version of the Describe compiler. It is a .Net console application that acts as a wrapper around the Describe Compiler dll and provides a command line interface for the compiler. There are two versions of the Describe Compiler CLI, represented by two different projects - the ```Describe Compiler CLI - Core``` and the ```Describe Compiler CLI - Framework```, that target .Net Core and .Net Framework, respectively. Both apps are more or less identical, but the Core App is the official one, which means that it gets new features implemented first.

The CLI app is relatively small in terms of codebase and relatively simple and straight forward in terms of architecture.
There are 5 distinct modules - Program, Main, Arguments, Messages and Datnik.

## Modules
C# console applications contain a class called ```Program``` that contains ```static void Main``` method. This is the entry point. This is ```Program.cs```. The Messages module - ```FunctionsMessages.cs``` contains methods for setting and changing console propperties and colors and outputting messages, like the help message and the app baner. The Main module - ```FunctionsMain.cs``` contains the main functionality of the app. The Arguments module - ```FunctionsArguments.cs``` contains the methods that are used to read the command line arguments. The Datnik structure - ```Datnik.cs``` is populated with all the data for the current command that is to be executed.


## Links
* [Program](/DescribeDocumentation/technical/cli/program)
* [Messages](/DescribeDocumentation/technical/cli/messages)
* [Main](/DescribeDocumentation/technical/cli/main)
* [Arguments](/DescribeDocumentation/technical/cli/arguments)
* [Datnik](/DescribeDocumentation/technical/cli/datnik)
---
layout: page
title: Describe Compiler CLI - Messages
permalink: /technical/cli/messages/
exclude: true
---
### Options
<span style="color:blue">```static bool ONE_BASED_ARG_INDEX```</span><br>Wether we are using one based index for error reporting. For example, if there is an error in the first cmd argument, if ```ONE_BASED_ARG_INDEX``` is ```true```, we will get something like ```Error at argument 1```. Otherwise we will get ```Error at argument 0```.

<span style="color:blue">```static ConsoleColor INFO_COLOR```</span><br>The color used for informational text forecolor.

<span style="color:blue">```static ConsoleColor TEXT_COLOR```</span><br>The color used for standard text forecolor.

<span style="color:blue">```static ConsoleColor ERROR_COLOR```</span><br>The color used for error text forecolor.

<span style="color:blue">```static ConsoleColor MOREINFO_COLOR```</span><br>The color used for less important informational text forecolor.

### Presetting
<span style="color:blue">```presetConsole()```</span><br>Set console dimensions and colors.

<span style="color:blue">```printLogo3(ConsoleColor logoColor)```</span><br>Output the ASCII art logo with 3 dashes for shadow to the console.

<span style="color:blue">```printLogo3()```</span><br>Output the ASCII art logo with 3 dashes for shadow to the console, using the default color for text.

<span style="color:blue">```printLogo2(ConsoleColor logoColor)```</span><br>Output the ASCII art logo with 2 dashes for shadow to the console.

<span style="color:blue">```printLogo2()```</span><br>Output the ASCII art logo with 2 dashes for shadow to the console, using the default color for text.

<span style="color:blue">```printLogo3Bicolor(ConsoleColor colorA, ConsoleColor colorB)```</span><br>Output the ASCII art logo with 2 dashes for shadow to the console, in 2 alternating colors.

<span style="color:blue">```printLogo3Bicolor()```</span><br>Output the ASCII art logo with 2 dashes for shadow to the console, in 2 alternating colors, using the default color for text and the default color for info.

### Themes
<span style="color:blue">```SetDefaultTheme()```</span><br>Set default color theme.

<span style="color:blue">```SetVioletTheme()```</span><br>Set white/violet color theme.

<span style="color:blue">```SetCyanTheme()```</span><br>Set cyan/violet color theme.

<span style="color:blue">```SetLightBlueTheme()```</span><br>Set light blue/white color theme.

<span style="color:blue">```SetDarkBlueTheme()```</span><br>Set dark blue/dark gray color theme.

### Errors
<span style="color:blue">```printWarning(string message)```</span><br>Output a warning message.

<span style="color:blue">```printExtTemplatesSuccess()```</span><br>Output message saying that ext command was successfully completed.

<span style="color:blue">```printCompilationSuccess()```</span><br>Output message saying that compilation was successfully completed.

<span style="color:blue">```printHelpMessage()```</span><br>Output the help message/usage data.

<span style="color:green">_All the error messages below show "Press any key to exit" message and wait for user input._</span>

<span style="color:blue">```printNoArgumentsError()```</span><br>Output error message saying "No arguments or invalid argument count" and shows usage data.

<span style="color:blue">```printArgumentError(string arg, int argIndex)```</span><br>Output error message saying "Invalid argument - """ and shows usage data.

<span style="color:blue">```printArgumentError(string arg, int argIndex, string message)```</span><br>Output error message saying "Invalid argument - "" - " and shows usage data.

<span style="color:blue">```printFatalError(string message)```</span><br>Output error message saying that a fatal error has occured.

### Logging
<span style="color:blue">```internal static string Log { get; private set; }```</span><br>Accumulate the full log here.

<span style="color:green">_Log methods listed below are passed to the parser as log event handlers and are called possibly many times during the parsing process, depending on the log verbosity level the parser is set to._</span>

<span style="color:blue">```ConsoleLog(string text)```</span><br>Output text to the console.

<span style="color:blue">```ConsoleLogInfo(string text)```</span><br>Output text with specific color (and possibly prefixes/suffixes) to the console.

<span style="color:blue">```ConsoleLogError(string text)```</span><br>Output text with specific color (and possibly prefixes/suffixes) to the console.

<span style="color:blue">```ConsoleLogParseInfo(string text)```</span><br>Output text with specific color (and possibly prefixes/suffixes) to the console.
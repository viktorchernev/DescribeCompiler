---
layout: page
title: Describe Compilation - CLI
permalink: /language/how-to-compile/cli
exclude: true
---
<br>The Describe Compiler CLI is a text-based app that provides a command line interface for the API compiler, so that users can compile Describe source files on the command line. The app is licensed under the [AGPL v3](https://www.gnu.org/licenses/agpl-3.0) public license.

### help

```DescribeCompilerCLI help```<br>
```DescribeCompilerCLI -h```<br>

<span style="color:orange">_help | -h_</span><br>

The help command is used to display usage / help message

### parse-file

```DescribeCompilerCLI parse-file "C:\parse\path\input.ds" "C:\result\path\output.json"```<br>
```translator=JSON verbosity=low logfile="C:\parse\path\log.txt"```<br> <!-- artifacts=use artifacts-path="C:\artifacts\path\input.dart" -->

<span style="color:orange">_parse-file PARSE_PATH RESULT_PATH [translator = ( TARGET_LANGUAGE | TRANSLATOR_NAME )] [verbosity= ( l | low | m | medium |h | high)| log-verbosity= ( l | low | m | medium | h | high)][logfile=LOG_PATH]_</span><br>

The parse-file command is used to parse a single file. First we specify the command, followed by the source file to be parsed and the output file path. Anything after that is optional.

* <span style="color:blue">**_translator_**</span><br>
Either the desired output language or the name of the translator to be used.

* <span style="color:blue">**_verbosity_**</span><br>
The log verbosity of the app. Same as ```log-verbosity```. ```l``` or ```low``` for low verbosity, ```m``` or ```medium``` for medium verbosity or ```h``` or ```high``` for high verbosity. Low is default.

<!--
* <span style="color:orange">**_artifacts - NOT IMPLEMENTED_**</span> - Whether to use artifacts. ```m``` or ```makeonly``` will only create new and overwrite existing artifacts, but will not consume them, ```t``` or ```takeonly``` will only consume but not create or update them, ```u``` or ```use``` will both use available or valid artifacts while updating invalid ones and creating new artifacts when not available, and ```n``` or ```no``` will ignore artifacts all-together. Default is no.

* <span style="color:orange">**_ARTIFACTS_PATH - NOT IMPLEMENTED_**</span> - Specifies the path of directory to store artifacts in.
-->

* <span style="color:blue">**_logfile_**</span><br>
Specifies path of directory or file to output logs to. If not specified, logs will be outputted only to the console, which is the default.

### parse-folder

```DescribeCompilerCLI parse-folder "C:\parse\path\input\" "C:\result\path\output.json"```<br>
```translator=JSON dsonly=true toponly=false onerror=ignore```<br>
```verbosity=low logfile="C:\parse\path\log.txt"```<br>

<span style="color:orange">_parse-folder PARSE_PATH RESULT_PATH [translator = ( TARGET_LANGUAGE | TRANSLATOR_NAME )][dsonly= ( true | false ) ][toponly= ( true | false ) ][onerror= ( stop | ignore )][verbosity= ( l | low | m | medium |h | high)| log-verbosity= ( l | low | m | medium | h | high)][logfile=LOG_PATH]_</span><br>

The parse-folder command is used to parse a directory full of Describe source files (.ds files). First we specify the command, followed by the source directory to be parsed and the output file path. Anything after that is optional.

* <span style="color:blue">**_translator_**</span><br>
Either the desired output language or the name of the translator to be used.

* <span style="color:blue">**_dsonly_**</span><br>
Whether to omit files that are not Describe source files (.DS). ```true``` or ```false```. Default is true.

* <span style="color:blue">**_toponly_**</span><br>
Whether to parse files in child directories or not. ```true``` or ```false```. Default is false.

* <span style="color:blue">**_onerror_**</span><br>
What to do when there is an error in source code. ```stop``` or ```ignore```. Default is stop.

* <span style="color:blue">**_verbosity_**</span><br>
The log verbosity of the app. Same as ```log-verbosity```. ```l``` or ```low``` for low verbosity, ```m``` or ```medium``` for medium verbosity or ```h``` or ```high``` for high verbosity. Low is default.

* <span style="color:blue">**_logfile_**</span><br>
Specifies path of directory or file to output logs to. If not specified, logs will be outputted only to the console, which is the default.

<br>
### Links
[Describe Compilation](/language/how-to-compile)<br> 
[Use the API version](/language/how-to-compile/api)<br>
[Use the AWS version](/language/how-to-compile/aws)<br>
[Back](/language/)
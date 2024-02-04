---
layout: page
title: Describe Compiler API - Compiler - Constructors
permalink: /technical/api/compiler/ctors/
exclude: true
---
Those are the constructors of the compiler.

<span style="color:blue">```DescribeCompiler(string templateName)```</span><br>

<span style="color:blue">```DescribeCompiler(string templateName, LogVerbosity verbosity)```</span><br>

<span style="color:blue">```DescribeCompiler(string templateName, LogVerbosity verbosity, Action logText)```</span><br>

<span style="color:blue">```DescribeCompiler(string templateName, LogVerbosity verbosity, Action logText, Action logError)```</span><br>

<span style="color:blue">```DescribeCompiler(string templateName, LogVerbosity verbosity, Action logText, Action logError, Action logInfo)```</span><br>

<span style="color:blue">```DescribeCompiler(string templateName, LogVerbosity verbosity, Action logText, Action logError, Action logInfo, Action logParserInfo)```</span><br><br>

<hr><br>
<span style="color:orange">templateName</span> - The name of the templates set to use<br>
<span style="color:orange">verbosity</span> - The logging verbosity of the parser<br>
<span style="color:orange">logText</span> - method to log text<br>
<span style="color:orange">logError</span> - method to log errors<br>
<span style="color:orange">logInfo</span> - method to log less important info<br>
<span style="color:orange">logParserInfo</span> - method to log parser output<br>
---
layout: page
title: Describe Compiler API - Compiler - Constructors
permalink: /technical/api/compiler/verbosity-medium/
exclude: true
---
**_This partial class (and source file) contains the actual parsing methods for medium-verbosity parser_**

<span style="color:blue">```bool ParseFolder_MediumVerbosity(DirectoryInfo dirInfo, out string translated)```</span><br>
Compile a folder of describe source files to another language. What the destination language is depends on the selected template set.<br>


<span style="color:blue">```bool ParseFile_MediumVerbosity(FileInfo fileInfo, out string translated)```</span><br>
Compile a describe source file to another language. What the destination language is depends on the selected template set.<br>


<span style="color:orange">```bool ParseFile_MediumVerbosity(FileInfo fileInfo, DescribeUnfold unfold)```</span><br>
Parse a describe source file and store the data to a DescribeUnfold structure.<br>


<span style="color:orange">```bool Parse_MediumVerbosity(TextReader reader, out Reduction root, out string FailMessage)```</span><br>
Parse a describe source file and get the parse tree in the form of GOLD parser reduction.<br>
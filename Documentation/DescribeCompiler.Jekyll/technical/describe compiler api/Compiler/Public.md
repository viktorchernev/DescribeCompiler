---
layout: page
title: Describe Compiler API - Compiler - Public
permalink: /technical/api/compiler/public/
exclude: true
---
The public methods of the compiler


<span style="color:blue">```bool ChangeGrammar(GrammarName grammarName)```</span><br>
Set different grammar version<br>

<span style="color:blue">```bool ParseFile_HighVerbosity(FileInfo fileInfo, out string translated)```</span><br>
Translate a folder of Describe source files ".ds"<br>

<span style="color:blue">```bool ParseFile(FileInfo fileInfo, out string translated)```</span><br>
Translate a Describe source file ".ds"<br>
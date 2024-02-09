---
layout: page
title: Describe Compiler API - Compiler - Properties
permalink: /technical/api/compiler/properties/
exclude: true
---
<span style="color:blue">```string Log {get;}```</span><br>
The Log property is used to retrieve the accumulated logs of the compiler. (It has a private setter and logs are accumulated in this variable)<br>

<span style="color:blue">```LogVerbosity Verbosity {get; set;}```</span><br>
The LogVerbosity property is used to set or retrieve the logging verbosity level of the parser.<br>

<span style="color:blue">```string LoadedGrammarName {get;}```</span><br>
Get the name of the grammar that is currently loaded in the compiler and will be used for parsing.<br>
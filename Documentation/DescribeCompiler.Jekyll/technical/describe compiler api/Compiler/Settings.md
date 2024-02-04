---
layout: page
title: Describe Compiler API - Compiler - Settings
permalink: /technical/api/compiler/settings/
exclude: true
---
Those are hardcoded settings that can be used to change the behaviour of the compiler.<br>


<span style="color:blue">```const bool PARSE_DS_ONLY```</span><span style="color:red">``` = true```</span><br>
Weather to parse only .ds files, or all the files in a directory.<br>

<span style="color:blue">```const bool PARSE_TOP_DIRECTORY_ONLY```</span><span style="color:red">``` = false```</span><br>
Weather to parse files in all sub-directories or only in the top directory.<br>

<span style="color:blue">```const string COMPILER_NAME```</span><span style="color:red">``` = "Describe Compiler v0.9.2"```</span><br>
A string representing the full name of the compiler (with the version).<br>

<span style="color:blue">```const string COMPILER_VER```</span><span style="color:red">``` = "0.9.2"```</span><br>
A string representing the compiler version.<br>

<span style="color:blue">```const GrammarName DEFAULT_GRAMMAR```</span><span style="color:red">``` = GrammarName.Decorators```</span><br>
The default grammar file to be loaded with this version of the compiler. The grammar is usually left alone, unless there is a very good reason to be changed, which, on the other hand, makes this the de facto grammar that is used.<br>
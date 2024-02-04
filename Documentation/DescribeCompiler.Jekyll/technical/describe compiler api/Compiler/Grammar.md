---
layout: page
title: Describe Compiler API - Compiler - Constructors
permalink: /technical/api/compiler/grammar/
exclude: true
---
**_This partial class (and source file) contains the methods for loading and changing grammars_**


<span style="color:blue">```bool LoadGrammar(byte[] grammar)```</span><br>
Load a CGT (compiled grammar table) file into the gold parser from a byte array<br>


<span style="color:orange">```string GrammarNameToFullGramarName(GrammarName name)```</span><br>
Helper method to get a string grammar name from the GrammarName enum.<br>


<span style="color:orange">```string GrammarNameToResourceName(GrammarName name)```</span><br>
Helper method to get a string resource name from the GrammarName enum.<br>
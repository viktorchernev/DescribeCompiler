---
layout: page
title: Describe Compiler API - Compiler - Constructors
permalink: /technical/api/compiler/statistics/
exclude: true
---
**_Those are statistics for the compilation process that get updated during the compilation process._**


<span style="color:blue">```bool isInitialized```</span><br>
If Ctor went wrong, this will be false. Also the compilation process will not be allowed to start.<br>

<span style="color:blue">```int FileCounter```</span><br>
The number of parsed files in the current operation.<br>

<span style="color:blue">```int TokenCounter```</span><br>
The number of produced tokens in the current operation.<br>

<span style="color:blue">```int ReductionCounter```</span><br>
The number of parsed reductions in the current operation.<br>
---
layout: page
title: Describe Compiler CLI - Messages
permalink: /technical/cli/main/
exclude: true
---
Previously there were more methods in the Main module, but since we have eliminated the external templating functionality, those have been deleted. More might be added again, as we add functionality for manipulating artifacts or config files, for example.

<span style="color:blue">```internal static bool Compile()```</span><br>
Compile source file(s)<br>
<span style="color:orange">returns</span> - True if successful, otherwise false
---
layout: page
title: Describe Compiler API - PreprocessorForDescribe06
permalink: /technical/api/preprocessors/prepreprocessor-v06/
exclude: true
---
<span style="color:blue">```string ProcessSource(string value)```</span>
Preprocess Describe source code.<br>
<span style="color:orange">value</span> - The source code string to be preprocessed.<br>
<span style="color:orange">returns</span> - The preprocessed source code string.<br>

We add a character before and after that we will not use, in order to skip if tests to see if we are not on the first or last char for null reference. The new line we keep, as it is a workaround for the runaway group last comment bug.
---
layout: page
title: Separate translator classes
permalink: /language/reference/versioning/v092/features/feature-8/
exclude: true
---
<br>_CHANGE: Separate translator classes_

REPLACES: @featureMultipleTranslatorClasses

We do not have the compiler methods ```ParseFile``` and ```ParseFolder``` output destination source code any more. Instead, those methods populate an unfold. There are separate translator classes in a separate namespace now that the user should use to translate the unfold to the destination language source code.

Until now, those translator classes were a part of the compiler and were called in the compilation process. By removing the translation from the compilation process we simplify the setting of compilation options and give more freedom to users to more easily write, modify and debug their own translators.


## Links
[Back](/language/reference/versioning/v092/compiler092/)
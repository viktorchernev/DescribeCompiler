---
layout: page
title: Describe Transpiler Documentation - Home
permalink: /tanspiler/api/
exclude: true
---
# Transpiler for the Describe Markup Language

This is the actual Compiler. Although I want to open a bracket hear to say that it is actually a Transpiler, rather than a true compiler, as it us a tool that translates a language to another high level language, as opposed to machine instructions, but many people might not be familiar with this terminology, so Compiler it is.

First of all we have the compiler here that compiles source codes. It can compile from a file, a folder, a string or multiple strings. And you can set other options as well.
You can compile to an AST, an Unfold or to multiple Unfold's.

Here we have a preprocessor. There is a preprocessor in the DescribeParser, but we will use this one instead, as this one not only inserts missing terminators at the end, but also deals with preprocessor directives, like language-version.

Finally, the Translators are used to translate an Unfold or AST to a target language.


[Preprocessors]()<br>
[Compiler]()<br>
[Translators]()<br>

### Links
[Back](/tanspiler/home/)
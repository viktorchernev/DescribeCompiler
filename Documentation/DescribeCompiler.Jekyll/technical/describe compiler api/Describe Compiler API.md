---
layout: page
title: Describe Compiler API
permalink: /technical/api/
exclude: true
---
## Compiler
The Describe Compiler API is a software library, containing the de-facto compiler for the Describe Markup Language, as well as some translators for different target languages (there are currently two translators that come with the library - one for HTML and one for JSON), residing in the "DescribeCompiler.Compiler" and "DescribeCompiler.Translators" namespaces, respectively.

1. Compilation and Translation - The compiler will read and parse the source files, one by one, and will populate with the data a type of in-memory structure called "the unfold" ("DescribeUnfold"). This structure plays the role of a syntax tree, and is the end product of the compilation process. The unfold can be further manipulated directly with .net code, or it can be translated to a destination language like HTML or JSON, which is the role of the translators.

2. Compilation process - There are four steps in the compilation process - Initialization, pre-parsing, parsing and optimization.

## Links

* [Grammars](/DescribeDocumentation/technical/api/grammars)
* [Compiler](/DescribeDocumentation/technical/api/compiler)
* [Preprocessors](/DescribeDocumentation/technical/api/preprocessors)
* [Optimizers](/DescribeDocumentation/technical/api/optimizers)

## Translators
#### HTML_PARACORD
#### JSON_COMMONER
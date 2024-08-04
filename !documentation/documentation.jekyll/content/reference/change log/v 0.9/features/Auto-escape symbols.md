---
layout: page
title: Auto-escape symbols
permalink: /v09/features/feature-3
exclude: true
---
_FEATURE: Auto-escape symbols_

Due to limitations in the Gold Parser architecture, symbols like stars and hyphens, and other symbols that are both text-chunk and parts of 2 symbol keywords need to be escaped, and if not - produce a lexical error. Those errors might be handled by resetting the parser state, or by adding the escape symbol in the source and parsing again the file in question. The former is the superior method, of course.

<span style="color:blue">Added checks and addition of escape backslash to the preprocessor method ```string EncodeNonAsciiCharacters(string value)```</span>

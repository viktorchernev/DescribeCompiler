---
layout: page
title: Cyrillic or special character
permalink: /v09/bugs/bug-2
exclude: true
---
_BUG: Cyrillic or special character_

<span style="color:red">Cyrillic or other special characters produce lexical errors. This is probably because the Gold Parser Builder does not add those as "printable characters"</span>

Possible solutions would be to
1. Redefine those "printable characters" in the builder grammar
2. Change values in the compiled grammar file
3. Rewrite the Gold Parser Builder

<span style="color:green">Added simple (preprocessing) method that checks the source file before parsing and escapes those characters to HTML escape sequences "&#xCODE;". Still don't work with some special characters, though - like planet earth</span>

---
layout: page
title: Testing - Grammar 0.8
permalink: /testing/grammar-v08/
exclude: true
---
<br>
_Describe Links (v0.8)_

<span style="font-style: italic;">```Grammar version 0.8 has to pass all the tests for Grammar versions 0.6 and 0.7 before passing the following:```</span><br>


<span style="color:green">basic functionality</span><br>
<span style="color:blue">```basic 1.ds```</span> - Some very simple list, with tags and links<br>
<span style="color:blue">```basic 2.ds```</span> - Some very simple list with 1 entry, with tags and links<br>
<span style="color:blue">```basic 3.ds```</span> - Some very simple list with 1 entry on the same line (in-lined production), with tags and links<br>
<span style="color:blue">```basic 4.ds```</span>  - Some very simple list ending with a new line character, with tags and links<br>
<span style="color:blue">```basic 5.ds```</span>  - Some very simple list ending with a new line character, with multiple new lines and an indented new line, with tags and links<br>


<span style="color:green">comments - testing how comments work</span><br>
<span style="color:blue">```comments 1.ds```</span> - Some very simple list with a line comment ("//"), with tags and links, empty links<br>
<span style="color:blue">```comments 2.ds```</span> - Some very simple list with a line comment ("//") and a commented out entry - delimited comment (/* ... */), with tags and links, empty links<br>
<span style="color:blue">```comments 3.ds```</span> - Some very simple list with a line comment ("//") and a commented out logic - multiple delimited comments (/* ... */), with tags and links<br>
<span style="color:blue">```comments 4.ds```</span> - Some very simple list with 2 line comments ("//"), ending with a comment on a new line, with tags and links (there is an issue with the GOLD parsed engine that results in a runaway group if source file ends with a comment. We handle it during preprocessing though).<br>
<span style="color:blue">```comments 5.ds```</span> - Some very simple list with 2 line comments ("//"), ending with a comment on the same line, with tags and links (there is an issue with the GOLD parsed engine that results in a runaway group if source file ends with a comment. We handle it during preprocessing though).<br>


<span style="color:green">empty - the idea here is to test empty productions (without entries)</span><br>
<span style="color:blue">```empty 1.ds```</span> - Simple empty production, with tags and a link.<br>
<span style="color:blue">```empty 2.ds```</span> - Simple empty production, no spaces, with tags and a link.<br>
<span style="color:blue">```empty 3.ds```</span> - Simple empty production, with spaces and new lines, with tags and 2 links and an empty link.<br>


<span style="color:green">escaped double characters - testing escape sequences</span><br>
<span style="color:blue">```escaped double characters 1.ds```</span> - Testing escape sequence - escaped forward slash, with tags and an escaped square bracket.<br>
<span style="color:blue">```spaces and escape sequences N.ds```</span> - Testing a combination of spaces, new lines and escape sequences. Linux style new lines ("\n"), with tags and links.<br>
<span style="color:blue">```spaces and escape sequences RN.ds```</span> - Testing a combination of spaces, new lines and escape sequences. Windows style new lines ("\r\n"), with tags and links.<br>


<span style="color:green">productions</span><br>
<span style="color:blue">```production in production 1.ds```</span> - Production containing a child production as first child.<br>
<span style="color:blue">```production in production 2.ds```</span> - Production containing a child production as last child.<br>
<span style="color:blue">```production in production 3.ds```</span> - Production containing a child production as middle child.<br>
<span style="color:blue">```production in production 4.ds```</span> - Production containing 2 child productions as first and second child.<br>
<span style="color:blue">```production in production 5.ds```</span> - Production containing 2 child productions as last and next to last child.<br>
<span style="color:blue">```production in production 6.ds```</span> - Production containing a child production containing a child production.<br>
<span style="color:blue">```production in production 7.ds```</span> - Production containing a child production containing a child production as last.<br>


<span style="color:green">other</span><br>
<span style="color:blue">```2 root nodes.ds```</span> - Two simple lists in one file, with tags and links.<br>
<span style="color:blue">```cyrillic.ds```</span> - Some very simple list in Cyrillic, with Cyrillic tags and Cyrillic links. This is for testing the pre-processor, as the GOLD Parser can't parse Cyrillic.

<br>
### Links
[Back](/testing)
---
layout: page
title: Testing - Grammar 0.6
permalink: /testing/grammar-v06/
exclude: true
---
<br>
_Describe Basics (v0.6)_

<span style="color:green">basic functionality</span><br>
<span style="color:blue">```basic 1.ds```</span> - Some very simple list<br>
<span style="color:blue">```basic 2.ds```</span> - Some very simple list with 1 entry<br>
<span style="color:blue">```basic 3.ds```</span> - Some very simple list with 1 entry on the same line (in-lined production)<br>
<span style="color:blue">```basic 4.ds```</span>  - Some very simple list ending with a new line character<br>


<span style="color:green">comments - testing how comments work</span><br>
<span style="color:blue">```comments 1.ds```</span> - Some very simple list with a line comment ("//")<br> 
<span style="color:blue">```comments 2.ds```</span> - Some very simple list with a line comment ("//") and a commented out entry - delimited comment (/* ... */)<br>
<span style="color:blue">```comments 3.ds```</span> - Some very simple list with a line comment ("//") and a commented out logic - multiple delimited comments (/* ... */)<br>
<span style="color:blue">```comments 4.ds```</span> - Some very simple list with 2 line comments ("//"), ending with a comment on a new line (there is an issue with the GOLD parsed engine that results in a runaway group if source file ends with a comment. We handle it during preprocessing though).<br>
<span style="color:blue">```comments 5.ds```</span> - Some very simple list with 2 line comments ("//"), ending with a comment on the same line (there is an issue with the GOLD parsed engine that results in a runaway group if source file ends with a comment. We handle it during preprocessing though).<br>


<span style="color:green">double characters - testing if characters that are a start of a multi-character terminal are correctly handled</span><br>
<span style="color:blue">```double characters 1.ds```</span> - Some very simple list containing a hyphen "-", as it is a start character of a producer "->"<br> 
<span style="color:blue">```double characters 2.ds```</span> - Some very simple list containing a forward slash "/", as it is a start character of a comment "//" or "/*"<br> 
<span style="color:blue">```double characters 3.ds```</span> - Some very simple list containing a back slash "\", as it is a start character of escape sequences "\,"<br>


<span style="color:green">empty - the idea here is to test empty productions (without entries)</span><br>
<span style="color:blue">```empty 1.ds```</span> - Simple empty production.<br>
<span style="color:blue">```empty 2.ds```</span> - Simple empty production, no spaces.<br>
<span style="color:blue">```empty 3.ds```</span> - Simple empty production, with spaces.<br>
<span style="color:blue">```empty 4.ds```</span> - Simple empty production, with spaces and new lines.<br>


<span style="color:green">escaped double characters - testing escape sequences</span><br>
<span style="color:blue">```escaped double characters 1.ds```</span> - Testing escape sequence - escaped dash.<br>
<span style="color:blue">```escaped double characters 2.ds```</span> - Testing escape sequence - escaped forward slash.<br>
<span style="color:blue">```escaped double characters 3.ds```</span> - Testing escape sequence - escaped backward slash (escape escape).<br>
<span style="color:blue">```spaces and escape sequences N.ds```</span> - Testing a combination of spaces, new lines and escape sequences. Linux style new lines ("\n").<br>
<span style="color:blue">```spaces and escape sequences RN.ds```</span> - Testing a combination of spaces, new lines and escape sequences. Windows style new lines ("\r\n").<br>


<span style="color:green">productions</span><br>
<span style="color:blue">```production in production 1.ds```</span> - Production containing a child production as first child.<br>
<span style="color:blue">```production in production 2.ds```</span> - Production containing a child production as last child.<br>
<span style="color:blue">```production in production 3.ds```</span> - Production containing a child production as middle child.<br>
<span style="color:blue">```production in production 4.ds```</span> - Production containing 2 child productions as first and second child.<br>
<span style="color:blue">```production in production 5.ds```</span> - Production containing 2 child productions as last and next to last child.<br>
<span style="color:blue">```production in production 6.ds```</span> - Production containing a child production containing a child production.<br>
<span style="color:blue">```production in production 7.ds```</span> - Production containing a child production containing a child production as last.<br>


<span style="color:green">other</span><br>
<span style="color:blue">```2 root nodes.ds```</span> - Two simple lists in one file<br>
<span style="color:blue">```cyrillic.ds```</span> - Some very simple list in Cyrillic. This is for testing the pre-processor, as the GOLD Parser can't parse Cyrillic.

<br>
### Links
[Back](/testing)
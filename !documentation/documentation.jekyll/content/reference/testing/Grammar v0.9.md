---
layout: page
title: Testing - Grammar 0.9
permalink: /testing/grammar-v09/
exclude: true
---
<br>
_Describe Decorators (v0.9)_


<span style="font-style: italic;">```Grammar version 0.9 has to pass all the tests for Grammar versions 0.6, 0.7 and 0.8, before passing the following:```</span><br>


<span style="color:green">basic functionality</span><br>
<span style="color:blue">```basic 1.ds```</span> - Some very simple list, with tags and links empty decorators<br>
<span style="color:blue">```basic 2.ds```</span> - Some very simple list with 1 entry, with tags and links and a decorator on multiple lines<br>
<span style="color:blue">```basic 3.ds```</span> - Some very simple list with 1 entry on the same line (in-lined production), with tags and links and a decorator<br>
<span style="color:blue">```basic 4.ds```</span>  - Some very simple list ending with a new line character, with tags and links and a decorator<br>


<span style="color:green">comments - testing how comments work</span><br>
<span style="color:blue">```comments 1.ds```</span> - Some very simple list with a line comment ("//"), with tags and links, empty links and erroneously placed decorators<br>
<span style="color:blue">```comments 2.ds```</span> - Some very simple list with a line comment ("//") and a commented out entry - delimited comment (/* ... */), with tags and links, empty links, multiple empty decorators<br>
<span style="color:blue">```comments 3.ds```</span> - Some very simple list with a line comment ("//") and a commented out logic - multiple delimited comments (/* ... */), with tags, links and decorators<br>
<span style="color:blue">```comments 4.ds```</span> - Some very simple list with 2 line comments ("//"), ending with a comment on a new line, with tags, links and decorators (there is an issue with the GOLD parsed engine that results in a runaway group if source file ends with a comment. We handle it during preprocessing though).<br>
<span style="color:blue">```comments 5.ds```</span> - Some very simple list with 2 line comments ("//"), ending with a comment on the same line, with tags, links and decorators (there is an issue with the GOLD parsed engine that results in a runaway group if source file ends with a comment. We handle it during preprocessing though).<br>


<span style="color:green">other</span><br>
<span style="color:blue">```2 root nodes.ds```</span> - Two simple lists in one file, with tags, links and decorators.<br>
<span style="color:blue">```cyrillic.ds```</span> - Some very simple list in Cyrillic, with Cyrillic decorators, with Cyrillic tags and Cyrillic links. This is for testing the pre-processor, as the GOLD Parser can't parse Cyrillic.

<br>
### Links
[Back](/testing)
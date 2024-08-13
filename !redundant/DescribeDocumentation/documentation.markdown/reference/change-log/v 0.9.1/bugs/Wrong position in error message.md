---
layout: page
title: Wrong position in error message
permalink: /language/reference/versioning/v091/bugs/bug-3/
exclude: true
---
<br>_BUG: Wrong position in error message_

<span style="color:red">The Gold parser engine gives wrong line number in error messages - most of the times wrong by 1 I think that it is not a bug per se, but the position is 0 based, and tabs are counted as 1 symbol.</span>

First problem is that the GoldParser gives the ```_GoldParser.CurrentPosition``` as 0 based, and this is easily remedied.

The second problem is that a text editor as Notepad++ counts a tab for example as 4 symbols, but this can vary between editors and various settings. Thus, a strategy must be devised to deal with the issue in the future. 

<span style="color:green">For now, I have just fixed the 0 based part of the problem.</span>


<br>
### Links
[Back](/language/reference/versioning/v091/compiler091/)
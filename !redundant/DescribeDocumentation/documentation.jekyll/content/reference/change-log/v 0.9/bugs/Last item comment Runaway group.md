---
layout: page
title: Last item comment Runaway group
permalink: /language/reference/versioning/v09/bugs/bug-5/
exclude: true
---
<br>_BUG: Last item comment Runaway group_

<span style="color:red">When a file ends with a line comment we end up with a runaway group.</span>

This is remedied by adding a new line after the comment. 

This is most likely because there is no new line to end the comment group.

<span style="color:green">Added a single new line at the end of every text file when preprocessing - This is more of a work around, but if we are going to have a preprocessor method - string EncodeNonAsciiCharacters(string value), and this is the status quo for the moment, we better use it to easily solve our other issues.</span>


<br><br>
### Links
[Back](/language/reference/versioning/v09/compiler09/)
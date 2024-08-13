---
layout: page
title: AWS - Lambda memory
permalink: /language/reference/versioning/v094/bugs/todo-bug-1/
exclude: true
---
<br>_BUG: AWS - Lambda memory_

1. Sometimes the "dark arts" lists are gone, and we only have it as an item (leaf node) from the PUBLIC list, probably from the file "@public"

2. I have rigged the DescribeCompiler.AWS lambda function project so that with the returned JSON I get the invoking POST request body, as well as the resulted JSON to be returned.

3. I have unwrapped the invoking POST request body, and it contains the correct full source code for the "DarkArts.@darkArts" file. When I feed that body to the Mock Lambda Test Tool, I get the correct JSON. However, when I run the Lambda function on amazon servers, I get the incorrect JSON with the missing lists, which is also, obviously slorter in terms of length

4. I have discovered that the last 10 describe source files from my input haven't been parsed.
I believe that the allowed RAM for my lambda function is exceeded, so the compilation process gets cut short in some way

Tried increasing the available RAM in Visual studio and this worked for a while. When this stopped working I decreased the available RAM back and now it works again. Also, when cold-starting the Lambda function we don't experience this issue.


<br>
### Links
[Back](/language/reference/versioning/v094/compiler094/)
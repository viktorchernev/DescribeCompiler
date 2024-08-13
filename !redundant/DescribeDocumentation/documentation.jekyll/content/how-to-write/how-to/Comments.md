---
layout: page
title: Describe - Comments
permalink: /language/how-to-write-comments/
exclude: true
---
<br>Comments in describe are much like comments in C++ or C#, or other C type languages - we have single line comments, that start with two slashes and a space `// ` and end with a new line, and we also have the delimited type, starting with slash and a star - `/*` and ending with a star and a slash - `*/`. 

Note that, a colon before two forward slashes `://` will escape the comment. This is done because we want to be able to write links in text - `https://abc...` e.g. without the need to escape the forward slashes, which would be annoying. We can also escape the colon, if needed to have a comment - `\://`.


<span style="color:blue">_Example:_</span>
```
//our solar system
solar system ->

	rocky planets -> //innermost

		/* 1-st */ Mercury,
		/* 2-nd */ Venus,
		/* 3-rd */ Earth,
		/* 4-th */ Mars;

	gas giants ->

		Jupiter,
		Saturn;

	ice giants -> //outermost

		Uranus,
		Neptune;
```

<span style="color:green">_Note - Nesting of comments is not supported, as in most major programming languages._</span>

<br>
### Links
[Next](/language/how-to-write-links/)<br>
[Prev](/language/how-to-write-lists/)
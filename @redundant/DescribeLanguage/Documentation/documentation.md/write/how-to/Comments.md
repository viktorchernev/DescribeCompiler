---
layout: page
title: Describe - Comments
permalink: /language/comments/
exclude: true
---
Comments in describe are much like comments in C++ or C#, or other C type languages - we have single line comments, that start with two slashes ```//``` and end with a new line, and we also have the delimited type, starting with slash and a star - ```/*``` and ending with a star and a slash - ```*/```.

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

### Links
[Next](/language/links)<br>
[Prev](/language/lists)
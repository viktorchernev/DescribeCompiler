---
layout: page
title: Describe - Delimiter mode
permalink: /language/deprecated-delimiter-mode/
exclude: true
---
<br>The Delimiter mode directive has been deprecated, as a better way to achieve the same functionality has been found. 
Below is the original article.

A main point in the development of the Describe language is to make the experience as seamless as possible for the user, and one of the main ways to achieve this is by eliminating the need to use escape sequences as much as possible. However, we need to escape angle brackets, because of tags ```<tagid>```, square brackets, because of links ```[http://someurl.net/]```, curly brackets because of decorators ```{color|red}``` commas and semicolons - ```,```, ```;```, and this thing, called a production arrow - ```->```. So how to avoid the need to escape those characters?

Version 1.0 of the Describe language utilizes the precompiler and the ```delimiter-mode``` directive to do just that. Basically, we have two modes or flavors of the language - ```mono``` mode and ```bi``` mode. When we have simpler lists, we can write Describe code like usual in mono mode - we don't need to do anything, and we will need to escape the above-mentioned special characters as usual, but when we have more complex lists that might contain special characters we can toggle to bi mode, using the delimiter-mode directive. In bi mode, we need to double the brackets. We don't need to double the commas, semicolons and production arrows, in cases when we write those at the end of the line.<br><br>

<span style="color:blue">**_delimiter-mode directive_**</span><br>
```delimiter-mode <bi>```<br>
```delimiter-mode <2>```<br>
```delimiter-mode <mono>```<br>
```delimiter-mode <1>```<br><br>

<span style="color:blue">**_in "bi" mode brackets are doubled_**</span><br>
```<someid>``` is ```<<someid>>```<br>
```[http://someurl.net/]``` is ```[[http://someurl.net/]]```<br>
```{color|red}``` is ```{ {color|red} }```<br><br>


<span style="color:blue">**_Bi mode_** - Commas, production arrows and semicolons does not need to be escaped because they are at the end of the lines.</span><br>
```
directives ->
	verbosity <<high>>,
	namespace <<treeofall.public.unsorted>>,
	delimiter-mode <<2>>;


unsorted <<rnode>> ->

	Amount of sleep needed, by age 
	[[http://somelink.net]]
	<<amountSleepNeeded>>,
	
	christianity denominations 
	{{color|blue}} <<christianityDenominations>>,
	
	World's Fastest Cars 2023 <<fastestCars2023>>,
	personality types <<personalityTraits>>;
```

<span style="color:blue">**_Bi mode_** - One liner.</span><br>
```
directives ->
	verbosity <<high>>,
	namespace <<treeofall.public.unsorted>>,
	delimiter-mode <<2>>;


unsorted <<rnode>> ->> sleep,, religion,, cars;
```

<br>
### Links
[Next](/language/how-to-write/)
[Prev](/language/deprecated-slash-notation/)

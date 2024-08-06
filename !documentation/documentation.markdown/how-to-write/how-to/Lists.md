---
layout: page
title: Describe - Lists
permalink: /language/how-to-write-lists/
exclude: true
---
<br>At the core of the describe language are the lists. We write describe lists by writing the title, followed by a production arrow ```->```, followed by the elements of the list, delimited with commas```,```, and we end with a semicolon ```;``` after the last element. Elements (also called items) are often written on a new line and with indentation, as to enhance readability. Lists (also called productions) may also contain other lists (compound lists), instead of just items (simple lists), and can also be empty (empty lists).

Empty lists are treated like items. Creating empty lists is a way of putting a placeholder, like saying - "this should be a list, but I am yet to figure out the rest of it".

The other core feature of the describe language is the ability of those lists to come together to form larger and larger lists. This is done via Tags, which we will learn about a bit later on.<br><br>


<span style="color:blue">_Simple list:_</span>
```
solar system inner planets ->

	Mercury,
	Venus,
	Earth,
	Mars;
```
<br><br>
<span style="color:blue">_Compound list:_</span>
```
solar system ->

	rocky planets ->

		Mercury,
		Venus,
		Earth,
		Mars;

	gas giants ->

		Jupiter,
		Saturn;

	ice giants ->

		Uranus,
		Neptune;
```
<br><br>
<span style="color:blue">_Empty list:_</span>
```
dwarf planets ->;
```

<br>
### Links
[Next](/language/how-to-write-comments)<br>
[Prev](/language/how-to-write)

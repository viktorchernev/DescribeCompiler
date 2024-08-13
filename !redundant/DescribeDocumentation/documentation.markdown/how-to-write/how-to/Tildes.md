---
layout: page
title: Describe - Tilde inversions
permalink: /language/how-to-write-tildes/
exclude: true
---
<br>Tildes, aka "tilde inversions" or simply "inversions" are an alternative way to add data to an entry, without using decorators, as decorators are not suitable for long texts.  To write a tilde inversion, simply put a tilde symbol ```~``` in front of the entry that you wish to invert. The inverted entry is no longer part of the production, but refers solely to the head of the production now.


The example below illustrate how to use inversions. In the first example, we use inversions to add shorter versions to some items in a list, including the head. In the second example, we achieve the same with decorators:


<span style="color:blue">_Example (tilde inversions):_</span>
```
Harry Potter books ->
~ HP books <shorter>,

	Harry Potter and the Sorcerer's Stone - J. K. Rowling ->
	~ Harry Potter & The Sorcerer's Stone <shorter>,
	~ The Sorcerer's Stone <shorter>;

	Harry Potter and the Chamber of Secrets - J. K. Rowling ->
	~Harry Potter The Chamber of Secrets <shorter>,
	~Chamber of secrets <shorter>;
;

```
<span style="color:blue">_Example (decorators):_</span>
```
Harry Potter books
{shorter| HP books} ->

	Harry Potter and the Sorcerer's Stone - J. K. Rowling
	{shorter|Harry Potter & The Sorcerer's Stone}
	{shorter|The Sorcerer's Stone},

	Harry Potter and the Chamber of Secrets - J. K. Rowling
	{shorter | Harry Potter The Chamber of Secrets}
	{shorter | Chamber of secrets};

```

<br>
### Links
[Prev](/language/how-to-write-lists/)<br>
[Back](/language/how-to-write/)

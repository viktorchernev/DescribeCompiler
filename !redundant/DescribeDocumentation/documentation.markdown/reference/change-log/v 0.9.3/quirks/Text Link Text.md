---
layout: page
title: Text Link Text
permalink: /language/reference/versioning/v093/quirks/quirk-1/
exclude: true
---
<br>_QUIRK: Text Link Text_

When we have text, followed by a link and some other text, the second text is interpreted as second entry. This is with the current implementation and Describe v0.9 grammar.

```
list ->

	home ->

		MSG (15),
		shade for windows,
		komarnici for the summer,
		bathroom taps,
		hanging clothes organiser 2 sections [https://www.alo.bg/5613840] (25),
		bathroom aromatizer (3),
		mop with handle (10),
		electric fly swapper (10+5),
		bathroom hangers (25);
```
is red as:
```
list ->

	home ->

		MSG (15),
		shade for windows,
		komarnici for the summer,
		bathroom taps,
		hanging clothes organiser 2 sections [https://www.alo.bg/5613840] 

	(25),
	bathroom aromatizer (3),
	mop with handle (10),
	electric fly swapper (10+5),
	bathroom hangers (25);
```

<br>
### Links
[Back](/language/reference/versioning/v093/compiler093/)
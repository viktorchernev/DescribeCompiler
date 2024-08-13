---
layout: page
title: Star Comments
permalink: /language/reference/versioning/v091/bugs/bug-2/
exclude: true
---
<br>_BUG: Star Comments_

<span style="color:red">There is a bug related to star comments - we might be erroneously escaping the stars for example?</span>

<span style="color:green">Yes, we did that. In ```EncodeNonAsciiCharacters``` we forgot to check if star is prefixed by "/" forward slash to not escape it. The issue has been fixed.</span>

```
directives -> namespace <treeofall.private.job>;


May <may2023> ->


	WEEK 22 ->
	
		Monday 29 May ->;
		Tuesday 30 May ->
			-deal with Stanislav and shed folders;

		Wednesday 31 May ->;
		Thirsday 01 June ->;
		Friday 02 June ->;


	/* WEEK Template
	WEEK ->
	
		Monday ->;
		Tuesday ->;
		Wednesday ->;
		Thirsday ->;
		Friday ->;
	*/
```


<br>
### Links
[Back](/language/reference/versioning/v091/compiler091/)
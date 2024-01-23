---
layout: page
title: One letter bug
permalink: /v09/bugs/bug-6
exclude: true
---
_BUG: One letter bug_

<span style="color:red">If we have a single symbol that is a Text and is parsed as text chunk, then we have some escaped symbol that should be parsed as text chunk as well, we get an error. for example:</span>

```t-shirt```

This might be due to some bug in the grammar 

<span style="color:green">Yes, was a simple grammar bug:

```Text = {TextCharacter}{TextCharacter}+```

should be

```Text = {TextCharacter}+```

as '+' is 1 or more, not 0 or more</span>

---
layout: page
title: Empty production null reference
permalink: /language/reference/versioning/v09/bugs/bug-3/
exclude: true
---
<br>_BUG: Empty production null reference_

<span style="color:red">An empty production causes "Failed to Unfold the parse tree : Object reference not set to an instance of an object."</span>

```apples ->;```

<span style="color:green">Was a bug in private ```static string DoExpression(DescribeUnfold u, Reduction r)```  - in Optimizations</span>


<br><br>
### Links
[Back](/language/reference/versioning/v09/compiler09/)
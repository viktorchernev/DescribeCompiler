---
layout: page
title: Redefinition bug
permalink: /language/reference/versioning/v09/bugs/bug-7/
exclude: true
---
<br>_BUG: Redefinition bug_

<span style="color:red">When same item is used in 2 productions (aka redefinition), we get "Failed to Unfold the parse tree : An item with the same key has already been added." This can be handled better, and the item key and file should be outputted in the error message.</span>

<span style="color:green">Code has been added to better highlight the source of the error, showing which item in which namespace caused the collision, and also the source file the collision is in. The code is in Optimizations - ```string DoExpression(DescribeUnfold u, Reduction r)```</span>


<br><br>
### Links
[Back](/language/reference/versioning/v09/compiler09/)
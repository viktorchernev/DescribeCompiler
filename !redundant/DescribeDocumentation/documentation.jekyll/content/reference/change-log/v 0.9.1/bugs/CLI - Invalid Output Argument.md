---
layout: page
title: CLI - Invalid Output Argument
permalink: /language/reference/versioning/v091/bugs/bug-1/
exclude: true
---
<br>_BUG: CLI - Invalid Output Argument_

<span style="color:red">When provided with invalid output path by the user, the CLI app will compile all the source and then throw an unhandled exception.</span>

The compiler must show proper error and not proceeding to compile anything at all. 

<span style="color:green">Code has been added to fix the issue.</span>

Bug was uncovered during testing of various invalid CLI arguments.


<br>
### Links
[Back](/language/reference/versioning/v091/compiler091/)
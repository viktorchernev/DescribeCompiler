---
layout: page
title: Warnings
permalink: /language/reference/versioning/v094/warnings/
exclude: true
---
<br>_Warnings to keep in mind in Describe Compiler v0.9.4_

### Grammar tests

<span style="color:#00CED1">In the grammar tests for version 1.0 Official the delimiter-mode directives are missing.
This will result in errors in testing</span>

```
directives ->> delimiter-mode <<bi>>;;
```

<br>
### Links
[Back](/language/reference/versioning/v094/compiler094/)
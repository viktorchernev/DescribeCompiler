---
layout: page
title: Single digits in timestamp
permalink: /v092/bugs/bug-4
exclude: true
---
_BUG: Single digits in timestamp_

<span style="color:red">In the output JSON, in the timestamp, we get time with no trailing zeroes:</span>

```
Built on 20 June 2023, 2:1:42.270 (UTC)
Built with Describe Compiler version 0.9.2
```
This should read instead:
```
Built on 20 June 2023, 02:01:42.270 (UTC)
Built with Describe Compiler version 0.9.2
```
<span style="color:green">Issue has been fixed.</span>

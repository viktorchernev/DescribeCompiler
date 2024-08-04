---
layout: page
title: Press any key after parse
permalink: /v093/bugs/bug-2
exclude: true
---
_BUG: Press any key after parse_

<span style="color:red">Should show "press any key to exit" after a successful parse operation. It is not shown after parsing a folder, to be precise.</span>

```
parse-folder "C:\Users\Viktor Chernev\Desktop\dbs\2023.12.12-200906461\Public\files" "C:\Users\Viktor Chernev\Desktop\testResult.json" translator="JSON" verbosity=low dsonly toponly=false onerror=ignore
```
```
parse-file "C:\Users\Viktor Chernev\Desktop\dbs\2023.12.12-200906461\Public\files@public.ds" "C:\Users\Viktor Chernev\Desktop\testResult.json" translator="JSON" verbosity=low
```

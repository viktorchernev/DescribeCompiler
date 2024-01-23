---
layout: page
title: CLI - Save log to a file
permalink: /v092/features/feature-2
exclude: true
---
_FEATURE: CLI - Save log to a file_

<span style="color:blue">Added a Log property in Messages that accumulates all the logging and can be saved to a file. If we use the flag ```logfile=LOG_PATH``` we do that in Program</span>

```
internal static string Log
{
	get;
	private set;
}
```

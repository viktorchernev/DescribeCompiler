---
layout: page
title: CLI CORE - Cannot read console keys
permalink: /v094/bugs/bug-1
exclude: true
---
_BUG: CLI CORE - Cannot read console keys_

<span style="color:red">We get an exception upon starting the APP:
```
System.InvalidOperationException: 'Cannot read keys when either application does not have a console or when console input has been redirected. Try Console.Read.'
```
</span>


<span style="color:green">Code has been added to fix the issue:</span>

```
Console.ReadKey();
```
changed to 
```
Console.Read();
```

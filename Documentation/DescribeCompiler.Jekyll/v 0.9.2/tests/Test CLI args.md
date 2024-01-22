---
layout: page
title: Test CLI args
permalink: /v092/tests/test-1
exclude: true
---
_TEST: Test CLI args_

1. help
```
-h
help
```
2. ext
```
ext
ext "C:\Users\Viktor Chernev\Desktop\docs-scratch"
```
3. extone
```
extone
extone RANDOM_STUFF
extone JSON_COMMONER
extone JSON_COMMONER "C:\Users\Viktor Chernev\Desktop\docs-scratch"
```
4. parse-file
```
parse-file "C:\Users\Viktor Chernev\Desktop\docs-scratch" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result"
parse-file "C:\Users\Viktor Chernev\Desktop\docs-scratch\technologiesAndInventions.ds" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.html"
parse-file "C:\Users\Viktor Chernev\Desktop\docs-scratch\technologiesAndInventions.ds" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER"
parse-file "C:\Users\Viktor Chernev\Desktop\docs-scratch\technologiesAndInventions.ds" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template=JSON_COMMONER
parse-file "C:\Users\Viktor Chernev\Desktop\docs-scratch\technologiesAndInventions.ds" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.html" template="C:\Users\Viktor Chernev\Desktop\docs-scratch\Templates\HTML_PARACORD"
parse-file "C:\Users\Viktor Chernev\Desktop\docs-scratch\technologiesAndInventions.ds" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=l
parse-file "C:\Users\Viktor Chernev\Desktop\docs-scratch\technologiesAndInventions.ds" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=m
parse-file "C:\Users\Viktor Chernev\Desktop\docs-scratch\technologiesAndInventions.ds" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=h
parse-file "C:\Users\Viktor Chernev\Desktop\docs-scratch\technologiesAndInventions.ds" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=low
parse-file "C:\Users\Viktor Chernev\Desktop\docs-scratch\technologiesAndInventions.ds" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=medium
parse-file "C:\Users\Viktor Chernev\Desktop\docs-scratch\technologiesAndInventions.ds" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=high
parse-file "C:\Users\Viktor Chernev\Desktop\docs-scratch\technologiesAndInventions.ds" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" log-verbosity=high
parse-file "C:\Users\Viktor Chernev\Desktop\docs-scratch\technologiesAndInventions.ds" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=high logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch\last-log.txt"
parse-file "C:\Users\Viktor Chernev\Desktop\docs-scratch\technologiesAndInventions.ds" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=high logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch\" - //there is a bug in visual studio I think where if your path in the command line parameter is in parentheses and ends with a backslash, it is treated as an escaped backslash
parse-file "C:\Users\Viktor Chernev\Desktop\docs-scratch\technologiesAndInventions.ds" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=high logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch"
parse-file "C:\Users\Viktor Chernev\Desktop\docs-scratch\technologiesAndInventions.ds" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=high artifacts=m logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch"
parse-file "C:\Users\Viktor Chernev\Desktop\docs-scratch\technologiesAndInventions.ds" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=high artifacts=t logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch"
parse-file "C:\Users\Viktor Chernev\Desktop\docs-scratch\technologiesAndInventions.ds" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=high artifacts=u logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch"
parse-file "C:\Users\Viktor Chernev\Desktop\docs-scratch\technologiesAndInventions.ds" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=high artifacts=n logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch"
parse-file "C:\Users\Viktor Chernev\Desktop\docs-scratch\technologiesAndInventions.ds" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=high artifacts=makeonly logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch"
parse-file "C:\Users\Viktor Chernev\Desktop\docs-scratch\technologiesAndInventions.ds" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=high artifacts=takeonly logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch"
parse-file "C:\Users\Viktor Chernev\Desktop\docs-scratch\technologiesAndInventions.ds" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=high artifacts=use logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch"
parse-file "C:\Users\Viktor Chernev\Desktop\docs-scratch\technologiesAndInventions.ds" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=high artifacts=no logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch"
```
5. parse-folder
```
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.html" 
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER"
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestD" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.html" template="C:\Users\Viktor Chernev\Desktop\docs-scratch\Templates\JSON_COMMONER"
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.html" template="C:\Users\Viktor Chernev\Desktop\docs-scratch\Templates\JSON_COMMONER"
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=l
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=low
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=m
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=medium
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=h
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=high
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=high logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch\last-log.txt"
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=low logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch\last-log.txt" artifacts=m
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=low logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch\last-log.txt" artifacts=t
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=low logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch\last-log.txt" artifacts=u
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=low logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch\last-log.txt" artifacts=n
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=low logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch\last-log.txt" artifacts=makeonly artifacts-path=""
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=low logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch\last-log.txt" artifacts=takeonly artifacts-path=
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=low logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch\last-log.txt" artifacts=use artifacts-path="C:\Users\Viktor Chernev\Desktop\docs-scratch\aaaa"
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=low logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch\last-log.txt" artifacts=no artifacts-path="C:\Users\Viktor Chernev\Desktop\docs-scratch"
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=low logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch\last-log.txt" dsonly
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=low logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch\last-log.txt" dsonly=true
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=low logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch\last-log.txt" dsonly=false
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=low logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch\last-log.txt" dsonly toponly
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=low logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch\last-log.txt" dsonly toponly=true
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=low logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch\last-log.txt" dsonly toponly=false
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=low logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch\last-log.txt" dsonly toponly=false onerror=stop
parse-folder "C:\Users\Viktor Chernev\Desktop\docs-scratch\TestData" "C:\Users\Viktor Chernev\Desktop\docs-scratch\result.json" template="JSON_COMMONER" verbosity=low logfile="C:\Users\Viktor Chernev\Desktop\docs-scratch\last-log.txt" dsonly toponly=false onerror=ignore
```

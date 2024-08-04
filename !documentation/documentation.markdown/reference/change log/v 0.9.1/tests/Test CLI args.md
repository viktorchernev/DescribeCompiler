---
layout: page
title: Test CLI args
permalink: /v091/tests/test-1
exclude: true
---
_TEST: Test CLI args_

1. default
```
"C:\Users\Viktor Chernev\Desktop\DataLists\Lists" verbosity=l "C:\Users\Viktor Chernev\Desktop\sss.html"
```
2. help
```
help
```
3. Valid in path, Valid out path
```
"C:\Users\Viktor Chernev\Desktop\DataLists\Lists" "C:\Users\Viktor Chernev\Desktop\sss.html"
```
4. Invalid in path, Valid out path
```
"C:\Users\Viktor Chernev\Desktop\DataLists\Lists" "C:\Users\xxx\Desktop\sss.html"
```
5. Valid in path, Invalid out path
```
"C:\Users\Viktor Chernev\Desktop\DataLists\Lists" "C:\Users\xxx\Desktop\sss.html"
```
6. Valid verbosity
```
a) "C:\Users\Viktor Chernev\Desktop\DataLists\Lists" verbosity=l "C:\Users\Viktor Chernev\Desktop\sss.html"
b) "C:\Users\Viktor Chernev\Desktop\DataLists\Lists" verbosity=low "C:\Users\Viktor Chernev\Desktop\sss.html"
c) "C:\Users\Viktor Chernev\Desktop\DataLists\Lists" verbosity=m "C:\Users\Viktor Chernev\Desktop\sss.html"
d) "C:\Users\Viktor Chernev\Desktop\DataLists\Lists" verbosity=medium "C:\Users\Viktor Chernev\Desktop\sss.html"
e) "C:\Users\Viktor Chernev\Desktop\DataLists\Lists" verbosity=h "C:\Users\Viktor Chernev\Desktop\sss.html"
f) "C:\Users\Viktor Chernev\Desktop\DataLists\Lists" verbosity=high "C:\Users\Viktor Chernev\Desktop\sss.html"
```
7. Valid verbosity CAPS
```
a) "C:\Users\Viktor Chernev\Desktop\DataLists\Lists" VERBOSITY=m "C:\Users\Viktor Chernev\Desktop\sss.html"
b) "C:\Users\Viktor Chernev\Desktop\DataLists\Lists" VERBOSITY=medium "C:\Users\Viktor Chernev\Desktop\sss.html"
c) "C:\Users\Viktor Chernev\Desktop\DataLists\Lists" verbosity=H "C:\Users\Viktor Chernev\Desktop\sss.html"
d) "C:\Users\Viktor Chernev\Desktop\DataLists\Lists" verbosity=HIGH "C:\Users\Viktor Chernev\Desktop\sss.html"
```
8. Invalid verbosity
```
"C:\Users\Viktor Chernev\Desktop\DataLists\Lists" verbosity=z "C:\Users\Viktor Chernev\Desktop\sss.html"
```
9. Invalid number of arguments by white space
```
C:\Users\Viktor Chernev\Desktop\DataLists\Lists
```

---
layout: page
title: Custom decorator for JSON translator
permalink: /v092/features/feature-5
exclude: true
---
_FEATURE: Custom decorator for JSON translator_

This is essentially a way to use decorators that are not implemented in the translator. Use the template for a custom decorator, and implemented the functionality in the front end instead.

```
{custom|NAME}
{custom|NAME|VALUE}
```
This feature has been added to the JSON_COMMONER set and the inbuilt JSON translator. There is a field "decorators" in all the appropriate templates (ones that have links). Below are 2 examples of the resulting JSON. Decorators declared as custom decorators will be in the "decorators" object in the JSON:
```
"decorators":[
    "{NAME}":"",
    "{NAME}":"",
    "{NAME}":"",
    ...
]
```
or
```
"decorators":[
    "{NAME}":"{VALUE}",
    "{NAME}":"{VALUE}",
    "{NAME}":"{VALUE}",
    ...
]
```
<span style="color:blue">Code has been implemented.</span>

This is yet to be added to the HTML translator in the future, but how will those decorators be added to the HTML tags? Probably as class names or some kind of attributes?

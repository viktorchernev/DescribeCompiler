---
layout: page
title: Describe - Decorators
permalink: /language/how-to-write-decorators/
exclude: true
---
<br>Decorators are basically some text enclosed in curly brackets - ```{``` and ```}```. Decorators are used to add different kinds of data to items - weather it is an instruction to change the color of the item, add particular icon image or transform the decorated item in some other fashion. Decorators can either be simple ones, consisting of just a key, or complex ones, consisting of a key and a value, delimited by a pipe symbol ```|```. 

A list of decorators and instructions for their use follows. However, in the Describe language grammar, a decorator is just some text in curly brackets. What a particular decorator will do is implemented in the particular translator, and if users are developing their own translators, they are free to implement their own decorators.

* <span style="color:blue">**_empty_** ```{empty}```</span><br>
The empty entry decorator is a simple decorator used to create empty entries. Those empty entries essentially act as new lines in lists. This decorator cannot be applied on an item that is a head of a production.

* <span style="color:blue">**_comment_** ```{comment}```</span><br>
The comment decorator is a simple decorator used to make an entry green and italicized.

* <span style="color:blue">**_nlcomment_** ```{nlcomment}```</span><br>
The nlcomment decorator is the same as the comment decorator, but adds an empty entry before the decorated entry, if the decorated entry is not the first in the list.

* <span style="color:blue">**_color_** ```{color|VALUE}```</span><br>
The color decorator is a complex one, and is used for setting the fore-color of the text of the item it is applied to. VALUE is any CSS compatible color - either in the hex notation #1234AA or a named color like limegreen.

* <span style="color:blue">**_bgcolor_** ```{bgcolor|VALUE}```</span><br>
The bgcolor decorator is a complex one, and is used for setting the back-color of the text of the item it is applied to. VALUE is any CSS compatible color - either in the hex notation #1234AA or a named color like limegreen.

* <span style="color:blue">**_bold_** ```{bold}```</span><br>
The bold decorator is a simple decorator used to make an entry bold.

* <span style="color:blue">**_italic_** ```{italic}```</span><br>
The italic decorator is a simple decorator used to make an entry italicized.

* <span style="color:blue">**_underline_** ```{underline}```</span><br>
The underline decorator is a simple decorator used to make an entry underlined.

* <span style="color:blue">**_striked_** ```{striked}```</span><br>
The striked decorator is a simple decorator used to add the strike-through CSS effect to an entry.

* <span style="color:blue">**_style_** ```{style|VALUE}```</span><br>
The style decorator is a complex decorator used with HTML translators to provide CSS for an entry. Value is a valid CSS string that goes in the style attribute of some item like ```<li>``` or ```<span>```.

* <span style="color:blue">**_custom_** ```{custom|NAME}```</span><br>
The custom decorator is a way to add a user defined decorator. How this is handled depends on the translator implementing it.

* <span style="color:blue">**_custom_** ```{custom|NAME|VALUE}```</span><br>
The custom decorator is a way to add a user defined decorator with a value. How this is handled depends on the translator implementing it.

* <span style="color:orange">**_*enlist_** ```{enlist|VALUE}``` *EXPERIMENTAL</span><br>
The enlist decorator is the list-creating aka placement decorator. It puts an entry in a sibling list. For example ```entry {enlist | refs}``` will create a sibling list ```refs``` and put the entry in it. ```entry {enlist | legend}``` will create a sibling list ```legend``` and put the entry in it.


<span style="color:blue">_Using decorators:_</span>
```
types of documentaries ->

	history {comment},
	Ancient Rome documentaries,
	Ancient Egypt documentaries,
	
	gap {empty},
	engineering {comment},
	Space Race documentaries {color|orange},
	Aerospace Engineering documentaries {color|#4287f5},
	Mechanical Engineering documentaries {color|#42F5E3},
	Biological Engineering {color|#ad6};
```

<span style="color:blue">_Using decorators (added comments):_</span>
```
//decorators example
types of documentaries ->

	history {comment}, //comment entry
	Ancient Rome documentaries,
	Ancient Egypt documentaries,
	
	gap {empty}, //empry entry
	engineering {comment}, //comment entry
	Space Race documentaries {color|orange}, //colored - named color
	Aerospace Engineering documentaries {color|#4287f5}, //colored - hex
	Mechanical Engineering documentaries {color|#42F5E3}, //colored - hex
	Biological Engineering {color|#ad6}; //colored - hex
```

<br>
### Links
[Next](/language/how-to-write-tags/)<br>
[Prev](/language/how-to-write-links/)

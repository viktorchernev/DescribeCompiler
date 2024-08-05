---
layout: page
title: Same id
permalink: /v092/bugs/bug-3
exclude: true
---
_BUG: Same id_

<span style="color:red">In the following source file the ```gap {empty}``` entry has been translated to have the same id as ```PRIVATE``` - that is ```treeofall.private.rnode```</span>

```
//"Lists/Private/@private.ds"
directives -> 
	namespace <treeofall.private>;


PRIVATE <rnode> ->

	health <.health.rnode>, 						//manage body
	cleaning <.cleaning.rnode>,						//manage environment
	fund management <.finance.rnode>,				//manage money
	stockpiling <.stockpiling.rnode>,				//manage stockpiles
	admin <.admin.rnode>,							//manage data
	work <.job.rnode>,								//manage job

	gap {empty},
	make sure <.makeSure.rnode>,
	projects <.projects.rnode>,
	ideas <.ideas.rnode>;
```

<span style="color:green">```EmptyItemTemplate``` in ```JsonTranslator``` mistakenly contains an ```{ID}``` socket that later gets replaced with the id of its parent production. Then, in the web page, in JavaScript we read it and override the legitimate value of the production title (branch item). Issue has been fixed.</span>

Cannot be parsed without preprocessing by the Describe Compiler preprocessor
========================================
Source Code (between the arrows)
========================================

🡆платове <ФЛГмссД5> ->

	вълнени платове <ПеП0ТхЗй>,
	памучни платове <ПТъЗАфЪа>,
	копринени платове <5Суак3ИЙ>,
	синтетични платове <ЛКтрт5КН>;🡄

========================================
Preprocessed (between the arrows)
========================================

🡆&#x043f\;&#x043b\;&#x0430\;&#x0442\;&#x043e\;&#x0432\;&#x0435\; <&#x0424\;&#x041b\;&#x0413\;&#x043c\;&#x0441\;&#x0441\;&#x0414\;5> ->

	&#x0432\;&#x044a\;&#x043b\;&#x043d\;&#x0435\;&#x043d\;&#x0438\; &#x043f\;&#x043b\;&#x0430\;&#x0442\;&#x043e\;&#x0432\;&#x0435\; <&#x041f\;&#x0435\;&#x041f\;0&#x0422\;&#x0445\;&#x0417\;&#x0439\;>,
	&#x043f\;&#x0430\;&#x043c\;&#x0443\;&#x0447\;&#x043d\;&#x0438\; &#x043f\;&#x043b\;&#x0430\;&#x0442\;&#x043e\;&#x0432\;&#x0435\; <&#x041f\;&#x0422\;&#x044a\;&#x0417\;&#x0410\;&#x0444\;&#x042a\;&#x0430\;>,
	&#x043a\;&#x043e\;&#x043f\;&#x0440\;&#x0438\;&#x043d\;&#x0435\;&#x043d\;&#x0438\; &#x043f\;&#x043b\;&#x0430\;&#x0442\;&#x043e\;&#x0432\;&#x0435\; <5&#x0421\;&#x0443\;&#x0430\;&#x043a\;3&#x0418\;&#x0419\;>,
	&#x0441\;&#x0438\;&#x043d\;&#x0442\;&#x0435\;&#x0442\;&#x0438\;&#x0447\;&#x043d\;&#x0438\; &#x043f\;&#x043b\;&#x0430\;&#x0442\;&#x043e\;&#x0432\;&#x0435\; <&#x041b\;&#x041a\;&#x0442\;&#x0440\;&#x0442\;5&#x041a\;&#x041d\;>;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  +--<item> ::= <text> <tag>
|  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--&#x043f
|  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--&#x043b
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--&#x0430
|  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  +--&#x0442
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x043e
|  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0432
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0435
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  +--<
|  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--&#x0424
|  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--&#x041b
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  +--&#x0413
|  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x043c
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0441
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0441
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0414
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--5
|  |  |  |  +-->
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  +--<item> ::= <text> <tag>
|  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    &#x0432
|  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--&#x044a
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  +--&#x043b
|  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x043d
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0435
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x043d
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0438
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +-- &#x043f
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x043b
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0430
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0442
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x043e
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0432
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0435
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--&#x041f
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--&#x0435
|  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  +--&#x041f
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--0&#x0422
|  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0445
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0417
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0439
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  +-->
|  |  |  +--,
|  |  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    &#x043f
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--&#x0430
|  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  +--&#x043c
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0443
|  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0447
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x043d
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0438
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +-- &#x043f
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x043b
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0430
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0442
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x043e
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0432
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0435
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--&#x041f
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  +--&#x0422
|  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x044a
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0417
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0410
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0444
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x042a
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0430
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  +-->
|  |  |  |  +--,
|  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--    &#x043a
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  +--&#x043e
|  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x043f
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0440
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0438
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x043d
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0435
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x043d
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0438
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +-- &#x043f
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x043b
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0430
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0442
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x043e
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0432
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0435
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--5&#x0421
|  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  +--&#x0443
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0430
|  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x043a
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--3&#x0418
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0419
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  +-->
|  |  |  |  |  +--,
|  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--    &#x0441
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  +--&#x0438
|  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x043d
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0442
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0435
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0442
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0438
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0447
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x043d
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0438
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +-- &#x043f
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x043b
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0430
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0442
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x043e
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0432
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0435
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--&#x041b
|  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  +--&#x041a
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0442
|  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0440
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x0442
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--5&#x041a
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--&#x041d
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeTerminator
|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  +--\;
|  |  |  |  |  |  |  +-->
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                    Description                                                             
---------------   -----   -----   -----   ----------------------------   ------------------------------------------------------------------------
Token Read            0       0       0   &#x043f                        Token type: Text                                                        
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       0       7   \;                             Token type: EscapeTerminator                                            
Reduce               18                   (1) ::= &#x043f                <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       0       9   &#x043b                        Token type: Text                                                        
Reduce               27                   (2) ::= \;                     <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       0      16   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (3) ::= &#x043b                <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       0      18   &#x0430                        Token type: Text                                                        
Reduce               27                   (4) ::= \;                     <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       0      25   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (5) ::= &#x0430                <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       0      27   &#x0442                        Token type: Text                                                        
Reduce               27                   (6) ::= \;                     <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       0      34   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (7) ::= &#x0442                <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       0      36   &#x043e                        Token type: Text                                                        
Reduce               27                   (8) ::= \;                     <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       0      43   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (9) ::= &#x043e                <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       0      45   &#x0432                        Token type: Text                                                        
Reduce               27                   (10) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       0      52   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (11) ::= &#x0432               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       0      54   &#x0435                        Token type: Text                                                        
Reduce               27                   (12) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       0      61   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (13) ::= &#x0435               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       0      64   <                              Token type: LeftArrow                                                   
Reduce               27                   (14) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Reduce               28                   (15) ::= (13) (14)             <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               28                   (16) ::= (12) (15)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (17) ::= (11) (16)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (18) ::= (10) (17)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (19) ::= (9) (18)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (20) ::= (8) (19)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (21) ::= (7) (20)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (22) ::= (6) (21)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (23) ::= (5) (22)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (24) ::= (4) (23)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (25) ::= (3) (24)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (26) ::= (2) (25)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               19                   (27) ::= (1) (26)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (28) ::= (27)                  <text> ::= <text-chunk-list>                                            
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       0      65   &#x0424                        Token type: Text                                                        
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       0      72   \;                             Token type: EscapeTerminator                                            
Reduce               18                   (29) ::= &#x0424               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       0      74   &#x041b                        Token type: Text                                                        
Reduce               27                   (30) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       0      81   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (31) ::= &#x041b               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       0      83   &#x0413                        Token type: Text                                                        
Reduce               27                   (32) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       0      90   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (33) ::= &#x0413               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       0      92   &#x043c                        Token type: Text                                                        
Reduce               27                   (34) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       0      99   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (35) ::= &#x043c               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       0     101   &#x0441                        Token type: Text                                                        
Reduce               27                   (36) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       0     108   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (37) ::= &#x0441               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       0     110   &#x0441                        Token type: Text                                                        
Reduce               27                   (38) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       0     117   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (39) ::= &#x0441               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       0     119   &#x0414                        Token type: Text                                                        
Reduce               27                   (40) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       0     126   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (41) ::= &#x0414               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       0     128   5                              Token type: Text                                                        
Reduce               27                   (42) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       0     129   >                              Token type: RightArrow                                                  
Reduce               27                   (43) ::= 5                     <text-chunk> ::= Text                                                   
Reduce               28                   (44) ::= (42) (43)             <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               28                   (45) ::= (41) (44)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (46) ::= (40) (45)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (47) ::= (39) (46)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (48) ::= (38) (47)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (49) ::= (37) (48)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (50) ::= (36) (49)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (51) ::= (35) (50)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (52) ::= (34) (51)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (53) ::= (33) (52)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (54) ::= (32) (53)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (55) ::= (31) (54)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (56) ::= (30) (55)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               19                   (57) ::= (29) (56)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               20                   (58) ::= (57)                  <text> ::= <text-chunk-list>                                            
Shift                29                                                  The parser shifted to state 29                                          
Token Read           29       0     131   -                              Token type: Hyphen                                                      
Reduce               26                   (59) ::= < (58) >              <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               14                   (60) ::= (28) (59)             <item> ::= <text> <tag>                                                 
Shift                23                                                  The parser shifted to state 23                                          
Token Read           23       0     132   >                              Token type: RightArrow                                                  
Shift                30                                                  The parser shifted to state 30                                          
Token Read           30       2       0       &#x0432                    Token type: Text                                                        
Reduce               24                   (61) ::= - >                   <producer> ::= Hyphen RightArrow                                        
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       2      11   \;                             Token type: EscapeTerminator                                            
Reduce               18                   (62) ::=     &#x0432           <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2      13   &#x044a                        Token type: Text                                                        
Reduce               27                   (63) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       2      20   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (64) ::= &#x044a               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2      22   &#x043b                        Token type: Text                                                        
Reduce               27                   (65) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       2      29   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (66) ::= &#x043b               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2      31   &#x043d                        Token type: Text                                                        
Reduce               27                   (67) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       2      38   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (68) ::= &#x043d               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2      40   &#x0435                        Token type: Text                                                        
Reduce               27                   (69) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       2      47   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (70) ::= &#x0435               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2      49   &#x043d                        Token type: Text                                                        
Reduce               27                   (71) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       2      56   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (72) ::= &#x043d               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2      58   &#x0438                        Token type: Text                                                        
Reduce               27                   (73) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       2      65   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (74) ::= &#x0438               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2      67    &#x043f                       Token type: Text                                                        
Reduce               27                   (75) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       2      75   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (76) ::=  &#x043f              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2      77   &#x043b                        Token type: Text                                                        
Reduce               27                   (77) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       2      84   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (78) ::= &#x043b               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2      86   &#x0430                        Token type: Text                                                        
Reduce               27                   (79) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       2      93   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (80) ::= &#x0430               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2      95   &#x0442                        Token type: Text                                                        
Reduce               27                   (81) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       2     102   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (82) ::= &#x0442               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2     104   &#x043e                        Token type: Text                                                        
Reduce               27                   (83) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       2     111   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (84) ::= &#x043e               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2     113   &#x0432                        Token type: Text                                                        
Reduce               27                   (85) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       2     120   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (86) ::= &#x0432               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2     122   &#x0435                        Token type: Text                                                        
Reduce               27                   (87) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       2     129   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (88) ::= &#x0435               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2     132   <                              Token type: LeftArrow                                                   
Reduce               27                   (89) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Reduce               28                   (90) ::= (88) (89)             <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               28                   (91) ::= (87) (90)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (92) ::= (86) (91)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (93) ::= (85) (92)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (94) ::= (84) (93)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (95) ::= (83) (94)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (96) ::= (82) (95)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (97) ::= (81) (96)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (98) ::= (80) (97)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (99) ::= (79) (98)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (100) ::= (78) (99)            <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (101) ::= (77) (100)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (102) ::= (76) (101)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (103) ::= (75) (102)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (104) ::= (74) (103)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (105) ::= (73) (104)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (106) ::= (72) (105)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (107) ::= (71) (106)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (108) ::= (70) (107)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (109) ::= (69) (108)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (110) ::= (68) (109)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (111) ::= (67) (110)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (112) ::= (66) (111)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (113) ::= (65) (112)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (114) ::= (64) (113)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (115) ::= (63) (114)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               19                   (116) ::= (62) (115)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (117) ::= (116)                <text> ::= <text-chunk-list>                                            
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       2     133   &#x041f                        Token type: Text                                                        
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       2     140   \;                             Token type: EscapeTerminator                                            
Reduce               18                   (118) ::= &#x041f              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2     142   &#x0435                        Token type: Text                                                        
Reduce               27                   (119) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       2     149   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (120) ::= &#x0435              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2     151   &#x041f                        Token type: Text                                                        
Reduce               27                   (121) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       2     158   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (122) ::= &#x041f              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2     160   0&#x0422                       Token type: Text                                                        
Reduce               27                   (123) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       2     168   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (124) ::= 0&#x0422             <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2     170   &#x0445                        Token type: Text                                                        
Reduce               27                   (125) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       2     177   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (126) ::= &#x0445              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2     179   &#x0417                        Token type: Text                                                        
Reduce               27                   (127) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       2     186   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (128) ::= &#x0417              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2     188   &#x0439                        Token type: Text                                                        
Reduce               27                   (129) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       2     195   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (130) ::= &#x0439              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2     197   >                              Token type: RightArrow                                                  
Reduce               27                   (131) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Reduce               28                   (132) ::= (130) (131)          <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               28                   (133) ::= (129) (132)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (134) ::= (128) (133)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (135) ::= (127) (134)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (136) ::= (126) (135)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (137) ::= (125) (136)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (138) ::= (124) (137)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (139) ::= (123) (138)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (140) ::= (122) (139)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (141) ::= (121) (140)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (142) ::= (120) (141)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (143) ::= (119) (142)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               19                   (144) ::= (118) (143)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               20                   (145) ::= (144)                <text> ::= <text-chunk-list>                                            
Shift                29                                                  The parser shifted to state 29                                          
Token Read           29       2     198   ,                              Token type: Separator                                                   
Reduce               26                   (146) ::= < (145) >            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (147) ::= (117) (146)          <item> ::= <text> <tag>                                                 
Shift                39                                                  The parser shifted to state 39                                          
Token Read           39       3       0       &#x043f                    Token type: Text                                                        
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       3      11   \;                             Token type: EscapeTerminator                                            
Reduce               18                   (148) ::=     &#x043f          <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3      13   &#x0430                        Token type: Text                                                        
Reduce               27                   (149) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       3      20   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (150) ::= &#x0430              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3      22   &#x043c                        Token type: Text                                                        
Reduce               27                   (151) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       3      29   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (152) ::= &#x043c              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3      31   &#x0443                        Token type: Text                                                        
Reduce               27                   (153) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       3      38   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (154) ::= &#x0443              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3      40   &#x0447                        Token type: Text                                                        
Reduce               27                   (155) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       3      47   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (156) ::= &#x0447              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3      49   &#x043d                        Token type: Text                                                        
Reduce               27                   (157) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       3      56   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (158) ::= &#x043d              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3      58   &#x0438                        Token type: Text                                                        
Reduce               27                   (159) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       3      65   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (160) ::= &#x0438              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3      67    &#x043f                       Token type: Text                                                        
Reduce               27                   (161) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       3      75   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (162) ::=  &#x043f             <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3      77   &#x043b                        Token type: Text                                                        
Reduce               27                   (163) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       3      84   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (164) ::= &#x043b              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3      86   &#x0430                        Token type: Text                                                        
Reduce               27                   (165) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       3      93   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (166) ::= &#x0430              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3      95   &#x0442                        Token type: Text                                                        
Reduce               27                   (167) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       3     102   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (168) ::= &#x0442              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3     104   &#x043e                        Token type: Text                                                        
Reduce               27                   (169) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       3     111   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (170) ::= &#x043e              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3     113   &#x0432                        Token type: Text                                                        
Reduce               27                   (171) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       3     120   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (172) ::= &#x0432              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3     122   &#x0435                        Token type: Text                                                        
Reduce               27                   (173) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       3     129   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (174) ::= &#x0435              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3     132   <                              Token type: LeftArrow                                                   
Reduce               27                   (175) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Reduce               28                   (176) ::= (174) (175)          <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               28                   (177) ::= (173) (176)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (178) ::= (172) (177)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (179) ::= (171) (178)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (180) ::= (170) (179)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (181) ::= (169) (180)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (182) ::= (168) (181)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (183) ::= (167) (182)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (184) ::= (166) (183)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (185) ::= (165) (184)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (186) ::= (164) (185)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (187) ::= (163) (186)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (188) ::= (162) (187)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (189) ::= (161) (188)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (190) ::= (160) (189)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (191) ::= (159) (190)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (192) ::= (158) (191)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (193) ::= (157) (192)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (194) ::= (156) (193)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (195) ::= (155) (194)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (196) ::= (154) (195)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (197) ::= (153) (196)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (198) ::= (152) (197)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (199) ::= (151) (198)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (200) ::= (150) (199)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (201) ::= (149) (200)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               19                   (202) ::= (148) (201)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (203) ::= (202)                <text> ::= <text-chunk-list>                                            
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       3     133   &#x041f                        Token type: Text                                                        
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       3     140   \;                             Token type: EscapeTerminator                                            
Reduce               18                   (204) ::= &#x041f              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3     142   &#x0422                        Token type: Text                                                        
Reduce               27                   (205) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       3     149   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (206) ::= &#x0422              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3     151   &#x044a                        Token type: Text                                                        
Reduce               27                   (207) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       3     158   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (208) ::= &#x044a              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3     160   &#x0417                        Token type: Text                                                        
Reduce               27                   (209) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       3     167   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (210) ::= &#x0417              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3     169   &#x0410                        Token type: Text                                                        
Reduce               27                   (211) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       3     176   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (212) ::= &#x0410              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3     178   &#x0444                        Token type: Text                                                        
Reduce               27                   (213) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       3     185   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (214) ::= &#x0444              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3     187   &#x042a                        Token type: Text                                                        
Reduce               27                   (215) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       3     194   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (216) ::= &#x042a              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3     196   &#x0430                        Token type: Text                                                        
Reduce               27                   (217) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       3     203   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (218) ::= &#x0430              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3     205   >                              Token type: RightArrow                                                  
Reduce               27                   (219) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Reduce               28                   (220) ::= (218) (219)          <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               28                   (221) ::= (217) (220)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (222) ::= (216) (221)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (223) ::= (215) (222)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (224) ::= (214) (223)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (225) ::= (213) (224)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (226) ::= (212) (225)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (227) ::= (211) (226)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (228) ::= (210) (227)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (229) ::= (209) (228)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (230) ::= (208) (229)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (231) ::= (207) (230)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (232) ::= (206) (231)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (233) ::= (205) (232)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               19                   (234) ::= (204) (233)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               20                   (235) ::= (234)                <text> ::= <text-chunk-list>                                            
Shift                29                                                  The parser shifted to state 29                                          
Token Read           29       3     206   ,                              Token type: Separator                                                   
Reduce               26                   (236) ::= < (235) >            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (237) ::= (203) (236)          <item> ::= <text> <tag>                                                 
Shift                39                                                  The parser shifted to state 39                                          
Token Read           39       4       0       &#x043a                    Token type: Text                                                        
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       4      11   \;                             Token type: EscapeTerminator                                            
Reduce               18                   (238) ::=     &#x043a          <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4      13   &#x043e                        Token type: Text                                                        
Reduce               27                   (239) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       4      20   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (240) ::= &#x043e              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4      22   &#x043f                        Token type: Text                                                        
Reduce               27                   (241) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       4      29   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (242) ::= &#x043f              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4      31   &#x0440                        Token type: Text                                                        
Reduce               27                   (243) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       4      38   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (244) ::= &#x0440              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4      40   &#x0438                        Token type: Text                                                        
Reduce               27                   (245) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       4      47   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (246) ::= &#x0438              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4      49   &#x043d                        Token type: Text                                                        
Reduce               27                   (247) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       4      56   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (248) ::= &#x043d              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4      58   &#x0435                        Token type: Text                                                        
Reduce               27                   (249) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       4      65   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (250) ::= &#x0435              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4      67   &#x043d                        Token type: Text                                                        
Reduce               27                   (251) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       4      74   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (252) ::= &#x043d              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4      76   &#x0438                        Token type: Text                                                        
Reduce               27                   (253) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       4      83   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (254) ::= &#x0438              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4      85    &#x043f                       Token type: Text                                                        
Reduce               27                   (255) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       4      93   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (256) ::=  &#x043f             <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4      95   &#x043b                        Token type: Text                                                        
Reduce               27                   (257) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       4     102   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (258) ::= &#x043b              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4     104   &#x0430                        Token type: Text                                                        
Reduce               27                   (259) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       4     111   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (260) ::= &#x0430              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4     113   &#x0442                        Token type: Text                                                        
Reduce               27                   (261) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       4     120   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (262) ::= &#x0442              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4     122   &#x043e                        Token type: Text                                                        
Reduce               27                   (263) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       4     129   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (264) ::= &#x043e              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4     131   &#x0432                        Token type: Text                                                        
Reduce               27                   (265) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       4     138   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (266) ::= &#x0432              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4     140   &#x0435                        Token type: Text                                                        
Reduce               27                   (267) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       4     147   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (268) ::= &#x0435              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4     150   <                              Token type: LeftArrow                                                   
Reduce               27                   (269) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Reduce               28                   (270) ::= (268) (269)          <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               28                   (271) ::= (267) (270)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (272) ::= (266) (271)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (273) ::= (265) (272)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (274) ::= (264) (273)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (275) ::= (263) (274)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (276) ::= (262) (275)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (277) ::= (261) (276)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (278) ::= (260) (277)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (279) ::= (259) (278)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (280) ::= (258) (279)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (281) ::= (257) (280)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (282) ::= (256) (281)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (283) ::= (255) (282)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (284) ::= (254) (283)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (285) ::= (253) (284)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (286) ::= (252) (285)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (287) ::= (251) (286)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (288) ::= (250) (287)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (289) ::= (249) (288)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (290) ::= (248) (289)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (291) ::= (247) (290)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (292) ::= (246) (291)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (293) ::= (245) (292)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (294) ::= (244) (293)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (295) ::= (243) (294)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (296) ::= (242) (295)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (297) ::= (241) (296)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (298) ::= (240) (297)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (299) ::= (239) (298)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               19                   (300) ::= (238) (299)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (301) ::= (300)                <text> ::= <text-chunk-list>                                            
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       4     151   5&#x0421                       Token type: Text                                                        
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       4     159   \;                             Token type: EscapeTerminator                                            
Reduce               18                   (302) ::= 5&#x0421             <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4     161   &#x0443                        Token type: Text                                                        
Reduce               27                   (303) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       4     168   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (304) ::= &#x0443              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4     170   &#x0430                        Token type: Text                                                        
Reduce               27                   (305) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       4     177   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (306) ::= &#x0430              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4     179   &#x043a                        Token type: Text                                                        
Reduce               27                   (307) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       4     186   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (308) ::= &#x043a              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4     188   3&#x0418                       Token type: Text                                                        
Reduce               27                   (309) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       4     196   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (310) ::= 3&#x0418             <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4     198   &#x0419                        Token type: Text                                                        
Reduce               27                   (311) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       4     205   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (312) ::= &#x0419              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4     207   >                              Token type: RightArrow                                                  
Reduce               27                   (313) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Reduce               28                   (314) ::= (312) (313)          <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               28                   (315) ::= (311) (314)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (316) ::= (310) (315)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (317) ::= (309) (316)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (318) ::= (308) (317)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (319) ::= (307) (318)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (320) ::= (306) (319)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (321) ::= (305) (320)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (322) ::= (304) (321)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (323) ::= (303) (322)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               19                   (324) ::= (302) (323)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               20                   (325) ::= (324)                <text> ::= <text-chunk-list>                                            
Shift                29                                                  The parser shifted to state 29                                          
Token Read           29       4     208   ,                              Token type: Separator                                                   
Reduce               26                   (326) ::= < (325) >            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (327) ::= (301) (326)          <item> ::= <text> <tag>                                                 
Shift                39                                                  The parser shifted to state 39                                          
Token Read           39       5       0       &#x0441                    Token type: Text                                                        
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       5      11   \;                             Token type: EscapeTerminator                                            
Reduce               18                   (328) ::=     &#x0441          <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5      13   &#x0438                        Token type: Text                                                        
Reduce               27                   (329) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       5      20   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (330) ::= &#x0438              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5      22   &#x043d                        Token type: Text                                                        
Reduce               27                   (331) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       5      29   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (332) ::= &#x043d              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5      31   &#x0442                        Token type: Text                                                        
Reduce               27                   (333) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       5      38   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (334) ::= &#x0442              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5      40   &#x0435                        Token type: Text                                                        
Reduce               27                   (335) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       5      47   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (336) ::= &#x0435              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5      49   &#x0442                        Token type: Text                                                        
Reduce               27                   (337) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       5      56   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (338) ::= &#x0442              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5      58   &#x0438                        Token type: Text                                                        
Reduce               27                   (339) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       5      65   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (340) ::= &#x0438              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5      67   &#x0447                        Token type: Text                                                        
Reduce               27                   (341) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       5      74   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (342) ::= &#x0447              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5      76   &#x043d                        Token type: Text                                                        
Reduce               27                   (343) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       5      83   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (344) ::= &#x043d              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5      85   &#x0438                        Token type: Text                                                        
Reduce               27                   (345) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       5      92   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (346) ::= &#x0438              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5      94    &#x043f                       Token type: Text                                                        
Reduce               27                   (347) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       5     102   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (348) ::=  &#x043f             <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5     104   &#x043b                        Token type: Text                                                        
Reduce               27                   (349) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       5     111   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (350) ::= &#x043b              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5     113   &#x0430                        Token type: Text                                                        
Reduce               27                   (351) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       5     120   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (352) ::= &#x0430              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5     122   &#x0442                        Token type: Text                                                        
Reduce               27                   (353) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       5     129   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (354) ::= &#x0442              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5     131   &#x043e                        Token type: Text                                                        
Reduce               27                   (355) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       5     138   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (356) ::= &#x043e              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5     140   &#x0432                        Token type: Text                                                        
Reduce               27                   (357) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       5     147   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (358) ::= &#x0432              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5     149   &#x0435                        Token type: Text                                                        
Reduce               27                   (359) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       5     156   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (360) ::= &#x0435              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5     159   <                              Token type: LeftArrow                                                   
Reduce               27                   (361) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Reduce               28                   (362) ::= (360) (361)          <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               28                   (363) ::= (359) (362)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (364) ::= (358) (363)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (365) ::= (357) (364)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (366) ::= (356) (365)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (367) ::= (355) (366)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (368) ::= (354) (367)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (369) ::= (353) (368)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (370) ::= (352) (369)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (371) ::= (351) (370)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (372) ::= (350) (371)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (373) ::= (349) (372)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (374) ::= (348) (373)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (375) ::= (347) (374)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (376) ::= (346) (375)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (377) ::= (345) (376)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (378) ::= (344) (377)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (379) ::= (343) (378)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (380) ::= (342) (379)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (381) ::= (341) (380)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (382) ::= (340) (381)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (383) ::= (339) (382)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (384) ::= (338) (383)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (385) ::= (337) (384)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (386) ::= (336) (385)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (387) ::= (335) (386)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (388) ::= (334) (387)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (389) ::= (333) (388)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (390) ::= (332) (389)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (391) ::= (331) (390)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (392) ::= (330) (391)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (393) ::= (329) (392)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               19                   (394) ::= (328) (393)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (395) ::= (394)                <text> ::= <text-chunk-list>                                            
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       5     160   &#x041b                        Token type: Text                                                        
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       5     167   \;                             Token type: EscapeTerminator                                            
Reduce               18                   (396) ::= &#x041b              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5     169   &#x041a                        Token type: Text                                                        
Reduce               27                   (397) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       5     176   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (398) ::= &#x041a              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5     178   &#x0442                        Token type: Text                                                        
Reduce               27                   (399) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       5     185   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (400) ::= &#x0442              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5     187   &#x0440                        Token type: Text                                                        
Reduce               27                   (401) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       5     194   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (402) ::= &#x0440              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5     196   &#x0442                        Token type: Text                                                        
Reduce               27                   (403) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       5     203   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (404) ::= &#x0442              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5     205   5&#x041a                       Token type: Text                                                        
Reduce               27                   (405) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       5     213   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (406) ::= 5&#x041a             <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5     215   &#x041d                        Token type: Text                                                        
Reduce               27                   (407) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                11                                                  The parser shifted to state 11                                          
Token Read           11       5     222   \;                             Token type: EscapeTerminator                                            
Reduce               27                   (408) ::= &#x041d              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5     224   >                              Token type: RightArrow                                                  
Reduce               27                   (409) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Reduce               28                   (410) ::= (408) (409)          <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               28                   (411) ::= (407) (410)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (412) ::= (406) (411)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (413) ::= (405) (412)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (414) ::= (404) (413)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (415) ::= (403) (414)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (416) ::= (402) (415)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (417) ::= (401) (416)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (418) ::= (400) (417)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (419) ::= (399) (418)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (420) ::= (398) (419)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (421) ::= (397) (420)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               19                   (422) ::= (396) (421)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               20                   (423) ::= (422)                <text> ::= <text-chunk-list>                                            
Shift                29                                                  The parser shifted to state 29                                          
Token Read           29       5     225   ;                              Token type: Terminator                                                  
Reduce               26                   (424) ::= < (423) >            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (425) ::= (395) (424)          <item> ::= <text> <tag>                                                 
Reduce               44                   (426) ::= (327) , (425)        <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               44                   (427) ::= (237) , (426)        <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               35                   (428) ::= (147) , (427)        <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                41                                                  The parser shifted to state 41                                          
Token Read           41       6       0                                  Token type: EOF                                                         
Reduce               12                   (429) ::= (60) (61) (428) ;    <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               15                   (430) ::= (429)                <scripture> ::= <expression>                                            
Accept               15                                                                                                                          



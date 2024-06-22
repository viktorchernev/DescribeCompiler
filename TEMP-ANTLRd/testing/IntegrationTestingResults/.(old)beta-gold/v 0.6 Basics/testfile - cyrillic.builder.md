Cannot be parsed without preprocessing by the Describe Compiler preprocessor
========================================
Source Code (between the arrows)
========================================

🡆платове ->

	вълнени платове,
	памучни платове,
	копринени платове,
	синтетични платове;🡄

========================================
Preprocessed (between the arrows)
========================================

🡆&#x043f\;&#x043b\;&#x0430\;&#x0442\;&#x043e\;&#x0432\;&#x0435\; ->

	&#x0432\;&#x044a\;&#x043b\;&#x043d\;&#x0435\;&#x043d\;&#x0438\; &#x043f\;&#x043b\;&#x0430\;&#x0442\;&#x043e\;&#x0432\;&#x0435\;,
	&#x043f\;&#x0430\;&#x043c\;&#x0443\;&#x0447\;&#x043d\;&#x0438\; &#x043f\;&#x043b\;&#x0430\;&#x0442\;&#x043e\;&#x0432\;&#x0435\;,
	&#x043a\;&#x043e\;&#x043f\;&#x0440\;&#x0438\;&#x043d\;&#x0435\;&#x043d\;&#x0438\; &#x043f\;&#x043b\;&#x0430\;&#x0442\;&#x043e\;&#x0432\;&#x0435\;,
	&#x0441\;&#x0438\;&#x043d\;&#x0442\;&#x0435\;&#x0442\;&#x0438\;&#x0447\;&#x043d\;&#x0438\; &#x043f\;&#x043b\;&#x0430\;&#x0442\;&#x043e\;&#x0432\;&#x0435\;;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  +--<item> ::= <text>
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
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  +--<item> ::= <text>
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
|  |  |  +--,
|  |  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  |  +--<item> ::= <text>
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
|  |  |  |  +--,
|  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  +--<item> ::= <text>
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
|  |  |  |  |  +--,
|  |  |  |  |  +--<item> ::= <text>
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
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                    Description                                                             
---------------   -----   -----   -----   ----------------------------   ------------------------------------------------------------------------
Token Read            0       0       0   &#x043f                        Token type: Text                                                        
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       0       7   \;                             Token type: EscapeTerminator                                            
Reduce               16                   (1) ::= &#x043f                <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       0       9   &#x043b                        Token type: Text                                                        
Reduce               22                   (2) ::= \;                     <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       0      16   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (3) ::= &#x043b                <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       0      18   &#x0430                        Token type: Text                                                        
Reduce               22                   (4) ::= \;                     <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       0      25   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (5) ::= &#x0430                <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       0      27   &#x0442                        Token type: Text                                                        
Reduce               22                   (6) ::= \;                     <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       0      34   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (7) ::= &#x0442                <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       0      36   &#x043e                        Token type: Text                                                        
Reduce               22                   (8) ::= \;                     <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       0      43   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (9) ::= &#x043e                <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       0      45   &#x0432                        Token type: Text                                                        
Reduce               22                   (10) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       0      52   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (11) ::= &#x0432               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       0      54   &#x0435                        Token type: Text                                                        
Reduce               22                   (12) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       0      61   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (13) ::= &#x0435               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       0      64   -                              Token type: Hyphen                                                      
Reduce               22                   (14) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Reduce               23                   (15) ::= (13) (14)             <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               23                   (16) ::= (12) (15)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (17) ::= (11) (16)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (18) ::= (10) (17)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (19) ::= (9) (18)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (20) ::= (8) (19)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (21) ::= (7) (20)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (22) ::= (6) (21)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (23) ::= (5) (22)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (24) ::= (4) (23)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (25) ::= (3) (24)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (26) ::= (2) (25)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (27) ::= (1) (26)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               15                   (28) ::= (27)                  <text> ::= <text-chunk-list>                                            
Reduce               13                   (29) ::= (28)                  <item> ::= <text>                                                       
Shift                20                                                  The parser shifted to state 20                                          
Token Read           20       0      65   >                              Token type: RightArrow                                                  
Shift                24                                                  The parser shifted to state 24                                          
Token Read           24       2       0       &#x0432                    Token type: Text                                                        
Reduce               21                   (30) ::= - >                   <producer> ::= Hyphen RightArrow                                        
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       2      11   \;                             Token type: EscapeTerminator                                            
Reduce               16                   (31) ::=     &#x0432           <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2      13   &#x044a                        Token type: Text                                                        
Reduce               22                   (32) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       2      20   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (33) ::= &#x044a               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2      22   &#x043b                        Token type: Text                                                        
Reduce               22                   (34) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       2      29   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (35) ::= &#x043b               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2      31   &#x043d                        Token type: Text                                                        
Reduce               22                   (36) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       2      38   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (37) ::= &#x043d               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2      40   &#x0435                        Token type: Text                                                        
Reduce               22                   (38) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       2      47   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (39) ::= &#x0435               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2      49   &#x043d                        Token type: Text                                                        
Reduce               22                   (40) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       2      56   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (41) ::= &#x043d               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2      58   &#x0438                        Token type: Text                                                        
Reduce               22                   (42) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       2      65   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (43) ::= &#x0438               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2      67    &#x043f                       Token type: Text                                                        
Reduce               22                   (44) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       2      75   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (45) ::=  &#x043f              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2      77   &#x043b                        Token type: Text                                                        
Reduce               22                   (46) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       2      84   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (47) ::= &#x043b               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2      86   &#x0430                        Token type: Text                                                        
Reduce               22                   (48) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       2      93   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (49) ::= &#x0430               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2      95   &#x0442                        Token type: Text                                                        
Reduce               22                   (50) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       2     102   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (51) ::= &#x0442               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2     104   &#x043e                        Token type: Text                                                        
Reduce               22                   (52) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       2     111   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (53) ::= &#x043e               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2     113   &#x0432                        Token type: Text                                                        
Reduce               22                   (54) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       2     120   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (55) ::= &#x0432               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2     122   &#x0435                        Token type: Text                                                        
Reduce               22                   (56) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       2     129   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (57) ::= &#x0435               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       2     131   ,                              Token type: Separator                                                   
Reduce               22                   (58) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Reduce               23                   (59) ::= (57) (58)             <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               23                   (60) ::= (56) (59)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (61) ::= (55) (60)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (62) ::= (54) (61)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (63) ::= (53) (62)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (64) ::= (52) (63)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (65) ::= (51) (64)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (66) ::= (50) (65)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (67) ::= (49) (66)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (68) ::= (48) (67)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (69) ::= (47) (68)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (70) ::= (46) (69)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (71) ::= (45) (70)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (72) ::= (44) (71)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (73) ::= (43) (72)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (74) ::= (42) (73)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (75) ::= (41) (74)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (76) ::= (40) (75)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (77) ::= (39) (76)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (78) ::= (38) (77)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (79) ::= (37) (78)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (80) ::= (36) (79)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (81) ::= (35) (80)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (82) ::= (34) (81)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (83) ::= (33) (82)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (84) ::= (32) (83)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (85) ::= (31) (84)             <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               15                   (86) ::= (85)                  <text> ::= <text-chunk-list>                                            
Reduce               27                   (87) ::= (86)                  <item> ::= <text>                                                       
Shift                33                                                  The parser shifted to state 33                                          
Token Read           33       3       0       &#x043f                    Token type: Text                                                        
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       3      11   \;                             Token type: EscapeTerminator                                            
Reduce               16                   (88) ::=     &#x043f           <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3      13   &#x0430                        Token type: Text                                                        
Reduce               22                   (89) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       3      20   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (90) ::= &#x0430               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3      22   &#x043c                        Token type: Text                                                        
Reduce               22                   (91) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       3      29   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (92) ::= &#x043c               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3      31   &#x0443                        Token type: Text                                                        
Reduce               22                   (93) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       3      38   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (94) ::= &#x0443               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3      40   &#x0447                        Token type: Text                                                        
Reduce               22                   (95) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       3      47   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (96) ::= &#x0447               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3      49   &#x043d                        Token type: Text                                                        
Reduce               22                   (97) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       3      56   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (98) ::= &#x043d               <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3      58   &#x0438                        Token type: Text                                                        
Reduce               22                   (99) ::= \;                    <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       3      65   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (100) ::= &#x0438              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3      67    &#x043f                       Token type: Text                                                        
Reduce               22                   (101) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       3      75   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (102) ::=  &#x043f             <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3      77   &#x043b                        Token type: Text                                                        
Reduce               22                   (103) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       3      84   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (104) ::= &#x043b              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3      86   &#x0430                        Token type: Text                                                        
Reduce               22                   (105) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       3      93   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (106) ::= &#x0430              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3      95   &#x0442                        Token type: Text                                                        
Reduce               22                   (107) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       3     102   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (108) ::= &#x0442              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3     104   &#x043e                        Token type: Text                                                        
Reduce               22                   (109) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       3     111   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (110) ::= &#x043e              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3     113   &#x0432                        Token type: Text                                                        
Reduce               22                   (111) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       3     120   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (112) ::= &#x0432              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3     122   &#x0435                        Token type: Text                                                        
Reduce               22                   (113) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       3     129   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (114) ::= &#x0435              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       3     131   ,                              Token type: Separator                                                   
Reduce               22                   (115) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Reduce               23                   (116) ::= (114) (115)          <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               23                   (117) ::= (113) (116)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (118) ::= (112) (117)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (119) ::= (111) (118)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (120) ::= (110) (119)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (121) ::= (109) (120)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (122) ::= (108) (121)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (123) ::= (107) (122)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (124) ::= (106) (123)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (125) ::= (105) (124)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (126) ::= (104) (125)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (127) ::= (103) (126)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (128) ::= (102) (127)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (129) ::= (101) (128)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (130) ::= (100) (129)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (131) ::= (99) (130)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (132) ::= (98) (131)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (133) ::= (97) (132)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (134) ::= (96) (133)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (135) ::= (95) (134)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (136) ::= (94) (135)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (137) ::= (93) (136)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (138) ::= (92) (137)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (139) ::= (91) (138)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (140) ::= (90) (139)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (141) ::= (89) (140)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (142) ::= (88) (141)           <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               15                   (143) ::= (142)                <text> ::= <text-chunk-list>                                            
Reduce               37                   (144) ::= (143)                <item> ::= <text>                                                       
Shift                33                                                  The parser shifted to state 33                                          
Token Read           33       4       0       &#x043a                    Token type: Text                                                        
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       4      11   \;                             Token type: EscapeTerminator                                            
Reduce               16                   (145) ::=     &#x043a          <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4      13   &#x043e                        Token type: Text                                                        
Reduce               22                   (146) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       4      20   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (147) ::= &#x043e              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4      22   &#x043f                        Token type: Text                                                        
Reduce               22                   (148) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       4      29   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (149) ::= &#x043f              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4      31   &#x0440                        Token type: Text                                                        
Reduce               22                   (150) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       4      38   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (151) ::= &#x0440              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4      40   &#x0438                        Token type: Text                                                        
Reduce               22                   (152) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       4      47   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (153) ::= &#x0438              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4      49   &#x043d                        Token type: Text                                                        
Reduce               22                   (154) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       4      56   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (155) ::= &#x043d              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4      58   &#x0435                        Token type: Text                                                        
Reduce               22                   (156) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       4      65   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (157) ::= &#x0435              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4      67   &#x043d                        Token type: Text                                                        
Reduce               22                   (158) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       4      74   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (159) ::= &#x043d              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4      76   &#x0438                        Token type: Text                                                        
Reduce               22                   (160) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       4      83   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (161) ::= &#x0438              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4      85    &#x043f                       Token type: Text                                                        
Reduce               22                   (162) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       4      93   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (163) ::=  &#x043f             <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4      95   &#x043b                        Token type: Text                                                        
Reduce               22                   (164) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       4     102   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (165) ::= &#x043b              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4     104   &#x0430                        Token type: Text                                                        
Reduce               22                   (166) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       4     111   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (167) ::= &#x0430              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4     113   &#x0442                        Token type: Text                                                        
Reduce               22                   (168) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       4     120   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (169) ::= &#x0442              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4     122   &#x043e                        Token type: Text                                                        
Reduce               22                   (170) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       4     129   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (171) ::= &#x043e              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4     131   &#x0432                        Token type: Text                                                        
Reduce               22                   (172) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       4     138   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (173) ::= &#x0432              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4     140   &#x0435                        Token type: Text                                                        
Reduce               22                   (174) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       4     147   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (175) ::= &#x0435              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       4     149   ,                              Token type: Separator                                                   
Reduce               22                   (176) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Reduce               23                   (177) ::= (175) (176)          <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               23                   (178) ::= (174) (177)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (179) ::= (173) (178)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (180) ::= (172) (179)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (181) ::= (171) (180)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (182) ::= (170) (181)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (183) ::= (169) (182)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (184) ::= (168) (183)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (185) ::= (167) (184)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (186) ::= (166) (185)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (187) ::= (165) (186)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (188) ::= (164) (187)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (189) ::= (163) (188)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (190) ::= (162) (189)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (191) ::= (161) (190)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (192) ::= (160) (191)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (193) ::= (159) (192)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (194) ::= (158) (193)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (195) ::= (157) (194)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (196) ::= (156) (195)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (197) ::= (155) (196)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (198) ::= (154) (197)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (199) ::= (153) (198)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (200) ::= (152) (199)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (201) ::= (151) (200)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (202) ::= (150) (201)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (203) ::= (149) (202)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (204) ::= (148) (203)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (205) ::= (147) (204)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (206) ::= (146) (205)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (207) ::= (145) (206)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               15                   (208) ::= (207)                <text> ::= <text-chunk-list>                                            
Reduce               37                   (209) ::= (208)                <item> ::= <text>                                                       
Shift                33                                                  The parser shifted to state 33                                          
Token Read           33       5       0       &#x0441                    Token type: Text                                                        
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       5      11   \;                             Token type: EscapeTerminator                                            
Reduce               16                   (210) ::=     &#x0441          <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5      13   &#x0438                        Token type: Text                                                        
Reduce               22                   (211) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       5      20   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (212) ::= &#x0438              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5      22   &#x043d                        Token type: Text                                                        
Reduce               22                   (213) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       5      29   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (214) ::= &#x043d              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5      31   &#x0442                        Token type: Text                                                        
Reduce               22                   (215) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       5      38   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (216) ::= &#x0442              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5      40   &#x0435                        Token type: Text                                                        
Reduce               22                   (217) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       5      47   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (218) ::= &#x0435              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5      49   &#x0442                        Token type: Text                                                        
Reduce               22                   (219) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       5      56   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (220) ::= &#x0442              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5      58   &#x0438                        Token type: Text                                                        
Reduce               22                   (221) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       5      65   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (222) ::= &#x0438              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5      67   &#x0447                        Token type: Text                                                        
Reduce               22                   (223) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       5      74   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (224) ::= &#x0447              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5      76   &#x043d                        Token type: Text                                                        
Reduce               22                   (225) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       5      83   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (226) ::= &#x043d              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5      85   &#x0438                        Token type: Text                                                        
Reduce               22                   (227) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       5      92   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (228) ::= &#x0438              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5      94    &#x043f                       Token type: Text                                                        
Reduce               22                   (229) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       5     102   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (230) ::=  &#x043f             <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5     104   &#x043b                        Token type: Text                                                        
Reduce               22                   (231) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       5     111   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (232) ::= &#x043b              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5     113   &#x0430                        Token type: Text                                                        
Reduce               22                   (233) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       5     120   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (234) ::= &#x0430              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5     122   &#x0442                        Token type: Text                                                        
Reduce               22                   (235) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       5     129   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (236) ::= &#x0442              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5     131   &#x043e                        Token type: Text                                                        
Reduce               22                   (237) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       5     138   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (238) ::= &#x043e              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5     140   &#x0432                        Token type: Text                                                        
Reduce               22                   (239) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       5     147   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (240) ::= &#x0432              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5     149   &#x0435                        Token type: Text                                                        
Reduce               22                   (241) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Shift                10                                                  The parser shifted to state 10                                          
Token Read           10       5     156   \;                             Token type: EscapeTerminator                                            
Reduce               22                   (242) ::= &#x0435              <text-chunk> ::= Text                                                   
Shift                 9                                                  The parser shifted to state 9                                           
Token Read            9       5     158   ;                              Token type: Terminator                                                  
Reduce               22                   (243) ::= \;                   <text-chunk> ::= EscapeTerminator                                       
Reduce               23                   (244) ::= (242) (243)          <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               23                   (245) ::= (241) (244)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (246) ::= (240) (245)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (247) ::= (239) (246)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (248) ::= (238) (247)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (249) ::= (237) (248)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (250) ::= (236) (249)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (251) ::= (235) (250)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (252) ::= (234) (251)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (253) ::= (233) (252)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (254) ::= (232) (253)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (255) ::= (231) (254)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (256) ::= (230) (255)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (257) ::= (229) (256)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (258) ::= (228) (257)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (259) ::= (227) (258)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (260) ::= (226) (259)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (261) ::= (225) (260)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (262) ::= (224) (261)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (263) ::= (223) (262)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (264) ::= (222) (263)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (265) ::= (221) (264)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (266) ::= (220) (265)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (267) ::= (219) (266)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (268) ::= (218) (267)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (269) ::= (217) (268)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (270) ::= (216) (269)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (271) ::= (215) (270)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (272) ::= (214) (271)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (273) ::= (213) (272)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (274) ::= (212) (273)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (275) ::= (211) (274)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (276) ::= (210) (275)          <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               15                   (277) ::= (276)                <text> ::= <text-chunk-list>                                            
Reduce               37                   (278) ::= (277)                <item> ::= <text>                                                       
Reduce               38                   (279) ::= (209) , (278)        <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               38                   (280) ::= (144) , (279)        <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               29                   (281) ::= (87) , (280)         <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                35                                                  The parser shifted to state 35                                          
Token Read           35       6       0                                  Token type: EOF                                                         
Reduce               11                   (282) ::= (29) (30) (281) ;    <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               14                   (283) ::= (282)                <scripture> ::= <expression>                                            
Accept               14                                                                                                                          



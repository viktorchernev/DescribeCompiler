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

🡆&#x043f\;&#x043b\;&#x0430\;&#x0442\;&#x043e\;&#x0432\;&#x0435\; ->>

	&#x0432\;&#x044a\;&#x043b\;&#x043d\;&#x0435\;&#x043d\;&#x0438\; &#x043f\;&#x043b\;&#x0430\;&#x0442\;&#x043e\;&#x0432\;&#x0435\;,,
	&#x043f\;&#x0430\;&#x043c\;&#x0443\;&#x0447\;&#x043d\;&#x0438\; &#x043f\;&#x043b\;&#x0430\;&#x0442\;&#x043e\;&#x0432\;&#x0435\;,,
	&#x043a\;&#x043e\;&#x043f\;&#x0440\;&#x0438\;&#x043d\;&#x0435\;&#x043d\;&#x0438\; &#x043f\;&#x043b\;&#x0430\;&#x0442\;&#x043e\;&#x0432\;&#x0435\;,,
	&#x0441\;&#x0438\;&#x043d\;&#x0442\;&#x0435\;&#x0442\;&#x0438\;&#x0447\;&#x043d\;&#x0438\; &#x043f\;&#x043b\;&#x0430\;&#x0442\;&#x043e\;&#x0432\;&#x0435\;;;
🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression-list> <terminator>
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
|  |  +--<producer> ::= Hyphen RightArrow RightArrow
|  |  |  +---
|  |  |  +-->
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <item> <separator> <item-or-expression-list>
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
|  |  |  +--<separator> ::= Separator Separator
|  |  |  |  +--,
|  |  |  |  +--,
|  |  |  +--<item-or-expression-list> ::= <item> <separator> <item-or-expression-list>
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
|  |  |  |  +--<separator> ::= Separator Separator
|  |  |  |  |  +--,
|  |  |  |  |  +--,
|  |  |  |  +--<item-or-expression-list> ::= <item> <separator> <item>
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
|  |  |  |  |  +--<separator> ::= Separator Separator
|  |  |  |  |  |  +--,
|  |  |  |  |  |  +--,
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
|  |  +--<terminator> ::= Terminator Terminator
|  |  |  +--;
|  |  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                        Description                                                               
---------------   -----   -----   -----   --------------------------------   --------------------------------------------------------------------------
Token Read            0       0       0   &#x043f                            Token type: Text                                                          
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       0       7   \;                                 Token type: EscapeTerminator                                              
Reduce               20                   (1) ::= &#x043f                    <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       0       9   &#x043b                            Token type: Text                                                          
Reduce               33                   (2) ::= \;                         <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       0      16   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (3) ::= &#x043b                    <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       0      18   &#x0430                            Token type: Text                                                          
Reduce               33                   (4) ::= \;                         <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       0      25   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (5) ::= &#x0430                    <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       0      27   &#x0442                            Token type: Text                                                          
Reduce               33                   (6) ::= \;                         <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       0      34   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (7) ::= &#x0442                    <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       0      36   &#x043e                            Token type: Text                                                          
Reduce               33                   (8) ::= \;                         <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       0      43   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (9) ::= &#x043e                    <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       0      45   &#x0432                            Token type: Text                                                          
Reduce               33                   (10) ::= \;                        <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       0      52   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (11) ::= &#x0432                   <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       0      54   &#x0435                            Token type: Text                                                          
Reduce               33                   (12) ::= \;                        <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       0      61   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (13) ::= &#x0435                   <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       0      64   -                                  Token type: Hyphen                                                        
Reduce               33                   (14) ::= \;                        <text-chunk> ::= EscapeTerminator                                         
Reduce               34                   (15) ::= (13) (14)                 <text-chunk-list> ::= <text-chunk> <text-chunk>                           
Reduce               34                   (16) ::= (12) (15)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (17) ::= (11) (16)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (18) ::= (10) (17)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (19) ::= (9) (18)                  <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (20) ::= (8) (19)                  <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (21) ::= (7) (20)                  <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (22) ::= (6) (21)                  <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (23) ::= (5) (22)                  <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (24) ::= (4) (23)                  <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (25) ::= (3) (24)                  <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (26) ::= (2) (25)                  <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               21                   (27) ::= (1) (26)                  <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               19                   (28) ::= (27)                      <text> ::= <text-chunk-list>                                              
Reduce               17                   (29) ::= (28)                      <item> ::= <text>                                                         
Shift                24                                                      The parser shifted to state 24                                            
Token Read           24       0      65   >                                  Token type: RightArrow                                                    
Shift                35                                                      The parser shifted to state 35                                            
Token Read           35       0      66   >                                  Token type: RightArrow                                                    
Shift                64                                                      The parser shifted to state 64                                            
Token Read           64       2       0       &#x0432                        Token type: Text                                                          
Reduce               25                   (30) ::= - > >                     <producer> ::= Hyphen RightArrow RightArrow                               
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       2      11   \;                                 Token type: EscapeTerminator                                              
Reduce               20                   (31) ::=     &#x0432               <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       2      13   &#x044a                            Token type: Text                                                          
Reduce               33                   (32) ::= \;                        <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       2      20   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (33) ::= &#x044a                   <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       2      22   &#x043b                            Token type: Text                                                          
Reduce               33                   (34) ::= \;                        <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       2      29   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (35) ::= &#x043b                   <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       2      31   &#x043d                            Token type: Text                                                          
Reduce               33                   (36) ::= \;                        <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       2      38   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (37) ::= &#x043d                   <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       2      40   &#x0435                            Token type: Text                                                          
Reduce               33                   (38) ::= \;                        <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       2      47   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (39) ::= &#x0435                   <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       2      49   &#x043d                            Token type: Text                                                          
Reduce               33                   (40) ::= \;                        <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       2      56   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (41) ::= &#x043d                   <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       2      58   &#x0438                            Token type: Text                                                          
Reduce               33                   (42) ::= \;                        <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       2      65   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (43) ::= &#x0438                   <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       2      67    &#x043f                           Token type: Text                                                          
Reduce               33                   (44) ::= \;                        <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       2      75   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (45) ::=  &#x043f                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       2      77   &#x043b                            Token type: Text                                                          
Reduce               33                   (46) ::= \;                        <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       2      84   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (47) ::= &#x043b                   <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       2      86   &#x0430                            Token type: Text                                                          
Reduce               33                   (48) ::= \;                        <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       2      93   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (49) ::= &#x0430                   <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       2      95   &#x0442                            Token type: Text                                                          
Reduce               33                   (50) ::= \;                        <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       2     102   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (51) ::= &#x0442                   <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       2     104   &#x043e                            Token type: Text                                                          
Reduce               33                   (52) ::= \;                        <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       2     111   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (53) ::= &#x043e                   <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       2     113   &#x0432                            Token type: Text                                                          
Reduce               33                   (54) ::= \;                        <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       2     120   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (55) ::= &#x0432                   <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       2     122   &#x0435                            Token type: Text                                                          
Reduce               33                   (56) ::= \;                        <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       2     129   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (57) ::= &#x0435                   <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       2     131   ,                                  Token type: Separator                                                     
Reduce               33                   (58) ::= \;                        <text-chunk> ::= EscapeTerminator                                         
Reduce               34                   (59) ::= (57) (58)                 <text-chunk-list> ::= <text-chunk> <text-chunk>                           
Reduce               34                   (60) ::= (56) (59)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (61) ::= (55) (60)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (62) ::= (54) (61)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (63) ::= (53) (62)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (64) ::= (52) (63)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (65) ::= (51) (64)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (66) ::= (50) (65)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (67) ::= (49) (66)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (68) ::= (48) (67)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (69) ::= (47) (68)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (70) ::= (46) (69)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (71) ::= (45) (70)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (72) ::= (44) (71)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (73) ::= (43) (72)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (74) ::= (42) (73)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (75) ::= (41) (74)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (76) ::= (40) (75)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (77) ::= (39) (76)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (78) ::= (38) (77)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (79) ::= (37) (78)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (80) ::= (36) (79)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (81) ::= (35) (80)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (82) ::= (34) (81)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (83) ::= (33) (82)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (84) ::= (32) (83)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               21                   (85) ::= (31) (84)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               19                   (86) ::= (85)                      <text> ::= <text-chunk-list>                                              
Reduce               38                   (87) ::= (86)                      <item> ::= <text>                                                         
Shift                69                                                      The parser shifted to state 69                                            
Token Read           69       2     132   ,                                  Token type: Separator                                                     
Shift                99                                                      The parser shifted to state 99                                            
Token Read           99       3       0       &#x043f                        Token type: Text                                                          
Reduce               70                   (88) ::= , ,                       <separator> ::= Separator Separator                                       
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       3      11   \;                                 Token type: EscapeTerminator                                              
Reduce               20                   (89) ::=     &#x043f               <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       3      13   &#x0430                            Token type: Text                                                          
Reduce               33                   (90) ::= \;                        <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       3      20   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (91) ::= &#x0430                   <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       3      22   &#x043c                            Token type: Text                                                          
Reduce               33                   (92) ::= \;                        <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       3      29   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (93) ::= &#x043c                   <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       3      31   &#x0443                            Token type: Text                                                          
Reduce               33                   (94) ::= \;                        <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       3      38   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (95) ::= &#x0443                   <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       3      40   &#x0447                            Token type: Text                                                          
Reduce               33                   (96) ::= \;                        <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       3      47   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (97) ::= &#x0447                   <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       3      49   &#x043d                            Token type: Text                                                          
Reduce               33                   (98) ::= \;                        <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       3      56   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (99) ::= &#x043d                   <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       3      58   &#x0438                            Token type: Text                                                          
Reduce               33                   (100) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       3      65   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (101) ::= &#x0438                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       3      67    &#x043f                           Token type: Text                                                          
Reduce               33                   (102) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       3      75   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (103) ::=  &#x043f                 <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       3      77   &#x043b                            Token type: Text                                                          
Reduce               33                   (104) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       3      84   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (105) ::= &#x043b                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       3      86   &#x0430                            Token type: Text                                                          
Reduce               33                   (106) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       3      93   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (107) ::= &#x0430                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       3      95   &#x0442                            Token type: Text                                                          
Reduce               33                   (108) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       3     102   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (109) ::= &#x0442                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       3     104   &#x043e                            Token type: Text                                                          
Reduce               33                   (110) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       3     111   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (111) ::= &#x043e                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       3     113   &#x0432                            Token type: Text                                                          
Reduce               33                   (112) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       3     120   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (113) ::= &#x0432                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       3     122   &#x0435                            Token type: Text                                                          
Reduce               33                   (114) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       3     129   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (115) ::= &#x0435                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       3     131   ,                                  Token type: Separator                                                     
Reduce               33                   (116) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Reduce               34                   (117) ::= (115) (116)              <text-chunk-list> ::= <text-chunk> <text-chunk>                           
Reduce               34                   (118) ::= (114) (117)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (119) ::= (113) (118)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (120) ::= (112) (119)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (121) ::= (111) (120)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (122) ::= (110) (121)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (123) ::= (109) (122)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (124) ::= (108) (123)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (125) ::= (107) (124)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (126) ::= (106) (125)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (127) ::= (105) (126)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (128) ::= (104) (127)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (129) ::= (103) (128)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (130) ::= (102) (129)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (131) ::= (101) (130)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (132) ::= (100) (131)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (133) ::= (99) (132)               <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (134) ::= (98) (133)               <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (135) ::= (97) (134)               <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (136) ::= (96) (135)               <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (137) ::= (95) (136)               <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (138) ::= (94) (137)               <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (139) ::= (93) (138)               <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (140) ::= (92) (139)               <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (141) ::= (91) (140)               <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (142) ::= (90) (141)               <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               21                   (143) ::= (89) (142)               <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               19                   (144) ::= (143)                    <text> ::= <text-chunk-list>                                              
Reduce              101                   (145) ::= (144)                    <item> ::= <text>                                                         
Shift                69                                                      The parser shifted to state 69                                            
Token Read           69       3     132   ,                                  Token type: Separator                                                     
Shift                99                                                      The parser shifted to state 99                                            
Token Read           99       4       0       &#x043a                        Token type: Text                                                          
Reduce               70                   (146) ::= , ,                      <separator> ::= Separator Separator                                       
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       4      11   \;                                 Token type: EscapeTerminator                                              
Reduce               20                   (147) ::=     &#x043a              <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       4      13   &#x043e                            Token type: Text                                                          
Reduce               33                   (148) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       4      20   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (149) ::= &#x043e                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       4      22   &#x043f                            Token type: Text                                                          
Reduce               33                   (150) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       4      29   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (151) ::= &#x043f                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       4      31   &#x0440                            Token type: Text                                                          
Reduce               33                   (152) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       4      38   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (153) ::= &#x0440                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       4      40   &#x0438                            Token type: Text                                                          
Reduce               33                   (154) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       4      47   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (155) ::= &#x0438                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       4      49   &#x043d                            Token type: Text                                                          
Reduce               33                   (156) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       4      56   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (157) ::= &#x043d                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       4      58   &#x0435                            Token type: Text                                                          
Reduce               33                   (158) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       4      65   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (159) ::= &#x0435                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       4      67   &#x043d                            Token type: Text                                                          
Reduce               33                   (160) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       4      74   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (161) ::= &#x043d                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       4      76   &#x0438                            Token type: Text                                                          
Reduce               33                   (162) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       4      83   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (163) ::= &#x0438                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       4      85    &#x043f                           Token type: Text                                                          
Reduce               33                   (164) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       4      93   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (165) ::=  &#x043f                 <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       4      95   &#x043b                            Token type: Text                                                          
Reduce               33                   (166) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       4     102   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (167) ::= &#x043b                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       4     104   &#x0430                            Token type: Text                                                          
Reduce               33                   (168) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       4     111   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (169) ::= &#x0430                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       4     113   &#x0442                            Token type: Text                                                          
Reduce               33                   (170) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       4     120   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (171) ::= &#x0442                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       4     122   &#x043e                            Token type: Text                                                          
Reduce               33                   (172) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       4     129   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (173) ::= &#x043e                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       4     131   &#x0432                            Token type: Text                                                          
Reduce               33                   (174) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       4     138   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (175) ::= &#x0432                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       4     140   &#x0435                            Token type: Text                                                          
Reduce               33                   (176) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       4     147   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (177) ::= &#x0435                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       4     149   ,                                  Token type: Separator                                                     
Reduce               33                   (178) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Reduce               34                   (179) ::= (177) (178)              <text-chunk-list> ::= <text-chunk> <text-chunk>                           
Reduce               34                   (180) ::= (176) (179)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (181) ::= (175) (180)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (182) ::= (174) (181)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (183) ::= (173) (182)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (184) ::= (172) (183)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (185) ::= (171) (184)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (186) ::= (170) (185)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (187) ::= (169) (186)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (188) ::= (168) (187)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (189) ::= (167) (188)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (190) ::= (166) (189)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (191) ::= (165) (190)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (192) ::= (164) (191)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (193) ::= (163) (192)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (194) ::= (162) (193)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (195) ::= (161) (194)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (196) ::= (160) (195)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (197) ::= (159) (196)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (198) ::= (158) (197)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (199) ::= (157) (198)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (200) ::= (156) (199)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (201) ::= (155) (200)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (202) ::= (154) (201)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (203) ::= (153) (202)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (204) ::= (152) (203)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (205) ::= (151) (204)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (206) ::= (150) (205)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (207) ::= (149) (206)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (208) ::= (148) (207)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               21                   (209) ::= (147) (208)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               19                   (210) ::= (209)                    <text> ::= <text-chunk-list>                                              
Reduce              101                   (211) ::= (210)                    <item> ::= <text>                                                         
Shift                69                                                      The parser shifted to state 69                                            
Token Read           69       4     150   ,                                  Token type: Separator                                                     
Shift                99                                                      The parser shifted to state 99                                            
Token Read           99       5       0       &#x0441                        Token type: Text                                                          
Reduce               70                   (212) ::= , ,                      <separator> ::= Separator Separator                                       
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       5      11   \;                                 Token type: EscapeTerminator                                              
Reduce               20                   (213) ::=     &#x0441              <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       5      13   &#x0438                            Token type: Text                                                          
Reduce               33                   (214) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       5      20   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (215) ::= &#x0438                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       5      22   &#x043d                            Token type: Text                                                          
Reduce               33                   (216) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       5      29   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (217) ::= &#x043d                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       5      31   &#x0442                            Token type: Text                                                          
Reduce               33                   (218) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       5      38   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (219) ::= &#x0442                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       5      40   &#x0435                            Token type: Text                                                          
Reduce               33                   (220) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       5      47   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (221) ::= &#x0435                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       5      49   &#x0442                            Token type: Text                                                          
Reduce               33                   (222) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       5      56   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (223) ::= &#x0442                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       5      58   &#x0438                            Token type: Text                                                          
Reduce               33                   (224) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       5      65   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (225) ::= &#x0438                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       5      67   &#x0447                            Token type: Text                                                          
Reduce               33                   (226) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       5      74   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (227) ::= &#x0447                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       5      76   &#x043d                            Token type: Text                                                          
Reduce               33                   (228) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       5      83   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (229) ::= &#x043d                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       5      85   &#x0438                            Token type: Text                                                          
Reduce               33                   (230) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       5      92   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (231) ::= &#x0438                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       5      94    &#x043f                           Token type: Text                                                          
Reduce               33                   (232) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       5     102   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (233) ::=  &#x043f                 <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       5     104   &#x043b                            Token type: Text                                                          
Reduce               33                   (234) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       5     111   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (235) ::= &#x043b                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       5     113   &#x0430                            Token type: Text                                                          
Reduce               33                   (236) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       5     120   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (237) ::= &#x0430                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       5     122   &#x0442                            Token type: Text                                                          
Reduce               33                   (238) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       5     129   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (239) ::= &#x0442                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       5     131   &#x043e                            Token type: Text                                                          
Reduce               33                   (240) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       5     138   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (241) ::= &#x043e                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       5     140   &#x0432                            Token type: Text                                                          
Reduce               33                   (242) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       5     147   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (243) ::= &#x0432                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       5     149   &#x0435                            Token type: Text                                                          
Reduce               33                   (244) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Shift                14                                                      The parser shifted to state 14                                            
Token Read           14       5     156   \;                                 Token type: EscapeTerminator                                              
Reduce               33                   (245) ::= &#x0435                  <text-chunk> ::= Text                                                     
Shift                13                                                      The parser shifted to state 13                                            
Token Read           13       5     158   ;                                  Token type: Terminator                                                    
Reduce               33                   (246) ::= \;                       <text-chunk> ::= EscapeTerminator                                         
Reduce               34                   (247) ::= (245) (246)              <text-chunk-list> ::= <text-chunk> <text-chunk>                           
Reduce               34                   (248) ::= (244) (247)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (249) ::= (243) (248)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (250) ::= (242) (249)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (251) ::= (241) (250)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (252) ::= (240) (251)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (253) ::= (239) (252)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (254) ::= (238) (253)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (255) ::= (237) (254)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (256) ::= (236) (255)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (257) ::= (235) (256)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (258) ::= (234) (257)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (259) ::= (233) (258)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (260) ::= (232) (259)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (261) ::= (231) (260)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (262) ::= (230) (261)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (263) ::= (229) (262)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (264) ::= (228) (263)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (265) ::= (227) (264)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (266) ::= (226) (265)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (267) ::= (225) (266)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (268) ::= (224) (267)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (269) ::= (223) (268)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (270) ::= (222) (269)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (271) ::= (221) (270)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (272) ::= (220) (271)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (273) ::= (219) (272)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (274) ::= (218) (273)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (275) ::= (217) (274)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (276) ::= (216) (275)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (277) ::= (215) (276)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (278) ::= (214) (277)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               21                   (279) ::= (213) (278)              <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               19                   (280) ::= (279)                    <text> ::= <text-chunk-list>                                              
Reduce              101                   (281) ::= (280)                    <item> ::= <text>                                                         
Reduce              102                   (282) ::= (211) (212) (281)        <item-or-expression-list> ::= <item> <separator> <item>                   
Reduce              102                   (283) ::= (145) (146) (282)        <item-or-expression-list> ::= <item> <separator> <item-or-expression-list>
Reduce               40                   (284) ::= (87) (88) (283)          <item-or-expression-list> ::= <item> <separator> <item-or-expression-list>
Shift                36                                                      The parser shifted to state 36                                            
Token Read           36       5     159   ;                                  Token type: Terminator                                                    
Shift                65                                                      The parser shifted to state 65                                            
Token Read           65       7       0                                      Token type: EOF                                                           
Reduce               72                   (285) ::= ; ;                      <terminator> ::= Terminator Terminator                                    
Reduce               15                   (286) ::= (29) (30) (284) (285)    <expression> ::= <item> <producer> <item-or-expression-list> <terminator> 
Reduce               18                   (287) ::= (286)                    <scripture> ::= <expression>                                              
Accept               18                                                                                                                                



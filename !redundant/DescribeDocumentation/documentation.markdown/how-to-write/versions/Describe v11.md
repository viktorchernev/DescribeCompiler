---
layout: page
title: Describe Doubles
permalink: /language/version-11/
exclude: true
---
<br>Describe version 1.1, code-named Doubles is the second official version of the language, although it is similar to a variant of version 1.0. The difference is that, in this version, the `<<` tags `>>`, `[[` links `]]` and `{% raw %}{{{% endraw %}` decorators `{% raw %}}}{% endraw %}` are enclosed in double brackets, thus allowing for text that contains single brackets of these kinds be conveniently written, without the need to escape said brackets.

The ANTLR4 parser grammar is given next.<br><br>

<span style="color:blue">_Describe 1.1 - Doubles_</span>
```
/* Describe Markup Language
 * version 1.1 (Doubles)
 * Created by DemonOfReason and ChatGPT
 * Finished on 20 June 2024 */

grammar Describe11;


// Define lexer rules for white spaces. Linespace is the same but with new line - '\n'
// ----------------------------------------------------------------------------------------------------------
// ' ' 					: A space character.
// '\r'					: A carriage return character (ASCII 13).
// '\n'					: A newline character (ASCII 10).
// '\t'					: A tab character (ASCII 9).
// '\u000B'				: A vertical tab character (ASCII 11).
// '\u000C'				: A form feed character (ASCII 12).
// '\u0085'				: A next line (NEL) character (Unicode character U+0085).
// '\u00A0'				: A non-breaking space (Unicode character U+00A0).
// '\u1680'				: An ogham space mark (Unicode character U+1680).
// '\u2000-\u200A'			: A range of en space to hair space (Unicode characters U+2000 to U+200A, inclusive).
// '\u2028'				: A line separator (Unicode character U+2028).
// '\u2029'				: A paragraph separator (Unicode character U+2029).
// '\u202F'				: A narrow no-break space (Unicode character U+202F).
// '\u205F'				: A medium mathematical space (Unicode character U+205F).
// '\u3000'				: An ideographic space (Unicode character U+3000).
// ----------------------------------------------------------------------------------------------------------
fragment WHITESPACE			: [ \r\t\u000B\u000C\u0085\u00A0\u1680\u2000-\u200A\u2028\u2029\u202F\u205F\u3000] ;
fragment LINESPACE			: [ \r\n\t\u000B\u000C\u0085\u00A0\u1680\u2000-\u200A\u2028\u2029\u202F\u205F\u3000] ;


// Define lexer rules for comments
LINE_COMMENT       			: '// ' .*? ('\r'? '\n' LINESPACE* | EOF) -> skip ;
BLOCK_COMMENT       			: '/*' .*? ('*/' LINESPACE* | EOF) -> skip ;
TAG					: '<<' .+? '>>' LINESPACE* ;
LINK					: '[[' .*? ']]' LINESPACE* ;
DECORATOR				: '{{' .*? '}}' LINESPACE* ;


// Define lexer rules for other tokens
HYPHEN					: '-' ;
TILDE					: '~' ;

PRODUCTION_ARROW			: '>' WHITESPACE* BLOCK_COMMENT* '\n' LINESPACE*
					| '>' WHITESPACE* BLOCK_COMMENT* LINE_COMMENT
					| '>>' LINESPACE* ;

SEPARATOR            			: ',' WHITESPACE* BLOCK_COMMENT* '\n' LINESPACE* 
					| ',' WHITESPACE* BLOCK_COMMENT* LINE_COMMENT
					| ',,' LINESPACE* ;

TERMINATOR           			: ';' WHITESPACE* BLOCK_COMMENT* ('\n' | EOF) LINESPACE* 
					| ';' WHITESPACE* BLOCK_COMMENT* LINE_COMMENT
					| ';;' LINESPACE* ;

FORWARD_SLASHES				: '//' LINESPACE* ;
FORWARD_SLASH				: '/' LINESPACE* ;
COMMA					: ',' LINESPACE* ;
SEMICOLON				: ';' LINESPACE* ;
RIGHT_ARROW             		: '>' LINESPACE* ;
LEFT_ARROW             			: '<' LINESPACE* ;
RIGHT_SQUARE      			: ']' LINESPACE* ;
LEFT_SQUARE      			: '[' LINESPACE* ;
RIGHT_CURL      			: '}' LINESPACE* ;
LEFT_CURL      				: '{' LINESPACE* ;
STAR					: '*' LINESPACE* ;

ESCAPE_ESCAPE        			: '\\\\' LINESPACE* ;
ESCAPE_HYPHEN      			: '\\-' LINESPACE* ;
ESCAPE_RIGHT_ARROW      		: '\\>' LINESPACE* ;
ESCAPE_LEFT_ARROW      			: '\\<' LINESPACE* ;
ESCAPE_RIGHT_SQUARE     	 	: '\\]' LINESPACE* ;
ESCAPE_LEFT_SQUARE      		: '\\[' LINESPACE* ;
ESCAPE_RIGHT_CURL      			: '\\}' LINESPACE* ;
ESCAPE_LEFT_CURL     	 		: '\\{' LINESPACE* ;
ESCAPE_SEPARATOR     			: '\\,' LINESPACE* ;
ESCAPE_TERMINATOR    			: '\\;' LINESPACE* ;
ESCAPE_LCOMMENT      			: '\\//' LINESPACE* ;
ESCAPE_BCOMMENT      			: '\\/*' LINESPACE* ;
ESCAPE               			: '\\' LINESPACE* ;


// Define lexer rule for data
// Note: For some reason we don't need to escape '[' and '|'
// and ANTLR does not like when we try to escape them
fragment DATA_CHAR			: ~[{}[\]\-<>,;*~/\\] ;
DATA                			: DATA_CHAR+ ;



// Define parser rules
producer				: HYPHEN PRODUCTION_ARROW ;

text_chunk				: ESCAPE_ESCAPE
					| ESCAPE_HYPHEN
					| ESCAPE_RIGHT_ARROW
					| ESCAPE_LEFT_ARROW
					| ESCAPE_RIGHT_SQUARE
					| ESCAPE_LEFT_SQUARE
					| ESCAPE_RIGHT_CURL
					| ESCAPE_LEFT_CURL
					| ESCAPE_SEPARATOR
					| ESCAPE_TERMINATOR
					| ESCAPE_LCOMMENT
					| ESCAPE_BCOMMENT
					| ESCAPE
							
					| HYPHEN
					| COMMA
					| SEMICOLON
							
					| RIGHT_ARROW
					| LEFT_ARROW
					| PRODUCTION_ARROW
					| RIGHT_SQUARE
					| LEFT_SQUARE
					| RIGHT_CURL
					| LEFT_CURL
							
					| FORWARD_SLASHES
					| FORWARD_SLASH
					| STAR
					| DATA ;


item 					: TILDE? (text_chunk)+ (TAG)?
					| TILDE? (text_chunk)+ (LINK)+
					| TILDE? (text_chunk)+ (DECORATOR)+
					| TILDE? (text_chunk)+ (LINK)+ TAG
					| TILDE? (text_chunk)+ TAG (LINK)+
					| TILDE? (text_chunk)+ (DECORATOR)+ TAG
					| TILDE? (text_chunk)+ TAG (DECORATOR)+
					| TILDE? (text_chunk)+ (DECORATOR)+ (LINK)+
					| TILDE? (text_chunk)+ (LINK)+ (DECORATOR)+
					| TILDE? (text_chunk)+ TAG (DECORATOR)+ (LINK)+
					| TILDE? (text_chunk)+ (DECORATOR)+ TAG (LINK)+
					| TILDE? (text_chunk)+ (DECORATOR)+ (LINK)+ TAG
					| TILDE? (text_chunk)+ TAG (LINK)+ (DECORATOR)+
					| TILDE? (text_chunk)+ (LINK)+ TAG (DECORATOR)+
					| TILDE? (text_chunk)+ (LINK)+ (DECORATOR)+ TAG ;


expression 				: item producer item_or_expression_list TERMINATOR
					| item producer item TERMINATOR
					| item producer expression TERMINATOR
					| item producer TERMINATOR ;


item_or_expression_part			: item SEPARATOR
					| expression (SEPARATOR)? ;


item_or_expression_list 		: (item_or_expression_part)+ item 
					| (item_or_expression_part)+ expression ;


expression_list				: (expression)+ expression ;


scripture 				: expression_list EOF
					| expression EOF ;

```

<br>
### Links
[Back](/language/how-to-write/)
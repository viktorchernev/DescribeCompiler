---
layout: page
title: Describe Tags
permalink: /language/version-07/
exclude: true
---
<br>Describe version 0.7, code-named Tags is the second test version of the language. It introduced tags and tagging with ids in angle brackets - ```<tagid>```

The ANTLR4 parser grammar is given next.<br><br>


<span style="color:blue">_Describe 0.7 - Tags_</span>
```
/* Describe Markup Language
 * version 0.7 (Tags)
 * Created by DemonOfReason and ChatGPT
 * Finished on 16 June 2024 */

grammar Describe07;


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
TAG					: '<' .+? '>' LINESPACE* ;

// Define lexer rules for other tokens
HYPHEN					: '-' ;
RIGHT_ARROW             		: '>' LINESPACE* ;
LEFT_ARROW             			: '<' LINESPACE* ;
SEPARATOR            			: ',' LINESPACE* ;
TERMINATOR           			: ';' LINESPACE* ;
FORWARD_SLASHES				: '//' LINESPACE* ;
FORWARD_SLASH     	 	        : '/' LINESPACE* ;
STAR					: '*' LINESPACE* ;

ESCAPE_ESCAPE        			: '\\\\' LINESPACE* ;
ESCAPE_HYPHEN      			: '\\-' LINESPACE* ;
ESCAPE_RIGHT_ARROW     		 	: '\\>' LINESPACE* ;
ESCAPE_LEFT_ARROW      			: '\\<' LINESPACE* ;
ESCAPE_SEPARATOR     			: '\\,' LINESPACE* ;
ESCAPE_TERMINATOR    			: '\\;' LINESPACE* ;
ESCAPE_LCOMMENT      			: '\\//' LINESPACE* ;
ESCAPE_BCOMMENT      			: '\\/*' LINESPACE* ;
ESCAPE               			: '\\' LINESPACE* ;

// Define lexer rule for data
fragment DATA_CHAR			: ~[\-<>,;*/\\] ;
DATA                			: DATA_CHAR+ ;

// Define parser rules
producer				: HYPHEN RIGHT_ARROW ;

text_chunk				: ESCAPE_ESCAPE
					| ESCAPE_HYPHEN
					| ESCAPE_RIGHT_ARROW
					| ESCAPE_LEFT_ARROW
					| ESCAPE_SEPARATOR
					| ESCAPE_TERMINATOR
					| ESCAPE_LCOMMENT
					| ESCAPE_BCOMMENT
					| ESCAPE
					| HYPHEN
							
					| RIGHT_ARROW
							
					| FORWARD_SLASHES
					| FORWARD_SLASH
					| STAR
					| DATA ;


item					: (text_chunk)+ (TAG)? ;

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
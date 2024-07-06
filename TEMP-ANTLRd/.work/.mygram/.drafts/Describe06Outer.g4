/** Describe Markup Language
 * version 0.6 (Basics)
 * Created by DemonOfReason and ChatGPT
 * Finished on 26 May 2024 */

grammar Describe06;


// Define lexer rules for comments
LINE_COMMENT       			: '//' .*? ('\r'? '\n' | EOF) -> skip ;
BLOCK_COMMENT       		: '/*' .*? '*/' -> skip ;
NEWLINE              		: '\n'+ | '\r\n'+ ;

// Define lexer rules for other tokens
HYPHEN						: '-' ;
RIGHT_ARROW             	: '>' [ \r\n\t\u000B\u000C\u0085\u00A0\u1680\u2000-\u200A\u2028\u2029\u202F\u205F\u3000]* ;
SEPARATOR            		: ',' [ \r\n\t\u000B\u000C\u0085\u00A0\u1680\u2000-\u200A\u2028\u2029\u202F\u205F\u3000]* ;
TERMINATOR           		: ';' [ \r\n\t\u000B\u000C\u0085\u00A0\u1680\u2000-\u200A\u2028\u2029\u202F\u205F\u3000]* ;
FORWARD_SLASH               : '/' ;

ESCAPE_ESCAPE        		: '\\\\' ;
ESCAPE_HYPHEN      			: '\\-' ;
ESCAPE_RIGHT_ARROW      	: '\\>' ;
ESCAPE_SEPARATOR     		: '\\,' ;
ESCAPE_TERMINATOR    		: '\\;' ;
ESCAPE_LCOMMENT      		: '\\//' ;
ESCAPE_BCOMMENT      		: '\\/*' ;
ESCAPE               		: '\\' ;

// Define lexer rule for data
fragment DATA_CHAR			: ~[\-<>,;*/\\] ;
DATA                		: DATA_CHAR+ ;

// Define parser rules
producer					: HYPHEN RIGHT_ARROW ;

text_chunk					: ESCAPE_ESCAPE
							| ESCAPE_HYPHEN
							| ESCAPE_RIGHT_ARROW
							| ESCAPE_SEPARATOR
							| ESCAPE_TERMINATOR
							| ESCAPE_LCOMMENT
							| ESCAPE_BCOMMENT
							| ESCAPE
							| NEWLINE
							| HYPHEN
							| RIGHT_ARROW
							| FORWARD_SLASH
							| DATA ;



item						: (text_chunk)+ ;

expression 					: item producer item_or_expression_list TERMINATOR
							| item producer item TERMINATOR
							| item producer expression TERMINATOR
							| item producer TERMINATOR ;

expression_outer			: item producer item_or_expression_list
							| item producer item_or_expression_list TERMINATOR
							| item producer item TERMINATOR
							| item producer expression TERMINATOR
							| item producer TERMINATOR ;


item_or_expression_part		: item SEPARATOR
							| expression (SEPARATOR)? ;

item_or_expression_list 	: (item_or_expression_part)+ item 
							| (item_or_expression_part)+ expression ;

expression_list				: (expression)+ expression
							| (expression)+ expression_outer ;

scripture 					: expression_list EOF
							| expression EOF
							| expression_outer EOF;
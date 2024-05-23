/** Describe Markup Language
 * version 0.6 (Basics)
 * Created by DemonOfReason and ChatGPT
 * Finished on 15 May 2024 */

grammar Describe06;


// Define lexer rules for comments
LINE_COMMENT       			: '//' .*? ('\r'? '\n' | EOF) -> skip ;
BLOCK_COMMENT       		: '/*' .*? '*/' -> skip ;
NEWLINE              		: '\n'+ | '\r\n'+ ;
WHITE_SPACE 				: [ \r\n\t\u000B\u000C\u0085\u00A0\u1680\u2000-\u200A\u2028\u2029\u202F\u205F\u3000]+ ;

// Define lexer rules for other tokens
PRODUCER             		: '->' ;
SEPARATOR            		: ',' ;
TERMINATOR           		: ';' ;

ESCAPE_ESCAPE        		: '\\\\' ;
ESCAPE_PRODUCER      		: '\\->' ;
ESCAPE_SEPARATOR     		: '\\,' ;
ESCAPE_TERMINATOR    		: '\\;' ;

ESCAPE_LCOMMENT      		: '\\//' ;
ESCAPE_BCOMMENT      		: '\\/*' ;

// Define lexer rule for data
DATA                		: ( . | '\\' ) ([a-zA-Z0-9_(){}<>[\]@#$%^&*+=~`:"?!])* ;

// Define parser rules
text_chunk					: ESCAPE_ESCAPE
							| ESCAPE_PRODUCER
							| ESCAPE_SEPARATOR
							| ESCAPE_TERMINATOR
							| ESCAPE_LCOMMENT
							| ESCAPE_BCOMMENT
							| NEWLINE
							| WHITE_SPACE
							| DATA ;

item						: text_chunk (text_chunk)* ;

expression					: item PRODUCER TERMINATOR    
							| item PRODUCER item_or_expression TERMINATOR
							| item PRODUCER item_or_expression_list TERMINATOR ;

item_or_expression			: item
							| expression ;

item_or_expression_list		: item SEPARATOR item_or_expression
							| expression (SEPARATOR)? item_or_expression
							| item SEPARATOR item_or_expression_list
							| expression (SEPARATOR)? item_or_expression_list ;

expression_list				: expression (expression)+ ;

scripture 					: expression_list text_chunk* EOF
							| expression text_chunk* EOF ;
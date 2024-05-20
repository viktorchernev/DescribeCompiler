/** Describe Markup Language
 * version 0.6 (Basics)
 * Created by DemonOfReason and ChatGPT
 * Finished on 15 May 2024 */

grammar Describe06;


// Define lexer rules for comments
LINE_COMMENT       			: '//' .*? ('\r'? '\n' | EOF) -> skip ;
BLOCK_COMMENT       		: '/*' .*? '*/' -> skip ;
NEWLINE              		: '\n'+ | '\r\n'+ ;

// Define lexer rules for other tokens
HYPHEN						: '-' ;
RIGHT_ARROW             	: '>' ;
SEPARATOR            		: ',' ;
TERMINATOR           		: ';' ;

ESCAPE_ESCAPE        		: '\\\\' ;
ESCAPE_HYPHEN      			: '\\-' ;
ESCAPE_RIGHT_ARROW      	: '\\>' ;
ESCAPE_SEPARATOR     		: '\\,' ;
ESCAPE_TERMINATOR    		: '\\;' ;
ESCAPE_LCOMMENT      		: '\\//' ;
ESCAPE_BCOMMENT      		: '\\/*' ;

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
							| NEWLINE
							| HYPHEN
							| RIGHT_ARROW
							| DATA ;

item						: text_chunk (text_chunk)* ;									//text_chunk+

expression					: item producer TERMINATOR    
							| item producer item_or_expression TERMINATOR
							| item producer item_or_expression_list TERMINATOR ;

item_or_expression			: item
							| expression ;

item_or_expression_list		: item SEPARATOR item_or_expression
							| expression (SEPARATOR)? item_or_expression
							| item SEPARATOR item_or_expression_list
							| expression (SEPARATOR)? item_or_expression_list ;

expression_list				: expression (expression)+ ;									//expression+ expression

scripture 					: expression_list text_chunk* EOF
							| expression text_chunk* EOF ;
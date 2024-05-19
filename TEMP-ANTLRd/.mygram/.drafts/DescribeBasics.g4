/** Describe Markup Language
 * version 0.6 (Describe Basics)
 * Created by DemonOfReason and ChatGPT
 * Created on 08 May 2024 
 * For more information visit: https://documentation.listiary.com/ 
 * or Github - https://github.com/viktorchernev/DescribeCompiler */

grammar DescribeBasics;

// Define lexer rules for comments
LCOMMENT_START       		: '//' .*? ('\r'? '\n' | EOF) -> skip ;
BCOMMENT_START       		: '/*' .*? '*/' -> skip ;
NEWLINE              		: '\n'+ | '\r\n'+ ;

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

DATA                		: .+ ; // Match any other characters


// Define parser rules
text_chunk					: ESCAPE_ESCAPE
							| ESCAPE_PRODUCER
							| ESCAPE_SEPARATOR
							| ESCAPE_TERMINATOR
							| ESCAPE_LCOMMENT
							| ESCAPE_BCOMMENT
							| NEWLINE 
							| DATA;

text						: text_chunk (text_chunk)* ;

item						: text ;

expression					: item PRODUCER TERMINATOR    
							| item PRODUCER item_or_expression TERMINATOR
							| item PRODUCER item_or_expression_list TERMINATOR ;

item_or_expression			: item
							| expression ;

item_or_expression_list		: item SEPARATOR item_or_expression
							| expression item_or_expression
							| item SEPARATOR item_or_expression_list
							| expression item_or_expression_list ;

expression_list				: expression (expression)+ ;

program 					: expression_list EOF
							| expression EOF;
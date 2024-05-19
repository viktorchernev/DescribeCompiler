/** Describe Markup Language
 * version 0.6 (Describe Basics)
 * Created by DemonOfReason and ChatGPT
 * Created on 08 May 2024 
 * For more information visit: https://documentation.listiary.com/ 
 * or Github - https://github.com/viktorchernev/DescribeCompiler */

grammar DescribeBasics;

// Define lexer rules for comments
LCOMMENT_START      		: '//' .*? ('\r'? '\n' | EOF) -> skip ;
BCOMMENT_START      		: '/*' .*? '*/' -> skip ;
NEWLINE             		: '\n'+ | '\r\n'+ ;

// Define lexer rules for other tokens
PRODUCER            		: '->' ;
SEPARATOR           		: ',' ;
TERMINATOR          		: ';' ;

ESCAPE_ESCAPE       		: '\\\\' ;
ESCAPE_PRODUCER     		: '\\->' ;
ESCAPE_SEPARATOR    		: '\\,' ;
ESCAPE_TERMINATOR   		: '\\;' ;

ESCAPE_LCOMMENT     		: '\\//' ;
ESCAPE_BCOMMENT     		: '\\/*' ;

DATA                		: .+ ; // Match any other characters


// Define parser rules
text_chunk					: DATA
							| ESCAPE_ESCAPE
							| ESCAPE_PRODUCER
							| ESCAPE_SEPARATOR
							| ESCAPE_TERMINATOR
							| ESCAPE_LCOMMENT
							| ESCAPE_BCOMMENT
							| NEWLINE ;

text_chunk_list				: text_chunk text_chunk
							| text_chunk_list text_chunk ;

text						: text_chunk
							| text_chunk_list ;

item_or_expression_list		: item SEPARATOR item
							| item SEPARATOR expression
							| expression item
							| expression expression
							| item SEPARATOR item_or_expression_list
							| expression SEPARATOR item_or_expression_list ;

item_or_expression			: item
							| expression ;

item						: text ;

expression_list				: expression expression
							| expression_list expression ;

expression					: item PRODUCER TERMINATOR    
							| item PRODUCER item_or_expression TERMINATOR
							| item PRODUCER item_or_expression_list TERMINATOR
							| item PRODUCER item_or_expression
							| item PRODUCER item_or_expression_list ;

program 					: expression EOF
							| expression_list EOF;
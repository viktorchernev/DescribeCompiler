/** Describe Markup Language
 * version 0.6 (Basics)
 * Created by DemonOfReason */

grammar DescribeBasics;


//Lexer
LCOMMENT_START				: '//' ;
BCOMMENT_START				: '/*' ;
BCOMMENT_END				: '*/' ;
NEWLINE 					: '\n'+ | '\r\n'+ ;

PRODUCER 					: '->' ;
SEPARATOR 					: ',' ;
TERMINATOR 					: ';' ;

ESCAPE_ESCAPE				: '\\\\' ;
ESCAPE_PRODUCER				: '\\->' ;
ESCAPE_SEPARATOR 			: '\\,' ;
ESCAPE_TERMINATOR 			: '\\;' ;

ESCAPE_LCOMMENT				: '\\//' ;
ESCAPE_BCOMMENT				: '\\/*' ;

DATA						: .(.)+? ;



//Parser
text_chunk					: DATA
							| ESCAPE_ESCAPE
							| ESCAPE_PRODUCER
							| ESCAPE_SEPARATOR
							| ESCAPE_TERMINATOR
							| ESCAPE_LCOMMENT
							| ESCAPE_BCOMMENT
							| NEWLINE ;

block_comment				: BCOMMENT_START text_chunk BCOMMENT_END
							| BCOMMENT_START text_chunk_list BCOMMENT_END ;

line_comment				: LCOMMENT_START text_chunk NEWLINE
							| LCOMMENT_START text_chunk_list NEWLINE ;

text_chunk_list				: text_chunk text_chunk
							| text_chunk text_chunk_list ;

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
							| expression expression_list ;

expression					: item PRODUCER TERMINATOR    
							| item PRODUCER item_or_expression TERMINATOR
							| item PRODUCER item_or_expression_list TERMINATOR
							| item PRODUCER item_or_expression
							| item PRODUCER item_or_expression_list ;

program 					: expression 
							| expression_list ;
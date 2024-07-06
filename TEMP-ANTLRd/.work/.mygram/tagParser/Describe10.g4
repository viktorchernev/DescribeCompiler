/* Describe Markup Language
 * version 1.0 (Lines)
 * Created by DemonOfReason and ChatGPT
 * Finished on 16 June 2024 */

grammar Describe10;


// Define lexer rules for comments
LINE_COMMENT       			: '// ' .*? ('\r'? '\n' [ \r\n\t\u000B\u000C\u0085\u00A0\u1680\u2000-\u200A\u2028\u2029\u202F\u205F\u3000]* | EOF) -> skip ;
BLOCK_COMMENT       		: '/*' .*? ('*/' [ \r\n\t\u000B\u000C\u0085\u00A0\u1680\u2000-\u200A\u2028\u2029\u202F\u205F\u3000]* | EOF) -> skip ;
LINK						: '[' .*? ']' [ \r\n\t\u000B\u000C\u0085\u00A0\u1680\u2000-\u200A\u2028\u2029\u202F\u205F\u3000]* ;
DECORATOR					: '{' .*? '}' [ \r\n\t\u000B\u000C\u0085\u00A0\u1680\u2000-\u200A\u2028\u2029\u202F\u205F\u3000]* ;

// Define lexer rules for other tokens
HYPHEN						: '-' ;

//not good. need whitespace between new line
PRODUCTION_ARROW            : '>' [ \r\t\u000B\u000C\u0085\u00A0\u1680\u2000-\u200A\u2028\u2029\u202F\u205F\u3000]* '\n' [ \r\n\t\u000B\u000C\u0085\u00A0\u1680\u2000-\u200A\u2028\u2029\u202F\u205F\u3000]* ;
DOUBLE_RIGHT_ARROW			: '>>' [ \r\n\t\u000B\u000C\u0085\u00A0\u1680\u2000-\u200A\u2028\u2029\u202F\u205F\u3000]*
RIGHT_ARROW             	: '>' [ \r\n\t\u000B\u000C\u0085\u00A0\u1680\u2000-\u200A\u2028\u2029\u202F\u205F\u3000]* ;
LEFT_ARROW             		: '<' [ \r\n\t\u000B\u000C\u0085\u00A0\u1680\u2000-\u200A\u2028\u2029\u202F\u205F\u3000]* ;

SEPARATOR            		: ',' [ \r\t\u000B\u000C\u0085\u00A0\u1680\u2000-\u200A\u2028\u2029\u202F\u205F\u3000]* '\n' [ \r\n\t\u000B\u000C\u0085\u00A0\u1680\u2000-\u200A\u2028\u2029\u202F\u205F\u3000]* 
							| ',,' [ \r\n\t\u000B\u000C\u0085\u00A0\u1680\u2000-\u200A\u2028\u2029\u202F\u205F\u3000]* ;

TERMINATOR           		: ';' [ \r\t\u000B\u000C\u0085\u00A0\u1680\u2000-\u200A\u2028\u2029\u202F\u205F\u3000]* '\n' [ \r\n\t\u000B\u000C\u0085\u00A0\u1680\u2000-\u200A\u2028\u2029\u202F\u205F\u3000]* 
							| ';;' [ \r\n\t\u000B\u000C\u0085\u00A0\u1680\u2000-\u200A\u2028\u2029\u202F\u205F\u3000]* ;

FORWARD_SLASHES             : '//' ;
FORWARD_SLASH               : '/' ;
COMMA						: ',' ;
SEMICOLON					: ';' ;

ESCAPE_ESCAPE        		: '\\\\' ;
ESCAPE_HYPHEN      			: '\\-' ;
ESCAPE_RIGHT_ARROW      	: '\\>' ;
ESCAPE_LEFT_ARROW      		: '\\<' ;
ESCAPE_RIGHT_SQUARE      	: '\\]' ;
ESCAPE_LEFT_SQUARE      	: '\\[' ;
ESCAPE_RIGHT_CURL      		: '\\}' ;
ESCAPE_LEFT_CURL     	 	: '\\{' ;
ESCAPE_SEPARATOR     		: '\\,' ;
ESCAPE_TERMINATOR    		: '\\;' ;
ESCAPE_LCOMMENT      		: '\\//' ;
ESCAPE_BCOMMENT      		: '\\/*' ;
ESCAPE               		: '\\' ;


// Define lexer rule for data
// Note: For some reason we don't need to escape '[' and '|'
// and ANTLR does not like when we try to escape them
fragment DATA_CHAR			: ~[{}[\]\-<>,;*/\\] ;
DATA                		: DATA_CHAR+ ;



// Define parser rules
producer					: HYPHEN ( PRODUCTION_ARROW | DOUBLE_RIGHT_ARROW );

text_chunk					: ESCAPE_ESCAPE
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
							| FORWARD_SLASHES
							| FORWARD_SLASH
							| DATA ;


tag							: LEFT_ARROW (DATA | HYPHEN | FORWARD_SLASH | FORWARD_SLASHES | ESCAPE | ESCAPE_ESCAPE)+ ( RIGHT_ARROW | PRODUCTION_ARROW ) ;


item 						: (text_chunk)+ (tag)?
							| (text_chunk)+ (LINK)+
							| (text_chunk)+ (DECORATOR)+
							| (text_chunk)+ (LINK)+ tag
							| (text_chunk)+ tag (LINK)+
							| (text_chunk)+ (DECORATOR)+ tag
							| (text_chunk)+ tag (DECORATOR)+
							| (text_chunk)+ (DECORATOR)+ (LINK)+
							| (text_chunk)+ (LINK)+ (DECORATOR)+
							| (text_chunk)+ tag (DECORATOR)+ (LINK)+
							| (text_chunk)+ (DECORATOR)+ tag (LINK)+
							| (text_chunk)+ (DECORATOR)+ (LINK)+ tag
							| (text_chunk)+ tag (LINK)+ (DECORATOR)+
							| (text_chunk)+ (LINK)+ tag (DECORATOR)+
							| (text_chunk)+ (LINK)+ (DECORATOR)+ tag ;


expression 					: item producer item_or_expression_list TERMINATOR
							| item producer item TERMINATOR
							| item producer expression TERMINATOR
							| item producer TERMINATOR ;


item_or_expression_part		: item SEPARATOR
							| expression (SEPARATOR)? ;


item_or_expression_list 	: (item_or_expression_part)+ item 
							| (item_or_expression_part)+ expression ;


expression_list				: (expression)+ expression ;


scripture 					: expression_list EOF
							| expression EOF ;
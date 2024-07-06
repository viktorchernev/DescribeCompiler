grammar Describe08;

// Define lexer rules for comments
LINE_COMMENT       			: '//' ~[\r\n]* -> skip ;
BLOCK_COMMENT       		: '/*' .*? '*/' -> skip ;
NEWLINE              		: '\r\n' | '\n' ;

// Define lexer rules for other tokens
HYPHEN						: '-' ;
PIPE						: '|' ;
RIGHT_ARROW             	: '>' [ \r\n\t]* ;
LEFT_ARROW             		: '<' [ \r\n\t]* ;
RIGHT_SQUARE             	: ']' [ \r\n\t]* ;
LEFT_SQUARE             	: '[' [ \r\n\t]* ;
SEPARATOR            		: ',' [ \r\n\t]* ;
TERMINATOR           		: ';' [ \r\n\t]* ;
FORWARD_SLASH               : '/' ;
URL                         : 'http' ('s'?) '://' (~[\r\n\[\]]+)* ; // Added URL rule to handle URLs in links

ESCAPE_ESCAPE        		: '\\\\' ;
ESCAPE_HYPHEN      			: '\\-' ;
ESCAPE_PIPE					: '\\|' ;
ESCAPE_RIGHT_ARROW      	: '\\>' ;
ESCAPE_LEFT_ARROW      		: '\\<' ;
ESCAPE_RIGHT_SQUARE      	: '\\]' ;
ESCAPE_LEFT_SQUARE      	: '\\[' ;
ESCAPE_SEPARATOR     		: '\\,' ;
ESCAPE_TERMINATOR    		: '\\;' ;
ESCAPE_LCOMMENT      		: '\\//' ;
ESCAPE_BCOMMENT      		: '\\/*' ;
ESCAPE               		: '\\' ;

// Define lexer rule for data
fragment DATA_CHAR			: ~[[|\]\-<>,;*/\\] ;
DATA                		: DATA_CHAR+ ;

// Define parser rules
producer					: HYPHEN RIGHT_ARROW ;

text_chunk					: ESCAPE_ESCAPE
							| ESCAPE_HYPHEN
							| ESCAPE_PIPE
							| ESCAPE_RIGHT_ARROW
							| ESCAPE_LEFT_ARROW
							| ESCAPE_RIGHT_SQUARE
							| ESCAPE_LEFT_SQUARE
							| ESCAPE_SEPARATOR
							| ESCAPE_TERMINATOR
							| ESCAPE_LCOMMENT
							| ESCAPE_BCOMMENT
							| ESCAPE
							| NEWLINE
							| HYPHEN
							| PIPE
							| RIGHT_ARROW
							| RIGHT_SQUARE
							| FORWARD_SLASH
							| DATA ;

tag							: LEFT_ARROW (DATA | HYPHEN | FORWARD_SLASH | ESCAPE | ESCAPE_ESCAPE)+ RIGHT_ARROW ;

link						: LEFT_SQUARE (URL | DATA | HYPHEN | FORWARD_SLASH | ESCAPE | ESCAPE_ESCAPE | SEPARATOR | TERMINATOR )+ RIGHT_SQUARE 
							| LEFT_SQUARE (URL | DATA | HYPHEN | FORWARD_SLASH | ESCAPE | ESCAPE_ESCAPE | SEPARATOR | TERMINATOR )+ PIPE (DATA | HYPHEN | FORWARD_SLASH | ESCAPE | ESCAPE_ESCAPE )+ RIGHT_SQUARE;

item 						: (text_chunk)+ (tag)?
							| (text_chunk)+ (link)+
							| (text_chunk)+ (link)+ tag
							| (text_chunk)+ tag (link)+ ;

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








// Define lexer rule for URL 
//fragment SCHEME 			: 'http' 's'? | 'ftp' | 'file' | 'mailto' | 'tel' | 'data' | 'ws' 's'?
//							| 'ldap' | 'sip' 's'? | 'sftp' | 'smb' | 'svn' | 'git' | 'nfs' | 'rtsp'
//							| 'magnet' | 'news' | 'irc' | 'jdbc' | 'chrome' ;
//
//URL 						: SCHEME '://' (~[ \r\n\t\u000B\u000C\u0085\u00A0\u1680\u2000-\u200A\u2028\u2029\u202F\u205F\u3000<>#"{}|\\^`]+)* ;
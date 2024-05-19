lexer grammar DescribeBasicsLexer;

LCOMMENT_START				: '//' ;
BCOMMENT_START				: '/*' ;
BCOMMENT_END				: '*/' ;

NEWLINE 				: '\n'+ | '\r\n'+ ;
PRODUCER 				: '->' ;
SEPARATOR 				: ',' ;
TERMINATOR 					: ';' ;

ESCAPE_ESCAPE				: '\\\\' ;
ESCAPE_PRODUCER				: '\\->' ;
ESCAPE_SEPARATOR 			: '\\,' ;
ESCAPE_TERMINATOR 			: '\\;' ;

ESCAPE_LCOMMENT				: '\\//' ;
ESCAPE_BCOMMENT				: '\\/*' ;

LOWERCASE  				: 'a'..'z' ;
UPPERCASE  				: 'A'..'Z' ;
NUMERIC					: '0'..'9' ;
DATA					: LOWERCASE+ | UPPERCASE+ | NUMERIC+ ;
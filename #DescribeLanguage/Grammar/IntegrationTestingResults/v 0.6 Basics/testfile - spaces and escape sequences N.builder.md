========================================
Source Code (between the arrows)
========================================

🡆fabric     s 	->

	wool   fabrics	,
	cotton\, fabrics textiles  ,
    silk\-\>fabrics,
    syntic 		fabrics;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  +--<item> ::= <text>
|  |  |  +--<text> ::= <text-chunk>
|  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  +--fabric     s    
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  +--<item> ::= <text>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--  wool   fabrics  
|  |  |  +--,
|  |  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  |  +--<item> ::= <text>
|  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--   cotton
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeSeparator
|  |  |  |  |  |  |  |  |  +--\,
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +-- fabrics textiles  
|  |  |  |  +--,
|  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--    silk
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeHyphen
|  |  |  |  |  |  |  |  |  |  +--\-
|  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeRightArrow
|  |  |  |  |  |  |  |  |  |  |  +--\>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  +--fabrics
|  |  |  |  |  +--,
|  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    syntic      fabrics
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                         Description                                                             
---------------   -----   -----   -----   ---------------------------------   ------------------------------------------------------------------------
Token Read            0       0       0   fabric     s                        Token type: Text                                                        
Shift                10                                                       The parser shifted to state 10                                          
Token Read           10       0      16   -                                   Token type: Hyphen                                                      
Reduce               16                   (1) ::= fabric     s                <text-chunk> ::= Text                                                   
Reduce               15                   (2) ::= (1)                         <text> ::= <text-chunk>                                                 
Reduce               13                   (3) ::= (2)                         <item> ::= <text>                                                       
Shift                20                                                       The parser shifted to state 20                                          
Token Read           20       0      17   >                                   Token type: RightArrow                                                  
Shift                24                                                       The parser shifted to state 24                                          
Token Read           24       0      18     wool   fabrics                    Token type: Text                                                        
Reduce               21                   (4) ::= - >                         <producer> ::= Hyphen RightArrow                                        
Shift                10                                                       The parser shifted to state 10                                          
Token Read           10       0      36   ,                                   Token type: Separator                                                   
Reduce               16                   (5) ::=   wool   fabrics            <text-chunk> ::= Text                                                   
Reduce               15                   (6) ::= (5)                         <text> ::= <text-chunk>                                                 
Reduce               27                   (7) ::= (6)                         <item> ::= <text>                                                       
Shift                33                                                       The parser shifted to state 33                                          
Token Read           33       0      37      cotton                           Token type: Text                                                        
Shift                10                                                       The parser shifted to state 10                                          
Token Read           10       0      46   \,                                  Token type: EscapeSeparator                                             
Reduce               16                   (8) ::=    cotton                   <text-chunk> ::= Text                                                   
Shift                 7                                                       The parser shifted to state 7                                           
Token Read            7       0      48    fabrics textiles                   Token type: Text                                                        
Reduce               22                   (9) ::= \,                          <text-chunk> ::= EscapeSeparator                                        
Shift                10                                                       The parser shifted to state 10                                          
Token Read           10       0      67   ,                                   Token type: Separator                                                   
Reduce               22                   (10) ::=  fabrics textiles          <text-chunk> ::= Text                                                   
Reduce               23                   (11) ::= (9) (10)                   <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               17                   (12) ::= (8) (11)                   <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               15                   (13) ::= (12)                       <text> ::= <text-chunk-list>                                            
Reduce               37                   (14) ::= (13)                       <item> ::= <text>                                                       
Shift                33                                                       The parser shifted to state 33                                          
Token Read           33       0      68       silk                            Token type: Text                                                        
Shift                10                                                       The parser shifted to state 10                                          
Token Read           10       0      76   \-                                  Token type: EscapeHyphen                                                
Reduce               16                   (15) ::=     silk                   <text-chunk> ::= Text                                                   
Shift                 4                                                       The parser shifted to state 4                                           
Token Read            4       0      78   \>                                  Token type: EscapeRightArrow                                            
Reduce               22                   (16) ::= \-                         <text-chunk> ::= EscapeHyphen                                           
Shift                 6                                                       The parser shifted to state 6                                           
Token Read            6       0      80   fabrics                             Token type: Text                                                        
Reduce               22                   (17) ::= \>                         <text-chunk> ::= EscapeRightArrow                                       
Shift                10                                                       The parser shifted to state 10                                          
Token Read           10       0      87   ,                                   Token type: Separator                                                   
Reduce               22                   (18) ::= fabrics                    <text-chunk> ::= Text                                                   
Reduce               23                   (19) ::= (17) (18)                  <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               23                   (20) ::= (16) (19)                  <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (21) ::= (15) (20)                  <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               15                   (22) ::= (21)                       <text> ::= <text-chunk-list>                                            
Reduce               37                   (23) ::= (22)                       <item> ::= <text>                                                       
Shift                33                                                       The parser shifted to state 33                                          
Token Read           33       0      88       syntic      fabrics             Token type: Text                                                        
Shift                10                                                       The parser shifted to state 10                                          
Token Read           10       0     111   ;                                   Token type: Terminator                                                  
Reduce               16                   (24) ::=     syntic      fabrics    <text-chunk> ::= Text                                                   
Reduce               15                   (25) ::= (24)                       <text> ::= <text-chunk>                                                 
Reduce               37                   (26) ::= (25)                       <item> ::= <text>                                                       
Reduce               38                   (27) ::= (23) , (26)                <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               38                   (28) ::= (14) , (27)                <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               29                   (29) ::= (7) , (28)                 <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                35                                                       The parser shifted to state 35                                          
Token Read           35       1       0                                       Token type: EOF                                                         
Reduce               11                   (30) ::= (3) (4) (29) ;             <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               14                   (31) ::= (30)                       <scripture> ::= <expression>                                            
Accept               14                                                                                                                               



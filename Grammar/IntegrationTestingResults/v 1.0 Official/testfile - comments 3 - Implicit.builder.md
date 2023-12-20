Cannot be parsed without preprocessing by the Describe Compiler preprocessor
Note: We do have second semicolon added in the comment, but this is not an issue
since the comments are discarded from the parser anyway.
========================================
Source Code (between the arrows)
========================================

🡆fabrics ->        //dude;

    wool fabrics, /* comment <*/
/* ->Comments, man */    cotton fabrics;🡄

========================================
Preprocessed (between the arrows)
========================================

🡆fabrics ->>        //dude;;

    wool fabrics\, /* comment \<*/
/* \-\>Comments\, man */    cotton fabrics;;
🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression> <terminator>
|  |  +--<item> ::= <text>
|  |  |  +--<text> ::= <text-chunk>
|  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  +--fabrics 
|  |  +--<producer> ::= Hyphen RightArrow RightArrow
|  |  |  +---
|  |  |  +-->
|  |  |  +-->
|  |  +--<item-or-expression> ::= <item>
|  |  |  +--<item> ::= <text>
|  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    wool fabrics
|  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= EscapeSeparator
|  |  |  |  |  |  |  |  +--\,
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    cotton fabrics
|  |  +--<terminator> ::= Terminator Terminator
|  |  |  +--;
|  |  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                   Description                                                         
---------------   -----   -----   -----   ---------------------------   --------------------------------------------------------------------
Token Read            0       0       0   fabrics                       Token type: Text                                                    
Shift                14                                                 The parser shifted to state 14                                      
Token Read           14       0       8   -                             Token type: Hyphen                                                  
Reduce               20                   (1) ::= fabrics               <text-chunk> ::= Text                                               
Reduce               19                   (2) ::= (1)                   <text> ::= <text-chunk>                                             
Reduce               17                   (3) ::= (2)                   <item> ::= <text>                                                   
Shift                24                                                 The parser shifted to state 24                                      
Token Read           24       0       9   >                             Token type: RightArrow                                              
Shift                35                                                 The parser shifted to state 35                                      
Token Read           35       0      10   >                             Token type: RightArrow                                              
Shift                64                                                 The parser shifted to state 64                                      
Token Read           64       2       0       wool fabrics              Token type: Text                                                    
Reduce               25                   (4) ::= - > >                 <producer> ::= Hyphen RightArrow RightArrow                         
Shift                14                                                 The parser shifted to state 14                                      
Token Read           14       2      16   \,                            Token type: EscapeSeparator                                         
Reduce               20                   (5) ::=     wool fabrics      <text-chunk> ::= Text                                               
Shift                11                                                 The parser shifted to state 11                                      
Token Read           11       3      24       cotton fabrics            Token type: Text                                                    
Reduce               33                   (6) ::= \,                    <text-chunk> ::= EscapeSeparator                                    
Shift                14                                                 The parser shifted to state 14                                      
Token Read           14       3      42   ;                             Token type: Terminator                                              
Reduce               33                   (7) ::=     cotton fabrics    <text-chunk> ::= Text                                               
Reduce               34                   (8) ::= (6) (7)               <text-chunk-list> ::= <text-chunk> <text-chunk>                     
Reduce               21                   (9) ::= (5) (8)               <text-chunk-list> ::= <text-chunk> <text-chunk-list>                
Reduce               19                   (10) ::= (9)                  <text> ::= <text-chunk-list>                                        
Reduce               38                   (11) ::= (10)                 <item> ::= <text>                                                   
Reduce               39                   (12) ::= (11)                 <item-or-expression> ::= <item>                                     
Shift                36                                                 The parser shifted to state 36                                      
Token Read           36       3      43   ;                             Token type: Terminator                                              
Shift                65                                                 The parser shifted to state 65                                      
Token Read           65       5       0                                 Token type: EOF                                                     
Reduce               71                   (13) ::= ; ;                  <terminator> ::= Terminator Terminator                              
Reduce               15                   (14) ::= (3) (4) (12) (13)    <expression> ::= <item> <producer> <item-or-expression> <terminator>
Reduce               18                   (15) ::= (14)                 <scripture> ::= <expression>                                        
Accept               18                                                                                                                     



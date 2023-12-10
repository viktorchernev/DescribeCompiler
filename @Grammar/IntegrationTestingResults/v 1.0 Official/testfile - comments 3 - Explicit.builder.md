========================================
Source Code (between the arrows)
========================================

🡆fabrics ->>        //dude;

    wool fabrics,, /* << comment <*/
/* ->Comments, man */    cotton fabrics;;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression-list> <terminator>
|  |  +--<item> ::= <text>
|  |  |  +--<text> ::= <text-chunk>
|  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  +--fabrics 
|  |  +--<producer> ::= Hyphen RightArrow RightArrow
|  |  |  +---
|  |  |  +-->
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <item> <separator> <item>
|  |  |  +--<item> ::= <text>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--    wool fabrics
|  |  |  +--<separator> ::= Separator Separator
|  |  |  |  +--,
|  |  |  |  +--,
|  |  |  +--<item> ::= <text>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--    cotton fabrics
|  |  +--<terminator> ::= Terminator Terminator
|  |  |  +--;
|  |  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                   Description                                                              
---------------   -----   -----   -----   ---------------------------   -------------------------------------------------------------------------
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
Token Read           14       2      16   ,                             Token type: Separator                                                    
Reduce               20                   (5) ::=     wool fabrics      <text-chunk> ::= Text                                                    
Reduce               19                   (6) ::= (5)                   <text> ::= <text-chunk>                                                  
Reduce               38                   (7) ::= (6)                   <item> ::= <text>                                                        
Shift                69                                                 The parser shifted to state 69                                           
Token Read           69       2      17   ,                             Token type: Separator                                                    
Shift                99                                                 The parser shifted to state 99                                           
Token Read           99       3      21       cotton fabrics            Token type: Text                                                         
Reduce               70                   (8) ::= , ,                   <separator> ::= Separator Separator                                      
Shift                14                                                 The parser shifted to state 14                                           
Token Read           14       3      39   ;                             Token type: Terminator                                                   
Reduce               20                   (9) ::=     cotton fabrics    <text-chunk> ::= Text                                                    
Reduce               19                   (10) ::= (9)                  <text> ::= <text-chunk>                                                  
Reduce              101                   (11) ::= (10)                 <item> ::= <text>                                                        
Reduce               40                   (12) ::= (7) (8) (11)         <item-or-expression-list> ::= <item> <separator> <item>                  
Shift                36                                                 The parser shifted to state 36                                           
Token Read           36       3      40   ;                             Token type: Terminator                                                   
Shift                65                                                 The parser shifted to state 65                                           
Token Read           65       4       0                                 Token type: EOF                                                          
Reduce               72                   (13) ::= ; ;                  <terminator> ::= Terminator Terminator                                   
Reduce               15                   (14) ::= (3) (4) (12) (13)    <expression> ::= <item> <producer> <item-or-expression-list> <terminator>
Reduce               18                   (15) ::= (14)                 <scripture> ::= <expression>                                             
Accept               18                                                                                                                          



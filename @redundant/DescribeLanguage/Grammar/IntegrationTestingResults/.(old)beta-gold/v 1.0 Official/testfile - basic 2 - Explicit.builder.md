========================================
Source Code (between the arrows)
========================================

🡆fabrics ->> 
	
	synthetic fabrics;;🡄

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
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--    synthetic fabrics
|  |  +--<terminator> ::= Terminator Terminator
|  |  |  +--;
|  |  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                      Description                                                         
---------------   -----   -----   -----   ------------------------------   --------------------------------------------------------------------
Token Read            0       0       0   fabrics                          Token type: Text                                                    
Shift                14                                                    The parser shifted to state 14                                      
Token Read           14       0       8   -                                Token type: Hyphen                                                  
Reduce               20                   (1) ::= fabrics                  <text-chunk> ::= Text                                               
Reduce               19                   (2) ::= (1)                      <text> ::= <text-chunk>                                             
Reduce               17                   (3) ::= (2)                      <item> ::= <text>                                                   
Shift                24                                                    The parser shifted to state 24                                      
Token Read           24       0       9   >                                Token type: RightArrow                                              
Shift                35                                                    The parser shifted to state 35                                      
Token Read           35       0      10   >                                Token type: RightArrow                                              
Shift                64                                                    The parser shifted to state 64                                      
Token Read           64       2       0       synthetic fabrics            Token type: Text                                                    
Reduce               25                   (4) ::= - > >                    <producer> ::= Hyphen RightArrow RightArrow                         
Shift                14                                                    The parser shifted to state 14                                      
Token Read           14       2      21   ;                                Token type: Terminator                                              
Reduce               20                   (5) ::=     synthetic fabrics    <text-chunk> ::= Text                                               
Reduce               19                   (6) ::= (5)                      <text> ::= <text-chunk>                                             
Reduce               38                   (7) ::= (6)                      <item> ::= <text>                                                   
Reduce               39                   (8) ::= (7)                      <item-or-expression> ::= <item>                                     
Shift                36                                                    The parser shifted to state 36                                      
Token Read           36       2      22   ;                                Token type: Terminator                                              
Shift                65                                                    The parser shifted to state 65                                      
Token Read           65       3       0                                    Token type: EOF                                                     
Reduce               71                   (9) ::= ; ;                      <terminator> ::= Terminator Terminator                              
Reduce               15                   (10) ::= (3) (4) (8) (9)         <expression> ::= <item> <producer> <item-or-expression> <terminator>
Reduce               18                   (11) ::= (10)                    <scripture> ::= <expression>                                        
Accept               18                                                                                                                        



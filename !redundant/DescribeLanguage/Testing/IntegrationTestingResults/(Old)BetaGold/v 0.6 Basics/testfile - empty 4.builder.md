========================================
Source Code (between the arrows)
========================================

🡆fabrics -> 

;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> Terminator
|  |  +--<item> ::= <text>
|  |  |  +--<text> ::= <text-chunk>
|  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  +--fabrics 
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value          Description                                  
---------------   -----   -----   -----   ------------------   ---------------------------------------------
Token Read            0       0       0   fabrics              Token type: Text                             
Shift                10                                        The parser shifted to state 10               
Token Read           10       0       8   -                    Token type: Hyphen                           
Reduce               16                   (1) ::= fabrics      <text-chunk> ::= Text                        
Reduce               15                   (2) ::= (1)          <text> ::= <text-chunk>                      
Reduce               13                   (3) ::= (2)          <item> ::= <text>                            
Shift                20                                        The parser shifted to state 20               
Token Read           20       0       9   >                    Token type: RightArrow                       
Shift                24                                        The parser shifted to state 24               
Token Read           24       2       0   ;                    Token type: Terminator                       
Reduce               21                   (4) ::= - >          <producer> ::= Hyphen RightArrow             
Shift                25                                        The parser shifted to state 25               
Token Read           25       3       0                        Token type: EOF                              
Reduce               11                   (5) ::= (3) (4) ;    <expression> ::= <item> <producer> Terminator
Reduce               14                   (6) ::= (5)          <scripture> ::= <expression>                 
Accept               14                                                                                     



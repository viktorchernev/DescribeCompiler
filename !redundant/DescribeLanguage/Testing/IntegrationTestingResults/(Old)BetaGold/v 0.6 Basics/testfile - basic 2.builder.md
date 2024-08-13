========================================
Source Code (between the arrows)
========================================

🡆fabrics -> 
	
	synthetic fabrics;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression> Terminator
|  |  +--<item> ::= <text>
|  |  |  +--<text> ::= <text-chunk>
|  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  +--fabrics 
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--<item-or-expression> ::= <item>
|  |  |  +--<item> ::= <text>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--    synthetic fabrics
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                      Description                                                       
---------------   -----   -----   -----   ------------------------------   ------------------------------------------------------------------
Token Read            0       0       0   fabrics                          Token type: Text                                                  
Shift                10                                                    The parser shifted to state 10                                    
Token Read           10       0       8   -                                Token type: Hyphen                                                
Reduce               16                   (1) ::= fabrics                  <text-chunk> ::= Text                                             
Reduce               15                   (2) ::= (1)                      <text> ::= <text-chunk>                                           
Reduce               13                   (3) ::= (2)                      <item> ::= <text>                                                 
Shift                20                                                    The parser shifted to state 20                                    
Token Read           20       0       9   >                                Token type: RightArrow                                            
Shift                24                                                    The parser shifted to state 24                                    
Token Read           24       2       0       synthetic fabrics            Token type: Text                                                  
Reduce               21                   (4) ::= - >                      <producer> ::= Hyphen RightArrow                                  
Shift                10                                                    The parser shifted to state 10                                    
Token Read           10       2      21   ;                                Token type: Terminator                                            
Reduce               16                   (5) ::=     synthetic fabrics    <text-chunk> ::= Text                                             
Reduce               15                   (6) ::= (5)                      <text> ::= <text-chunk>                                           
Reduce               27                   (7) ::= (6)                      <item> ::= <text>                                                 
Reduce               28                   (8) ::= (7)                      <item-or-expression> ::= <item>                                   
Shift                34                                                    The parser shifted to state 34                                    
Token Read           34       3       0                                    Token type: EOF                                                   
Reduce               11                   (9) ::= (3) (4) (8) ;            <expression> ::= <item> <producer> <item-or-expression> Terminator
Reduce               14                   (10) ::= (9)                     <scripture> ::= <expression>                                      
Accept               14                                                                                                                      



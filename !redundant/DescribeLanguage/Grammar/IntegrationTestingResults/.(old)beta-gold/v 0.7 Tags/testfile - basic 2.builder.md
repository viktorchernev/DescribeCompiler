========================================
Source Code (between the arrows)
========================================

🡆fabrics -> 
	
	synthetic fabrics <i1NLckN6>;🡄

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
|  |  |  +--<item> ::= <text> <tag>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--    synthetic fabrics 
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--i1NLckN6
|  |  |  |  |  +-->
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                       Description                                                       
---------------   -----   -----   -----   -------------------------------   ------------------------------------------------------------------
Token Read            0       0       0   fabrics                           Token type: Text                                                  
Shift                11                                                     The parser shifted to state 11                                    
Token Read           11       0       8   -                                 Token type: Hyphen                                                
Reduce               18                   (1) ::= fabrics                   <text-chunk> ::= Text                                             
Reduce               17                   (2) ::= (1)                       <text> ::= <text-chunk>                                           
Reduce               14                   (3) ::= (2)                       <item> ::= <text>                                                 
Shift                23                                                     The parser shifted to state 23                                    
Token Read           23       0       9   >                                 Token type: RightArrow                                            
Shift                30                                                     The parser shifted to state 30                                    
Token Read           30       2       0       synthetic fabrics             Token type: Text                                                  
Reduce               24                   (4) ::= - >                       <producer> ::= Hyphen RightArrow                                  
Shift                11                                                     The parser shifted to state 11                                    
Token Read           11       2      22   <                                 Token type: LeftArrow                                             
Reduce               18                   (5) ::=     synthetic fabrics     <text-chunk> ::= Text                                             
Reduce               17                   (6) ::= (5)                       <text> ::= <text-chunk>                                           
Shift                10                                                     The parser shifted to state 10                                    
Token Read           10       2      23   i1NLckN6                          Token type: Text                                                  
Shift                11                                                     The parser shifted to state 11                                    
Token Read           11       2      31   >                                 Token type: RightArrow                                            
Reduce               18                   (7) ::= i1NLckN6                  <text-chunk> ::= Text                                             
Reduce               20                   (8) ::= (7)                       <text> ::= <text-chunk>                                           
Shift                29                                                     The parser shifted to state 29                                    
Token Read           29       2      32   ;                                 Token type: Terminator                                            
Reduce               26                   (9) ::= < (8) >                   <tag> ::= LeftArrow <text> RightArrow                             
Reduce               33                   (10) ::= (6) (9)                  <item> ::= <text> <tag>                                           
Reduce               34                   (11) ::= (10)                     <item-or-expression> ::= <item>                                   
Shift                40                                                     The parser shifted to state 40                                    
Token Read           40       3       0                                     Token type: EOF                                                   
Reduce               12                   (12) ::= (3) (4) (11) ;           <expression> ::= <item> <producer> <item-or-expression> Terminator
Reduce               15                   (13) ::= (12)                     <scripture> ::= <expression>                                      
Accept               15                                                                                                                       



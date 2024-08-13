========================================
Source Code (between the arrows)
========================================

🡆fabrics<YMFX0PTE>-> ;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> Terminator
|  |  +--<item> ::= <text> <tag>
|  |  |  +--<text> ::= <text-chunk>
|  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  +--fabrics
|  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  +--<
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--YMFX0PTE
|  |  |  |  +-->
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
Shift                11                                        The parser shifted to state 11               
Token Read           11       0       7   <                    Token type: LeftArrow                        
Reduce               18                   (1) ::= fabrics      <text-chunk> ::= Text                        
Reduce               17                   (2) ::= (1)          <text> ::= <text-chunk>                      
Shift                10                                        The parser shifted to state 10               
Token Read           10       0       8   YMFX0PTE             Token type: Text                             
Shift                11                                        The parser shifted to state 11               
Token Read           11       0      16   >                    Token type: RightArrow                       
Reduce               18                   (3) ::= YMFX0PTE     <text-chunk> ::= Text                        
Reduce               20                   (4) ::= (3)          <text> ::= <text-chunk>                      
Shift                29                                        The parser shifted to state 29               
Token Read           29       0      17   -                    Token type: Hyphen                           
Reduce               26                   (5) ::= < (4) >      <tag> ::= LeftArrow <text> RightArrow        
Reduce               14                   (6) ::= (2) (5)      <item> ::= <text> <tag>                      
Shift                23                                        The parser shifted to state 23               
Token Read           23       0      18   >                    Token type: RightArrow                       
Shift                30                                        The parser shifted to state 30               
Token Read           30       0      20   ;                    Token type: Terminator                       
Reduce               24                   (7) ::= - >          <producer> ::= Hyphen RightArrow             
Shift                31                                        The parser shifted to state 31               
Token Read           31       1       0                        Token type: EOF                              
Reduce               12                   (8) ::= (6) (7) ;    <expression> ::= <item> <producer> Terminator
Reduce               15                   (9) ::= (8)          <scripture> ::= <expression>                 
Accept               15                                                                                     



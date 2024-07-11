========================================
Source Code (between the arrows)
========================================

🡆fabrics <zAfn39Kh>-> synthetic fabrics <hOy5oL3B> ;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression> Terminator
|  |  +--<item> ::= <text> <tag>
|  |  |  +--<text> ::= <text-chunk>
|  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  +--fabrics 
|  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  +--<
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--zAfn39Kh
|  |  |  |  +-->
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--<item-or-expression> ::= <item>
|  |  |  +--<item> ::= <text> <tag>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +-- synthetic fabrics 
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--hOy5oL3B
|  |  |  |  |  +-->
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                    Description                                                       
---------------   -----   -----   -----   ----------------------------   ------------------------------------------------------------------
Token Read            0       0       0   fabrics                        Token type: Text                                                  
Shift                11                                                  The parser shifted to state 11                                    
Token Read           11       0       8   <                              Token type: LeftArrow                                             
Reduce               18                   (1) ::= fabrics                <text-chunk> ::= Text                                             
Reduce               17                   (2) ::= (1)                    <text> ::= <text-chunk>                                           
Shift                10                                                  The parser shifted to state 10                                    
Token Read           10       0       9   zAfn39Kh                       Token type: Text                                                  
Shift                11                                                  The parser shifted to state 11                                    
Token Read           11       0      17   >                              Token type: RightArrow                                            
Reduce               18                   (3) ::= zAfn39Kh               <text-chunk> ::= Text                                             
Reduce               20                   (4) ::= (3)                    <text> ::= <text-chunk>                                           
Shift                29                                                  The parser shifted to state 29                                    
Token Read           29       0      18   -                              Token type: Hyphen                                                
Reduce               26                   (5) ::= < (4) >                <tag> ::= LeftArrow <text> RightArrow                             
Reduce               14                   (6) ::= (2) (5)                <item> ::= <text> <tag>                                           
Shift                23                                                  The parser shifted to state 23                                    
Token Read           23       0      19   >                              Token type: RightArrow                                            
Shift                30                                                  The parser shifted to state 30                                    
Token Read           30       0      20    synthetic fabrics             Token type: Text                                                  
Reduce               24                   (7) ::= - >                    <producer> ::= Hyphen RightArrow                                  
Shift                11                                                  The parser shifted to state 11                                    
Token Read           11       0      39   <                              Token type: LeftArrow                                             
Reduce               18                   (8) ::=  synthetic fabrics     <text-chunk> ::= Text                                             
Reduce               17                   (9) ::= (8)                    <text> ::= <text-chunk>                                           
Shift                10                                                  The parser shifted to state 10                                    
Token Read           10       0      40   hOy5oL3B                       Token type: Text                                                  
Shift                11                                                  The parser shifted to state 11                                    
Token Read           11       0      48   >                              Token type: RightArrow                                            
Reduce               18                   (10) ::= hOy5oL3B              <text-chunk> ::= Text                                             
Reduce               20                   (11) ::= (10)                  <text> ::= <text-chunk>                                           
Shift                29                                                  The parser shifted to state 29                                    
Token Read           29       0      50   ;                              Token type: Terminator                                            
Reduce               26                   (12) ::= < (11) >              <tag> ::= LeftArrow <text> RightArrow                             
Reduce               33                   (13) ::= (9) (12)              <item> ::= <text> <tag>                                           
Reduce               34                   (14) ::= (13)                  <item-or-expression> ::= <item>                                   
Shift                40                                                  The parser shifted to state 40                                    
Token Read           40       1       0                                  Token type: EOF                                                   
Reduce               12                   (15) ::= (6) (7) (14) ;        <expression> ::= <item> <producer> <item-or-expression> Terminator
Reduce               15                   (16) ::= (15)                  <scripture> ::= <expression>                                      
Accept               15                                                                                                                    



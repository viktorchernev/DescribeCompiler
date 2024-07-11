========================================
Source Code (between the arrows)
========================================

🡆fabrics
<SIrifQYp>
[https://www.notube.com/watch?v=hTui12lKus]
[https://www.notube.com/watch?v=hTui12lKus]
[]
-> 

;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> Terminator
|  |  +--<item> ::= <text> <tag> <links>
|  |  |  +--<text> ::= <text-chunk>
|  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  +--fabrics
|  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  +--<
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--SIrifQYp
|  |  |  |  +-->
|  |  |  +--<links> ::= Link <links>
|  |  |  |  +--[https://www.notube.com/watch?v=hTui12lKus]
|  |  |  |  +--<links> ::= Link Link
|  |  |  |  |  +--[https://www.notube.com/watch?v=hTui12lKus]
|  |  |  |  |  +--[]
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                                                Description                                  
---------------   -----   -----   -----   --------------------------------------------------------   ---------------------------------------------
Token Read            0       0       0   fabrics                                                    Token type: Text                             
Shift                12                                                                              The parser shifted to state 12               
Token Read           12       1       0   <                                                          Token type: LeftArrow                        
Reduce               18                   (1) ::= fabrics                                            <text-chunk> ::= Text                        
Reduce               17                   (2) ::= (1)                                                <text> ::= <text-chunk>                      
Shift                24                                                                              The parser shifted to state 24               
Token Read           24       1       1   SIrifQYp                                                   Token type: Text                             
Shift                12                                                                              The parser shifted to state 12               
Token Read           12       1       9   >                                                          Token type: RightArrow                       
Reduce               18                   (3) ::= SIrifQYp                                           <text-chunk> ::= Text                        
Reduce               36                   (4) ::= (3)                                                <text> ::= <text-chunk>                      
Shift                49                                                                              The parser shifted to state 49               
Token Read           49       2       0   [https://www.notube.com/watch?v=hTui12lKus]                Token type: Link                             
Reduce               27                   (5) ::= < (4) >                                            <tag> ::= LeftArrow <text> RightArrow        
Shift                41                                                                              The parser shifted to state 41               
Token Read           41       3       0   [https://www.notube.com/watch?v=hTui12lKus]                Token type: Link                             
Shift                37                                                                              The parser shifted to state 37               
Token Read           37       4       0   []                                                         Token type: Link                             
Shift                37                                                                              The parser shifted to state 37               
Token Read           37       5       0   -                                                          Token type: Hyphen                           
Reduce               38                   (6) ::= [https://www.notube.com/watch?v=hTui12lKus] []     <links> ::= Link Link                        
Reduce               42                   (7) ::= [https://www.notube.com/watch?v=hTui12lKus] (6)    <links> ::= Link <links>                     
Reduce               15                   (8) ::= (2) (5) (7)                                        <item> ::= <text> <tag> <links>              
Shift                22                                                                              The parser shifted to state 22               
Token Read           22       5       1   >                                                          Token type: RightArrow                       
Shift                30                                                                              The parser shifted to state 30               
Token Read           30       7       0   ;                                                          Token type: Terminator                       
Reduce               23                   (9) ::= - >                                                <producer> ::= Hyphen RightArrow             
Shift                31                                                                              The parser shifted to state 31               
Token Read           31       8       0                                                              Token type: EOF                              
Reduce               13                   (10) ::= (8) (9) ;                                         <expression> ::= <item> <producer> Terminator
Reduce               16                   (11) ::= (10)                                              <scripture> ::= <expression>                 
Accept               16                                                                                                                           



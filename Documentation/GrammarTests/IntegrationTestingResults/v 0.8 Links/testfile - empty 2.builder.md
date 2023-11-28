========================================
Source Code (between the arrows)
========================================

🡆fabrics <YACUz3H9> [https://www.notube.com/watch?v=hTui12lKus]->;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> Terminator
|  |  +--<item> ::= <text> <tag> Link
|  |  |  +--<text> ::= <text-chunk>
|  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  +--fabrics 
|  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  +--<
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--YACUz3H9
|  |  |  |  +-->
|  |  |  +--[https://www.notube.com/watch?v=hTui12lKus]
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                                                    Description                                  
---------------   -----   -----   -----   ------------------------------------------------------------   ---------------------------------------------
Token Read            0       0       0   fabrics                                                        Token type: Text                             
Shift                12                                                                                  The parser shifted to state 12               
Token Read           12       0       8   <                                                              Token type: LeftArrow                        
Reduce               18                   (1) ::= fabrics                                                <text-chunk> ::= Text                        
Reduce               17                   (2) ::= (1)                                                    <text> ::= <text-chunk>                      
Shift                24                                                                                  The parser shifted to state 24               
Token Read           24       0       9   YACUz3H9                                                       Token type: Text                             
Shift                12                                                                                  The parser shifted to state 12               
Token Read           12       0      17   >                                                              Token type: RightArrow                       
Reduce               18                   (3) ::= YACUz3H9                                               <text-chunk> ::= Text                        
Reduce               36                   (4) ::= (3)                                                    <text> ::= <text-chunk>                      
Shift                49                                                                                  The parser shifted to state 49               
Token Read           49       0      19   [https://www.notube.com/watch?v=hTui12lKus]                    Token type: Link                             
Reduce               27                   (5) ::= < (4) >                                                <tag> ::= LeftArrow <text> RightArrow        
Shift                41                                                                                  The parser shifted to state 41               
Token Read           41       0      62   -                                                              Token type: Hyphen                           
Reduce               15                   (6) ::= (2) (5) [https://www.notube.com/watch?v=hTui12lKus]    <item> ::= <text> <tag> Link                 
Shift                22                                                                                  The parser shifted to state 22               
Token Read           22       0      63   >                                                              Token type: RightArrow                       
Shift                30                                                                                  The parser shifted to state 30               
Token Read           30       0      64   ;                                                              Token type: Terminator                       
Reduce               23                   (7) ::= - >                                                    <producer> ::= Hyphen RightArrow             
Shift                31                                                                                  The parser shifted to state 31               
Token Read           31       1       0                                                                  Token type: EOF                              
Reduce               13                   (8) ::= (6) (7) ;                                              <expression> ::= <item> <producer> Terminator
Reduce               16                   (9) ::= (8)                                                    <scripture> ::= <expression>                 
Accept               16                                                                                                                               



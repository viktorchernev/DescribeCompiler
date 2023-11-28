========================================
Source Code (between the arrows)
========================================

🡆fabrics [https://www.notube.com/watch?v=hTui12lKus]<zAfn39Kh>-> synthetic fabrics <hOy5oL3B> ;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression> Terminator
|  |  +--<item> ::= <text> Link <tag>
|  |  |  +--<text> ::= <text-chunk>
|  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  +--fabrics 
|  |  |  +--[https://www.notube.com/watch?v=hTui12lKus]
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

Parse Action      State    Line     Col   Parse Value                                                    Description                                                       
---------------   -----   -----   -----   ------------------------------------------------------------   ------------------------------------------------------------------
Token Read            0       0       0   fabrics                                                        Token type: Text                                                  
Shift                12                                                                                  The parser shifted to state 12                                    
Token Read           12       0       8   [https://www.notube.com/watch?v=hTui12lKus]                    Token type: Link                                                  
Reduce               18                   (1) ::= fabrics                                                <text-chunk> ::= Text                                             
Reduce               17                   (2) ::= (1)                                                    <text> ::= <text-chunk>                                           
Shift                25                                                                                  The parser shifted to state 25                                    
Token Read           25       0      51   <                                                              Token type: LeftArrow                                             
Shift                24                                                                                  The parser shifted to state 24                                    
Token Read           24       0      52   zAfn39Kh                                                       Token type: Text                                                  
Shift                12                                                                                  The parser shifted to state 12                                    
Token Read           12       0      60   >                                                              Token type: RightArrow                                            
Reduce               18                   (3) ::= zAfn39Kh                                               <text-chunk> ::= Text                                             
Reduce               36                   (4) ::= (3)                                                    <text> ::= <text-chunk>                                           
Shift                49                                                                                  The parser shifted to state 49                                    
Token Read           49       0      61   -                                                              Token type: Hyphen                                                
Reduce               39                   (5) ::= < (4) >                                                <tag> ::= LeftArrow <text> RightArrow                             
Reduce               15                   (6) ::= (2) [https://www.notube.com/watch?v=hTui12lKus] (5)    <item> ::= <text> Link <tag>                                      
Shift                22                                                                                  The parser shifted to state 22                                    
Token Read           22       0      62   >                                                              Token type: RightArrow                                            
Shift                30                                                                                  The parser shifted to state 30                                    
Token Read           30       0      63    synthetic fabrics                                             Token type: Text                                                  
Reduce               23                   (7) ::= - >                                                    <producer> ::= Hyphen RightArrow                                  
Shift                12                                                                                  The parser shifted to state 12                                    
Token Read           12       0      82   <                                                              Token type: LeftArrow                                             
Reduce               18                   (8) ::=  synthetic fabrics                                     <text-chunk> ::= Text                                             
Reduce               17                   (9) ::= (8)                                                    <text> ::= <text-chunk>                                           
Shift                24                                                                                  The parser shifted to state 24                                    
Token Read           24       0      83   hOy5oL3B                                                       Token type: Text                                                  
Shift                12                                                                                  The parser shifted to state 12                                    
Token Read           12       0      91   >                                                              Token type: RightArrow                                            
Reduce               18                   (10) ::= hOy5oL3B                                              <text-chunk> ::= Text                                             
Reduce               36                   (11) ::= (10)                                                  <text> ::= <text-chunk>                                           
Shift                49                                                                                  The parser shifted to state 49                                    
Token Read           49       0      93   ;                                                              Token type: Terminator                                            
Reduce               27                   (12) ::= < (11) >                                              <tag> ::= LeftArrow <text> RightArrow                             
Reduce               33                   (13) ::= (9) (12)                                              <item> ::= <text> <tag>                                           
Reduce               34                   (14) ::= (13)                                                  <item-or-expression> ::= <item>                                   
Shift                47                                                                                  The parser shifted to state 47                                    
Token Read           47       1       0                                                                  Token type: EOF                                                   
Reduce               13                   (15) ::= (6) (7) (14) ;                                        <expression> ::= <item> <producer> <item-or-expression> Terminator
Reduce               16                   (16) ::= (15)                                                  <scripture> ::= <expression>                                      
Accept               16                                                                                                                                                    



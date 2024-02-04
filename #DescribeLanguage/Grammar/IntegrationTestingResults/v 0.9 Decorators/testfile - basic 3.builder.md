========================================
Source Code (between the arrows)
========================================

🡆fabrics [https://www.notube.com/watch?v=hTui12lKus] {color | red}<zAfn39Kh>-> synthetic fabrics <hOy5oL3B> ;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression> Terminator
|  |  +--<item> ::= <text> Link Decorator <tag>
|  |  |  +--<text> ::= <text-chunk>
|  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  +--fabrics 
|  |  |  +--[https://www.notube.com/watch?v=hTui12lKus]
|  |  |  +--{color | red}
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

Parse Action      State    Line     Col   Parse Value                                                                  Description                                                       
---------------   -----   -----   -----   --------------------------------------------------------------------------   ------------------------------------------------------------------
Token Read            0       0       0   fabrics                                                                      Token type: Text                                                  
Shift                14                                                                                                The parser shifted to state 14                                    
Token Read           14       0       8   [https://www.notube.com/watch?v=hTui12lKus]                                  Token type: Link                                                  
Reduce               20                   (1) ::= fabrics                                                              <text-chunk> ::= Text                                             
Reduce               19                   (2) ::= (1)                                                                  <text> ::= <text-chunk>                                           
Shift                28                                                                                                The parser shifted to state 28                                    
Token Read           28       0      52   {color | red}                                                                Token type: Decorator                                             
Shift                46                                                                                                The parser shifted to state 46                                    
Token Read           46       0      65   <                                                                            Token type: LeftArrow                                             
Shift                27                                                                                                The parser shifted to state 27                                    
Token Read           27       0      66   zAfn39Kh                                                                     Token type: Text                                                  
Shift                14                                                                                                The parser shifted to state 14                                    
Token Read           14       0      74   >                                                                            Token type: RightArrow                                            
Reduce               20                   (3) ::= zAfn39Kh                                                             <text-chunk> ::= Text                                             
Reduce               45                   (4) ::= (3)                                                                  <text> ::= <text-chunk>                                           
Shift                71                                                                                                The parser shifted to state 71                                    
Token Read           71       0      75   -                                                                            Token type: Hyphen                                                
Reduce               72                   (5) ::= < (4) >                                                              <tag> ::= LeftArrow <text> RightArrow                             
Reduce               17                   (6) ::= (2) [https://www.notube.com/watch?v=hTui12lKus] {color | red} (5)    <item> ::= <text> Link Decorator <tag>                            
Shift                24                                                                                                The parser shifted to state 24                                    
Token Read           24       0      76   >                                                                            Token type: RightArrow                                            
Shift                34                                                                                                The parser shifted to state 34                                    
Token Read           34       0      77    synthetic fabrics                                                           Token type: Text                                                  
Reduce               25                   (7) ::= - >                                                                  <producer> ::= Hyphen RightArrow                                  
Shift                14                                                                                                The parser shifted to state 14                                    
Token Read           14       0      96   <                                                                            Token type: LeftArrow                                             
Reduce               20                   (8) ::=  synthetic fabrics                                                   <text-chunk> ::= Text                                             
Reduce               19                   (9) ::= (8)                                                                  <text> ::= <text-chunk>                                           
Shift                27                                                                                                The parser shifted to state 27                                    
Token Read           27       0      97   hOy5oL3B                                                                     Token type: Text                                                  
Shift                14                                                                                                The parser shifted to state 14                                    
Token Read           14       0     105   >                                                                            Token type: RightArrow                                            
Reduce               20                   (10) ::= hOy5oL3B                                                            <text-chunk> ::= Text                                             
Reduce               45                   (11) ::= (10)                                                                <text> ::= <text-chunk>                                           
Shift                71                                                                                                The parser shifted to state 71                                    
Token Read           71       0     107   ;                                                                            Token type: Terminator                                            
Reduce               31                   (12) ::= < (11) >                                                            <tag> ::= LeftArrow <text> RightArrow                             
Reduce               37                   (13) ::= (9) (12)                                                            <item> ::= <text> <tag>                                           
Reduce               38                   (14) ::= (13)                                                                <item-or-expression> ::= <item>                                   
Shift                65                                                                                                The parser shifted to state 65                                    
Token Read           65       1       0                                                                                Token type: EOF                                                   
Reduce               15                   (15) ::= (6) (7) (14) ;                                                      <expression> ::= <item> <producer> <item-or-expression> Terminator
Reduce               18                   (16) ::= (15)                                                                <scripture> ::= <expression>                                      
Accept               18                                                                                                                                                                  



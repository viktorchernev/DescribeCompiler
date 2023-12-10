========================================
Source Code (between the arrows)
========================================

🡆fa \/ br\/ics\/ ->>

    wool\/fabrics,,
    \/cotton fabrics,,
    \/ silk \/ fabrics,,
    synthetic fabrics\/;;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression-list> <terminator>
|  |  +--<item> ::= <text>
|  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--fa 
|  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  +--<text-chunk> ::= EscapeFSlash
|  |  |  |  |  |  |  +--\/
|  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +-- br
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeFSlash
|  |  |  |  |  |  |  |  |  +--\/
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--ics
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeFSlash
|  |  |  |  |  |  |  |  |  |  +--\/
|  |  +--<producer> ::= Hyphen RightArrow RightArrow
|  |  |  +---
|  |  |  +-->
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <item> <separator> <item-or-expression-list>
|  |  |  +--<item> ::= <text>
|  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    wool
|  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= EscapeFSlash
|  |  |  |  |  |  |  |  +--\/
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--fabrics
|  |  |  +--<separator> ::= Separator Separator
|  |  |  |  +--,
|  |  |  |  +--,
|  |  |  +--<item-or-expression-list> ::= <item> <separator> <item-or-expression-list>
|  |  |  |  +--<item> ::= <text>
|  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= EscapeFSlash
|  |  |  |  |  |  |  |  +--\/
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--cotton fabrics
|  |  |  |  +--<separator> ::= Separator Separator
|  |  |  |  |  +--,
|  |  |  |  |  +--,
|  |  |  |  +--<item-or-expression-list> ::= <item> <separator> <item>
|  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeFSlash
|  |  |  |  |  |  |  |  |  +--\/
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +-- silk 
|  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeFSlash
|  |  |  |  |  |  |  |  |  |  |  +--\/
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  +-- fabrics
|  |  |  |  |  +--<separator> ::= Separator Separator
|  |  |  |  |  |  +--,
|  |  |  |  |  |  +--,
|  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--    synthetic fabrics
|  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeFSlash
|  |  |  |  |  |  |  |  |  +--\/
|  |  +--<terminator> ::= Terminator Terminator
|  |  |  +--;
|  |  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                       Description                                                               
---------------   -----   -----   -----   -------------------------------   --------------------------------------------------------------------------
Token Read            0       0       0   fa                                Token type: Text                                                          
Shift                14                                                     The parser shifted to state 14                                            
Token Read           14       0       3   \/                                Token type: EscapeFSlash                                                  
Reduce               20                   (1) ::= fa                        <text-chunk> ::= Text                                                     
Shift                 3                                                     The parser shifted to state 3                                             
Token Read            3       0       5    br                               Token type: Text                                                          
Reduce               33                   (2) ::= \/                        <text-chunk> ::= EscapeFSlash                                             
Shift                14                                                     The parser shifted to state 14                                            
Token Read           14       0       8   \/                                Token type: EscapeFSlash                                                  
Reduce               33                   (3) ::=  br                       <text-chunk> ::= Text                                                     
Shift                 3                                                     The parser shifted to state 3                                             
Token Read            3       0      10   ics                               Token type: Text                                                          
Reduce               33                   (4) ::= \/                        <text-chunk> ::= EscapeFSlash                                             
Shift                14                                                     The parser shifted to state 14                                            
Token Read           14       0      13   \/                                Token type: EscapeFSlash                                                  
Reduce               33                   (5) ::= ics                       <text-chunk> ::= Text                                                     
Shift                 3                                                     The parser shifted to state 3                                             
Token Read            3       0      16   -                                 Token type: Hyphen                                                        
Reduce               33                   (6) ::= \/                        <text-chunk> ::= EscapeFSlash                                             
Reduce               34                   (7) ::= (5) (6)                   <text-chunk-list> ::= <text-chunk> <text-chunk>                           
Reduce               34                   (8) ::= (4) (7)                   <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (9) ::= (3) (8)                   <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               34                   (10) ::= (2) (9)                  <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               21                   (11) ::= (1) (10)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               19                   (12) ::= (11)                     <text> ::= <text-chunk-list>                                              
Reduce               17                   (13) ::= (12)                     <item> ::= <text>                                                         
Shift                24                                                     The parser shifted to state 24                                            
Token Read           24       0      17   >                                 Token type: RightArrow                                                    
Shift                35                                                     The parser shifted to state 35                                            
Token Read           35       0      18   >                                 Token type: RightArrow                                                    
Shift                64                                                     The parser shifted to state 64                                            
Token Read           64       2       0       wool                          Token type: Text                                                          
Reduce               25                   (14) ::= - > >                    <producer> ::= Hyphen RightArrow RightArrow                               
Shift                14                                                     The parser shifted to state 14                                            
Token Read           14       2       8   \/                                Token type: EscapeFSlash                                                  
Reduce               20                   (15) ::=     wool                 <text-chunk> ::= Text                                                     
Shift                 3                                                     The parser shifted to state 3                                             
Token Read            3       2      10   fabrics                           Token type: Text                                                          
Reduce               33                   (16) ::= \/                       <text-chunk> ::= EscapeFSlash                                             
Shift                14                                                     The parser shifted to state 14                                            
Token Read           14       2      17   ,                                 Token type: Separator                                                     
Reduce               33                   (17) ::= fabrics                  <text-chunk> ::= Text                                                     
Reduce               34                   (18) ::= (16) (17)                <text-chunk-list> ::= <text-chunk> <text-chunk>                           
Reduce               21                   (19) ::= (15) (18)                <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               19                   (20) ::= (19)                     <text> ::= <text-chunk-list>                                              
Reduce               38                   (21) ::= (20)                     <item> ::= <text>                                                         
Shift                69                                                     The parser shifted to state 69                                            
Token Read           69       2      18   ,                                 Token type: Separator                                                     
Shift                99                                                     The parser shifted to state 99                                            
Token Read           99       3       4   \/                                Token type: EscapeFSlash                                                  
Reduce               70                   (22) ::= , ,                      <separator> ::= Separator Separator                                       
Shift                 3                                                     The parser shifted to state 3                                             
Token Read            3       3       6   cotton fabrics                    Token type: Text                                                          
Reduce               20                   (23) ::= \/                       <text-chunk> ::= EscapeFSlash                                             
Shift                14                                                     The parser shifted to state 14                                            
Token Read           14       3      20   ,                                 Token type: Separator                                                     
Reduce               33                   (24) ::= cotton fabrics           <text-chunk> ::= Text                                                     
Reduce               21                   (25) ::= (23) (24)                <text-chunk-list> ::= <text-chunk> <text-chunk>                           
Reduce               19                   (26) ::= (25)                     <text> ::= <text-chunk-list>                                              
Reduce              101                   (27) ::= (26)                     <item> ::= <text>                                                         
Shift                69                                                     The parser shifted to state 69                                            
Token Read           69       3      21   ,                                 Token type: Separator                                                     
Shift                99                                                     The parser shifted to state 99                                            
Token Read           99       4       4   \/                                Token type: EscapeFSlash                                                  
Reduce               70                   (28) ::= , ,                      <separator> ::= Separator Separator                                       
Shift                 3                                                     The parser shifted to state 3                                             
Token Read            3       4       6    silk                             Token type: Text                                                          
Reduce               20                   (29) ::= \/                       <text-chunk> ::= EscapeFSlash                                             
Shift                14                                                     The parser shifted to state 14                                            
Token Read           14       4      12   \/                                Token type: EscapeFSlash                                                  
Reduce               33                   (30) ::=  silk                    <text-chunk> ::= Text                                                     
Shift                 3                                                     The parser shifted to state 3                                             
Token Read            3       4      14    fabrics                          Token type: Text                                                          
Reduce               33                   (31) ::= \/                       <text-chunk> ::= EscapeFSlash                                             
Shift                14                                                     The parser shifted to state 14                                            
Token Read           14       4      22   ,                                 Token type: Separator                                                     
Reduce               33                   (32) ::=  fabrics                 <text-chunk> ::= Text                                                     
Reduce               34                   (33) ::= (31) (32)                <text-chunk-list> ::= <text-chunk> <text-chunk>                           
Reduce               34                   (34) ::= (30) (33)                <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               21                   (35) ::= (29) (34)                <text-chunk-list> ::= <text-chunk> <text-chunk-list>                      
Reduce               19                   (36) ::= (35)                     <text> ::= <text-chunk-list>                                              
Reduce              101                   (37) ::= (36)                     <item> ::= <text>                                                         
Shift                69                                                     The parser shifted to state 69                                            
Token Read           69       4      23   ,                                 Token type: Separator                                                     
Shift                99                                                     The parser shifted to state 99                                            
Token Read           99       5       0       synthetic fabrics             Token type: Text                                                          
Reduce               70                   (38) ::= , ,                      <separator> ::= Separator Separator                                       
Shift                14                                                     The parser shifted to state 14                                            
Token Read           14       5      21   \/                                Token type: EscapeFSlash                                                  
Reduce               20                   (39) ::=     synthetic fabrics    <text-chunk> ::= Text                                                     
Shift                 3                                                     The parser shifted to state 3                                             
Token Read            3       5      23   ;                                 Token type: Terminator                                                    
Reduce               33                   (40) ::= \/                       <text-chunk> ::= EscapeFSlash                                             
Reduce               21                   (41) ::= (39) (40)                <text-chunk-list> ::= <text-chunk> <text-chunk>                           
Reduce               19                   (42) ::= (41)                     <text> ::= <text-chunk-list>                                              
Reduce              101                   (43) ::= (42)                     <item> ::= <text>                                                         
Reduce              102                   (44) ::= (37) (38) (43)           <item-or-expression-list> ::= <item> <separator> <item>                   
Reduce              102                   (45) ::= (27) (28) (44)           <item-or-expression-list> ::= <item> <separator> <item-or-expression-list>
Reduce               40                   (46) ::= (21) (22) (45)           <item-or-expression-list> ::= <item> <separator> <item-or-expression-list>
Shift                36                                                     The parser shifted to state 36                                            
Token Read           36       5      24   ;                                 Token type: Terminator                                                    
Shift                65                                                     The parser shifted to state 65                                            
Token Read           65       6       0                                     Token type: EOF                                                           
Reduce               72                   (47) ::= ; ;                      <terminator> ::= Terminator Terminator                                    
Reduce               15                   (48) ::= (13) (14) (46) (47)      <expression> ::= <item> <producer> <item-or-expression-list> <terminator> 
Reduce               18                   (49) ::= (48)                     <scripture> ::= <expression>                                              
Accept               18                                                                                                                               



Cannot be parsed without preprocessing by the Describe Compiler preprocessor
========================================
Source Code (between the arrows)
========================================

🡆fa / br/ics/ ->

    wool/fabrics,
    /cotton fabrics,
    / silk / fabrics,
    synthetic fabrics/;🡄

========================================
Preprocessed (between the arrows)
========================================

🡆fa \/ br\/ics\/ ->

    wool\/fabrics,
    \/cotton fabrics,
    \/ silk \/ fabrics,
    synthetic fabrics\/;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
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
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
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
|  |  |  +--,
|  |  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  |  +--<item> ::= <text>
|  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= EscapeFSlash
|  |  |  |  |  |  |  |  +--\/
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--cotton fabrics
|  |  |  |  +--,
|  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
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
|  |  |  |  |  +--,
|  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--    synthetic fabrics
|  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeFSlash
|  |  |  |  |  |  |  |  |  +--\/
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                       Description                                                             
---------------   -----   -----   -----   -------------------------------   ------------------------------------------------------------------------
Token Read            0       0       0   fa                                Token type: Text                                                        
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       0       3   \/                                Token type: EscapeFSlash                                                
Reduce               16                   (1) ::= fa                        <text-chunk> ::= Text                                                   
Shift                 3                                                     The parser shifted to state 3                                           
Token Read            3       0       5    br                               Token type: Text                                                        
Reduce               22                   (2) ::= \/                        <text-chunk> ::= EscapeFSlash                                           
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       0       8   \/                                Token type: EscapeFSlash                                                
Reduce               22                   (3) ::=  br                       <text-chunk> ::= Text                                                   
Shift                 3                                                     The parser shifted to state 3                                           
Token Read            3       0      10   ics                               Token type: Text                                                        
Reduce               22                   (4) ::= \/                        <text-chunk> ::= EscapeFSlash                                           
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       0      13   \/                                Token type: EscapeFSlash                                                
Reduce               22                   (5) ::= ics                       <text-chunk> ::= Text                                                   
Shift                 3                                                     The parser shifted to state 3                                           
Token Read            3       0      16   -                                 Token type: Hyphen                                                      
Reduce               22                   (6) ::= \/                        <text-chunk> ::= EscapeFSlash                                           
Reduce               23                   (7) ::= (5) (6)                   <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               23                   (8) ::= (4) (7)                   <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (9) ::= (3) (8)                   <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               23                   (10) ::= (2) (9)                  <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (11) ::= (1) (10)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               15                   (12) ::= (11)                     <text> ::= <text-chunk-list>                                            
Reduce               13                   (13) ::= (12)                     <item> ::= <text>                                                       
Shift                20                                                     The parser shifted to state 20                                          
Token Read           20       0      17   >                                 Token type: RightArrow                                                  
Shift                24                                                     The parser shifted to state 24                                          
Token Read           24       2       0       wool                          Token type: Text                                                        
Reduce               21                   (14) ::= - >                      <producer> ::= Hyphen RightArrow                                        
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       2       8   \/                                Token type: EscapeFSlash                                                
Reduce               16                   (15) ::=     wool                 <text-chunk> ::= Text                                                   
Shift                 3                                                     The parser shifted to state 3                                           
Token Read            3       2      10   fabrics                           Token type: Text                                                        
Reduce               22                   (16) ::= \/                       <text-chunk> ::= EscapeFSlash                                           
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       2      17   ,                                 Token type: Separator                                                   
Reduce               22                   (17) ::= fabrics                  <text-chunk> ::= Text                                                   
Reduce               23                   (18) ::= (16) (17)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               17                   (19) ::= (15) (18)                <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               15                   (20) ::= (19)                     <text> ::= <text-chunk-list>                                            
Reduce               27                   (21) ::= (20)                     <item> ::= <text>                                                       
Shift                33                                                     The parser shifted to state 33                                          
Token Read           33       3       4   \/                                Token type: EscapeFSlash                                                
Shift                 3                                                     The parser shifted to state 3                                           
Token Read            3       3       6   cotton fabrics                    Token type: Text                                                        
Reduce               16                   (22) ::= \/                       <text-chunk> ::= EscapeFSlash                                           
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       3      20   ,                                 Token type: Separator                                                   
Reduce               22                   (23) ::= cotton fabrics           <text-chunk> ::= Text                                                   
Reduce               17                   (24) ::= (22) (23)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               15                   (25) ::= (24)                     <text> ::= <text-chunk-list>                                            
Reduce               37                   (26) ::= (25)                     <item> ::= <text>                                                       
Shift                33                                                     The parser shifted to state 33                                          
Token Read           33       4       4   \/                                Token type: EscapeFSlash                                                
Shift                 3                                                     The parser shifted to state 3                                           
Token Read            3       4       6    silk                             Token type: Text                                                        
Reduce               16                   (27) ::= \/                       <text-chunk> ::= EscapeFSlash                                           
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       4      12   \/                                Token type: EscapeFSlash                                                
Reduce               22                   (28) ::=  silk                    <text-chunk> ::= Text                                                   
Shift                 3                                                     The parser shifted to state 3                                           
Token Read            3       4      14    fabrics                          Token type: Text                                                        
Reduce               22                   (29) ::= \/                       <text-chunk> ::= EscapeFSlash                                           
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       4      22   ,                                 Token type: Separator                                                   
Reduce               22                   (30) ::=  fabrics                 <text-chunk> ::= Text                                                   
Reduce               23                   (31) ::= (29) (30)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               23                   (32) ::= (28) (31)                <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (33) ::= (27) (32)                <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               15                   (34) ::= (33)                     <text> ::= <text-chunk-list>                                            
Reduce               37                   (35) ::= (34)                     <item> ::= <text>                                                       
Shift                33                                                     The parser shifted to state 33                                          
Token Read           33       5       0       synthetic fabrics             Token type: Text                                                        
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       5      21   \/                                Token type: EscapeFSlash                                                
Reduce               16                   (36) ::=     synthetic fabrics    <text-chunk> ::= Text                                                   
Shift                 3                                                     The parser shifted to state 3                                           
Token Read            3       5      23   ;                                 Token type: Terminator                                                  
Reduce               22                   (37) ::= \/                       <text-chunk> ::= EscapeFSlash                                           
Reduce               17                   (38) ::= (36) (37)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               15                   (39) ::= (38)                     <text> ::= <text-chunk-list>                                            
Reduce               37                   (40) ::= (39)                     <item> ::= <text>                                                       
Reduce               38                   (41) ::= (35) , (40)              <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               38                   (42) ::= (26) , (41)              <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               29                   (43) ::= (21) , (42)              <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                35                                                     The parser shifted to state 35                                          
Token Read           35       6       0                                     Token type: EOF                                                         
Reduce               11                   (44) ::= (13) (14) (43) ;         <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               14                   (45) ::= (44)                     <scripture> ::= <expression>                                            
Accept               14                                                                                                                             



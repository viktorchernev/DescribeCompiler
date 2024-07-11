Cannot be parsed without preprocessing by the Describe Compiler preprocessor
========================================
Source Code (between the arrows)
========================================

🡆fa \ br\ics\ <AkoHsBxP>->

    wool\fabrics <\2\2gPwg0Z>,
    \cotton fabrics <\6KbLpKF2>,
    \ silk \ fabrics <YA0\Cn7gP>,
    synthetic fabrics\ \<V4tLOkb5>;🡄

========================================
Preprocessed (between the arrows)
========================================

🡆fa \\ br\\ics\\ <AkoHsBxP>->

    wool\\fabrics <\\2\\2gPwg0Z>,
    \\cotton fabrics <\\6KbLpKF2>,
    \\ silk \\ fabrics <YA0\\Cn7gP>,
    synthetic fabrics\\ \<V4tLOkb5>;
🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  +--<item> ::= <text> <tag>
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
|  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  +--<
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--ToUZ5J7e
|  |  |  |  +-->
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  +--<item> ::= <text> <tag>
|  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    wool
|  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= EscapeFSlash
|  |  |  |  |  |  |  |  +--\/
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--fabrics 
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= EscapeFSlash
|  |  |  |  |  |  |  |  +--\/
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--DZChUWeh
|  |  |  |  |  +-->
|  |  |  +--,
|  |  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= EscapeFSlash
|  |  |  |  |  |  |  |  +--\/
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--cotton fabrics 
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--XBru
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeFSlash
|  |  |  |  |  |  |  |  |  |  +--\/
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--v3rK
|  |  |  |  |  |  +-->
|  |  |  |  +--,
|  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  +--<item> ::= <text> <tag>
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
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--7tewYK
|  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeFSlash
|  |  |  |  |  |  |  |  |  |  |  +--\/
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  +--BC
|  |  |  |  |  |  |  +-->
|  |  |  |  |  +--,
|  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--    synthetic fabrics
|  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeFSlash
|  |  |  |  |  |  |  |  |  +--\/
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--qStgB
|  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeFSlash
|  |  |  |  |  |  |  |  |  |  |  +--\/
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  +--Iqw
|  |  |  |  |  |  |  +-->
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                       Description                                                             
---------------   -----   -----   -----   -------------------------------   ------------------------------------------------------------------------
Token Read            0       0       0   fa                                Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       0       3   \/                                Token type: EscapeFSlash                                                
Reduce               18                   (1) ::= fa                        <text-chunk> ::= Text                                                   
Shift                 3                                                     The parser shifted to state 3                                           
Token Read            3       0       5    br                               Token type: Text                                                        
Reduce               27                   (2) ::= \/                        <text-chunk> ::= EscapeFSlash                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       0       8   \/                                Token type: EscapeFSlash                                                
Reduce               27                   (3) ::=  br                       <text-chunk> ::= Text                                                   
Shift                 3                                                     The parser shifted to state 3                                           
Token Read            3       0      10   ics                               Token type: Text                                                        
Reduce               27                   (4) ::= \/                        <text-chunk> ::= EscapeFSlash                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       0      13   \/                                Token type: EscapeFSlash                                                
Reduce               27                   (5) ::= ics                       <text-chunk> ::= Text                                                   
Shift                 3                                                     The parser shifted to state 3                                           
Token Read            3       0      16   <                                 Token type: LeftArrow                                                   
Reduce               27                   (6) ::= \/                        <text-chunk> ::= EscapeFSlash                                           
Reduce               28                   (7) ::= (5) (6)                   <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               28                   (8) ::= (4) (7)                   <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (9) ::= (3) (8)                   <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (10) ::= (2) (9)                  <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               19                   (11) ::= (1) (10)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (12) ::= (11)                     <text> ::= <text-chunk-list>                                            
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       0      17   ToUZ5J7e                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       0      25   >                                 Token type: RightArrow                                                  
Reduce               18                   (13) ::= ToUZ5J7e                 <text-chunk> ::= Text                                                   
Reduce               20                   (14) ::= (13)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       0      27   -                                 Token type: Hyphen                                                      
Reduce               26                   (15) ::= < (14) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               14                   (16) ::= (12) (15)                <item> ::= <text> <tag>                                                 
Shift                23                                                     The parser shifted to state 23                                          
Token Read           23       0      28   >                                 Token type: RightArrow                                                  
Shift                30                                                     The parser shifted to state 30                                          
Token Read           30       2       0       wool                          Token type: Text                                                        
Reduce               24                   (17) ::= - >                      <producer> ::= Hyphen RightArrow                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       2       8   \/                                Token type: EscapeFSlash                                                
Reduce               18                   (18) ::=     wool                 <text-chunk> ::= Text                                                   
Shift                 3                                                     The parser shifted to state 3                                           
Token Read            3       2      10   fabrics                           Token type: Text                                                        
Reduce               27                   (19) ::= \/                       <text-chunk> ::= EscapeFSlash                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       2      18   <                                 Token type: LeftArrow                                                   
Reduce               27                   (20) ::= fabrics                  <text-chunk> ::= Text                                                   
Reduce               28                   (21) ::= (19) (20)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               19                   (22) ::= (18) (21)                <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (23) ::= (22)                     <text> ::= <text-chunk-list>                                            
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       2      19   \/                                Token type: EscapeFSlash                                                
Shift                 3                                                     The parser shifted to state 3                                           
Token Read            3       2      21   DZChUWeh                          Token type: Text                                                        
Reduce               18                   (24) ::= \/                       <text-chunk> ::= EscapeFSlash                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       2      29   >                                 Token type: RightArrow                                                  
Reduce               27                   (25) ::= DZChUWeh                 <text-chunk> ::= Text                                                   
Reduce               19                   (26) ::= (24) (25)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               20                   (27) ::= (26)                     <text> ::= <text-chunk-list>                                            
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       2      30   ,                                 Token type: Separator                                                   
Reduce               26                   (28) ::= < (27) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (29) ::= (23) (28)                <item> ::= <text> <tag>                                                 
Shift                39                                                     The parser shifted to state 39                                          
Token Read           39       3       4   \/                                Token type: EscapeFSlash                                                
Shift                 3                                                     The parser shifted to state 3                                           
Token Read            3       3       6   cotton fabrics                    Token type: Text                                                        
Reduce               18                   (30) ::= \/                       <text-chunk> ::= EscapeFSlash                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       3      21   <                                 Token type: LeftArrow                                                   
Reduce               27                   (31) ::= cotton fabrics           <text-chunk> ::= Text                                                   
Reduce               19                   (32) ::= (30) (31)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               17                   (33) ::= (32)                     <text> ::= <text-chunk-list>                                            
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       3      22   XBru                              Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       3      26   \/                                Token type: EscapeFSlash                                                
Reduce               18                   (34) ::= XBru                     <text-chunk> ::= Text                                                   
Shift                 3                                                     The parser shifted to state 3                                           
Token Read            3       3      28   v3rK                              Token type: Text                                                        
Reduce               27                   (35) ::= \/                       <text-chunk> ::= EscapeFSlash                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       3      32   >                                 Token type: RightArrow                                                  
Reduce               27                   (36) ::= v3rK                     <text-chunk> ::= Text                                                   
Reduce               28                   (37) ::= (35) (36)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               19                   (38) ::= (34) (37)                <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               20                   (39) ::= (38)                     <text> ::= <text-chunk-list>                                            
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       3      33   ,                                 Token type: Separator                                                   
Reduce               26                   (40) ::= < (39) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (41) ::= (33) (40)                <item> ::= <text> <tag>                                                 
Shift                39                                                     The parser shifted to state 39                                          
Token Read           39       4       4   \/                                Token type: EscapeFSlash                                                
Shift                 3                                                     The parser shifted to state 3                                           
Token Read            3       4       6    silk                             Token type: Text                                                        
Reduce               18                   (42) ::= \/                       <text-chunk> ::= EscapeFSlash                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       4      12   \/                                Token type: EscapeFSlash                                                
Reduce               27                   (43) ::=  silk                    <text-chunk> ::= Text                                                   
Shift                 3                                                     The parser shifted to state 3                                           
Token Read            3       4      14    fabrics                          Token type: Text                                                        
Reduce               27                   (44) ::= \/                       <text-chunk> ::= EscapeFSlash                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       4      22   <                                 Token type: LeftArrow                                                   
Reduce               27                   (45) ::=  fabrics                 <text-chunk> ::= Text                                                   
Reduce               28                   (46) ::= (44) (45)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               28                   (47) ::= (43) (46)                <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               19                   (48) ::= (42) (47)                <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (49) ::= (48)                     <text> ::= <text-chunk-list>                                            
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       4      23   7tewYK                            Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       4      29   \/                                Token type: EscapeFSlash                                                
Reduce               18                   (50) ::= 7tewYK                   <text-chunk> ::= Text                                                   
Shift                 3                                                     The parser shifted to state 3                                           
Token Read            3       4      31   BC                                Token type: Text                                                        
Reduce               27                   (51) ::= \/                       <text-chunk> ::= EscapeFSlash                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       4      33   >                                 Token type: RightArrow                                                  
Reduce               27                   (52) ::= BC                       <text-chunk> ::= Text                                                   
Reduce               28                   (53) ::= (51) (52)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               19                   (54) ::= (50) (53)                <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               20                   (55) ::= (54)                     <text> ::= <text-chunk-list>                                            
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       4      34   ,                                 Token type: Separator                                                   
Reduce               26                   (56) ::= < (55) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (57) ::= (49) (56)                <item> ::= <text> <tag>                                                 
Shift                39                                                     The parser shifted to state 39                                          
Token Read           39       5       0       synthetic fabrics             Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       5      21   \/                                Token type: EscapeFSlash                                                
Reduce               18                   (58) ::=     synthetic fabrics    <text-chunk> ::= Text                                                   
Shift                 3                                                     The parser shifted to state 3                                           
Token Read            3       5      23   <                                 Token type: LeftArrow                                                   
Reduce               27                   (59) ::= \/                       <text-chunk> ::= EscapeFSlash                                           
Reduce               19                   (60) ::= (58) (59)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               17                   (61) ::= (60)                     <text> ::= <text-chunk-list>                                            
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       5      24   qStgB                             Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       5      29   \/                                Token type: EscapeFSlash                                                
Reduce               18                   (62) ::= qStgB                    <text-chunk> ::= Text                                                   
Shift                 3                                                     The parser shifted to state 3                                           
Token Read            3       5      31   Iqw                               Token type: Text                                                        
Reduce               27                   (63) ::= \/                       <text-chunk> ::= EscapeFSlash                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       5      34   >                                 Token type: RightArrow                                                  
Reduce               27                   (64) ::= Iqw                      <text-chunk> ::= Text                                                   
Reduce               28                   (65) ::= (63) (64)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               19                   (66) ::= (62) (65)                <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               20                   (67) ::= (66)                     <text> ::= <text-chunk-list>                                            
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       5      35   ;                                 Token type: Terminator                                                  
Reduce               26                   (68) ::= < (67) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (69) ::= (61) (68)                <item> ::= <text> <tag>                                                 
Reduce               44                   (70) ::= (57) , (69)              <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               44                   (71) ::= (41) , (70)              <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               35                   (72) ::= (29) , (71)              <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                41                                                     The parser shifted to state 41                                          
Token Read           41       7       0                                     Token type: EOF                                                         
Reduce               12                   (73) ::= (16) (17) (72) ;         <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               15                   (74) ::= (73)                     <scripture> ::= <expression>                                            
Accept               15                                                                                                                             



========================================
Source Code (between the arrows)
========================================

🡆fa \\ br\\ics\\ <rDD37re8> ->

    wool\\fabrics <uCzQa\\\\1uW>,
    \\cotton fabrics <UxMKgYjI\\>,
    \\ silk \\ fabrics <Ux6\\wwQBT>,
    synthetic fabrics\\ <\\dbpyUcza>;🡄

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
|  |  |  |  |  |  +--<text-chunk> ::= EscapeBSlash
|  |  |  |  |  |  |  +--\\
|  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +-- br
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeBSlash
|  |  |  |  |  |  |  |  |  +--\\
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--ics
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeBSlash
|  |  |  |  |  |  |  |  |  |  +--\\
|  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  +--<
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--rDD37re8
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
|  |  |  |  |  |  |  +--<text-chunk> ::= EscapeBSlash
|  |  |  |  |  |  |  |  +--\\
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--fabrics 
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--uCzQa
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeBSlash
|  |  |  |  |  |  |  |  |  +--\\
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeBSlash
|  |  |  |  |  |  |  |  |  |  +--\\
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--1uW
|  |  |  |  |  +-->
|  |  |  +--,
|  |  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= EscapeBSlash
|  |  |  |  |  |  |  |  +--\\
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--cotton fabrics 
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--UxMKgYjI
|  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeBSlash
|  |  |  |  |  |  |  |  |  +--\\
|  |  |  |  |  |  +-->
|  |  |  |  +--,
|  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeBSlash
|  |  |  |  |  |  |  |  |  +--\\
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +-- silk 
|  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeBSlash
|  |  |  |  |  |  |  |  |  |  |  +--\\
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  +-- fabrics 
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--Ux6
|  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeBSlash
|  |  |  |  |  |  |  |  |  |  |  +--\\
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  +--wwQBT
|  |  |  |  |  |  |  +-->
|  |  |  |  |  +--,
|  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--    synthetic fabrics
|  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeBSlash
|  |  |  |  |  |  |  |  |  +--\\
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeBSlash
|  |  |  |  |  |  |  |  |  |  +--\\
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--dbpyUcza
|  |  |  |  |  |  |  +-->
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                       Description                                                             
---------------   -----   -----   -----   -------------------------------   ------------------------------------------------------------------------
Token Read            0       0       0   fa                                Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       0       3   \\                                Token type: EscapeBSlash                                                
Reduce               18                   (1) ::= fa                        <text-chunk> ::= Text                                                   
Shift                 1                                                     The parser shifted to state 1                                           
Token Read            1       0       5    br                               Token type: Text                                                        
Reduce               27                   (2) ::= \\                        <text-chunk> ::= EscapeBSlash                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       0       8   \\                                Token type: EscapeBSlash                                                
Reduce               27                   (3) ::=  br                       <text-chunk> ::= Text                                                   
Shift                 1                                                     The parser shifted to state 1                                           
Token Read            1       0      10   ics                               Token type: Text                                                        
Reduce               27                   (4) ::= \\                        <text-chunk> ::= EscapeBSlash                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       0      13   \\                                Token type: EscapeBSlash                                                
Reduce               27                   (5) ::= ics                       <text-chunk> ::= Text                                                   
Shift                 1                                                     The parser shifted to state 1                                           
Token Read            1       0      16   <                                 Token type: LeftArrow                                                   
Reduce               27                   (6) ::= \\                        <text-chunk> ::= EscapeBSlash                                           
Reduce               28                   (7) ::= (5) (6)                   <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               28                   (8) ::= (4) (7)                   <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (9) ::= (3) (8)                   <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (10) ::= (2) (9)                  <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               19                   (11) ::= (1) (10)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (12) ::= (11)                     <text> ::= <text-chunk-list>                                            
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       0      17   rDD37re8                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       0      25   >                                 Token type: RightArrow                                                  
Reduce               18                   (13) ::= rDD37re8                 <text-chunk> ::= Text                                                   
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
Token Read           11       2       8   \\                                Token type: EscapeBSlash                                                
Reduce               18                   (18) ::=     wool                 <text-chunk> ::= Text                                                   
Shift                 1                                                     The parser shifted to state 1                                           
Token Read            1       2      10   fabrics                           Token type: Text                                                        
Reduce               27                   (19) ::= \\                       <text-chunk> ::= EscapeBSlash                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       2      18   <                                 Token type: LeftArrow                                                   
Reduce               27                   (20) ::= fabrics                  <text-chunk> ::= Text                                                   
Reduce               28                   (21) ::= (19) (20)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               19                   (22) ::= (18) (21)                <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (23) ::= (22)                     <text> ::= <text-chunk-list>                                            
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       2      19   uCzQa                             Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       2      24   \\                                Token type: EscapeBSlash                                                
Reduce               18                   (24) ::= uCzQa                    <text-chunk> ::= Text                                                   
Shift                 1                                                     The parser shifted to state 1                                           
Token Read            1       2      26   \\                                Token type: EscapeBSlash                                                
Reduce               27                   (25) ::= \\                       <text-chunk> ::= EscapeBSlash                                           
Shift                 1                                                     The parser shifted to state 1                                           
Token Read            1       2      28   1uW                               Token type: Text                                                        
Reduce               27                   (26) ::= \\                       <text-chunk> ::= EscapeBSlash                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       2      31   >                                 Token type: RightArrow                                                  
Reduce               27                   (27) ::= 1uW                      <text-chunk> ::= Text                                                   
Reduce               28                   (28) ::= (26) (27)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               28                   (29) ::= (25) (28)                <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               19                   (30) ::= (24) (29)                <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               20                   (31) ::= (30)                     <text> ::= <text-chunk-list>                                            
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       2      32   ,                                 Token type: Separator                                                   
Reduce               26                   (32) ::= < (31) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (33) ::= (23) (32)                <item> ::= <text> <tag>                                                 
Shift                39                                                     The parser shifted to state 39                                          
Token Read           39       3       4   \\                                Token type: EscapeBSlash                                                
Shift                 1                                                     The parser shifted to state 1                                           
Token Read            1       3       6   cotton fabrics                    Token type: Text                                                        
Reduce               18                   (34) ::= \\                       <text-chunk> ::= EscapeBSlash                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       3      21   <                                 Token type: LeftArrow                                                   
Reduce               27                   (35) ::= cotton fabrics           <text-chunk> ::= Text                                                   
Reduce               19                   (36) ::= (34) (35)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               17                   (37) ::= (36)                     <text> ::= <text-chunk-list>                                            
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       3      22   UxMKgYjI                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       3      30   \\                                Token type: EscapeBSlash                                                
Reduce               18                   (38) ::= UxMKgYjI                 <text-chunk> ::= Text                                                   
Shift                 1                                                     The parser shifted to state 1                                           
Token Read            1       3      32   >                                 Token type: RightArrow                                                  
Reduce               27                   (39) ::= \\                       <text-chunk> ::= EscapeBSlash                                           
Reduce               19                   (40) ::= (38) (39)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               20                   (41) ::= (40)                     <text> ::= <text-chunk-list>                                            
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       3      33   ,                                 Token type: Separator                                                   
Reduce               26                   (42) ::= < (41) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (43) ::= (37) (42)                <item> ::= <text> <tag>                                                 
Shift                39                                                     The parser shifted to state 39                                          
Token Read           39       4       4   \\                                Token type: EscapeBSlash                                                
Shift                 1                                                     The parser shifted to state 1                                           
Token Read            1       4       6    silk                             Token type: Text                                                        
Reduce               18                   (44) ::= \\                       <text-chunk> ::= EscapeBSlash                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       4      12   \\                                Token type: EscapeBSlash                                                
Reduce               27                   (45) ::=  silk                    <text-chunk> ::= Text                                                   
Shift                 1                                                     The parser shifted to state 1                                           
Token Read            1       4      14    fabrics                          Token type: Text                                                        
Reduce               27                   (46) ::= \\                       <text-chunk> ::= EscapeBSlash                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       4      23   <                                 Token type: LeftArrow                                                   
Reduce               27                   (47) ::=  fabrics                 <text-chunk> ::= Text                                                   
Reduce               28                   (48) ::= (46) (47)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               28                   (49) ::= (45) (48)                <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               19                   (50) ::= (44) (49)                <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (51) ::= (50)                     <text> ::= <text-chunk-list>                                            
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       4      24   Ux6                               Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       4      27   \\                                Token type: EscapeBSlash                                                
Reduce               18                   (52) ::= Ux6                      <text-chunk> ::= Text                                                   
Shift                 1                                                     The parser shifted to state 1                                           
Token Read            1       4      29   wwQBT                             Token type: Text                                                        
Reduce               27                   (53) ::= \\                       <text-chunk> ::= EscapeBSlash                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       4      34   >                                 Token type: RightArrow                                                  
Reduce               27                   (54) ::= wwQBT                    <text-chunk> ::= Text                                                   
Reduce               28                   (55) ::= (53) (54)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               19                   (56) ::= (52) (55)                <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               20                   (57) ::= (56)                     <text> ::= <text-chunk-list>                                            
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       4      35   ,                                 Token type: Separator                                                   
Reduce               26                   (58) ::= < (57) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (59) ::= (51) (58)                <item> ::= <text> <tag>                                                 
Shift                39                                                     The parser shifted to state 39                                          
Token Read           39       5       0       synthetic fabrics             Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       5      21   \\                                Token type: EscapeBSlash                                                
Reduce               18                   (60) ::=     synthetic fabrics    <text-chunk> ::= Text                                                   
Shift                 1                                                     The parser shifted to state 1                                           
Token Read            1       5      24   <                                 Token type: LeftArrow                                                   
Reduce               27                   (61) ::= \\                       <text-chunk> ::= EscapeBSlash                                           
Reduce               19                   (62) ::= (60) (61)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               17                   (63) ::= (62)                     <text> ::= <text-chunk-list>                                            
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       5      25   \\                                Token type: EscapeBSlash                                                
Shift                 1                                                     The parser shifted to state 1                                           
Token Read            1       5      27   dbpyUcza                          Token type: Text                                                        
Reduce               18                   (64) ::= \\                       <text-chunk> ::= EscapeBSlash                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       5      35   >                                 Token type: RightArrow                                                  
Reduce               27                   (65) ::= dbpyUcza                 <text-chunk> ::= Text                                                   
Reduce               19                   (66) ::= (64) (65)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               20                   (67) ::= (66)                     <text> ::= <text-chunk-list>                                            
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       5      36   ;                                 Token type: Terminator                                                  
Reduce               26                   (68) ::= < (67) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (69) ::= (63) (68)                <item> ::= <text> <tag>                                                 
Reduce               44                   (70) ::= (59) , (69)              <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               44                   (71) ::= (43) , (70)              <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               35                   (72) ::= (33) , (71)              <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                41                                                     The parser shifted to state 41                                          
Token Read           41       6       0                                     Token type: EOF                                                         
Reduce               12                   (73) ::= (16) (17) (72) ;         <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               15                   (74) ::= (73)                     <scripture> ::= <expression>                                            
Accept               15                                                                                                                             



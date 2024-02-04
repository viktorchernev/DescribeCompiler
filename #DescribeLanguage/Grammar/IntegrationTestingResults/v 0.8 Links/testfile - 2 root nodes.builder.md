========================================
Source Code (between the arrows)
========================================

🡆macronutrients <Zcm0y9mS> ->

    fiber <ZxMvmqeZ> [https://www.notube.com/watch?v=hTui12lKus],
    water <xePTheNI> [https://www.notube.com/watch?v=hTui12lKus];

micronutrients [] <l7qy3zi2>->

    vitamins (ABCDEK) <6Nq8AWj7>,
    minerals (micronutrients) <jG4U9bwg>;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression-list>
|  +--<expression-list> ::= <expression> <expression>
|  |  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  |  +--<item> ::= <text> <tag>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--macronutrients 
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--Zcm0y9mS
|  |  |  |  |  +-->
|  |  |  +--<producer> ::= Hyphen RightArrow
|  |  |  |  +---
|  |  |  |  +-->
|  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  +--<item> ::= <text> <tag> Link
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    fiber 
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--ZxMvmqeZ
|  |  |  |  |  |  +-->
|  |  |  |  |  +--[https://www.notube.com/watch?v=hTui12lKus]
|  |  |  |  +--,
|  |  |  |  +--<item> ::= <text> <tag> Link
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    water 
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--xePTheNI
|  |  |  |  |  |  +-->
|  |  |  |  |  +--[https://www.notube.com/watch?v=hTui12lKus]
|  |  |  +--;
|  |  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  |  +--<item> ::= <text> Link <tag>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--micronutrients 
|  |  |  |  +--[]
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--l7qy3zi2
|  |  |  |  |  +-->
|  |  |  +--<producer> ::= Hyphen RightArrow
|  |  |  |  +---
|  |  |  |  +-->
|  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    vitamins (ABCDEK) 
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--6Nq8AWj7
|  |  |  |  |  |  +-->
|  |  |  |  +--,
|  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    minerals (micronutrients) 
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--jG4U9bwg
|  |  |  |  |  |  +-->
|  |  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                                                       Description                                                            
---------------   -----   -----   -----   ---------------------------------------------------------------   -----------------------------------------------------------------------
Token Read            0       0       0   macronutrients                                                    Token type: Text                                                       
Shift                12                                                                                     The parser shifted to state 12                                         
Token Read           12       0      15   <                                                                 Token type: LeftArrow                                                  
Reduce               18                   (1) ::= macronutrients                                            <text-chunk> ::= Text                                                  
Reduce               17                   (2) ::= (1)                                                       <text> ::= <text-chunk>                                                
Shift                24                                                                                     The parser shifted to state 24                                         
Token Read           24       0      16   Zcm0y9mS                                                          Token type: Text                                                       
Shift                12                                                                                     The parser shifted to state 12                                         
Token Read           12       0      24   >                                                                 Token type: RightArrow                                                 
Reduce               18                   (3) ::= Zcm0y9mS                                                  <text-chunk> ::= Text                                                  
Reduce               36                   (4) ::= (3)                                                       <text> ::= <text-chunk>                                                
Shift                49                                                                                     The parser shifted to state 49                                         
Token Read           49       0      26   -                                                                 Token type: Hyphen                                                     
Reduce               27                   (5) ::= < (4) >                                                   <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               15                   (6) ::= (2) (5)                                                   <item> ::= <text> <tag>                                                
Shift                22                                                                                     The parser shifted to state 22                                         
Token Read           22       0      27   >                                                                 Token type: RightArrow                                                 
Shift                30                                                                                     The parser shifted to state 30                                         
Token Read           30       2       0       fiber                                                         Token type: Text                                                       
Reduce               23                   (7) ::= - >                                                       <producer> ::= Hyphen RightArrow                                       
Shift                12                                                                                     The parser shifted to state 12                                         
Token Read           12       2      10   <                                                                 Token type: LeftArrow                                                  
Reduce               18                   (8) ::=     fiber                                                 <text-chunk> ::= Text                                                  
Reduce               17                   (9) ::= (8)                                                       <text> ::= <text-chunk>                                                
Shift                24                                                                                     The parser shifted to state 24                                         
Token Read           24       2      11   ZxMvmqeZ                                                          Token type: Text                                                       
Shift                12                                                                                     The parser shifted to state 12                                         
Token Read           12       2      19   >                                                                 Token type: RightArrow                                                 
Reduce               18                   (10) ::= ZxMvmqeZ                                                 <text-chunk> ::= Text                                                  
Reduce               36                   (11) ::= (10)                                                     <text> ::= <text-chunk>                                                
Shift                49                                                                                     The parser shifted to state 49                                         
Token Read           49       2      21   [https://www.notube.com/watch?v=hTui12lKus]                       Token type: Link                                                       
Reduce               27                   (12) ::= < (11) >                                                 <tag> ::= LeftArrow <text> RightArrow                                  
Shift                41                                                                                     The parser shifted to state 41                                         
Token Read           41       2      64   ,                                                                 Token type: Separator                                                  
Reduce               33                   (13) ::= (9) (12) [https://www.notube.com/watch?v=hTui12lKus]     <item> ::= <text> <tag> Link                                           
Shift                46                                                                                     The parser shifted to state 46                                         
Token Read           46       3       0       water                                                         Token type: Text                                                       
Shift                12                                                                                     The parser shifted to state 12                                         
Token Read           12       3      10   <                                                                 Token type: LeftArrow                                                  
Reduce               18                   (14) ::=     water                                                <text-chunk> ::= Text                                                  
Reduce               17                   (15) ::= (14)                                                     <text> ::= <text-chunk>                                                
Shift                24                                                                                     The parser shifted to state 24                                         
Token Read           24       3      11   xePTheNI                                                          Token type: Text                                                       
Shift                12                                                                                     The parser shifted to state 12                                         
Token Read           12       3      19   >                                                                 Token type: RightArrow                                                 
Reduce               18                   (16) ::= xePTheNI                                                 <text-chunk> ::= Text                                                  
Reduce               36                   (17) ::= (16)                                                     <text> ::= <text-chunk>                                                
Shift                49                                                                                     The parser shifted to state 49                                         
Token Read           49       3      21   [https://www.notube.com/watch?v=hTui12lKus]                       Token type: Link                                                       
Reduce               27                   (18) ::= < (17) >                                                 <tag> ::= LeftArrow <text> RightArrow                                  
Shift                41                                                                                     The parser shifted to state 41                                         
Token Read           41       3      64   ;                                                                 Token type: Terminator                                                 
Reduce               51                   (19) ::= (15) (18) [https://www.notube.com/watch?v=hTui12lKus]    <item> ::= <text> <tag> Link                                           
Reduce               35                   (20) ::= (13) , (19)                                              <item-or-expression-list> ::= <item> Separator <item>                  
Shift                48                                                                                     The parser shifted to state 48                                         
Token Read           48       5       0   micronutrients                                                    Token type: Text                                                       
Reduce               13                   (21) ::= (6) (7) (20) ;                                           <expression> ::= <item> <producer> <item-or-expression-list> Terminator
Shift                12                                                                                     The parser shifted to state 12                                         
Token Read           12       5      15   []                                                                Token type: Link                                                       
Reduce               18                   (22) ::= micronutrients                                           <text-chunk> ::= Text                                                  
Reduce               17                   (23) ::= (22)                                                     <text> ::= <text-chunk>                                                
Shift                25                                                                                     The parser shifted to state 25                                         
Token Read           25       5      18   <                                                                 Token type: LeftArrow                                                  
Shift                24                                                                                     The parser shifted to state 24                                         
Token Read           24       5      19   l7qy3zi2                                                          Token type: Text                                                       
Shift                12                                                                                     The parser shifted to state 12                                         
Token Read           12       5      27   >                                                                 Token type: RightArrow                                                 
Reduce               18                   (24) ::= l7qy3zi2                                                 <text-chunk> ::= Text                                                  
Reduce               36                   (25) ::= (24)                                                     <text> ::= <text-chunk>                                                
Shift                49                                                                                     The parser shifted to state 49                                         
Token Read           49       5      28   -                                                                 Token type: Hyphen                                                     
Reduce               39                   (26) ::= < (25) >                                                 <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               15                   (27) ::= (23) [] (26)                                             <item> ::= <text> Link <tag>                                           
Shift                22                                                                                     The parser shifted to state 22                                         
Token Read           22       5      29   >                                                                 Token type: RightArrow                                                 
Shift                30                                                                                     The parser shifted to state 30                                         
Token Read           30       7       0       vitamins (ABCDEK)                                             Token type: Text                                                       
Reduce               23                   (28) ::= - >                                                      <producer> ::= Hyphen RightArrow                                       
Shift                12                                                                                     The parser shifted to state 12                                         
Token Read           12       7      22   <                                                                 Token type: LeftArrow                                                  
Reduce               18                   (29) ::=     vitamins (ABCDEK)                                    <text-chunk> ::= Text                                                  
Reduce               17                   (30) ::= (29)                                                     <text> ::= <text-chunk>                                                
Shift                24                                                                                     The parser shifted to state 24                                         
Token Read           24       7      23   6Nq8AWj7                                                          Token type: Text                                                       
Shift                12                                                                                     The parser shifted to state 12                                         
Token Read           12       7      31   >                                                                 Token type: RightArrow                                                 
Reduce               18                   (31) ::= 6Nq8AWj7                                                 <text-chunk> ::= Text                                                  
Reduce               36                   (32) ::= (31)                                                     <text> ::= <text-chunk>                                                
Shift                49                                                                                     The parser shifted to state 49                                         
Token Read           49       7      32   ,                                                                 Token type: Separator                                                  
Reduce               27                   (33) ::= < (32) >                                                 <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               33                   (34) ::= (30) (33)                                                <item> ::= <text> <tag>                                                
Shift                46                                                                                     The parser shifted to state 46                                         
Token Read           46       8       0       minerals (micronutrients)                                     Token type: Text                                                       
Shift                12                                                                                     The parser shifted to state 12                                         
Token Read           12       8      30   <                                                                 Token type: LeftArrow                                                  
Reduce               18                   (35) ::=     minerals (micronutrients)                            <text-chunk> ::= Text                                                  
Reduce               17                   (36) ::= (35)                                                     <text> ::= <text-chunk>                                                
Shift                24                                                                                     The parser shifted to state 24                                         
Token Read           24       8      31   jG4U9bwg                                                          Token type: Text                                                       
Shift                12                                                                                     The parser shifted to state 12                                         
Token Read           12       8      39   >                                                                 Token type: RightArrow                                                 
Reduce               18                   (37) ::= jG4U9bwg                                                 <text-chunk> ::= Text                                                  
Reduce               36                   (38) ::= (37)                                                     <text> ::= <text-chunk>                                                
Shift                49                                                                                     The parser shifted to state 49                                         
Token Read           49       8      40   ;                                                                 Token type: Terminator                                                 
Reduce               27                   (39) ::= < (38) >                                                 <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               51                   (40) ::= (36) (39)                                                <item> ::= <text> <tag>                                                
Reduce               35                   (41) ::= (34) , (40)                                              <item-or-expression-list> ::= <item> Separator <item>                  
Shift                48                                                                                     The parser shifted to state 48                                         
Token Read           48       9       0                                                                     Token type: EOF                                                        
Reduce               20                   (42) ::= (27) (28) (41) ;                                         <expression> ::= <item> <producer> <item-or-expression-list> Terminator
Reduce               14                   (43) ::= (21) (42)                                                <expression-list> ::= <expression> <expression>                        
Reduce               16                   (44) ::= (43)                                                     <scripture> ::= <expression-list>                                      
Accept               16                                                                                                                                                            



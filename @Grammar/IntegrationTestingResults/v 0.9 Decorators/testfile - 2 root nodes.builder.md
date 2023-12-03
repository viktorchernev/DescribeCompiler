========================================
Source Code (between the arrows)
========================================

🡆macronutrients <Zcm0y9mS> 
{icon | nutrients.png}
->

    fiber <ZxMvmqeZ> [https://www.notube.com/watch?v=hTui12lKus],
    water <xePTheNI> [https://www.notube.com/watch?v=hTui12lKus];

micronutrients [] {icon | micronutrients.png} <l7qy3zi2>->

    vitamins (ABCDEK) <6Nq8AWj7>,
    minerals (micronutrients) <jG4U9bwg>;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression-list>
|  +--<expression-list> ::= <expression> <expression>
|  |  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  |  +--<item> ::= <text> <tag> Decorator
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--macronutrients 
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--Zcm0y9mS
|  |  |  |  |  +-->
|  |  |  |  +--{icon | nutrients.png}
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
|  |  |  +--<item> ::= <text> Link Decorator <tag>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--micronutrients 
|  |  |  |  +--[]
|  |  |  |  +--{icon | micronutrients.png}
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
Shift                14                                                                                     The parser shifted to state 14                                         
Token Read           14       0      15   <                                                                 Token type: LeftArrow                                                  
Reduce               20                   (1) ::= macronutrients                                            <text-chunk> ::= Text                                                  
Reduce               19                   (2) ::= (1)                                                       <text> ::= <text-chunk>                                                
Shift                27                                                                                     The parser shifted to state 27                                         
Token Read           27       0      16   Zcm0y9mS                                                          Token type: Text                                                       
Shift                14                                                                                     The parser shifted to state 14                                         
Token Read           14       0      24   >                                                                 Token type: RightArrow                                                 
Reduce               20                   (3) ::= Zcm0y9mS                                                  <text-chunk> ::= Text                                                  
Reduce               45                   (4) ::= (3)                                                       <text> ::= <text-chunk>                                                
Shift                71                                                                                     The parser shifted to state 71                                         
Token Read           71       1       0   {icon | nutrients.png}                                            Token type: Decorator                                                  
Reduce               31                   (5) ::= < (4) >                                                   <tag> ::= LeftArrow <text> RightArrow                                  
Shift                57                                                                                     The parser shifted to state 57                                         
Token Read           57       2       0   -                                                                 Token type: Hyphen                                                     
Reduce               17                   (6) ::= (2) (5) {icon | nutrients.png}                            <item> ::= <text> <tag> Decorator                                      
Shift                24                                                                                     The parser shifted to state 24                                         
Token Read           24       2       1   >                                                                 Token type: RightArrow                                                 
Shift                34                                                                                     The parser shifted to state 34                                         
Token Read           34       4       0       fiber                                                         Token type: Text                                                       
Reduce               25                   (7) ::= - >                                                       <producer> ::= Hyphen RightArrow                                       
Shift                14                                                                                     The parser shifted to state 14                                         
Token Read           14       4      10   <                                                                 Token type: LeftArrow                                                  
Reduce               20                   (8) ::=     fiber                                                 <text-chunk> ::= Text                                                  
Reduce               19                   (9) ::= (8)                                                       <text> ::= <text-chunk>                                                
Shift                27                                                                                     The parser shifted to state 27                                         
Token Read           27       4      11   ZxMvmqeZ                                                          Token type: Text                                                       
Shift                14                                                                                     The parser shifted to state 14                                         
Token Read           14       4      19   >                                                                 Token type: RightArrow                                                 
Reduce               20                   (10) ::= ZxMvmqeZ                                                 <text-chunk> ::= Text                                                  
Reduce               45                   (11) ::= (10)                                                     <text> ::= <text-chunk>                                                
Shift                71                                                                                     The parser shifted to state 71                                         
Token Read           71       4      21   [https://www.notube.com/watch?v=hTui12lKus]                       Token type: Link                                                       
Reduce               31                   (12) ::= < (11) >                                                 <tag> ::= LeftArrow <text> RightArrow                                  
Shift                58                                                                                     The parser shifted to state 58                                         
Token Read           58       4      64   ,                                                                 Token type: Separator                                                  
Reduce               37                   (13) ::= (9) (12) [https://www.notube.com/watch?v=hTui12lKus]     <item> ::= <text> <tag> Link                                           
Shift                64                                                                                     The parser shifted to state 64                                         
Token Read           64       5       0       water                                                         Token type: Text                                                       
Shift                14                                                                                     The parser shifted to state 14                                         
Token Read           14       5      10   <                                                                 Token type: LeftArrow                                                  
Reduce               20                   (14) ::=     water                                                <text-chunk> ::= Text                                                  
Reduce               19                   (15) ::= (14)                                                     <text> ::= <text-chunk>                                                
Shift                27                                                                                     The parser shifted to state 27                                         
Token Read           27       5      11   xePTheNI                                                          Token type: Text                                                       
Shift                14                                                                                     The parser shifted to state 14                                         
Token Read           14       5      19   >                                                                 Token type: RightArrow                                                 
Reduce               20                   (16) ::= xePTheNI                                                 <text-chunk> ::= Text                                                  
Reduce               45                   (17) ::= (16)                                                     <text> ::= <text-chunk>                                                
Shift                71                                                                                     The parser shifted to state 71                                         
Token Read           71       5      21   [https://www.notube.com/watch?v=hTui12lKus]                       Token type: Link                                                       
Reduce               31                   (18) ::= < (17) >                                                 <tag> ::= LeftArrow <text> RightArrow                                  
Shift                58                                                                                     The parser shifted to state 58                                         
Token Read           58       5      64   ;                                                                 Token type: Terminator                                                 
Reduce               93                   (19) ::= (15) (18) [https://www.notube.com/watch?v=hTui12lKus]    <item> ::= <text> <tag> Link                                           
Reduce               39                   (20) ::= (13) , (19)                                              <item-or-expression-list> ::= <item> Separator <item>                  
Shift                66                                                                                     The parser shifted to state 66                                         
Token Read           66       7       0   micronutrients                                                    Token type: Text                                                       
Reduce               15                   (21) ::= (6) (7) (20) ;                                           <expression> ::= <item> <producer> <item-or-expression-list> Terminator
Shift                14                                                                                     The parser shifted to state 14                                         
Token Read           14       7      15   []                                                                Token type: Link                                                       
Reduce               20                   (22) ::= micronutrients                                           <text-chunk> ::= Text                                                  
Reduce               19                   (23) ::= (22)                                                     <text> ::= <text-chunk>                                                
Shift                28                                                                                     The parser shifted to state 28                                         
Token Read           28       7      18   {icon | micronutrients.png}                                       Token type: Decorator                                                  
Shift                46                                                                                     The parser shifted to state 46                                         
Token Read           46       7      46   <                                                                 Token type: LeftArrow                                                  
Shift                27                                                                                     The parser shifted to state 27                                         
Token Read           27       7      47   l7qy3zi2                                                          Token type: Text                                                       
Shift                14                                                                                     The parser shifted to state 14                                         
Token Read           14       7      55   >                                                                 Token type: RightArrow                                                 
Reduce               20                   (24) ::= l7qy3zi2                                                 <text-chunk> ::= Text                                                  
Reduce               45                   (25) ::= (24)                                                     <text> ::= <text-chunk>                                                
Shift                71                                                                                     The parser shifted to state 71                                         
Token Read           71       7      56   -                                                                 Token type: Hyphen                                                     
Reduce               72                   (26) ::= < (25) >                                                 <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               17                   (27) ::= (23) [] {icon | micronutrients.png} (26)                 <item> ::= <text> Link Decorator <tag>                                 
Shift                24                                                                                     The parser shifted to state 24                                         
Token Read           24       7      57   >                                                                 Token type: RightArrow                                                 
Shift                34                                                                                     The parser shifted to state 34                                         
Token Read           34       9       0       vitamins (ABCDEK)                                             Token type: Text                                                       
Reduce               25                   (28) ::= - >                                                      <producer> ::= Hyphen RightArrow                                       
Shift                14                                                                                     The parser shifted to state 14                                         
Token Read           14       9      22   <                                                                 Token type: LeftArrow                                                  
Reduce               20                   (29) ::=     vitamins (ABCDEK)                                    <text-chunk> ::= Text                                                  
Reduce               19                   (30) ::= (29)                                                     <text> ::= <text-chunk>                                                
Shift                27                                                                                     The parser shifted to state 27                                         
Token Read           27       9      23   6Nq8AWj7                                                          Token type: Text                                                       
Shift                14                                                                                     The parser shifted to state 14                                         
Token Read           14       9      31   >                                                                 Token type: RightArrow                                                 
Reduce               20                   (31) ::= 6Nq8AWj7                                                 <text-chunk> ::= Text                                                  
Reduce               45                   (32) ::= (31)                                                     <text> ::= <text-chunk>                                                
Shift                71                                                                                     The parser shifted to state 71                                         
Token Read           71       9      32   ,                                                                 Token type: Separator                                                  
Reduce               31                   (33) ::= < (32) >                                                 <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               37                   (34) ::= (30) (33)                                                <item> ::= <text> <tag>                                                
Shift                64                                                                                     The parser shifted to state 64                                         
Token Read           64      10       0       minerals (micronutrients)                                     Token type: Text                                                       
Shift                14                                                                                     The parser shifted to state 14                                         
Token Read           14      10      30   <                                                                 Token type: LeftArrow                                                  
Reduce               20                   (35) ::=     minerals (micronutrients)                            <text-chunk> ::= Text                                                  
Reduce               19                   (36) ::= (35)                                                     <text> ::= <text-chunk>                                                
Shift                27                                                                                     The parser shifted to state 27                                         
Token Read           27      10      31   jG4U9bwg                                                          Token type: Text                                                       
Shift                14                                                                                     The parser shifted to state 14                                         
Token Read           14      10      39   >                                                                 Token type: RightArrow                                                 
Reduce               20                   (37) ::= jG4U9bwg                                                 <text-chunk> ::= Text                                                  
Reduce               45                   (38) ::= (37)                                                     <text> ::= <text-chunk>                                                
Shift                71                                                                                     The parser shifted to state 71                                         
Token Read           71      10      40   ;                                                                 Token type: Terminator                                                 
Reduce               31                   (39) ::= < (38) >                                                 <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               93                   (40) ::= (36) (39)                                                <item> ::= <text> <tag>                                                
Reduce               39                   (41) ::= (34) , (40)                                              <item-or-expression-list> ::= <item> Separator <item>                  
Shift                66                                                                                     The parser shifted to state 66                                         
Token Read           66      11       0                                                                     Token type: EOF                                                        
Reduce               22                   (42) ::= (27) (28) (41) ;                                         <expression> ::= <item> <producer> <item-or-expression-list> Terminator
Reduce               16                   (43) ::= (21) (42)                                                <expression-list> ::= <expression> <expression>                        
Reduce               18                   (44) ::= (43)                                                     <scripture> ::= <expression-list>                                      
Accept               18                                                                                                                                                            



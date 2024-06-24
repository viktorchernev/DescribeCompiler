========================================
Source Code (between the arrows)
========================================

🡆macronutrients <Zcm0y9mS> ->

    fiber <ZxMvmqeZ>,
    water <xePTheNI>;

micronutrients <l7qy3zi2>->

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
|  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    fiber 
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--ZxMvmqeZ
|  |  |  |  |  |  +-->
|  |  |  |  +--,
|  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    water 
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--xePTheNI
|  |  |  |  |  |  +-->
|  |  |  +--;
|  |  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  |  +--<item> ::= <text> <tag>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--micronutrients 
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

Parse Action      State    Line     Col   Parse Value                                Description                                                            
---------------   -----   -----   -----   ----------------------------------------   -----------------------------------------------------------------------
Token Read            0       0       0   macronutrients                             Token type: Text                                                       
Shift                11                                                              The parser shifted to state 11                                         
Token Read           11       0      15   <                                          Token type: LeftArrow                                                  
Reduce               18                   (1) ::= macronutrients                     <text-chunk> ::= Text                                                  
Reduce               17                   (2) ::= (1)                                <text> ::= <text-chunk>                                                
Shift                10                                                              The parser shifted to state 10                                         
Token Read           10       0      16   Zcm0y9mS                                   Token type: Text                                                       
Shift                11                                                              The parser shifted to state 11                                         
Token Read           11       0      24   >                                          Token type: RightArrow                                                 
Reduce               18                   (3) ::= Zcm0y9mS                           <text-chunk> ::= Text                                                  
Reduce               20                   (4) ::= (3)                                <text> ::= <text-chunk>                                                
Shift                29                                                              The parser shifted to state 29                                         
Token Read           29       0      26   -                                          Token type: Hyphen                                                     
Reduce               26                   (5) ::= < (4) >                            <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               14                   (6) ::= (2) (5)                            <item> ::= <text> <tag>                                                
Shift                23                                                              The parser shifted to state 23                                         
Token Read           23       0      27   >                                          Token type: RightArrow                                                 
Shift                30                                                              The parser shifted to state 30                                         
Token Read           30       0      28       fiber                                  Token type: Text                                                       
Reduce               24                   (7) ::= - >                                <producer> ::= Hyphen RightArrow                                       
Shift                11                                                              The parser shifted to state 11                                         
Token Read           11       0      38   <                                          Token type: LeftArrow                                                  
Reduce               18                   (8) ::=     fiber                          <text-chunk> ::= Text                                                  
Reduce               17                   (9) ::= (8)                                <text> ::= <text-chunk>                                                
Shift                10                                                              The parser shifted to state 10                                         
Token Read           10       0      39   ZxMvmqeZ                                   Token type: Text                                                       
Shift                11                                                              The parser shifted to state 11                                         
Token Read           11       0      47   >                                          Token type: RightArrow                                                 
Reduce               18                   (10) ::= ZxMvmqeZ                          <text-chunk> ::= Text                                                  
Reduce               20                   (11) ::= (10)                              <text> ::= <text-chunk>                                                
Shift                29                                                              The parser shifted to state 29                                         
Token Read           29       0      48   ,                                          Token type: Separator                                                  
Reduce               26                   (12) ::= < (11) >                          <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               33                   (13) ::= (9) (12)                          <item> ::= <text> <tag>                                                
Shift                39                                                              The parser shifted to state 39                                         
Token Read           39       0      49       water                                  Token type: Text                                                       
Shift                11                                                              The parser shifted to state 11                                         
Token Read           11       0      59   <                                          Token type: LeftArrow                                                  
Reduce               18                   (14) ::=     water                         <text-chunk> ::= Text                                                  
Reduce               17                   (15) ::= (14)                              <text> ::= <text-chunk>                                                
Shift                10                                                              The parser shifted to state 10                                         
Token Read           10       0      60   xePTheNI                                   Token type: Text                                                       
Shift                11                                                              The parser shifted to state 11                                         
Token Read           11       0      68   >                                          Token type: RightArrow                                                 
Reduce               18                   (16) ::= xePTheNI                          <text-chunk> ::= Text                                                  
Reduce               20                   (17) ::= (16)                              <text> ::= <text-chunk>                                                
Shift                29                                                              The parser shifted to state 29                                         
Token Read           29       0      69   ;                                          Token type: Terminator                                                 
Reduce               26                   (18) ::= < (17) >                          <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               43                   (19) ::= (15) (18)                         <item> ::= <text> <tag>                                                
Reduce               35                   (20) ::= (13) , (19)                       <item-or-expression-list> ::= <item> Separator <item>                  
Shift                41                                                              The parser shifted to state 41                                         
Token Read           41       0      70   micronutrients                             Token type: Text                                                       
Reduce               12                   (21) ::= (6) (7) (20) ;                    <expression> ::= <item> <producer> <item-or-expression-list> Terminator
Shift                11                                                              The parser shifted to state 11                                         
Token Read           11       0      85   <                                          Token type: LeftArrow                                                  
Reduce               18                   (22) ::= micronutrients                    <text-chunk> ::= Text                                                  
Reduce               17                   (23) ::= (22)                              <text> ::= <text-chunk>                                                
Shift                10                                                              The parser shifted to state 10                                         
Token Read           10       0      86   l7qy3zi2                                   Token type: Text                                                       
Shift                11                                                              The parser shifted to state 11                                         
Token Read           11       0      94   >                                          Token type: RightArrow                                                 
Reduce               18                   (24) ::= l7qy3zi2                          <text-chunk> ::= Text                                                  
Reduce               20                   (25) ::= (24)                              <text> ::= <text-chunk>                                                
Shift                29                                                              The parser shifted to state 29                                         
Token Read           29       0      95   -                                          Token type: Hyphen                                                     
Reduce               26                   (26) ::= < (25) >                          <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               14                   (27) ::= (23) (26)                         <item> ::= <text> <tag>                                                
Shift                23                                                              The parser shifted to state 23                                         
Token Read           23       0      96   >                                          Token type: RightArrow                                                 
Shift                30                                                              The parser shifted to state 30                                         
Token Read           30       0      97       vitamins (ABCDEK)                      Token type: Text                                                       
Reduce               24                   (28) ::= - >                               <producer> ::= Hyphen RightArrow                                       
Shift                11                                                              The parser shifted to state 11                                         
Token Read           11       0     119   <                                          Token type: LeftArrow                                                  
Reduce               18                   (29) ::=     vitamins (ABCDEK)             <text-chunk> ::= Text                                                  
Reduce               17                   (30) ::= (29)                              <text> ::= <text-chunk>                                                
Shift                10                                                              The parser shifted to state 10                                         
Token Read           10       0     120   6Nq8AWj7                                   Token type: Text                                                       
Shift                11                                                              The parser shifted to state 11                                         
Token Read           11       0     128   >                                          Token type: RightArrow                                                 
Reduce               18                   (31) ::= 6Nq8AWj7                          <text-chunk> ::= Text                                                  
Reduce               20                   (32) ::= (31)                              <text> ::= <text-chunk>                                                
Shift                29                                                              The parser shifted to state 29                                         
Token Read           29       0     129   ,                                          Token type: Separator                                                  
Reduce               26                   (33) ::= < (32) >                          <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               33                   (34) ::= (30) (33)                         <item> ::= <text> <tag>                                                
Shift                39                                                              The parser shifted to state 39                                         
Token Read           39       0     130       minerals (micronutrients)              Token type: Text                                                       
Shift                11                                                              The parser shifted to state 11                                         
Token Read           11       0     160   <                                          Token type: LeftArrow                                                  
Reduce               18                   (35) ::=     minerals (micronutrients)     <text-chunk> ::= Text                                                  
Reduce               17                   (36) ::= (35)                              <text> ::= <text-chunk>                                                
Shift                10                                                              The parser shifted to state 10                                         
Token Read           10       0     161   jG4U9bwg                                   Token type: Text                                                       
Shift                11                                                              The parser shifted to state 11                                         
Token Read           11       0     169   >                                          Token type: RightArrow                                                 
Reduce               18                   (37) ::= jG4U9bwg                          <text-chunk> ::= Text                                                  
Reduce               20                   (38) ::= (37)                              <text> ::= <text-chunk>                                                
Shift                29                                                              The parser shifted to state 29                                         
Token Read           29       0     170   ;                                          Token type: Terminator                                                 
Reduce               26                   (39) ::= < (38) >                          <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               43                   (40) ::= (36) (39)                         <item> ::= <text> <tag>                                                
Reduce               35                   (41) ::= (34) , (40)                       <item-or-expression-list> ::= <item> Separator <item>                  
Shift                41                                                              The parser shifted to state 41                                         
Token Read           41       1       0                                              Token type: EOF                                                        
Reduce               21                   (42) ::= (27) (28) (41) ;                  <expression> ::= <item> <producer> <item-or-expression-list> Terminator
Reduce               13                   (43) ::= (21) (42)                         <expression-list> ::= <expression> <expression>                        
Reduce               15                   (44) ::= (43)                              <scripture> ::= <expression-list>                                      
Accept               15                                                                                                                                     



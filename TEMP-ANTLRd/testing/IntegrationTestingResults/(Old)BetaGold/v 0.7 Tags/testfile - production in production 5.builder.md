========================================
Source Code (between the arrows)
========================================

🡆macronutrients <SxOf3elF> ->

	water <8S3IwDlG>,
    salt <RV4OUQoy>,
    fiber <G3tWgyDr> ->

        what <AwPl7oBK>,
        not <OcIUTGif>;
	
	science <k543P1uB> ->
		
		math <IZZ9vPiK>,
		informathics <OMH9y9Jn>,
		medicine <UuA1ITf9>;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression-list>
|  |  +--<item> ::= <text> <tag>
|  |  |  +--<text> ::= <text-chunk>
|  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  +--macronutrients 
|  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  +--<
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--SxOf3elF
|  |  |  |  +-->
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  +--<item> ::= <text> <tag>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--    water 
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--8S3IwDlG
|  |  |  |  |  +-->
|  |  |  +--,
|  |  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    salt 
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--RV4OUQoy
|  |  |  |  |  |  +-->
|  |  |  |  +--,
|  |  |  |  +--<item-or-expression-list> ::= <expression> <expression>
|  |  |  |  |  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--    fiber 
|  |  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--G3tWgyDr
|  |  |  |  |  |  |  |  +-->
|  |  |  |  |  |  +--<producer> ::= Hyphen RightArrow
|  |  |  |  |  |  |  +---
|  |  |  |  |  |  |  +-->
|  |  |  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--        what 
|  |  |  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  +--AwPl7oBK
|  |  |  |  |  |  |  |  |  +-->
|  |  |  |  |  |  |  +--,
|  |  |  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--        not 
|  |  |  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  +--OcIUTGif
|  |  |  |  |  |  |  |  |  +-->
|  |  |  |  |  |  +--;
|  |  |  |  |  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--    science 
|  |  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--k543P1uB
|  |  |  |  |  |  |  |  +-->
|  |  |  |  |  |  +--<producer> ::= Hyphen RightArrow
|  |  |  |  |  |  |  +---
|  |  |  |  |  |  |  +-->
|  |  |  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--        math 
|  |  |  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  +--IZZ9vPiK
|  |  |  |  |  |  |  |  |  +-->
|  |  |  |  |  |  |  +--,
|  |  |  |  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  +--        informathics 
|  |  |  |  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  +--OMH9y9Jn
|  |  |  |  |  |  |  |  |  |  +-->
|  |  |  |  |  |  |  |  +--,
|  |  |  |  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  +--        medicine 
|  |  |  |  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  +--UuA1ITf9
|  |  |  |  |  |  |  |  |  |  +-->
|  |  |  |  |  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                       Description                                                             
---------------   -----   -----   -----   -------------------------------   ------------------------------------------------------------------------
Token Read            0       0       0   macronutrients                    Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       0      15   <                                 Token type: LeftArrow                                                   
Reduce               18                   (1) ::= macronutrients            <text-chunk> ::= Text                                                   
Reduce               17                   (2) ::= (1)                       <text> ::= <text-chunk>                                                 
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       0      16   SxOf3elF                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       0      24   >                                 Token type: RightArrow                                                  
Reduce               18                   (3) ::= SxOf3elF                  <text-chunk> ::= Text                                                   
Reduce               20                   (4) ::= (3)                       <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       0      26   -                                 Token type: Hyphen                                                      
Reduce               26                   (5) ::= < (4) >                   <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               14                   (6) ::= (2) (5)                   <item> ::= <text> <tag>                                                 
Shift                23                                                     The parser shifted to state 23                                          
Token Read           23       0      27   >                                 Token type: RightArrow                                                  
Shift                30                                                     The parser shifted to state 30                                          
Token Read           30       2       0       water                         Token type: Text                                                        
Reduce               24                   (7) ::= - >                       <producer> ::= Hyphen RightArrow                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       2      10   <                                 Token type: LeftArrow                                                   
Reduce               18                   (8) ::=     water                 <text-chunk> ::= Text                                                   
Reduce               17                   (9) ::= (8)                       <text> ::= <text-chunk>                                                 
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       2      11   8S3IwDlG                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       2      19   >                                 Token type: RightArrow                                                  
Reduce               18                   (10) ::= 8S3IwDlG                 <text-chunk> ::= Text                                                   
Reduce               20                   (11) ::= (10)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       2      20   ,                                 Token type: Separator                                                   
Reduce               26                   (12) ::= < (11) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (13) ::= (9) (12)                 <item> ::= <text> <tag>                                                 
Shift                39                                                     The parser shifted to state 39                                          
Token Read           39       3       0       salt                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       3       9   <                                 Token type: LeftArrow                                                   
Reduce               18                   (14) ::=     salt                 <text-chunk> ::= Text                                                   
Reduce               17                   (15) ::= (14)                     <text> ::= <text-chunk>                                                 
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       3      10   RV4OUQoy                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       3      18   >                                 Token type: RightArrow                                                  
Reduce               18                   (16) ::= RV4OUQoy                 <text-chunk> ::= Text                                                   
Reduce               20                   (17) ::= (16)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       3      19   ,                                 Token type: Separator                                                   
Reduce               26                   (18) ::= < (17) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (19) ::= (15) (18)                <item> ::= <text> <tag>                                                 
Shift                39                                                     The parser shifted to state 39                                          
Token Read           39       4       0       fiber                         Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       4      10   <                                 Token type: LeftArrow                                                   
Reduce               18                   (20) ::=     fiber                <text-chunk> ::= Text                                                   
Reduce               17                   (21) ::= (20)                     <text> ::= <text-chunk>                                                 
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       4      11   G3tWgyDr                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       4      19   >                                 Token type: RightArrow                                                  
Reduce               18                   (22) ::= G3tWgyDr                 <text-chunk> ::= Text                                                   
Reduce               20                   (23) ::= (22)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       4      21   -                                 Token type: Hyphen                                                      
Reduce               26                   (24) ::= < (23) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (25) ::= (21) (24)                <item> ::= <text> <tag>                                                 
Shift                23                                                     The parser shifted to state 23                                          
Token Read           23       4      22   >                                 Token type: RightArrow                                                  
Shift                30                                                     The parser shifted to state 30                                          
Token Read           30       6       0           what                      Token type: Text                                                        
Reduce               24                   (26) ::= - >                      <producer> ::= Hyphen RightArrow                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       6      13   <                                 Token type: LeftArrow                                                   
Reduce               18                   (27) ::=         what             <text-chunk> ::= Text                                                   
Reduce               17                   (28) ::= (27)                     <text> ::= <text-chunk>                                                 
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       6      14   AwPl7oBK                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       6      22   >                                 Token type: RightArrow                                                  
Reduce               18                   (29) ::= AwPl7oBK                 <text-chunk> ::= Text                                                   
Reduce               20                   (30) ::= (29)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       6      23   ,                                 Token type: Separator                                                   
Reduce               26                   (31) ::= < (30) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (32) ::= (28) (31)                <item> ::= <text> <tag>                                                 
Shift                39                                                     The parser shifted to state 39                                          
Token Read           39       7       0           not                       Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       7      12   <                                 Token type: LeftArrow                                                   
Reduce               18                   (33) ::=         not              <text-chunk> ::= Text                                                   
Reduce               17                   (34) ::= (33)                     <text> ::= <text-chunk>                                                 
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       7      13   OcIUTGif                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       7      21   >                                 Token type: RightArrow                                                  
Reduce               18                   (35) ::= OcIUTGif                 <text-chunk> ::= Text                                                   
Reduce               20                   (36) ::= (35)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       7      22   ;                                 Token type: Terminator                                                  
Reduce               26                   (37) ::= < (36) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (38) ::= (34) (37)                <item> ::= <text> <tag>                                                 
Reduce               35                   (39) ::= (32) , (38)              <item-or-expression-list> ::= <item> Separator <item>                   
Shift                41                                                     The parser shifted to state 41                                          
Token Read           41       9       0       science                       Token type: Text                                                        
Reduce               42                   (40) ::= (25) (26) (39) ;         <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       9      12   <                                 Token type: LeftArrow                                                   
Reduce               18                   (41) ::=     science              <text-chunk> ::= Text                                                   
Reduce               17                   (42) ::= (41)                     <text> ::= <text-chunk>                                                 
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       9      13   k543P1uB                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       9      21   >                                 Token type: RightArrow                                                  
Reduce               18                   (43) ::= k543P1uB                 <text-chunk> ::= Text                                                   
Reduce               20                   (44) ::= (43)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       9      23   -                                 Token type: Hyphen                                                      
Reduce               26                   (45) ::= < (44) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               37                   (46) ::= (42) (45)                <item> ::= <text> <tag>                                                 
Shift                23                                                     The parser shifted to state 23                                          
Token Read           23       9      24   >                                 Token type: RightArrow                                                  
Shift                30                                                     The parser shifted to state 30                                          
Token Read           30      11       0           math                      Token type: Text                                                        
Reduce               24                   (47) ::= - >                      <producer> ::= Hyphen RightArrow                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11      11      13   <                                 Token type: LeftArrow                                                   
Reduce               18                   (48) ::=         math             <text-chunk> ::= Text                                                   
Reduce               17                   (49) ::= (48)                     <text> ::= <text-chunk>                                                 
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10      11      14   IZZ9vPiK                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11      11      22   >                                 Token type: RightArrow                                                  
Reduce               18                   (50) ::= IZZ9vPiK                 <text-chunk> ::= Text                                                   
Reduce               20                   (51) ::= (50)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29      11      23   ,                                 Token type: Separator                                                   
Reduce               26                   (52) ::= < (51) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (53) ::= (49) (52)                <item> ::= <text> <tag>                                                 
Shift                39                                                     The parser shifted to state 39                                          
Token Read           39      12       0           informathics              Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11      12      21   <                                 Token type: LeftArrow                                                   
Reduce               18                   (54) ::=         informathics     <text-chunk> ::= Text                                                   
Reduce               17                   (55) ::= (54)                     <text> ::= <text-chunk>                                                 
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10      12      22   OMH9y9Jn                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11      12      30   >                                 Token type: RightArrow                                                  
Reduce               18                   (56) ::= OMH9y9Jn                 <text-chunk> ::= Text                                                   
Reduce               20                   (57) ::= (56)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29      12      31   ,                                 Token type: Separator                                                   
Reduce               26                   (58) ::= < (57) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (59) ::= (55) (58)                <item> ::= <text> <tag>                                                 
Shift                39                                                     The parser shifted to state 39                                          
Token Read           39      13       0           medicine                  Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11      13      17   <                                 Token type: LeftArrow                                                   
Reduce               18                   (60) ::=         medicine         <text-chunk> ::= Text                                                   
Reduce               17                   (61) ::= (60)                     <text> ::= <text-chunk>                                                 
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10      13      18   UuA1ITf9                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11      13      26   >                                 Token type: RightArrow                                                  
Reduce               18                   (62) ::= UuA1ITf9                 <text-chunk> ::= Text                                                   
Reduce               20                   (63) ::= (62)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29      13      27   ;                                 Token type: Terminator                                                  
Reduce               26                   (64) ::= < (63) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (65) ::= (61) (64)                <item> ::= <text> <tag>                                                 
Reduce               44                   (66) ::= (59) , (65)              <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               35                   (67) ::= (53) , (66)              <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                41                                                     The parser shifted to state 41                                          
Token Read           41      14       0                                     Token type: EOF                                                         
Reduce               36                   (68) ::= (46) (47) (67) ;         <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               44                   (69) ::= (40) (68)                <item-or-expression-list> ::= <expression> <expression>                 
Reduce               44                   (70) ::= (19) , (69)              <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               35                   (71) ::= (13) , (70)              <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               12                   (72) ::= (6) (7) (71)             <expression> ::= <item> <producer> <item-or-expression-list>            
Reduce               15                   (73) ::= (72)                     <scripture> ::= <expression>                                            
Accept               15                                                                                                                             



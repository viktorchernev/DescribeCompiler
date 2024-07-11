========================================
Source Code (between the arrows)
========================================

🡆macronutrients <xkQxOfc9> ->

    fiber <CbALGP8d> ->

        what <7KNUmetK>,
        not <6qFQ0HxK>;
	
	science <o8lvOnlB> ->
		
		math <SbQjE2YS>,
		informathics <CVOSiiAS>,
		medicine <1G0hZLJ4>;
    
    water <ozhHnNOU>,
    salt <jMBLOKGE>;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  +--<item> ::= <text> <tag>
|  |  |  +--<text> ::= <text-chunk>
|  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  +--macronutrients 
|  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  +--<
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--xkQxOfc9
|  |  |  |  +-->
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <expression> <item-or-expression-list>
|  |  |  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    fiber 
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--CbALGP8d
|  |  |  |  |  |  +-->
|  |  |  |  +--<producer> ::= Hyphen RightArrow
|  |  |  |  |  +---
|  |  |  |  |  +-->
|  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--        what 
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--7KNUmetK
|  |  |  |  |  |  |  +-->
|  |  |  |  |  +--,
|  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--        not 
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--6qFQ0HxK
|  |  |  |  |  |  |  +-->
|  |  |  |  +--;
|  |  |  +--<item-or-expression-list> ::= <expression> <item-or-expression-list>
|  |  |  |  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    science 
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--o8lvOnlB
|  |  |  |  |  |  |  +-->
|  |  |  |  |  +--<producer> ::= Hyphen RightArrow
|  |  |  |  |  |  +---
|  |  |  |  |  |  +-->
|  |  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--        math 
|  |  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--SbQjE2YS
|  |  |  |  |  |  |  |  +-->
|  |  |  |  |  |  +--,
|  |  |  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--        informathics 
|  |  |  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  +--CVOSiiAS
|  |  |  |  |  |  |  |  |  +-->
|  |  |  |  |  |  |  +--,
|  |  |  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--        medicine 
|  |  |  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  +--1G0hZLJ4
|  |  |  |  |  |  |  |  |  +-->
|  |  |  |  |  +--;
|  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    water 
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--ozhHnNOU
|  |  |  |  |  |  |  +-->
|  |  |  |  |  +--,
|  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    salt 
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--jMBLOKGE
|  |  |  |  |  |  |  +-->
|  |  +--;


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
Token Read           10       0      16   xkQxOfc9                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       0      24   >                                 Token type: RightArrow                                                  
Reduce               18                   (3) ::= xkQxOfc9                  <text-chunk> ::= Text                                                   
Reduce               20                   (4) ::= (3)                       <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       0      26   -                                 Token type: Hyphen                                                      
Reduce               26                   (5) ::= < (4) >                   <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               14                   (6) ::= (2) (5)                   <item> ::= <text> <tag>                                                 
Shift                23                                                     The parser shifted to state 23                                          
Token Read           23       0      27   >                                 Token type: RightArrow                                                  
Shift                30                                                     The parser shifted to state 30                                          
Token Read           30       2       0       fiber                         Token type: Text                                                        
Reduce               24                   (7) ::= - >                       <producer> ::= Hyphen RightArrow                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       2      10   <                                 Token type: LeftArrow                                                   
Reduce               18                   (8) ::=     fiber                 <text-chunk> ::= Text                                                   
Reduce               17                   (9) ::= (8)                       <text> ::= <text-chunk>                                                 
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       2      11   CbALGP8d                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       2      19   >                                 Token type: RightArrow                                                  
Reduce               18                   (10) ::= CbALGP8d                 <text-chunk> ::= Text                                                   
Reduce               20                   (11) ::= (10)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       2      21   -                                 Token type: Hyphen                                                      
Reduce               26                   (12) ::= < (11) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (13) ::= (9) (12)                 <item> ::= <text> <tag>                                                 
Shift                23                                                     The parser shifted to state 23                                          
Token Read           23       2      22   >                                 Token type: RightArrow                                                  
Shift                30                                                     The parser shifted to state 30                                          
Token Read           30       4       0           what                      Token type: Text                                                        
Reduce               24                   (14) ::= - >                      <producer> ::= Hyphen RightArrow                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       4      13   <                                 Token type: LeftArrow                                                   
Reduce               18                   (15) ::=         what             <text-chunk> ::= Text                                                   
Reduce               17                   (16) ::= (15)                     <text> ::= <text-chunk>                                                 
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       4      14   7KNUmetK                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       4      22   >                                 Token type: RightArrow                                                  
Reduce               18                   (17) ::= 7KNUmetK                 <text-chunk> ::= Text                                                   
Reduce               20                   (18) ::= (17)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       4      23   ,                                 Token type: Separator                                                   
Reduce               26                   (19) ::= < (18) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (20) ::= (16) (19)                <item> ::= <text> <tag>                                                 
Shift                39                                                     The parser shifted to state 39                                          
Token Read           39       5       0           not                       Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       5      12   <                                 Token type: LeftArrow                                                   
Reduce               18                   (21) ::=         not              <text-chunk> ::= Text                                                   
Reduce               17                   (22) ::= (21)                     <text> ::= <text-chunk>                                                 
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       5      13   6qFQ0HxK                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       5      21   >                                 Token type: RightArrow                                                  
Reduce               18                   (23) ::= 6qFQ0HxK                 <text-chunk> ::= Text                                                   
Reduce               20                   (24) ::= (23)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       5      22   ;                                 Token type: Terminator                                                  
Reduce               26                   (25) ::= < (24) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (26) ::= (22) (25)                <item> ::= <text> <tag>                                                 
Reduce               35                   (27) ::= (20) , (26)              <item-or-expression-list> ::= <item> Separator <item>                   
Shift                41                                                     The parser shifted to state 41                                          
Token Read           41       7       0       science                       Token type: Text                                                        
Reduce               32                   (28) ::= (13) (14) (27) ;         <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       7      12   <                                 Token type: LeftArrow                                                   
Reduce               18                   (29) ::=     science              <text-chunk> ::= Text                                                   
Reduce               17                   (30) ::= (29)                     <text> ::= <text-chunk>                                                 
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       7      13   o8lvOnlB                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       7      21   >                                 Token type: RightArrow                                                  
Reduce               18                   (31) ::= o8lvOnlB                 <text-chunk> ::= Text                                                   
Reduce               20                   (32) ::= (31)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       7      23   -                                 Token type: Hyphen                                                      
Reduce               26                   (33) ::= < (32) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               37                   (34) ::= (30) (33)                <item> ::= <text> <tag>                                                 
Shift                23                                                     The parser shifted to state 23                                          
Token Read           23       7      24   >                                 Token type: RightArrow                                                  
Shift                30                                                     The parser shifted to state 30                                          
Token Read           30       9       0           math                      Token type: Text                                                        
Reduce               24                   (35) ::= - >                      <producer> ::= Hyphen RightArrow                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       9      13   <                                 Token type: LeftArrow                                                   
Reduce               18                   (36) ::=         math             <text-chunk> ::= Text                                                   
Reduce               17                   (37) ::= (36)                     <text> ::= <text-chunk>                                                 
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       9      14   SbQjE2YS                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       9      22   >                                 Token type: RightArrow                                                  
Reduce               18                   (38) ::= SbQjE2YS                 <text-chunk> ::= Text                                                   
Reduce               20                   (39) ::= (38)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       9      23   ,                                 Token type: Separator                                                   
Reduce               26                   (40) ::= < (39) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (41) ::= (37) (40)                <item> ::= <text> <tag>                                                 
Shift                39                                                     The parser shifted to state 39                                          
Token Read           39      10       0           informathics              Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11      10      21   <                                 Token type: LeftArrow                                                   
Reduce               18                   (42) ::=         informathics     <text-chunk> ::= Text                                                   
Reduce               17                   (43) ::= (42)                     <text> ::= <text-chunk>                                                 
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10      10      22   CVOSiiAS                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11      10      30   >                                 Token type: RightArrow                                                  
Reduce               18                   (44) ::= CVOSiiAS                 <text-chunk> ::= Text                                                   
Reduce               20                   (45) ::= (44)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29      10      31   ,                                 Token type: Separator                                                   
Reduce               26                   (46) ::= < (45) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (47) ::= (43) (46)                <item> ::= <text> <tag>                                                 
Shift                39                                                     The parser shifted to state 39                                          
Token Read           39      11       0           medicine                  Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11      11      17   <                                 Token type: LeftArrow                                                   
Reduce               18                   (48) ::=         medicine         <text-chunk> ::= Text                                                   
Reduce               17                   (49) ::= (48)                     <text> ::= <text-chunk>                                                 
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10      11      18   1G0hZLJ4                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11      11      26   >                                 Token type: RightArrow                                                  
Reduce               18                   (50) ::= 1G0hZLJ4                 <text-chunk> ::= Text                                                   
Reduce               20                   (51) ::= (50)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29      11      27   ;                                 Token type: Terminator                                                  
Reduce               26                   (52) ::= < (51) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (53) ::= (49) (52)                <item> ::= <text> <tag>                                                 
Reduce               44                   (54) ::= (47) , (53)              <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               35                   (55) ::= (41) , (54)              <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                41                                                     The parser shifted to state 41                                          
Token Read           41      13       0       water                         Token type: Text                                                        
Reduce               36                   (56) ::= (34) (35) (55) ;         <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11      13      10   <                                 Token type: LeftArrow                                                   
Reduce               18                   (57) ::=     water                <text-chunk> ::= Text                                                   
Reduce               17                   (58) ::= (57)                     <text> ::= <text-chunk>                                                 
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10      13      11   ozhHnNOU                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11      13      19   >                                 Token type: RightArrow                                                  
Reduce               18                   (59) ::= ozhHnNOU                 <text-chunk> ::= Text                                                   
Reduce               20                   (60) ::= (59)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29      13      20   ,                                 Token type: Separator                                                   
Reduce               26                   (61) ::= < (60) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               37                   (62) ::= (58) (61)                <item> ::= <text> <tag>                                                 
Shift                39                                                     The parser shifted to state 39                                          
Token Read           39      14       0       salt                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11      14       9   <                                 Token type: LeftArrow                                                   
Reduce               18                   (63) ::=     salt                 <text-chunk> ::= Text                                                   
Reduce               17                   (64) ::= (63)                     <text> ::= <text-chunk>                                                 
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10      14      10   jMBLOKGE                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11      14      18   >                                 Token type: RightArrow                                                  
Reduce               18                   (65) ::= jMBLOKGE                 <text-chunk> ::= Text                                                   
Reduce               20                   (66) ::= (65)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29      14      19   ;                                 Token type: Terminator                                                  
Reduce               26                   (67) ::= < (66) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (68) ::= (64) (67)                <item> ::= <text> <tag>                                                 
Reduce               38                   (69) ::= (62) , (68)              <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               38                   (70) ::= (56) (69)                <item-or-expression-list> ::= <expression> <item-or-expression-list>    
Reduce               35                   (71) ::= (28) (70)                <item-or-expression-list> ::= <expression> <item-or-expression-list>    
Shift                41                                                     The parser shifted to state 41                                          
Token Read           41      15       0                                     Token type: EOF                                                         
Reduce               12                   (72) ::= (6) (7) (71) ;           <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               15                   (73) ::= (72)                     <scripture> ::= <expression>                                            
Accept               15                                                                                                                             



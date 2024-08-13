========================================
Source Code (between the arrows)
========================================

🡆macronutrients <ryQ27h6e> ->

	water <hAdLCBLZ>,
    salt <GotVxcPm>,
    fiber <CHcd0L0E> ->

        what <jiSw0LNV>,
        not <TpR3PZdW>;
	
	science <qlMb3HAO> ->
			
		informathics <jn0zFcnW>,
		medicine <JZmdtZj5>,
		
		math <bYBIKVXn> ->
			algebra <nFxP8YKb>,
			geometry <hDNMVYP0>;🡄

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
|  |  |  |  |  |  +--ryQ27h6e
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
|  |  |  |  |  |  |  +--hAdLCBLZ
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
|  |  |  |  |  |  |  |  +--GotVxcPm
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
|  |  |  |  |  |  |  |  |  |  +--CHcd0L0E
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
|  |  |  |  |  |  |  |  |  |  |  +--jiSw0LNV
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
|  |  |  |  |  |  |  |  |  |  |  +--TpR3PZdW
|  |  |  |  |  |  |  |  |  +-->
|  |  |  |  |  |  +--;
|  |  |  |  |  +--<expression> ::= <item> <producer> <item-or-expression-list>
|  |  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--    science 
|  |  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--qlMb3HAO
|  |  |  |  |  |  |  |  +-->
|  |  |  |  |  |  +--<producer> ::= Hyphen RightArrow
|  |  |  |  |  |  |  +---
|  |  |  |  |  |  |  +-->
|  |  |  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--        informathics 
|  |  |  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  +--jn0zFcnW
|  |  |  |  |  |  |  |  |  +-->
|  |  |  |  |  |  |  +--,
|  |  |  |  |  |  |  +--<item-or-expression-list> ::= <item> Separator <expression>
|  |  |  |  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  +--        medicine 
|  |  |  |  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  +--JZmdtZj5
|  |  |  |  |  |  |  |  |  |  +-->
|  |  |  |  |  |  |  |  +--,
|  |  |  |  |  |  |  |  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  |  |  |  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  +--        math 
|  |  |  |  |  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  +--bYBIKVXn
|  |  |  |  |  |  |  |  |  |  |  +-->
|  |  |  |  |  |  |  |  |  +--<producer> ::= Hyphen RightArrow
|  |  |  |  |  |  |  |  |  |  +---
|  |  |  |  |  |  |  |  |  |  +-->
|  |  |  |  |  |  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  |  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  +--            algebra 
|  |  |  |  |  |  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--nFxP8YKb
|  |  |  |  |  |  |  |  |  |  |  |  +-->
|  |  |  |  |  |  |  |  |  |  +--,
|  |  |  |  |  |  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  +--            geometry 
|  |  |  |  |  |  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  |  +--hDNMVYP0
|  |  |  |  |  |  |  |  |  |  |  |  +-->
|  |  |  |  |  |  |  |  |  +--;


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
Token Read           10       0      16   ryQ27h6e                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       0      24   >                                 Token type: RightArrow                                                  
Reduce               18                   (3) ::= ryQ27h6e                  <text-chunk> ::= Text                                                   
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
Token Read           10       2      11   hAdLCBLZ                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       2      19   >                                 Token type: RightArrow                                                  
Reduce               18                   (10) ::= hAdLCBLZ                 <text-chunk> ::= Text                                                   
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
Token Read           10       3      10   GotVxcPm                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       3      18   >                                 Token type: RightArrow                                                  
Reduce               18                   (16) ::= GotVxcPm                 <text-chunk> ::= Text                                                   
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
Token Read           10       4      11   CHcd0L0E                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       4      19   >                                 Token type: RightArrow                                                  
Reduce               18                   (22) ::= CHcd0L0E                 <text-chunk> ::= Text                                                   
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
Token Read           10       6      14   jiSw0LNV                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       6      22   >                                 Token type: RightArrow                                                  
Reduce               18                   (29) ::= jiSw0LNV                 <text-chunk> ::= Text                                                   
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
Token Read           10       7      13   TpR3PZdW                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       7      21   >                                 Token type: RightArrow                                                  
Reduce               18                   (35) ::= TpR3PZdW                 <text-chunk> ::= Text                                                   
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
Token Read           10       9      13   qlMb3HAO                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       9      21   >                                 Token type: RightArrow                                                  
Reduce               18                   (43) ::= qlMb3HAO                 <text-chunk> ::= Text                                                   
Reduce               20                   (44) ::= (43)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       9      23   -                                 Token type: Hyphen                                                      
Reduce               26                   (45) ::= < (44) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               37                   (46) ::= (42) (45)                <item> ::= <text> <tag>                                                 
Shift                23                                                     The parser shifted to state 23                                          
Token Read           23       9      24   >                                 Token type: RightArrow                                                  
Shift                30                                                     The parser shifted to state 30                                          
Token Read           30      11       0           informathics              Token type: Text                                                        
Reduce               24                   (47) ::= - >                      <producer> ::= Hyphen RightArrow                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11      11      21   <                                 Token type: LeftArrow                                                   
Reduce               18                   (48) ::=         informathics     <text-chunk> ::= Text                                                   
Reduce               17                   (49) ::= (48)                     <text> ::= <text-chunk>                                                 
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10      11      22   jn0zFcnW                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11      11      30   >                                 Token type: RightArrow                                                  
Reduce               18                   (50) ::= jn0zFcnW                 <text-chunk> ::= Text                                                   
Reduce               20                   (51) ::= (50)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29      11      31   ,                                 Token type: Separator                                                   
Reduce               26                   (52) ::= < (51) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (53) ::= (49) (52)                <item> ::= <text> <tag>                                                 
Shift                39                                                     The parser shifted to state 39                                          
Token Read           39      12       0           medicine                  Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11      12      17   <                                 Token type: LeftArrow                                                   
Reduce               18                   (54) ::=         medicine         <text-chunk> ::= Text                                                   
Reduce               17                   (55) ::= (54)                     <text> ::= <text-chunk>                                                 
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10      12      18   JZmdtZj5                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11      12      26   >                                 Token type: RightArrow                                                  
Reduce               18                   (56) ::= JZmdtZj5                 <text-chunk> ::= Text                                                   
Reduce               20                   (57) ::= (56)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29      12      27   ,                                 Token type: Separator                                                   
Reduce               26                   (58) ::= < (57) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (59) ::= (55) (58)                <item> ::= <text> <tag>                                                 
Shift                39                                                     The parser shifted to state 39                                          
Token Read           39      14       0           math                      Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11      14      13   <                                 Token type: LeftArrow                                                   
Reduce               18                   (60) ::=         math             <text-chunk> ::= Text                                                   
Reduce               17                   (61) ::= (60)                     <text> ::= <text-chunk>                                                 
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10      14      14   bYBIKVXn                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11      14      22   >                                 Token type: RightArrow                                                  
Reduce               18                   (62) ::= bYBIKVXn                 <text-chunk> ::= Text                                                   
Reduce               20                   (63) ::= (62)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29      14      24   -                                 Token type: Hyphen                                                      
Reduce               26                   (64) ::= < (63) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (65) ::= (61) (64)                <item> ::= <text> <tag>                                                 
Shift                23                                                     The parser shifted to state 23                                          
Token Read           23      14      25   >                                 Token type: RightArrow                                                  
Shift                30                                                     The parser shifted to state 30                                          
Token Read           30      15       0               algebra               Token type: Text                                                        
Reduce               24                   (66) ::= - >                      <producer> ::= Hyphen RightArrow                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11      15      20   <                                 Token type: LeftArrow                                                   
Reduce               18                   (67) ::=             algebra      <text-chunk> ::= Text                                                   
Reduce               17                   (68) ::= (67)                     <text> ::= <text-chunk>                                                 
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10      15      21   nFxP8YKb                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11      15      29   >                                 Token type: RightArrow                                                  
Reduce               18                   (69) ::= nFxP8YKb                 <text-chunk> ::= Text                                                   
Reduce               20                   (70) ::= (69)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29      15      30   ,                                 Token type: Separator                                                   
Reduce               26                   (71) ::= < (70) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (72) ::= (68) (71)                <item> ::= <text> <tag>                                                 
Shift                39                                                     The parser shifted to state 39                                          
Token Read           39      16       0               geometry              Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11      16      21   <                                 Token type: LeftArrow                                                   
Reduce               18                   (73) ::=             geometry     <text-chunk> ::= Text                                                   
Reduce               17                   (74) ::= (73)                     <text> ::= <text-chunk>                                                 
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10      16      22   hDNMVYP0                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11      16      30   >                                 Token type: RightArrow                                                  
Reduce               18                   (75) ::= hDNMVYP0                 <text-chunk> ::= Text                                                   
Reduce               20                   (76) ::= (75)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29      16      31   ;                                 Token type: Terminator                                                  
Reduce               26                   (77) ::= < (76) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (78) ::= (74) (77)                <item> ::= <text> <tag>                                                 
Reduce               35                   (79) ::= (72) , (78)              <item-or-expression-list> ::= <item> Separator <item>                   
Shift                41                                                     The parser shifted to state 41                                          
Token Read           41      17       0                                     Token type: EOF                                                         
Reduce               42                   (80) ::= (65) (66) (79) ;         <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               44                   (81) ::= (59) , (80)              <item-or-expression-list> ::= <item> Separator <expression>             
Reduce               35                   (82) ::= (53) , (81)              <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               36                   (83) ::= (46) (47) (82)           <expression> ::= <item> <producer> <item-or-expression-list>            
Reduce               44                   (84) ::= (40) (83)                <item-or-expression-list> ::= <expression> <expression>                 
Reduce               44                   (85) ::= (19) , (84)              <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               35                   (86) ::= (13) , (85)              <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               12                   (87) ::= (6) (7) (86)             <expression> ::= <item> <producer> <item-or-expression-list>            
Reduce               15                   (88) ::= (87)                     <scripture> ::= <expression>                                            
Accept               15                                                                                                                             



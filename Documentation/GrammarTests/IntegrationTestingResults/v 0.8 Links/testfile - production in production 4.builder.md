========================================
Source Code (between the arrows)
========================================

🡆macronutrients <xkQxOfc9> ->

    fiber <CbALGP8d> ->

        what <7KNUmetK>,
        not [http://testlink.com/] <6qFQ0HxK>;
	
	science <o8lvOnlB> ->
		
		math <SbQjE2YS>,
		informathics <CVOSiiAS>,
		medicine [http://testlink.com/] <1G0hZLJ4>;
    
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
|  |  |  |  |  +--<item> ::= <text> Link <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--        not 
|  |  |  |  |  |  +--[http://testlink.com/]
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
|  |  |  |  |  |  |  +--<item> ::= <text> Link <tag>
|  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--        medicine 
|  |  |  |  |  |  |  |  +--[http://testlink.com/]
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

Parse Action      State    Line     Col   Parse Value                                  Description                                                             
---------------   -----   -----   -----   ------------------------------------------   ------------------------------------------------------------------------
Token Read            0       0       0   macronutrients                               Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       0      15   <                                            Token type: LeftArrow                                                   
Reduce               18                   (1) ::= macronutrients                       <text-chunk> ::= Text                                                   
Reduce               17                   (2) ::= (1)                                  <text> ::= <text-chunk>                                                 
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24       0      16   xkQxOfc9                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       0      24   >                                            Token type: RightArrow                                                  
Reduce               18                   (3) ::= xkQxOfc9                             <text-chunk> ::= Text                                                   
Reduce               36                   (4) ::= (3)                                  <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49       0      26   -                                            Token type: Hyphen                                                      
Reduce               27                   (5) ::= < (4) >                              <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               15                   (6) ::= (2) (5)                              <item> ::= <text> <tag>                                                 
Shift                22                                                                The parser shifted to state 22                                          
Token Read           22       0      27   >                                            Token type: RightArrow                                                  
Shift                30                                                                The parser shifted to state 30                                          
Token Read           30       2       0       fiber                                    Token type: Text                                                        
Reduce               23                   (7) ::= - >                                  <producer> ::= Hyphen RightArrow                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       2      10   <                                            Token type: LeftArrow                                                   
Reduce               18                   (8) ::=     fiber                            <text-chunk> ::= Text                                                   
Reduce               17                   (9) ::= (8)                                  <text> ::= <text-chunk>                                                 
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24       2      11   CbALGP8d                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       2      19   >                                            Token type: RightArrow                                                  
Reduce               18                   (10) ::= CbALGP8d                            <text-chunk> ::= Text                                                   
Reduce               36                   (11) ::= (10)                                <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49       2      21   -                                            Token type: Hyphen                                                      
Reduce               27                   (12) ::= < (11) >                            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (13) ::= (9) (12)                            <item> ::= <text> <tag>                                                 
Shift                22                                                                The parser shifted to state 22                                          
Token Read           22       2      22   >                                            Token type: RightArrow                                                  
Shift                30                                                                The parser shifted to state 30                                          
Token Read           30       4       0           what                                 Token type: Text                                                        
Reduce               23                   (14) ::= - >                                 <producer> ::= Hyphen RightArrow                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       4      13   <                                            Token type: LeftArrow                                                   
Reduce               18                   (15) ::=         what                        <text-chunk> ::= Text                                                   
Reduce               17                   (16) ::= (15)                                <text> ::= <text-chunk>                                                 
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24       4      14   7KNUmetK                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       4      22   >                                            Token type: RightArrow                                                  
Reduce               18                   (17) ::= 7KNUmetK                            <text-chunk> ::= Text                                                   
Reduce               36                   (18) ::= (17)                                <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49       4      23   ,                                            Token type: Separator                                                   
Reduce               27                   (19) ::= < (18) >                            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (20) ::= (16) (19)                           <item> ::= <text> <tag>                                                 
Shift                46                                                                The parser shifted to state 46                                          
Token Read           46       5       0           not                                  Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       5      12   [http://testlink.com/]                       Token type: Link                                                        
Reduce               18                   (21) ::=         not                         <text-chunk> ::= Text                                                   
Reduce               17                   (22) ::= (21)                                <text> ::= <text-chunk>                                                 
Shift                25                                                                The parser shifted to state 25                                          
Token Read           25       5      35   <                                            Token type: LeftArrow                                                   
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24       5      36   6qFQ0HxK                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       5      44   >                                            Token type: RightArrow                                                  
Reduce               18                   (23) ::= 6qFQ0HxK                            <text-chunk> ::= Text                                                   
Reduce               36                   (24) ::= (23)                                <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49       5      45   ;                                            Token type: Terminator                                                  
Reduce               39                   (25) ::= < (24) >                            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               51                   (26) ::= (22) [http://testlink.com/] (25)    <item> ::= <text> Link <tag>                                            
Reduce               35                   (27) ::= (20) , (26)                         <item-or-expression-list> ::= <item> Separator <item>                   
Shift                48                                                                The parser shifted to state 48                                          
Token Read           48       7       0       science                                  Token type: Text                                                        
Reduce               32                   (28) ::= (13) (14) (27) ;                    <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       7      12   <                                            Token type: LeftArrow                                                   
Reduce               18                   (29) ::=     science                         <text-chunk> ::= Text                                                   
Reduce               17                   (30) ::= (29)                                <text> ::= <text-chunk>                                                 
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24       7      13   o8lvOnlB                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       7      21   >                                            Token type: RightArrow                                                  
Reduce               18                   (31) ::= o8lvOnlB                            <text-chunk> ::= Text                                                   
Reduce               36                   (32) ::= (31)                                <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49       7      23   -                                            Token type: Hyphen                                                      
Reduce               27                   (33) ::= < (32) >                            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               44                   (34) ::= (30) (33)                           <item> ::= <text> <tag>                                                 
Shift                22                                                                The parser shifted to state 22                                          
Token Read           22       7      24   >                                            Token type: RightArrow                                                  
Shift                30                                                                The parser shifted to state 30                                          
Token Read           30       9       0           math                                 Token type: Text                                                        
Reduce               23                   (35) ::= - >                                 <producer> ::= Hyphen RightArrow                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       9      13   <                                            Token type: LeftArrow                                                   
Reduce               18                   (36) ::=         math                        <text-chunk> ::= Text                                                   
Reduce               17                   (37) ::= (36)                                <text> ::= <text-chunk>                                                 
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24       9      14   SbQjE2YS                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       9      22   >                                            Token type: RightArrow                                                  
Reduce               18                   (38) ::= SbQjE2YS                            <text-chunk> ::= Text                                                   
Reduce               36                   (39) ::= (38)                                <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49       9      23   ,                                            Token type: Separator                                                   
Reduce               27                   (40) ::= < (39) >                            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (41) ::= (37) (40)                           <item> ::= <text> <tag>                                                 
Shift                46                                                                The parser shifted to state 46                                          
Token Read           46      10       0           informathics                         Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12      10      21   <                                            Token type: LeftArrow                                                   
Reduce               18                   (42) ::=         informathics                <text-chunk> ::= Text                                                   
Reduce               17                   (43) ::= (42)                                <text> ::= <text-chunk>                                                 
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24      10      22   CVOSiiAS                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12      10      30   >                                            Token type: RightArrow                                                  
Reduce               18                   (44) ::= CVOSiiAS                            <text-chunk> ::= Text                                                   
Reduce               36                   (45) ::= (44)                                <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49      10      31   ,                                            Token type: Separator                                                   
Reduce               27                   (46) ::= < (45) >                            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               51                   (47) ::= (43) (46)                           <item> ::= <text> <tag>                                                 
Shift                46                                                                The parser shifted to state 46                                          
Token Read           46      11       0           medicine                             Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12      11      17   [http://testlink.com/]                       Token type: Link                                                        
Reduce               18                   (48) ::=         medicine                    <text-chunk> ::= Text                                                   
Reduce               17                   (49) ::= (48)                                <text> ::= <text-chunk>                                                 
Shift                25                                                                The parser shifted to state 25                                          
Token Read           25      11      40   <                                            Token type: LeftArrow                                                   
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24      11      41   1G0hZLJ4                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12      11      49   >                                            Token type: RightArrow                                                  
Reduce               18                   (50) ::= 1G0hZLJ4                            <text-chunk> ::= Text                                                   
Reduce               36                   (51) ::= (50)                                <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49      11      50   ;                                            Token type: Terminator                                                  
Reduce               39                   (52) ::= < (51) >                            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               51                   (53) ::= (49) [http://testlink.com/] (52)    <item> ::= <text> Link <tag>                                            
Reduce               52                   (54) ::= (47) , (53)                         <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               35                   (55) ::= (41) , (54)                         <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                48                                                                The parser shifted to state 48                                          
Token Read           48      13       0       water                                    Token type: Text                                                        
Reduce               43                   (56) ::= (34) (35) (55) ;                    <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12      13      10   <                                            Token type: LeftArrow                                                   
Reduce               18                   (57) ::=     water                           <text-chunk> ::= Text                                                   
Reduce               17                   (58) ::= (57)                                <text> ::= <text-chunk>                                                 
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24      13      11   ozhHnNOU                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12      13      19   >                                            Token type: RightArrow                                                  
Reduce               18                   (59) ::= ozhHnNOU                            <text-chunk> ::= Text                                                   
Reduce               36                   (60) ::= (59)                                <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49      13      20   ,                                            Token type: Separator                                                   
Reduce               27                   (61) ::= < (60) >                            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               44                   (62) ::= (58) (61)                           <item> ::= <text> <tag>                                                 
Shift                46                                                                The parser shifted to state 46                                          
Token Read           46      14       0       salt                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12      14       9   <                                            Token type: LeftArrow                                                   
Reduce               18                   (63) ::=     salt                            <text-chunk> ::= Text                                                   
Reduce               17                   (64) ::= (63)                                <text> ::= <text-chunk>                                                 
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24      14      10   jMBLOKGE                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12      14      18   >                                            Token type: RightArrow                                                  
Reduce               18                   (65) ::= jMBLOKGE                            <text-chunk> ::= Text                                                   
Reduce               36                   (66) ::= (65)                                <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49      14      19   ;                                            Token type: Terminator                                                  
Reduce               27                   (67) ::= < (66) >                            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               51                   (68) ::= (64) (67)                           <item> ::= <text> <tag>                                                 
Reduce               45                   (69) ::= (62) , (68)                         <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               45                   (70) ::= (56) (69)                           <item-or-expression-list> ::= <expression> <item-or-expression-list>    
Reduce               35                   (71) ::= (28) (70)                           <item-or-expression-list> ::= <expression> <item-or-expression-list>    
Shift                48                                                                The parser shifted to state 48                                          
Token Read           48      15       0                                                Token type: EOF                                                         
Reduce               13                   (72) ::= (6) (7) (71) ;                      <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               16                   (73) ::= (72)                                <scripture> ::= <expression>                                            
Accept               16                                                                                                                                        



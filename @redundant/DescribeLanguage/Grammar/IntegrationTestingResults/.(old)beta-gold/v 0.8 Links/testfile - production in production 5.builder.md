========================================
Source Code (between the arrows)
========================================

🡆macronutrients [http://testlink.com/]<SxOf3elF> ->

	water <8S3IwDlG>,
    salt <RV4OUQoy>,
    fiber <G3tWgyDr> ->

        what <AwPl7oBK>,
        not <OcIUTGif>;
	
	science [http://testlink.com/]<k543P1uB> ->
		
		math <IZZ9vPiK>,
		informathics <OMH9y9Jn>,
		medicine <UuA1ITf9>;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression-list>
|  |  +--<item> ::= <text> Link <tag>
|  |  |  +--<text> ::= <text-chunk>
|  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  +--macronutrients 
|  |  |  +--[http://testlink.com/]
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
|  |  |  |  |  |  +--<item> ::= <text> Link <tag>
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--    science 
|  |  |  |  |  |  |  +--[http://testlink.com/]
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

Parse Action      State    Line     Col   Parse Value                                  Description                                                             
---------------   -----   -----   -----   ------------------------------------------   ------------------------------------------------------------------------
Token Read            0       0       0   macronutrients                               Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       0      15   [http://testlink.com/]                       Token type: Link                                                        
Reduce               18                   (1) ::= macronutrients                       <text-chunk> ::= Text                                                   
Reduce               17                   (2) ::= (1)                                  <text> ::= <text-chunk>                                                 
Shift                25                                                                The parser shifted to state 25                                          
Token Read           25       0      37   <                                            Token type: LeftArrow                                                   
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24       0      38   SxOf3elF                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       0      46   >                                            Token type: RightArrow                                                  
Reduce               18                   (3) ::= SxOf3elF                             <text-chunk> ::= Text                                                   
Reduce               36                   (4) ::= (3)                                  <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49       0      48   -                                            Token type: Hyphen                                                      
Reduce               39                   (5) ::= < (4) >                              <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               15                   (6) ::= (2) [http://testlink.com/] (5)       <item> ::= <text> Link <tag>                                            
Shift                22                                                                The parser shifted to state 22                                          
Token Read           22       0      49   >                                            Token type: RightArrow                                                  
Shift                30                                                                The parser shifted to state 30                                          
Token Read           30       2       0       water                                    Token type: Text                                                        
Reduce               23                   (7) ::= - >                                  <producer> ::= Hyphen RightArrow                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       2      10   <                                            Token type: LeftArrow                                                   
Reduce               18                   (8) ::=     water                            <text-chunk> ::= Text                                                   
Reduce               17                   (9) ::= (8)                                  <text> ::= <text-chunk>                                                 
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24       2      11   8S3IwDlG                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       2      19   >                                            Token type: RightArrow                                                  
Reduce               18                   (10) ::= 8S3IwDlG                            <text-chunk> ::= Text                                                   
Reduce               36                   (11) ::= (10)                                <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49       2      20   ,                                            Token type: Separator                                                   
Reduce               27                   (12) ::= < (11) >                            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (13) ::= (9) (12)                            <item> ::= <text> <tag>                                                 
Shift                46                                                                The parser shifted to state 46                                          
Token Read           46       3       0       salt                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       3       9   <                                            Token type: LeftArrow                                                   
Reduce               18                   (14) ::=     salt                            <text-chunk> ::= Text                                                   
Reduce               17                   (15) ::= (14)                                <text> ::= <text-chunk>                                                 
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24       3      10   RV4OUQoy                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       3      18   >                                            Token type: RightArrow                                                  
Reduce               18                   (16) ::= RV4OUQoy                            <text-chunk> ::= Text                                                   
Reduce               36                   (17) ::= (16)                                <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49       3      19   ,                                            Token type: Separator                                                   
Reduce               27                   (18) ::= < (17) >                            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               51                   (19) ::= (15) (18)                           <item> ::= <text> <tag>                                                 
Shift                46                                                                The parser shifted to state 46                                          
Token Read           46       4       0       fiber                                    Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       4      10   <                                            Token type: LeftArrow                                                   
Reduce               18                   (20) ::=     fiber                           <text-chunk> ::= Text                                                   
Reduce               17                   (21) ::= (20)                                <text> ::= <text-chunk>                                                 
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24       4      11   G3tWgyDr                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       4      19   >                                            Token type: RightArrow                                                  
Reduce               18                   (22) ::= G3tWgyDr                            <text-chunk> ::= Text                                                   
Reduce               36                   (23) ::= (22)                                <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49       4      21   -                                            Token type: Hyphen                                                      
Reduce               27                   (24) ::= < (23) >                            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               51                   (25) ::= (21) (24)                           <item> ::= <text> <tag>                                                 
Shift                22                                                                The parser shifted to state 22                                          
Token Read           22       4      22   >                                            Token type: RightArrow                                                  
Shift                30                                                                The parser shifted to state 30                                          
Token Read           30       6       0           what                                 Token type: Text                                                        
Reduce               23                   (26) ::= - >                                 <producer> ::= Hyphen RightArrow                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       6      13   <                                            Token type: LeftArrow                                                   
Reduce               18                   (27) ::=         what                        <text-chunk> ::= Text                                                   
Reduce               17                   (28) ::= (27)                                <text> ::= <text-chunk>                                                 
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24       6      14   AwPl7oBK                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       6      22   >                                            Token type: RightArrow                                                  
Reduce               18                   (29) ::= AwPl7oBK                            <text-chunk> ::= Text                                                   
Reduce               36                   (30) ::= (29)                                <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49       6      23   ,                                            Token type: Separator                                                   
Reduce               27                   (31) ::= < (30) >                            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (32) ::= (28) (31)                           <item> ::= <text> <tag>                                                 
Shift                46                                                                The parser shifted to state 46                                          
Token Read           46       7       0           not                                  Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       7      12   <                                            Token type: LeftArrow                                                   
Reduce               18                   (33) ::=         not                         <text-chunk> ::= Text                                                   
Reduce               17                   (34) ::= (33)                                <text> ::= <text-chunk>                                                 
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24       7      13   OcIUTGif                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       7      21   >                                            Token type: RightArrow                                                  
Reduce               18                   (35) ::= OcIUTGif                            <text-chunk> ::= Text                                                   
Reduce               36                   (36) ::= (35)                                <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49       7      22   ;                                            Token type: Terminator                                                  
Reduce               27                   (37) ::= < (36) >                            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               51                   (38) ::= (34) (37)                           <item> ::= <text> <tag>                                                 
Reduce               35                   (39) ::= (32) , (38)                         <item-or-expression-list> ::= <item> Separator <item>                   
Shift                48                                                                The parser shifted to state 48                                          
Token Read           48       9       0       science                                  Token type: Text                                                        
Reduce               50                   (40) ::= (25) (26) (39) ;                    <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       9      12   [http://testlink.com/]                       Token type: Link                                                        
Reduce               18                   (41) ::=     science                         <text-chunk> ::= Text                                                   
Reduce               17                   (42) ::= (41)                                <text> ::= <text-chunk>                                                 
Shift                25                                                                The parser shifted to state 25                                          
Token Read           25       9      34   <                                            Token type: LeftArrow                                                   
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24       9      35   k543P1uB                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       9      43   >                                            Token type: RightArrow                                                  
Reduce               18                   (43) ::= k543P1uB                            <text-chunk> ::= Text                                                   
Reduce               36                   (44) ::= (43)                                <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49       9      45   -                                            Token type: Hyphen                                                      
Reduce               39                   (45) ::= < (44) >                            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               44                   (46) ::= (42) [http://testlink.com/] (45)    <item> ::= <text> Link <tag>                                            
Shift                22                                                                The parser shifted to state 22                                          
Token Read           22       9      46   >                                            Token type: RightArrow                                                  
Shift                30                                                                The parser shifted to state 30                                          
Token Read           30      11       0           math                                 Token type: Text                                                        
Reduce               23                   (47) ::= - >                                 <producer> ::= Hyphen RightArrow                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12      11      13   <                                            Token type: LeftArrow                                                   
Reduce               18                   (48) ::=         math                        <text-chunk> ::= Text                                                   
Reduce               17                   (49) ::= (48)                                <text> ::= <text-chunk>                                                 
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24      11      14   IZZ9vPiK                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12      11      22   >                                            Token type: RightArrow                                                  
Reduce               18                   (50) ::= IZZ9vPiK                            <text-chunk> ::= Text                                                   
Reduce               36                   (51) ::= (50)                                <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49      11      23   ,                                            Token type: Separator                                                   
Reduce               27                   (52) ::= < (51) >                            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (53) ::= (49) (52)                           <item> ::= <text> <tag>                                                 
Shift                46                                                                The parser shifted to state 46                                          
Token Read           46      12       0           informathics                         Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12      12      21   <                                            Token type: LeftArrow                                                   
Reduce               18                   (54) ::=         informathics                <text-chunk> ::= Text                                                   
Reduce               17                   (55) ::= (54)                                <text> ::= <text-chunk>                                                 
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24      12      22   OMH9y9Jn                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12      12      30   >                                            Token type: RightArrow                                                  
Reduce               18                   (56) ::= OMH9y9Jn                            <text-chunk> ::= Text                                                   
Reduce               36                   (57) ::= (56)                                <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49      12      31   ,                                            Token type: Separator                                                   
Reduce               27                   (58) ::= < (57) >                            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               51                   (59) ::= (55) (58)                           <item> ::= <text> <tag>                                                 
Shift                46                                                                The parser shifted to state 46                                          
Token Read           46      13       0           medicine                             Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12      13      17   <                                            Token type: LeftArrow                                                   
Reduce               18                   (60) ::=         medicine                    <text-chunk> ::= Text                                                   
Reduce               17                   (61) ::= (60)                                <text> ::= <text-chunk>                                                 
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24      13      18   UuA1ITf9                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12      13      26   >                                            Token type: RightArrow                                                  
Reduce               18                   (62) ::= UuA1ITf9                            <text-chunk> ::= Text                                                   
Reduce               36                   (63) ::= (62)                                <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49      13      27   ;                                            Token type: Terminator                                                  
Reduce               27                   (64) ::= < (63) >                            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               51                   (65) ::= (61) (64)                           <item> ::= <text> <tag>                                                 
Reduce               52                   (66) ::= (59) , (65)                         <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               35                   (67) ::= (53) , (66)                         <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                48                                                                The parser shifted to state 48                                          
Token Read           48      14       0                                                Token type: EOF                                                         
Reduce               43                   (68) ::= (46) (47) (67) ;                    <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               52                   (69) ::= (40) (68)                           <item-or-expression-list> ::= <expression> <expression>                 
Reduce               52                   (70) ::= (19) , (69)                         <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               35                   (71) ::= (13) , (70)                         <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               13                   (72) ::= (6) (7) (71)                        <expression> ::= <item> <producer> <item-or-expression-list>            
Reduce               16                   (73) ::= (72)                                <scripture> ::= <expression>                                            
Accept               16                                                                                                                                        



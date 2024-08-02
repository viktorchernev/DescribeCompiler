========================================
Source Code (between the arrows)
========================================

🡆macronutrients <oVs6tsnU> ->

    water <9Y9uFDwu>,
	fiber <PALnQoTQ>[http://testlink.com/] ->

        what [http://testlink.com/]<6hlYVfaz>,
        not [http://testlink.com/]<gubSBEDe>;

	somth else [http://testlink.com/]<hAyLdw3m>;🡄

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
|  |  |  |  |  |  +--oVs6tsnU
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
|  |  |  |  |  |  |  +--9Y9uFDwu
|  |  |  |  |  +-->
|  |  |  +--,
|  |  |  +--<item-or-expression-list> ::= <expression> <item>
|  |  |  |  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  |  |  |  +--<item> ::= <text> <tag> Link
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    fiber 
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--PALnQoTQ
|  |  |  |  |  |  |  +-->
|  |  |  |  |  |  +--[http://testlink.com/]
|  |  |  |  |  +--<producer> ::= Hyphen RightArrow
|  |  |  |  |  |  +---
|  |  |  |  |  |  +-->
|  |  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  |  +--<item> ::= <text> Link <tag>
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--        what 
|  |  |  |  |  |  |  +--[http://testlink.com/]
|  |  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--6hlYVfaz
|  |  |  |  |  |  |  |  +-->
|  |  |  |  |  |  +--,
|  |  |  |  |  |  +--<item> ::= <text> Link <tag>
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--        not 
|  |  |  |  |  |  |  +--[http://testlink.com/]
|  |  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--gubSBEDe
|  |  |  |  |  |  |  |  +-->
|  |  |  |  |  +--;
|  |  |  |  +--<item> ::= <text> Link <tag>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    somth else 
|  |  |  |  |  +--[http://testlink.com/]
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--hAyLdw3m
|  |  |  |  |  |  +-->
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
Token Read           24       0      16   oVs6tsnU                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       0      24   >                                            Token type: RightArrow                                                  
Reduce               18                   (3) ::= oVs6tsnU                             <text-chunk> ::= Text                                                   
Reduce               36                   (4) ::= (3)                                  <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49       0      26   -                                            Token type: Hyphen                                                      
Reduce               27                   (5) ::= < (4) >                              <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               15                   (6) ::= (2) (5)                              <item> ::= <text> <tag>                                                 
Shift                22                                                                The parser shifted to state 22                                          
Token Read           22       0      27   >                                            Token type: RightArrow                                                  
Shift                30                                                                The parser shifted to state 30                                          
Token Read           30       2       0       water                                    Token type: Text                                                        
Reduce               23                   (7) ::= - >                                  <producer> ::= Hyphen RightArrow                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       2      10   <                                            Token type: LeftArrow                                                   
Reduce               18                   (8) ::=     water                            <text-chunk> ::= Text                                                   
Reduce               17                   (9) ::= (8)                                  <text> ::= <text-chunk>                                                 
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24       2      11   9Y9uFDwu                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       2      19   >                                            Token type: RightArrow                                                  
Reduce               18                   (10) ::= 9Y9uFDwu                            <text-chunk> ::= Text                                                   
Reduce               36                   (11) ::= (10)                                <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49       2      20   ,                                            Token type: Separator                                                   
Reduce               27                   (12) ::= < (11) >                            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (13) ::= (9) (12)                            <item> ::= <text> <tag>                                                 
Shift                46                                                                The parser shifted to state 46                                          
Token Read           46       3       0       fiber                                    Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       3      10   <                                            Token type: LeftArrow                                                   
Reduce               18                   (14) ::=     fiber                           <text-chunk> ::= Text                                                   
Reduce               17                   (15) ::= (14)                                <text> ::= <text-chunk>                                                 
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24       3      11   PALnQoTQ                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       3      19   >                                            Token type: RightArrow                                                  
Reduce               18                   (16) ::= PALnQoTQ                            <text-chunk> ::= Text                                                   
Reduce               36                   (17) ::= (16)                                <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49       3      20   [http://testlink.com/]                       Token type: Link                                                        
Reduce               27                   (18) ::= < (17) >                            <tag> ::= LeftArrow <text> RightArrow                                   
Shift                41                                                                The parser shifted to state 41                                          
Token Read           41       3      43   -                                            Token type: Hyphen                                                      
Reduce               51                   (19) ::= (15) (18) [http://testlink.com/]    <item> ::= <text> <tag> Link                                            
Shift                22                                                                The parser shifted to state 22                                          
Token Read           22       3      44   >                                            Token type: RightArrow                                                  
Shift                30                                                                The parser shifted to state 30                                          
Token Read           30       5       0           what                                 Token type: Text                                                        
Reduce               23                   (20) ::= - >                                 <producer> ::= Hyphen RightArrow                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       5      13   [http://testlink.com/]                       Token type: Link                                                        
Reduce               18                   (21) ::=         what                        <text-chunk> ::= Text                                                   
Reduce               17                   (22) ::= (21)                                <text> ::= <text-chunk>                                                 
Shift                25                                                                The parser shifted to state 25                                          
Token Read           25       5      35   <                                            Token type: LeftArrow                                                   
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24       5      36   6hlYVfaz                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       5      44   >                                            Token type: RightArrow                                                  
Reduce               18                   (23) ::= 6hlYVfaz                            <text-chunk> ::= Text                                                   
Reduce               36                   (24) ::= (23)                                <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49       5      45   ,                                            Token type: Separator                                                   
Reduce               39                   (25) ::= < (24) >                            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (26) ::= (22) [http://testlink.com/] (25)    <item> ::= <text> Link <tag>                                            
Shift                46                                                                The parser shifted to state 46                                          
Token Read           46       6       0           not                                  Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       6      12   [http://testlink.com/]                       Token type: Link                                                        
Reduce               18                   (27) ::=         not                         <text-chunk> ::= Text                                                   
Reduce               17                   (28) ::= (27)                                <text> ::= <text-chunk>                                                 
Shift                25                                                                The parser shifted to state 25                                          
Token Read           25       6      34   <                                            Token type: LeftArrow                                                   
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24       6      35   gubSBEDe                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       6      43   >                                            Token type: RightArrow                                                  
Reduce               18                   (29) ::= gubSBEDe                            <text-chunk> ::= Text                                                   
Reduce               36                   (30) ::= (29)                                <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49       6      44   ;                                            Token type: Terminator                                                  
Reduce               39                   (31) ::= < (30) >                            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               51                   (32) ::= (28) [http://testlink.com/] (31)    <item> ::= <text> Link <tag>                                            
Reduce               35                   (33) ::= (26) , (32)                         <item-or-expression-list> ::= <item> Separator <item>                   
Shift                48                                                                The parser shifted to state 48                                          
Token Read           48       8       0       somth else                               Token type: Text                                                        
Reduce               50                   (34) ::= (19) (20) (33) ;                    <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       8      15   [http://testlink.com/]                       Token type: Link                                                        
Reduce               18                   (35) ::=     somth else                      <text-chunk> ::= Text                                                   
Reduce               17                   (36) ::= (35)                                <text> ::= <text-chunk>                                                 
Shift                25                                                                The parser shifted to state 25                                          
Token Read           25       8      37   <                                            Token type: LeftArrow                                                   
Shift                24                                                                The parser shifted to state 24                                          
Token Read           24       8      38   hAyLdw3m                                     Token type: Text                                                        
Shift                12                                                                The parser shifted to state 12                                          
Token Read           12       8      46   >                                            Token type: RightArrow                                                  
Reduce               18                   (37) ::= hAyLdw3m                            <text-chunk> ::= Text                                                   
Reduce               36                   (38) ::= (37)                                <text> ::= <text-chunk>                                                 
Shift                49                                                                The parser shifted to state 49                                          
Token Read           49       8      47   ;                                            Token type: Terminator                                                  
Reduce               39                   (39) ::= < (38) >                            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               44                   (40) ::= (36) [http://testlink.com/] (39)    <item> ::= <text> Link <tag>                                            
Reduce               52                   (41) ::= (34) (40)                           <item-or-expression-list> ::= <expression> <item>                       
Reduce               35                   (42) ::= (13) , (41)                         <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                48                                                                The parser shifted to state 48                                          
Token Read           48       9       0                                                Token type: EOF                                                         
Reduce               13                   (43) ::= (6) (7) (42) ;                      <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               16                   (44) ::= (43)                                <scripture> ::= <expression>                                            
Accept               16                                                                                                                                        



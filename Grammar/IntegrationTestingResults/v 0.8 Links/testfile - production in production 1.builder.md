========================================
Source Code (between the arrows)
========================================

🡆macronutrients <0CmyN2Mb> ->

    fiber <CMxWzMs5> ->

        what [http://testlink.com/]<hzAzwlx6>,
        not <UHOcZPAm>;
    
    water <BBmOZjJa>;🡄

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
|  |  |  |  |  |  +--0CmyN2Mb
|  |  |  |  +-->
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <expression> <item>
|  |  |  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    fiber 
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--CMxWzMs5
|  |  |  |  |  |  +-->
|  |  |  |  +--<producer> ::= Hyphen RightArrow
|  |  |  |  |  +---
|  |  |  |  |  +-->
|  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  +--<item> ::= <text> Link <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--        what 
|  |  |  |  |  |  +--[http://testlink.com/]
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--hzAzwlx6
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
|  |  |  |  |  |  |  |  |  +--UHOcZPAm
|  |  |  |  |  |  |  +-->
|  |  |  |  +--;
|  |  |  +--<item> ::= <text> <tag>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--    water 
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--BBmOZjJa
|  |  |  |  |  +-->
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                                  Description                                                            
---------------   -----   -----   -----   ------------------------------------------   -----------------------------------------------------------------------
Token Read            0       0       0   macronutrients                               Token type: Text                                                       
Shift                12                                                                The parser shifted to state 12                                         
Token Read           12       0      15   <                                            Token type: LeftArrow                                                  
Reduce               18                   (1) ::= macronutrients                       <text-chunk> ::= Text                                                  
Reduce               17                   (2) ::= (1)                                  <text> ::= <text-chunk>                                                
Shift                24                                                                The parser shifted to state 24                                         
Token Read           24       0      16   0CmyN2Mb                                     Token type: Text                                                       
Shift                12                                                                The parser shifted to state 12                                         
Token Read           12       0      24   >                                            Token type: RightArrow                                                 
Reduce               18                   (3) ::= 0CmyN2Mb                             <text-chunk> ::= Text                                                  
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
Token Read           24       2      11   CMxWzMs5                                     Token type: Text                                                       
Shift                12                                                                The parser shifted to state 12                                         
Token Read           12       2      19   >                                            Token type: RightArrow                                                 
Reduce               18                   (10) ::= CMxWzMs5                            <text-chunk> ::= Text                                                  
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
Token Read           12       4      13   [http://testlink.com/]                       Token type: Link                                                       
Reduce               18                   (15) ::=         what                        <text-chunk> ::= Text                                                  
Reduce               17                   (16) ::= (15)                                <text> ::= <text-chunk>                                                
Shift                25                                                                The parser shifted to state 25                                         
Token Read           25       4      35   <                                            Token type: LeftArrow                                                  
Shift                24                                                                The parser shifted to state 24                                         
Token Read           24       4      36   hzAzwlx6                                     Token type: Text                                                       
Shift                12                                                                The parser shifted to state 12                                         
Token Read           12       4      44   >                                            Token type: RightArrow                                                 
Reduce               18                   (17) ::= hzAzwlx6                            <text-chunk> ::= Text                                                  
Reduce               36                   (18) ::= (17)                                <text> ::= <text-chunk>                                                
Shift                49                                                                The parser shifted to state 49                                         
Token Read           49       4      45   ,                                            Token type: Separator                                                  
Reduce               39                   (19) ::= < (18) >                            <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               33                   (20) ::= (16) [http://testlink.com/] (19)    <item> ::= <text> Link <tag>                                           
Shift                46                                                                The parser shifted to state 46                                         
Token Read           46       5       0           not                                  Token type: Text                                                       
Shift                12                                                                The parser shifted to state 12                                         
Token Read           12       5      12   <                                            Token type: LeftArrow                                                  
Reduce               18                   (21) ::=         not                         <text-chunk> ::= Text                                                  
Reduce               17                   (22) ::= (21)                                <text> ::= <text-chunk>                                                
Shift                24                                                                The parser shifted to state 24                                         
Token Read           24       5      13   UHOcZPAm                                     Token type: Text                                                       
Shift                12                                                                The parser shifted to state 12                                         
Token Read           12       5      21   >                                            Token type: RightArrow                                                 
Reduce               18                   (23) ::= UHOcZPAm                            <text-chunk> ::= Text                                                  
Reduce               36                   (24) ::= (23)                                <text> ::= <text-chunk>                                                
Shift                49                                                                The parser shifted to state 49                                         
Token Read           49       5      22   ;                                            Token type: Terminator                                                 
Reduce               27                   (25) ::= < (24) >                            <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               51                   (26) ::= (22) (25)                           <item> ::= <text> <tag>                                                
Reduce               35                   (27) ::= (20) , (26)                         <item-or-expression-list> ::= <item> Separator <item>                  
Shift                48                                                                The parser shifted to state 48                                         
Token Read           48       7       0       water                                    Token type: Text                                                       
Reduce               32                   (28) ::= (13) (14) (27) ;                    <expression> ::= <item> <producer> <item-or-expression-list> Terminator
Shift                12                                                                The parser shifted to state 12                                         
Token Read           12       7      10   <                                            Token type: LeftArrow                                                  
Reduce               18                   (29) ::=     water                           <text-chunk> ::= Text                                                  
Reduce               17                   (30) ::= (29)                                <text> ::= <text-chunk>                                                
Shift                24                                                                The parser shifted to state 24                                         
Token Read           24       7      11   BBmOZjJa                                     Token type: Text                                                       
Shift                12                                                                The parser shifted to state 12                                         
Token Read           12       7      19   >                                            Token type: RightArrow                                                 
Reduce               18                   (31) ::= BBmOZjJa                            <text-chunk> ::= Text                                                  
Reduce               36                   (32) ::= (31)                                <text> ::= <text-chunk>                                                
Shift                49                                                                The parser shifted to state 49                                         
Token Read           49       7      20   ;                                            Token type: Terminator                                                 
Reduce               27                   (33) ::= < (32) >                            <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               44                   (34) ::= (30) (33)                           <item> ::= <text> <tag>                                                
Reduce               35                   (35) ::= (28) (34)                           <item-or-expression-list> ::= <expression> <item>                      
Shift                48                                                                The parser shifted to state 48                                         
Token Read           48       8       0                                                Token type: EOF                                                        
Reduce               13                   (36) ::= (6) (7) (35) ;                      <expression> ::= <item> <producer> <item-or-expression-list> Terminator
Reduce               16                   (37) ::= (36)                                <scripture> ::= <expression>                                           
Accept               16                                                                                                                                       



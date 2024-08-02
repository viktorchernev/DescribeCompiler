========================================
Source Code (between the arrows)
========================================

🡆macronutrients [http://testlink.com/]<eQxYylc3> ->

    water <tdgS8qBO>,
	fiber <OpdFntBx> ->

        what [http://testlink.com/]<MLUxjdg8>,
        not <qkVgxZIs>;🡄

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
|  |  |  |  |  |  +--eQxYylc3
|  |  |  |  +-->
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <item> Separator <expression>
|  |  |  +--<item> ::= <text> <tag>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--    water 
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--tdgS8qBO
|  |  |  |  |  +-->
|  |  |  +--,
|  |  |  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    fiber 
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--OpdFntBx
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
|  |  |  |  |  |  |  |  |  +--MLUxjdg8
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
|  |  |  |  |  |  |  |  |  +--qkVgxZIs
|  |  |  |  |  |  |  +-->
|  |  |  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                                  Description                                                            
---------------   -----   -----   -----   ------------------------------------------   -----------------------------------------------------------------------
Token Read            0       0       0   macronutrients                               Token type: Text                                                       
Shift                12                                                                The parser shifted to state 12                                         
Token Read           12       0      15   [http://testlink.com/]                       Token type: Link                                                       
Reduce               18                   (1) ::= macronutrients                       <text-chunk> ::= Text                                                  
Reduce               17                   (2) ::= (1)                                  <text> ::= <text-chunk>                                                
Shift                25                                                                The parser shifted to state 25                                         
Token Read           25       0      37   <                                            Token type: LeftArrow                                                  
Shift                24                                                                The parser shifted to state 24                                         
Token Read           24       0      38   eQxYylc3                                     Token type: Text                                                       
Shift                12                                                                The parser shifted to state 12                                         
Token Read           12       0      46   >                                            Token type: RightArrow                                                 
Reduce               18                   (3) ::= eQxYylc3                             <text-chunk> ::= Text                                                  
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
Token Read           24       2      11   tdgS8qBO                                     Token type: Text                                                       
Shift                12                                                                The parser shifted to state 12                                         
Token Read           12       2      19   >                                            Token type: RightArrow                                                 
Reduce               18                   (10) ::= tdgS8qBO                            <text-chunk> ::= Text                                                  
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
Token Read           24       3      11   OpdFntBx                                     Token type: Text                                                       
Shift                12                                                                The parser shifted to state 12                                         
Token Read           12       3      19   >                                            Token type: RightArrow                                                 
Reduce               18                   (16) ::= OpdFntBx                            <text-chunk> ::= Text                                                  
Reduce               36                   (17) ::= (16)                                <text> ::= <text-chunk>                                                
Shift                49                                                                The parser shifted to state 49                                         
Token Read           49       3      21   -                                            Token type: Hyphen                                                     
Reduce               27                   (18) ::= < (17) >                            <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               51                   (19) ::= (15) (18)                           <item> ::= <text> <tag>                                                
Shift                22                                                                The parser shifted to state 22                                         
Token Read           22       3      22   >                                            Token type: RightArrow                                                 
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
Token Read           24       5      36   MLUxjdg8                                     Token type: Text                                                       
Shift                12                                                                The parser shifted to state 12                                         
Token Read           12       5      44   >                                            Token type: RightArrow                                                 
Reduce               18                   (23) ::= MLUxjdg8                            <text-chunk> ::= Text                                                  
Reduce               36                   (24) ::= (23)                                <text> ::= <text-chunk>                                                
Shift                49                                                                The parser shifted to state 49                                         
Token Read           49       5      45   ,                                            Token type: Separator                                                  
Reduce               39                   (25) ::= < (24) >                            <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               33                   (26) ::= (22) [http://testlink.com/] (25)    <item> ::= <text> Link <tag>                                           
Shift                46                                                                The parser shifted to state 46                                         
Token Read           46       6       0           not                                  Token type: Text                                                       
Shift                12                                                                The parser shifted to state 12                                         
Token Read           12       6      12   <                                            Token type: LeftArrow                                                  
Reduce               18                   (27) ::=         not                         <text-chunk> ::= Text                                                  
Reduce               17                   (28) ::= (27)                                <text> ::= <text-chunk>                                                
Shift                24                                                                The parser shifted to state 24                                         
Token Read           24       6      13   qkVgxZIs                                     Token type: Text                                                       
Shift                12                                                                The parser shifted to state 12                                         
Token Read           12       6      21   >                                            Token type: RightArrow                                                 
Reduce               18                   (29) ::= qkVgxZIs                            <text-chunk> ::= Text                                                  
Reduce               36                   (30) ::= (29)                                <text> ::= <text-chunk>                                                
Shift                49                                                                The parser shifted to state 49                                         
Token Read           49       6      22   ;                                            Token type: Terminator                                                 
Reduce               27                   (31) ::= < (30) >                            <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               51                   (32) ::= (28) (31)                           <item> ::= <text> <tag>                                                
Reduce               35                   (33) ::= (26) , (32)                         <item-or-expression-list> ::= <item> Separator <item>                  
Shift                48                                                                The parser shifted to state 48                                         
Token Read           48       7       0                                                Token type: EOF                                                        
Reduce               50                   (34) ::= (19) (20) (33) ;                    <expression> ::= <item> <producer> <item-or-expression-list> Terminator
Reduce               35                   (35) ::= (13) , (34)                         <item-or-expression-list> ::= <item> Separator <expression>            
Reduce               13                   (36) ::= (6) (7) (35)                        <expression> ::= <item> <producer> <item-or-expression-list>           
Reduce               16                   (37) ::= (36)                                <scripture> ::= <expression>                                           
Accept               16                                                                                                                                       



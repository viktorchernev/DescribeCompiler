========================================
Source Code (between the arrows)
========================================

🡆macronutrients <eQxYylc3> ->

    water <tdgS8qBO>,
	fiber <OpdFntBx> ->

        what <MLUxjdg8>,
        not <qkVgxZIs>;🡄

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
|  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--        what 
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

Parse Action      State    Line     Col   Parse Value                  Description                                                            
---------------   -----   -----   -----   --------------------------   -----------------------------------------------------------------------
Token Read            0       0       0   macronutrients               Token type: Text                                                       
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       0      15   <                            Token type: LeftArrow                                                  
Reduce               18                   (1) ::= macronutrients       <text-chunk> ::= Text                                                  
Reduce               17                   (2) ::= (1)                  <text> ::= <text-chunk>                                                
Shift                10                                                The parser shifted to state 10                                         
Token Read           10       0      16   eQxYylc3                     Token type: Text                                                       
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       0      24   >                            Token type: RightArrow                                                 
Reduce               18                   (3) ::= eQxYylc3             <text-chunk> ::= Text                                                  
Reduce               20                   (4) ::= (3)                  <text> ::= <text-chunk>                                                
Shift                29                                                The parser shifted to state 29                                         
Token Read           29       0      26   -                            Token type: Hyphen                                                     
Reduce               26                   (5) ::= < (4) >              <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               14                   (6) ::= (2) (5)              <item> ::= <text> <tag>                                                
Shift                23                                                The parser shifted to state 23                                         
Token Read           23       0      27   >                            Token type: RightArrow                                                 
Shift                30                                                The parser shifted to state 30                                         
Token Read           30       2       0       water                    Token type: Text                                                       
Reduce               24                   (7) ::= - >                  <producer> ::= Hyphen RightArrow                                       
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       2      10   <                            Token type: LeftArrow                                                  
Reduce               18                   (8) ::=     water            <text-chunk> ::= Text                                                  
Reduce               17                   (9) ::= (8)                  <text> ::= <text-chunk>                                                
Shift                10                                                The parser shifted to state 10                                         
Token Read           10       2      11   tdgS8qBO                     Token type: Text                                                       
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       2      19   >                            Token type: RightArrow                                                 
Reduce               18                   (10) ::= tdgS8qBO            <text-chunk> ::= Text                                                  
Reduce               20                   (11) ::= (10)                <text> ::= <text-chunk>                                                
Shift                29                                                The parser shifted to state 29                                         
Token Read           29       2      20   ,                            Token type: Separator                                                  
Reduce               26                   (12) ::= < (11) >            <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               33                   (13) ::= (9) (12)            <item> ::= <text> <tag>                                                
Shift                39                                                The parser shifted to state 39                                         
Token Read           39       3       0       fiber                    Token type: Text                                                       
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       3      10   <                            Token type: LeftArrow                                                  
Reduce               18                   (14) ::=     fiber           <text-chunk> ::= Text                                                  
Reduce               17                   (15) ::= (14)                <text> ::= <text-chunk>                                                
Shift                10                                                The parser shifted to state 10                                         
Token Read           10       3      11   OpdFntBx                     Token type: Text                                                       
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       3      19   >                            Token type: RightArrow                                                 
Reduce               18                   (16) ::= OpdFntBx            <text-chunk> ::= Text                                                  
Reduce               20                   (17) ::= (16)                <text> ::= <text-chunk>                                                
Shift                29                                                The parser shifted to state 29                                         
Token Read           29       3      21   -                            Token type: Hyphen                                                     
Reduce               26                   (18) ::= < (17) >            <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               43                   (19) ::= (15) (18)           <item> ::= <text> <tag>                                                
Shift                23                                                The parser shifted to state 23                                         
Token Read           23       3      22   >                            Token type: RightArrow                                                 
Shift                30                                                The parser shifted to state 30                                         
Token Read           30       5       0           what                 Token type: Text                                                       
Reduce               24                   (20) ::= - >                 <producer> ::= Hyphen RightArrow                                       
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       5      13   <                            Token type: LeftArrow                                                  
Reduce               18                   (21) ::=         what        <text-chunk> ::= Text                                                  
Reduce               17                   (22) ::= (21)                <text> ::= <text-chunk>                                                
Shift                10                                                The parser shifted to state 10                                         
Token Read           10       5      14   MLUxjdg8                     Token type: Text                                                       
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       5      22   >                            Token type: RightArrow                                                 
Reduce               18                   (23) ::= MLUxjdg8            <text-chunk> ::= Text                                                  
Reduce               20                   (24) ::= (23)                <text> ::= <text-chunk>                                                
Shift                29                                                The parser shifted to state 29                                         
Token Read           29       5      23   ,                            Token type: Separator                                                  
Reduce               26                   (25) ::= < (24) >            <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               33                   (26) ::= (22) (25)           <item> ::= <text> <tag>                                                
Shift                39                                                The parser shifted to state 39                                         
Token Read           39       6       0           not                  Token type: Text                                                       
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       6      12   <                            Token type: LeftArrow                                                  
Reduce               18                   (27) ::=         not         <text-chunk> ::= Text                                                  
Reduce               17                   (28) ::= (27)                <text> ::= <text-chunk>                                                
Shift                10                                                The parser shifted to state 10                                         
Token Read           10       6      13   qkVgxZIs                     Token type: Text                                                       
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       6      21   >                            Token type: RightArrow                                                 
Reduce               18                   (29) ::= qkVgxZIs            <text-chunk> ::= Text                                                  
Reduce               20                   (30) ::= (29)                <text> ::= <text-chunk>                                                
Shift                29                                                The parser shifted to state 29                                         
Token Read           29       6      22   ;                            Token type: Terminator                                                 
Reduce               26                   (31) ::= < (30) >            <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               43                   (32) ::= (28) (31)           <item> ::= <text> <tag>                                                
Reduce               35                   (33) ::= (26) , (32)         <item-or-expression-list> ::= <item> Separator <item>                  
Shift                41                                                The parser shifted to state 41                                         
Token Read           41       7       0                                Token type: EOF                                                        
Reduce               42                   (34) ::= (19) (20) (33) ;    <expression> ::= <item> <producer> <item-or-expression-list> Terminator
Reduce               35                   (35) ::= (13) , (34)         <item-or-expression-list> ::= <item> Separator <expression>            
Reduce               12                   (36) ::= (6) (7) (35)        <expression> ::= <item> <producer> <item-or-expression-list>           
Reduce               15                   (37) ::= (36)                <scripture> ::= <expression>                                           
Accept               15                                                                                                                       



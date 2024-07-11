========================================
Source Code (between the arrows)
========================================

🡆macronutrients <0CmyN2Mb> ->

    fiber <CMxWzMs5> ->

        what <hzAzwlx6>,
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
|  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--        what 
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

Parse Action      State    Line     Col   Parse Value                  Description                                                            
---------------   -----   -----   -----   --------------------------   -----------------------------------------------------------------------
Token Read            0       0       0   macronutrients               Token type: Text                                                       
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       0      15   <                            Token type: LeftArrow                                                  
Reduce               18                   (1) ::= macronutrients       <text-chunk> ::= Text                                                  
Reduce               17                   (2) ::= (1)                  <text> ::= <text-chunk>                                                
Shift                10                                                The parser shifted to state 10                                         
Token Read           10       0      16   0CmyN2Mb                     Token type: Text                                                       
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       0      24   >                            Token type: RightArrow                                                 
Reduce               18                   (3) ::= 0CmyN2Mb             <text-chunk> ::= Text                                                  
Reduce               20                   (4) ::= (3)                  <text> ::= <text-chunk>                                                
Shift                29                                                The parser shifted to state 29                                         
Token Read           29       0      26   -                            Token type: Hyphen                                                     
Reduce               26                   (5) ::= < (4) >              <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               14                   (6) ::= (2) (5)              <item> ::= <text> <tag>                                                
Shift                23                                                The parser shifted to state 23                                         
Token Read           23       0      27   >                            Token type: RightArrow                                                 
Shift                30                                                The parser shifted to state 30                                         
Token Read           30       2       0       fiber                    Token type: Text                                                       
Reduce               24                   (7) ::= - >                  <producer> ::= Hyphen RightArrow                                       
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       2      10   <                            Token type: LeftArrow                                                  
Reduce               18                   (8) ::=     fiber            <text-chunk> ::= Text                                                  
Reduce               17                   (9) ::= (8)                  <text> ::= <text-chunk>                                                
Shift                10                                                The parser shifted to state 10                                         
Token Read           10       2      11   CMxWzMs5                     Token type: Text                                                       
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       2      19   >                            Token type: RightArrow                                                 
Reduce               18                   (10) ::= CMxWzMs5            <text-chunk> ::= Text                                                  
Reduce               20                   (11) ::= (10)                <text> ::= <text-chunk>                                                
Shift                29                                                The parser shifted to state 29                                         
Token Read           29       2      21   -                            Token type: Hyphen                                                     
Reduce               26                   (12) ::= < (11) >            <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               33                   (13) ::= (9) (12)            <item> ::= <text> <tag>                                                
Shift                23                                                The parser shifted to state 23                                         
Token Read           23       2      22   >                            Token type: RightArrow                                                 
Shift                30                                                The parser shifted to state 30                                         
Token Read           30       4       0           what                 Token type: Text                                                       
Reduce               24                   (14) ::= - >                 <producer> ::= Hyphen RightArrow                                       
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       4      13   <                            Token type: LeftArrow                                                  
Reduce               18                   (15) ::=         what        <text-chunk> ::= Text                                                  
Reduce               17                   (16) ::= (15)                <text> ::= <text-chunk>                                                
Shift                10                                                The parser shifted to state 10                                         
Token Read           10       4      14   hzAzwlx6                     Token type: Text                                                       
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       4      22   >                            Token type: RightArrow                                                 
Reduce               18                   (17) ::= hzAzwlx6            <text-chunk> ::= Text                                                  
Reduce               20                   (18) ::= (17)                <text> ::= <text-chunk>                                                
Shift                29                                                The parser shifted to state 29                                         
Token Read           29       4      23   ,                            Token type: Separator                                                  
Reduce               26                   (19) ::= < (18) >            <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               33                   (20) ::= (16) (19)           <item> ::= <text> <tag>                                                
Shift                39                                                The parser shifted to state 39                                         
Token Read           39       5       0           not                  Token type: Text                                                       
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       5      12   <                            Token type: LeftArrow                                                  
Reduce               18                   (21) ::=         not         <text-chunk> ::= Text                                                  
Reduce               17                   (22) ::= (21)                <text> ::= <text-chunk>                                                
Shift                10                                                The parser shifted to state 10                                         
Token Read           10       5      13   UHOcZPAm                     Token type: Text                                                       
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       5      21   >                            Token type: RightArrow                                                 
Reduce               18                   (23) ::= UHOcZPAm            <text-chunk> ::= Text                                                  
Reduce               20                   (24) ::= (23)                <text> ::= <text-chunk>                                                
Shift                29                                                The parser shifted to state 29                                         
Token Read           29       5      22   ;                            Token type: Terminator                                                 
Reduce               26                   (25) ::= < (24) >            <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               43                   (26) ::= (22) (25)           <item> ::= <text> <tag>                                                
Reduce               35                   (27) ::= (20) , (26)         <item-or-expression-list> ::= <item> Separator <item>                  
Shift                41                                                The parser shifted to state 41                                         
Token Read           41       7       0       water                    Token type: Text                                                       
Reduce               32                   (28) ::= (13) (14) (27) ;    <expression> ::= <item> <producer> <item-or-expression-list> Terminator
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       7      10   <                            Token type: LeftArrow                                                  
Reduce               18                   (29) ::=     water           <text-chunk> ::= Text                                                  
Reduce               17                   (30) ::= (29)                <text> ::= <text-chunk>                                                
Shift                10                                                The parser shifted to state 10                                         
Token Read           10       7      11   BBmOZjJa                     Token type: Text                                                       
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       7      19   >                            Token type: RightArrow                                                 
Reduce               18                   (31) ::= BBmOZjJa            <text-chunk> ::= Text                                                  
Reduce               20                   (32) ::= (31)                <text> ::= <text-chunk>                                                
Shift                29                                                The parser shifted to state 29                                         
Token Read           29       7      20   ;                            Token type: Terminator                                                 
Reduce               26                   (33) ::= < (32) >            <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               37                   (34) ::= (30) (33)           <item> ::= <text> <tag>                                                
Reduce               35                   (35) ::= (28) (34)           <item-or-expression-list> ::= <expression> <item>                      
Shift                41                                                The parser shifted to state 41                                         
Token Read           41       8       0                                Token type: EOF                                                        
Reduce               12                   (36) ::= (6) (7) (35) ;      <expression> ::= <item> <producer> <item-or-expression-list> Terminator
Reduce               15                   (37) ::= (36)                <scripture> ::= <expression>                                           
Accept               15                                                                                                                       



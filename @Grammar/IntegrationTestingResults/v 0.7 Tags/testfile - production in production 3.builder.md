========================================
Source Code (between the arrows)
========================================

🡆macronutrients <oVs6tsnU> ->

    water <9Y9uFDwu>,
	fiber <PALnQoTQ> ->

        what <6hlYVfaz>,
        not <gubSBEDe>;

	somth else <hAyLdw3m>;🡄

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
|  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    fiber 
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--PALnQoTQ
|  |  |  |  |  |  |  +-->
|  |  |  |  |  +--<producer> ::= Hyphen RightArrow
|  |  |  |  |  |  +---
|  |  |  |  |  |  +-->
|  |  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--        what 
|  |  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--6hlYVfaz
|  |  |  |  |  |  |  |  +-->
|  |  |  |  |  |  +--,
|  |  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--        not 
|  |  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--gubSBEDe
|  |  |  |  |  |  |  |  +-->
|  |  |  |  |  +--;
|  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    somth else 
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

Parse Action      State    Line     Col   Parse Value                  Description                                                             
---------------   -----   -----   -----   --------------------------   ------------------------------------------------------------------------
Token Read            0       0       0   macronutrients               Token type: Text                                                        
Shift                11                                                The parser shifted to state 11                                          
Token Read           11       0      15   <                            Token type: LeftArrow                                                   
Reduce               18                   (1) ::= macronutrients       <text-chunk> ::= Text                                                   
Reduce               17                   (2) ::= (1)                  <text> ::= <text-chunk>                                                 
Shift                10                                                The parser shifted to state 10                                          
Token Read           10       0      16   oVs6tsnU                     Token type: Text                                                        
Shift                11                                                The parser shifted to state 11                                          
Token Read           11       0      24   >                            Token type: RightArrow                                                  
Reduce               18                   (3) ::= oVs6tsnU             <text-chunk> ::= Text                                                   
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
Token Read           10       2      11   9Y9uFDwu                     Token type: Text                                                        
Shift                11                                                The parser shifted to state 11                                          
Token Read           11       2      19   >                            Token type: RightArrow                                                  
Reduce               18                   (10) ::= 9Y9uFDwu            <text-chunk> ::= Text                                                   
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
Token Read           10       3      11   PALnQoTQ                     Token type: Text                                                        
Shift                11                                                The parser shifted to state 11                                          
Token Read           11       3      19   >                            Token type: RightArrow                                                  
Reduce               18                   (16) ::= PALnQoTQ            <text-chunk> ::= Text                                                   
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
Token Read           10       5      14   6hlYVfaz                     Token type: Text                                                        
Shift                11                                                The parser shifted to state 11                                          
Token Read           11       5      22   >                            Token type: RightArrow                                                  
Reduce               18                   (23) ::= 6hlYVfaz            <text-chunk> ::= Text                                                   
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
Token Read           10       6      13   gubSBEDe                     Token type: Text                                                        
Shift                11                                                The parser shifted to state 11                                          
Token Read           11       6      21   >                            Token type: RightArrow                                                  
Reduce               18                   (29) ::= gubSBEDe            <text-chunk> ::= Text                                                   
Reduce               20                   (30) ::= (29)                <text> ::= <text-chunk>                                                 
Shift                29                                                The parser shifted to state 29                                          
Token Read           29       6      22   ;                            Token type: Terminator                                                  
Reduce               26                   (31) ::= < (30) >            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (32) ::= (28) (31)           <item> ::= <text> <tag>                                                 
Reduce               35                   (33) ::= (26) , (32)         <item-or-expression-list> ::= <item> Separator <item>                   
Shift                41                                                The parser shifted to state 41                                          
Token Read           41       8       0       somth else               Token type: Text                                                        
Reduce               42                   (34) ::= (19) (20) (33) ;    <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Shift                11                                                The parser shifted to state 11                                          
Token Read           11       8      15   <                            Token type: LeftArrow                                                   
Reduce               18                   (35) ::=     somth else      <text-chunk> ::= Text                                                   
Reduce               17                   (36) ::= (35)                <text> ::= <text-chunk>                                                 
Shift                10                                                The parser shifted to state 10                                          
Token Read           10       8      16   hAyLdw3m                     Token type: Text                                                        
Shift                11                                                The parser shifted to state 11                                          
Token Read           11       8      24   >                            Token type: RightArrow                                                  
Reduce               18                   (37) ::= hAyLdw3m            <text-chunk> ::= Text                                                   
Reduce               20                   (38) ::= (37)                <text> ::= <text-chunk>                                                 
Shift                29                                                The parser shifted to state 29                                          
Token Read           29       8      25   ;                            Token type: Terminator                                                  
Reduce               26                   (39) ::= < (38) >            <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               37                   (40) ::= (36) (39)           <item> ::= <text> <tag>                                                 
Reduce               44                   (41) ::= (34) (40)           <item-or-expression-list> ::= <expression> <item>                       
Reduce               35                   (42) ::= (13) , (41)         <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                41                                                The parser shifted to state 41                                          
Token Read           41       9       0                                Token type: EOF                                                         
Reduce               12                   (43) ::= (6) (7) (42) ;      <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               15                   (44) ::= (43)                <scripture> ::= <expression>                                            
Accept               15                                                                                                                        



========================================
Source Code (between the arrows)
========================================

🡆macronutrients ->

    water,
	fiber ->

        what,
        not;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression-list>
|  |  +--<item> ::= <text>
|  |  |  +--<text> ::= <text-chunk>
|  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  +--macronutrients 
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <item> Separator <expression>
|  |  |  +--<item> ::= <text>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--    water
|  |  |  +--,
|  |  |  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  |  |  +--<item> ::= <text>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    fiber 
|  |  |  |  +--<producer> ::= Hyphen RightArrow
|  |  |  |  |  +---
|  |  |  |  |  +-->
|  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--        what
|  |  |  |  |  +--,
|  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--        not
|  |  |  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                  Description                                                            
---------------   -----   -----   -----   --------------------------   -----------------------------------------------------------------------
Token Read            0       0       0   macronutrients               Token type: Text                                                       
Shift                10                                                The parser shifted to state 10                                         
Token Read           10       0      15   -                            Token type: Hyphen                                                     
Reduce               16                   (1) ::= macronutrients       <text-chunk> ::= Text                                                  
Reduce               15                   (2) ::= (1)                  <text> ::= <text-chunk>                                                
Reduce               13                   (3) ::= (2)                  <item> ::= <text>                                                      
Shift                20                                                The parser shifted to state 20                                         
Token Read           20       0      16   >                            Token type: RightArrow                                                 
Shift                24                                                The parser shifted to state 24                                         
Token Read           24       2       0       water                    Token type: Text                                                       
Reduce               21                   (4) ::= - >                  <producer> ::= Hyphen RightArrow                                       
Shift                10                                                The parser shifted to state 10                                         
Token Read           10       2       9   ,                            Token type: Separator                                                  
Reduce               16                   (5) ::=     water            <text-chunk> ::= Text                                                  
Reduce               15                   (6) ::= (5)                  <text> ::= <text-chunk>                                                
Reduce               27                   (7) ::= (6)                  <item> ::= <text>                                                      
Shift                33                                                The parser shifted to state 33                                         
Token Read           33       3       0       fiber                    Token type: Text                                                       
Shift                10                                                The parser shifted to state 10                                         
Token Read           10       3      10   -                            Token type: Hyphen                                                     
Reduce               16                   (8) ::=     fiber            <text-chunk> ::= Text                                                  
Reduce               15                   (9) ::= (8)                  <text> ::= <text-chunk>                                                
Reduce               37                   (10) ::= (9)                 <item> ::= <text>                                                      
Shift                20                                                The parser shifted to state 20                                         
Token Read           20       3      11   >                            Token type: RightArrow                                                 
Shift                24                                                The parser shifted to state 24                                         
Token Read           24       5       0           what                 Token type: Text                                                       
Reduce               21                   (11) ::= - >                 <producer> ::= Hyphen RightArrow                                       
Shift                10                                                The parser shifted to state 10                                         
Token Read           10       5      12   ,                            Token type: Separator                                                  
Reduce               16                   (12) ::=         what        <text-chunk> ::= Text                                                  
Reduce               15                   (13) ::= (12)                <text> ::= <text-chunk>                                                
Reduce               27                   (14) ::= (13)                <item> ::= <text>                                                      
Shift                33                                                The parser shifted to state 33                                         
Token Read           33       6       0           not                  Token type: Text                                                       
Shift                10                                                The parser shifted to state 10                                         
Token Read           10       6      11   ;                            Token type: Terminator                                                 
Reduce               16                   (15) ::=         not         <text-chunk> ::= Text                                                  
Reduce               15                   (16) ::= (15)                <text> ::= <text-chunk>                                                
Reduce               37                   (17) ::= (16)                <item> ::= <text>                                                      
Reduce               29                   (18) ::= (14) , (17)         <item-or-expression-list> ::= <item> Separator <item>                  
Shift                35                                                The parser shifted to state 35                                         
Token Read           35       7       0                                Token type: EOF                                                        
Reduce               36                   (19) ::= (10) (11) (18) ;    <expression> ::= <item> <producer> <item-or-expression-list> Terminator
Reduce               29                   (20) ::= (7) , (19)          <item-or-expression-list> ::= <item> Separator <expression>            
Reduce               11                   (21) ::= (3) (4) (20)        <expression> ::= <item> <producer> <item-or-expression-list>           
Reduce               14                   (22) ::= (21)                <scripture> ::= <expression>                                           
Accept               14                                                                                                                       



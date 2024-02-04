========================================
Source Code (between the arrows)
========================================

🡆macronutrients ->

    fiber ->

        what,
        not;
	
	science ->
		
		math,
		informathics,
		medicine;
    
    water,
    salt;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  +--<item> ::= <text>
|  |  |  +--<text> ::= <text-chunk>
|  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  +--macronutrients 
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <expression> <item-or-expression-list>
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
|  |  |  +--<item-or-expression-list> ::= <expression> <item-or-expression-list>
|  |  |  |  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    science 
|  |  |  |  |  +--<producer> ::= Hyphen RightArrow
|  |  |  |  |  |  +---
|  |  |  |  |  |  +-->
|  |  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--        math
|  |  |  |  |  |  +--,
|  |  |  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--        informathics
|  |  |  |  |  |  |  +--,
|  |  |  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--        medicine
|  |  |  |  |  +--;
|  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    water
|  |  |  |  |  +--,
|  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    salt
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                      Description                                                             
---------------   -----   -----   -----   ------------------------------   ------------------------------------------------------------------------
Token Read            0       0       0   macronutrients                   Token type: Text                                                        
Shift                10                                                    The parser shifted to state 10                                          
Token Read           10       0      15   -                                Token type: Hyphen                                                      
Reduce               16                   (1) ::= macronutrients           <text-chunk> ::= Text                                                   
Reduce               15                   (2) ::= (1)                      <text> ::= <text-chunk>                                                 
Reduce               13                   (3) ::= (2)                      <item> ::= <text>                                                       
Shift                20                                                    The parser shifted to state 20                                          
Token Read           20       0      16   >                                Token type: RightArrow                                                  
Shift                24                                                    The parser shifted to state 24                                          
Token Read           24       2       0       fiber                        Token type: Text                                                        
Reduce               21                   (4) ::= - >                      <producer> ::= Hyphen RightArrow                                        
Shift                10                                                    The parser shifted to state 10                                          
Token Read           10       2      10   -                                Token type: Hyphen                                                      
Reduce               16                   (5) ::=     fiber                <text-chunk> ::= Text                                                   
Reduce               15                   (6) ::= (5)                      <text> ::= <text-chunk>                                                 
Reduce               27                   (7) ::= (6)                      <item> ::= <text>                                                       
Shift                20                                                    The parser shifted to state 20                                          
Token Read           20       2      11   >                                Token type: RightArrow                                                  
Shift                24                                                    The parser shifted to state 24                                          
Token Read           24       4       0           what                     Token type: Text                                                        
Reduce               21                   (8) ::= - >                      <producer> ::= Hyphen RightArrow                                        
Shift                10                                                    The parser shifted to state 10                                          
Token Read           10       4      12   ,                                Token type: Separator                                                   
Reduce               16                   (9) ::=         what             <text-chunk> ::= Text                                                   
Reduce               15                   (10) ::= (9)                     <text> ::= <text-chunk>                                                 
Reduce               27                   (11) ::= (10)                    <item> ::= <text>                                                       
Shift                33                                                    The parser shifted to state 33                                          
Token Read           33       5       0           not                      Token type: Text                                                        
Shift                10                                                    The parser shifted to state 10                                          
Token Read           10       5      11   ;                                Token type: Terminator                                                  
Reduce               16                   (12) ::=         not             <text-chunk> ::= Text                                                   
Reduce               15                   (13) ::= (12)                    <text> ::= <text-chunk>                                                 
Reduce               37                   (14) ::= (13)                    <item> ::= <text>                                                       
Reduce               29                   (15) ::= (11) , (14)             <item-or-expression-list> ::= <item> Separator <item>                   
Shift                35                                                    The parser shifted to state 35                                          
Token Read           35       7       0       science                      Token type: Text                                                        
Reduce               26                   (16) ::= (7) (8) (15) ;          <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Shift                10                                                    The parser shifted to state 10                                          
Token Read           10       7      12   -                                Token type: Hyphen                                                      
Reduce               16                   (17) ::=     science             <text-chunk> ::= Text                                                   
Reduce               15                   (18) ::= (17)                    <text> ::= <text-chunk>                                                 
Reduce               31                   (19) ::= (18)                    <item> ::= <text>                                                       
Shift                20                                                    The parser shifted to state 20                                          
Token Read           20       7      13   >                                Token type: RightArrow                                                  
Shift                24                                                    The parser shifted to state 24                                          
Token Read           24       9       0           math                     Token type: Text                                                        
Reduce               21                   (20) ::= - >                     <producer> ::= Hyphen RightArrow                                        
Shift                10                                                    The parser shifted to state 10                                          
Token Read           10       9      12   ,                                Token type: Separator                                                   
Reduce               16                   (21) ::=         math            <text-chunk> ::= Text                                                   
Reduce               15                   (22) ::= (21)                    <text> ::= <text-chunk>                                                 
Reduce               27                   (23) ::= (22)                    <item> ::= <text>                                                       
Shift                33                                                    The parser shifted to state 33                                          
Token Read           33      10       0           informathics             Token type: Text                                                        
Shift                10                                                    The parser shifted to state 10                                          
Token Read           10      10      20   ,                                Token type: Separator                                                   
Reduce               16                   (24) ::=         informathics    <text-chunk> ::= Text                                                   
Reduce               15                   (25) ::= (24)                    <text> ::= <text-chunk>                                                 
Reduce               37                   (26) ::= (25)                    <item> ::= <text>                                                       
Shift                33                                                    The parser shifted to state 33                                          
Token Read           33      11       0           medicine                 Token type: Text                                                        
Shift                10                                                    The parser shifted to state 10                                          
Token Read           10      11      16   ;                                Token type: Terminator                                                  
Reduce               16                   (27) ::=         medicine        <text-chunk> ::= Text                                                   
Reduce               15                   (28) ::= (27)                    <text> ::= <text-chunk>                                                 
Reduce               37                   (29) ::= (28)                    <item> ::= <text>                                                       
Reduce               38                   (30) ::= (26) , (29)             <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               29                   (31) ::= (23) , (30)             <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                35                                                    The parser shifted to state 35                                          
Token Read           35      13       0       water                        Token type: Text                                                        
Reduce               30                   (32) ::= (19) (20) (31) ;        <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Shift                10                                                    The parser shifted to state 10                                          
Token Read           10      13       9   ,                                Token type: Separator                                                   
Reduce               16                   (33) ::=     water               <text-chunk> ::= Text                                                   
Reduce               15                   (34) ::= (33)                    <text> ::= <text-chunk>                                                 
Reduce               31                   (35) ::= (34)                    <item> ::= <text>                                                       
Shift                33                                                    The parser shifted to state 33                                          
Token Read           33      14       0       salt                         Token type: Text                                                        
Shift                10                                                    The parser shifted to state 10                                          
Token Read           10      14       8   ;                                Token type: Terminator                                                  
Reduce               16                   (36) ::=     salt                <text-chunk> ::= Text                                                   
Reduce               15                   (37) ::= (36)                    <text> ::= <text-chunk>                                                 
Reduce               37                   (38) ::= (37)                    <item> ::= <text>                                                       
Reduce               32                   (39) ::= (35) , (38)             <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               32                   (40) ::= (32) (39)               <item-or-expression-list> ::= <expression> <item-or-expression-list>    
Reduce               29                   (41) ::= (16) (40)               <item-or-expression-list> ::= <expression> <item-or-expression-list>    
Shift                35                                                    The parser shifted to state 35                                          
Token Read           35      15       0                                    Token type: EOF                                                         
Reduce               11                   (42) ::= (3) (4) (41) ;          <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               14                   (43) ::= (42)                    <scripture> ::= <expression>                                            
Accept               14                                                                                                                            



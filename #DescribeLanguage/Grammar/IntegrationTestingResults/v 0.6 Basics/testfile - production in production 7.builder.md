========================================
Source Code (between the arrows)
========================================

🡆macronutrients ->

	water,
    salt,
    fiber ->

        what,
        not;
	
	science ->
			
		informathics,
		medicine,
		
		math ->
			algebra,
			geometry;🡄

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
|  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  +--<item> ::= <text>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--    water
|  |  |  +--,
|  |  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  |  +--<item> ::= <text>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    salt
|  |  |  |  +--,
|  |  |  |  +--<item-or-expression-list> ::= <expression> <expression>
|  |  |  |  |  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--    fiber 
|  |  |  |  |  |  +--<producer> ::= Hyphen RightArrow
|  |  |  |  |  |  |  +---
|  |  |  |  |  |  |  +-->
|  |  |  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--        what
|  |  |  |  |  |  |  +--,
|  |  |  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--        not
|  |  |  |  |  |  +--;
|  |  |  |  |  +--<expression> ::= <item> <producer> <item-or-expression-list>
|  |  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--    science 
|  |  |  |  |  |  +--<producer> ::= Hyphen RightArrow
|  |  |  |  |  |  |  +---
|  |  |  |  |  |  |  +-->
|  |  |  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--        informathics
|  |  |  |  |  |  |  +--,
|  |  |  |  |  |  |  +--<item-or-expression-list> ::= <item> Separator <expression>
|  |  |  |  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  +--        medicine
|  |  |  |  |  |  |  |  +--,
|  |  |  |  |  |  |  |  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  |  |  |  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  +--        math 
|  |  |  |  |  |  |  |  |  +--<producer> ::= Hyphen RightArrow
|  |  |  |  |  |  |  |  |  |  +---
|  |  |  |  |  |  |  |  |  |  +-->
|  |  |  |  |  |  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  |  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  +--            algebra
|  |  |  |  |  |  |  |  |  |  +--,
|  |  |  |  |  |  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  |  +--            geometry
|  |  |  |  |  |  |  |  |  +--;


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
Token Read           24       2       0       water                        Token type: Text                                                        
Reduce               21                   (4) ::= - >                      <producer> ::= Hyphen RightArrow                                        
Shift                10                                                    The parser shifted to state 10                                          
Token Read           10       2       9   ,                                Token type: Separator                                                   
Reduce               16                   (5) ::=     water                <text-chunk> ::= Text                                                   
Reduce               15                   (6) ::= (5)                      <text> ::= <text-chunk>                                                 
Reduce               27                   (7) ::= (6)                      <item> ::= <text>                                                       
Shift                33                                                    The parser shifted to state 33                                          
Token Read           33       3       0       salt                         Token type: Text                                                        
Shift                10                                                    The parser shifted to state 10                                          
Token Read           10       3       8   ,                                Token type: Separator                                                   
Reduce               16                   (8) ::=     salt                 <text-chunk> ::= Text                                                   
Reduce               15                   (9) ::= (8)                      <text> ::= <text-chunk>                                                 
Reduce               37                   (10) ::= (9)                     <item> ::= <text>                                                       
Shift                33                                                    The parser shifted to state 33                                          
Token Read           33       4       0       fiber                        Token type: Text                                                        
Shift                10                                                    The parser shifted to state 10                                          
Token Read           10       4      10   -                                Token type: Hyphen                                                      
Reduce               16                   (11) ::=     fiber               <text-chunk> ::= Text                                                   
Reduce               15                   (12) ::= (11)                    <text> ::= <text-chunk>                                                 
Reduce               37                   (13) ::= (12)                    <item> ::= <text>                                                       
Shift                20                                                    The parser shifted to state 20                                          
Token Read           20       4      11   >                                Token type: RightArrow                                                  
Shift                24                                                    The parser shifted to state 24                                          
Token Read           24       6       0           what                     Token type: Text                                                        
Reduce               21                   (14) ::= - >                     <producer> ::= Hyphen RightArrow                                        
Shift                10                                                    The parser shifted to state 10                                          
Token Read           10       6      12   ,                                Token type: Separator                                                   
Reduce               16                   (15) ::=         what            <text-chunk> ::= Text                                                   
Reduce               15                   (16) ::= (15)                    <text> ::= <text-chunk>                                                 
Reduce               27                   (17) ::= (16)                    <item> ::= <text>                                                       
Shift                33                                                    The parser shifted to state 33                                          
Token Read           33       7       0           not                      Token type: Text                                                        
Shift                10                                                    The parser shifted to state 10                                          
Token Read           10       7      11   ;                                Token type: Terminator                                                  
Reduce               16                   (18) ::=         not             <text-chunk> ::= Text                                                   
Reduce               15                   (19) ::= (18)                    <text> ::= <text-chunk>                                                 
Reduce               37                   (20) ::= (19)                    <item> ::= <text>                                                       
Reduce               29                   (21) ::= (17) , (20)             <item-or-expression-list> ::= <item> Separator <item>                   
Shift                35                                                    The parser shifted to state 35                                          
Token Read           35       9       0       science                      Token type: Text                                                        
Reduce               36                   (22) ::= (13) (14) (21) ;        <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Shift                10                                                    The parser shifted to state 10                                          
Token Read           10       9      12   -                                Token type: Hyphen                                                      
Reduce               16                   (23) ::=     science             <text-chunk> ::= Text                                                   
Reduce               15                   (24) ::= (23)                    <text> ::= <text-chunk>                                                 
Reduce               31                   (25) ::= (24)                    <item> ::= <text>                                                       
Shift                20                                                    The parser shifted to state 20                                          
Token Read           20       9      13   >                                Token type: RightArrow                                                  
Shift                24                                                    The parser shifted to state 24                                          
Token Read           24      11       0           informathics             Token type: Text                                                        
Reduce               21                   (26) ::= - >                     <producer> ::= Hyphen RightArrow                                        
Shift                10                                                    The parser shifted to state 10                                          
Token Read           10      11      20   ,                                Token type: Separator                                                   
Reduce               16                   (27) ::=         informathics    <text-chunk> ::= Text                                                   
Reduce               15                   (28) ::= (27)                    <text> ::= <text-chunk>                                                 
Reduce               27                   (29) ::= (28)                    <item> ::= <text>                                                       
Shift                33                                                    The parser shifted to state 33                                          
Token Read           33      12       0           medicine                 Token type: Text                                                        
Shift                10                                                    The parser shifted to state 10                                          
Token Read           10      12      16   ,                                Token type: Separator                                                   
Reduce               16                   (30) ::=         medicine        <text-chunk> ::= Text                                                   
Reduce               15                   (31) ::= (30)                    <text> ::= <text-chunk>                                                 
Reduce               37                   (32) ::= (31)                    <item> ::= <text>                                                       
Shift                33                                                    The parser shifted to state 33                                          
Token Read           33      14       0           math                     Token type: Text                                                        
Shift                10                                                    The parser shifted to state 10                                          
Token Read           10      14      13   -                                Token type: Hyphen                                                      
Reduce               16                   (33) ::=         math            <text-chunk> ::= Text                                                   
Reduce               15                   (34) ::= (33)                    <text> ::= <text-chunk>                                                 
Reduce               37                   (35) ::= (34)                    <item> ::= <text>                                                       
Shift                20                                                    The parser shifted to state 20                                          
Token Read           20      14      14   >                                Token type: RightArrow                                                  
Shift                24                                                    The parser shifted to state 24                                          
Token Read           24      15       0               algebra              Token type: Text                                                        
Reduce               21                   (36) ::= - >                     <producer> ::= Hyphen RightArrow                                        
Shift                10                                                    The parser shifted to state 10                                          
Token Read           10      15      19   ,                                Token type: Separator                                                   
Reduce               16                   (37) ::=             algebra     <text-chunk> ::= Text                                                   
Reduce               15                   (38) ::= (37)                    <text> ::= <text-chunk>                                                 
Reduce               27                   (39) ::= (38)                    <item> ::= <text>                                                       
Shift                33                                                    The parser shifted to state 33                                          
Token Read           33      16       0               geometry             Token type: Text                                                        
Shift                10                                                    The parser shifted to state 10                                          
Token Read           10      16      20   ;                                Token type: Terminator                                                  
Reduce               16                   (40) ::=             geometry    <text-chunk> ::= Text                                                   
Reduce               15                   (41) ::= (40)                    <text> ::= <text-chunk>                                                 
Reduce               37                   (42) ::= (41)                    <item> ::= <text>                                                       
Reduce               29                   (43) ::= (39) , (42)             <item-or-expression-list> ::= <item> Separator <item>                   
Shift                35                                                    The parser shifted to state 35                                          
Token Read           35      17       0                                    Token type: EOF                                                         
Reduce               36                   (44) ::= (35) (36) (43) ;        <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               38                   (45) ::= (32) , (44)             <item-or-expression-list> ::= <item> Separator <expression>             
Reduce               29                   (46) ::= (29) , (45)             <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               30                   (47) ::= (25) (26) (46)          <expression> ::= <item> <producer> <item-or-expression-list>            
Reduce               38                   (48) ::= (22) (47)               <item-or-expression-list> ::= <expression> <expression>                 
Reduce               38                   (49) ::= (10) , (48)             <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               29                   (50) ::= (7) , (49)              <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               11                   (51) ::= (3) (4) (50)            <expression> ::= <item> <producer> <item-or-expression-list>            
Reduce               14                   (52) ::= (51)                    <scripture> ::= <expression>                                            
Accept               14                                                                                                                            



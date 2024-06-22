========================================
Source Code (between the arrows)
========================================

🡆macronutrients ->

    fiber,
    water;

micronutrients ->

    vitamins (ABCDEK),
    minerals (micronutrients);🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression-list>
|  +--<expression-list> ::= <expression> <expression>
|  |  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  |  +--<item> ::= <text>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--macronutrients 
|  |  |  +--<producer> ::= Hyphen RightArrow
|  |  |  |  +---
|  |  |  |  +-->
|  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  +--<item> ::= <text>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    fiber
|  |  |  |  +--,
|  |  |  |  +--<item> ::= <text>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    water
|  |  |  +--;
|  |  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  |  +--<item> ::= <text>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--micronutrients 
|  |  |  +--<producer> ::= Hyphen RightArrow
|  |  |  |  +---
|  |  |  |  +-->
|  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  +--<item> ::= <text>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    vitamins (ABCDEK)
|  |  |  |  +--,
|  |  |  |  +--<item> ::= <text>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    minerals (micronutrients)
|  |  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                               Description                                                            
---------------   -----   -----   -----   ---------------------------------------   -----------------------------------------------------------------------
Token Read            0       0       0   macronutrients                            Token type: Text                                                       
Shift                10                                                             The parser shifted to state 10                                         
Token Read           10       0      15   -                                         Token type: Hyphen                                                     
Reduce               16                   (1) ::= macronutrients                    <text-chunk> ::= Text                                                  
Reduce               15                   (2) ::= (1)                               <text> ::= <text-chunk>                                                
Reduce               13                   (3) ::= (2)                               <item> ::= <text>                                                      
Shift                20                                                             The parser shifted to state 20                                         
Token Read           20       0      16   >                                         Token type: RightArrow                                                 
Shift                24                                                             The parser shifted to state 24                                         
Token Read           24       0      17       fiber                                 Token type: Text                                                       
Reduce               21                   (4) ::= - >                               <producer> ::= Hyphen RightArrow                                       
Shift                10                                                             The parser shifted to state 10                                         
Token Read           10       0      26   ,                                         Token type: Separator                                                  
Reduce               16                   (5) ::=     fiber                         <text-chunk> ::= Text                                                  
Reduce               15                   (6) ::= (5)                               <text> ::= <text-chunk>                                                
Reduce               27                   (7) ::= (6)                               <item> ::= <text>                                                      
Shift                33                                                             The parser shifted to state 33                                         
Token Read           33       0      27       water                                 Token type: Text                                                       
Shift                10                                                             The parser shifted to state 10                                         
Token Read           10       0      36   ;                                         Token type: Terminator                                                 
Reduce               16                   (8) ::=     water                         <text-chunk> ::= Text                                                  
Reduce               15                   (9) ::= (8)                               <text> ::= <text-chunk>                                                
Reduce               37                   (10) ::= (9)                              <item> ::= <text>                                                      
Reduce               29                   (11) ::= (7) , (10)                       <item-or-expression-list> ::= <item> Separator <item>                  
Shift                35                                                             The parser shifted to state 35                                         
Token Read           35       0      37   micronutrients                            Token type: Text                                                       
Reduce               11                   (12) ::= (3) (4) (11) ;                   <expression> ::= <item> <producer> <item-or-expression-list> Terminator
Shift                10                                                             The parser shifted to state 10                                         
Token Read           10       0      52   -                                         Token type: Hyphen                                                     
Reduce               16                   (13) ::= micronutrients                   <text-chunk> ::= Text                                                  
Reduce               15                   (14) ::= (13)                             <text> ::= <text-chunk>                                                
Reduce               13                   (15) ::= (14)                             <item> ::= <text>                                                      
Shift                20                                                             The parser shifted to state 20                                         
Token Read           20       0      53   >                                         Token type: RightArrow                                                 
Shift                24                                                             The parser shifted to state 24                                         
Token Read           24       0      54       vitamins (ABCDEK)                     Token type: Text                                                       
Reduce               21                   (16) ::= - >                              <producer> ::= Hyphen RightArrow                                       
Shift                10                                                             The parser shifted to state 10                                         
Token Read           10       0      75   ,                                         Token type: Separator                                                  
Reduce               16                   (17) ::=     vitamins (ABCDEK)            <text-chunk> ::= Text                                                  
Reduce               15                   (18) ::= (17)                             <text> ::= <text-chunk>                                                
Reduce               27                   (19) ::= (18)                             <item> ::= <text>                                                      
Shift                33                                                             The parser shifted to state 33                                         
Token Read           33       0      76       minerals (micronutrients)             Token type: Text                                                       
Shift                10                                                             The parser shifted to state 10                                         
Token Read           10       0     105   ;                                         Token type: Terminator                                                 
Reduce               16                   (20) ::=     minerals (micronutrients)    <text-chunk> ::= Text                                                  
Reduce               15                   (21) ::= (20)                             <text> ::= <text-chunk>                                                
Reduce               37                   (22) ::= (21)                             <item> ::= <text>                                                      
Reduce               29                   (23) ::= (19) , (22)                      <item-or-expression-list> ::= <item> Separator <item>                  
Shift                35                                                             The parser shifted to state 35                                         
Token Read           35       1       0                                             Token type: EOF                                                        
Reduce               18                   (24) ::= (15) (16) (23) ;                 <expression> ::= <item> <producer> <item-or-expression-list> Terminator
Reduce               12                   (25) ::= (12) (24)                        <expression-list> ::= <expression> <expression>                        
Reduce               14                   (26) ::= (25)                             <scripture> ::= <expression-list>                                      
Accept               14                                                                                                                                    



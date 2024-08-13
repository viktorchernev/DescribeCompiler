========================================
Source Code (between the arrows)
========================================

🡆macronutrients ->

    fiber ->

        what,
        not;
    
    water;🡄

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
|  |  +--<item-or-expression-list> ::= <expression> <item>
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
|  |  |  +--<item> ::= <text>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--    water
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                Description                                                            
---------------   -----   -----   -----   ------------------------   -----------------------------------------------------------------------
Token Read            0       0       0   macronutrients             Token type: Text                                                       
Shift                10                                              The parser shifted to state 10                                         
Token Read           10       0      15   -                          Token type: Hyphen                                                     
Reduce               16                   (1) ::= macronutrients     <text-chunk> ::= Text                                                  
Reduce               15                   (2) ::= (1)                <text> ::= <text-chunk>                                                
Reduce               13                   (3) ::= (2)                <item> ::= <text>                                                      
Shift                20                                              The parser shifted to state 20                                         
Token Read           20       0      16   >                          Token type: RightArrow                                                 
Shift                24                                              The parser shifted to state 24                                         
Token Read           24       2       0       fiber                  Token type: Text                                                       
Reduce               21                   (4) ::= - >                <producer> ::= Hyphen RightArrow                                       
Shift                10                                              The parser shifted to state 10                                         
Token Read           10       2      10   -                          Token type: Hyphen                                                     
Reduce               16                   (5) ::=     fiber          <text-chunk> ::= Text                                                  
Reduce               15                   (6) ::= (5)                <text> ::= <text-chunk>                                                
Reduce               27                   (7) ::= (6)                <item> ::= <text>                                                      
Shift                20                                              The parser shifted to state 20                                         
Token Read           20       2      11   >                          Token type: RightArrow                                                 
Shift                24                                              The parser shifted to state 24                                         
Token Read           24       4       0           what               Token type: Text                                                       
Reduce               21                   (8) ::= - >                <producer> ::= Hyphen RightArrow                                       
Shift                10                                              The parser shifted to state 10                                         
Token Read           10       4      12   ,                          Token type: Separator                                                  
Reduce               16                   (9) ::=         what       <text-chunk> ::= Text                                                  
Reduce               15                   (10) ::= (9)               <text> ::= <text-chunk>                                                
Reduce               27                   (11) ::= (10)              <item> ::= <text>                                                      
Shift                33                                              The parser shifted to state 33                                         
Token Read           33       5       0           not                Token type: Text                                                       
Shift                10                                              The parser shifted to state 10                                         
Token Read           10       5      11   ;                          Token type: Terminator                                                 
Reduce               16                   (12) ::=         not       <text-chunk> ::= Text                                                  
Reduce               15                   (13) ::= (12)              <text> ::= <text-chunk>                                                
Reduce               37                   (14) ::= (13)              <item> ::= <text>                                                      
Reduce               29                   (15) ::= (11) , (14)       <item-or-expression-list> ::= <item> Separator <item>                  
Shift                35                                              The parser shifted to state 35                                         
Token Read           35       7       0       water                  Token type: Text                                                       
Reduce               26                   (16) ::= (7) (8) (15) ;    <expression> ::= <item> <producer> <item-or-expression-list> Terminator
Shift                10                                              The parser shifted to state 10                                         
Token Read           10       7       9   ;                          Token type: Terminator                                                 
Reduce               16                   (17) ::=     water         <text-chunk> ::= Text                                                  
Reduce               15                   (18) ::= (17)              <text> ::= <text-chunk>                                                
Reduce               31                   (19) ::= (18)              <item> ::= <text>                                                      
Reduce               29                   (20) ::= (16) (19)         <item-or-expression-list> ::= <expression> <item>                      
Shift                35                                              The parser shifted to state 35                                         
Token Read           35       8       0                              Token type: EOF                                                        
Reduce               11                   (21) ::= (3) (4) (20) ;    <expression> ::= <item> <producer> <item-or-expression-list> Terminator
Reduce               14                   (22) ::= (21)              <scripture> ::= <expression>                                           
Accept               14                                                                                                                     



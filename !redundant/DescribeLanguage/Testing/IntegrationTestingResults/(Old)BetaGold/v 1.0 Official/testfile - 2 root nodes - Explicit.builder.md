========================================
Source Code (between the arrows)
========================================

🡆macronutrients ->>

    fiber,,
    water;;

micronutrients ->>

    vitamins (ABCDEK),,
    minerals (micronutrients);;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression-list>
|  +--<expression-list> ::= <expression> <expression>
|  |  +--<expression> ::= <item> <producer> <item-or-expression-list> <terminator>
|  |  |  +--<item> ::= <text>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--macronutrients 
|  |  |  +--<producer> ::= Hyphen RightArrow RightArrow
|  |  |  |  +---
|  |  |  |  +-->
|  |  |  |  +-->
|  |  |  +--<item-or-expression-list> ::= <item> <separator> <item>
|  |  |  |  +--<item> ::= <text>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    fiber
|  |  |  |  +--<separator> ::= Separator Separator
|  |  |  |  |  +--,
|  |  |  |  |  +--,
|  |  |  |  +--<item> ::= <text>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    water
|  |  |  +--<terminator> ::= Terminator Terminator
|  |  |  |  +--;
|  |  |  |  +--;
|  |  +--<expression> ::= <item> <producer> <item-or-expression-list> <terminator>
|  |  |  +--<item> ::= <text>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--micronutrients 
|  |  |  +--<producer> ::= Hyphen RightArrow RightArrow
|  |  |  |  +---
|  |  |  |  +-->
|  |  |  |  +-->
|  |  |  +--<item-or-expression-list> ::= <item> <separator> <item>
|  |  |  |  +--<item> ::= <text>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    vitamins (ABCDEK)
|  |  |  |  +--<separator> ::= Separator Separator
|  |  |  |  |  +--,
|  |  |  |  |  +--,
|  |  |  |  +--<item> ::= <text>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    minerals (micronutrients)
|  |  |  +--<terminator> ::= Terminator Terminator
|  |  |  |  +--;
|  |  |  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                               Description                                                              
---------------   -----   -----   -----   ---------------------------------------   -------------------------------------------------------------------------
Token Read            0       0       0   macronutrients                            Token type: Text                                                         
Shift                14                                                             The parser shifted to state 14                                           
Token Read           14       0      15   -                                         Token type: Hyphen                                                       
Reduce               20                   (1) ::= macronutrients                    <text-chunk> ::= Text                                                    
Reduce               19                   (2) ::= (1)                               <text> ::= <text-chunk>                                                  
Reduce               17                   (3) ::= (2)                               <item> ::= <text>                                                        
Shift                24                                                             The parser shifted to state 24                                           
Token Read           24       0      16   >                                         Token type: RightArrow                                                   
Shift                35                                                             The parser shifted to state 35                                           
Token Read           35       0      17   >                                         Token type: RightArrow                                                   
Shift                64                                                             The parser shifted to state 64                                           
Token Read           64       2       0       fiber                                 Token type: Text                                                         
Reduce               25                   (4) ::= - > >                             <producer> ::= Hyphen RightArrow RightArrow                              
Shift                14                                                             The parser shifted to state 14                                           
Token Read           14       2       9   ,                                         Token type: Separator                                                    
Reduce               20                   (5) ::=     fiber                         <text-chunk> ::= Text                                                    
Reduce               19                   (6) ::= (5)                               <text> ::= <text-chunk>                                                  
Reduce               38                   (7) ::= (6)                               <item> ::= <text>                                                        
Shift                69                                                             The parser shifted to state 69                                           
Token Read           69       2      10   ,                                         Token type: Separator                                                    
Shift                99                                                             The parser shifted to state 99                                           
Token Read           99       3       0       water                                 Token type: Text                                                         
Reduce               70                   (8) ::= , ,                               <separator> ::= Separator Separator                                      
Shift                14                                                             The parser shifted to state 14                                           
Token Read           14       3       9   ;                                         Token type: Terminator                                                   
Reduce               20                   (9) ::=     water                         <text-chunk> ::= Text                                                    
Reduce               19                   (10) ::= (9)                              <text> ::= <text-chunk>                                                  
Reduce              101                   (11) ::= (10)                             <item> ::= <text>                                                        
Reduce               40                   (12) ::= (7) (8) (11)                     <item-or-expression-list> ::= <item> <separator> <item>                  
Shift                36                                                             The parser shifted to state 36                                           
Token Read           36       3      10   ;                                         Token type: Terminator                                                   
Shift                65                                                             The parser shifted to state 65                                           
Token Read           65       5       0   micronutrients                            Token type: Text                                                         
Reduce               72                   (13) ::= ; ;                              <terminator> ::= Terminator Terminator                                   
Reduce               15                   (14) ::= (3) (4) (12) (13)                <expression> ::= <item> <producer> <item-or-expression-list> <terminator>
Shift                14                                                             The parser shifted to state 14                                           
Token Read           14       5      15   -                                         Token type: Hyphen                                                       
Reduce               20                   (15) ::= micronutrients                   <text-chunk> ::= Text                                                    
Reduce               19                   (16) ::= (15)                             <text> ::= <text-chunk>                                                  
Reduce               17                   (17) ::= (16)                             <item> ::= <text>                                                        
Shift                24                                                             The parser shifted to state 24                                           
Token Read           24       5      16   >                                         Token type: RightArrow                                                   
Shift                35                                                             The parser shifted to state 35                                           
Token Read           35       5      17   >                                         Token type: RightArrow                                                   
Shift                64                                                             The parser shifted to state 64                                           
Token Read           64       7       0       vitamins (ABCDEK)                     Token type: Text                                                         
Reduce               25                   (18) ::= - > >                            <producer> ::= Hyphen RightArrow RightArrow                              
Shift                14                                                             The parser shifted to state 14                                           
Token Read           14       7      21   ,                                         Token type: Separator                                                    
Reduce               20                   (19) ::=     vitamins (ABCDEK)            <text-chunk> ::= Text                                                    
Reduce               19                   (20) ::= (19)                             <text> ::= <text-chunk>                                                  
Reduce               38                   (21) ::= (20)                             <item> ::= <text>                                                        
Shift                69                                                             The parser shifted to state 69                                           
Token Read           69       7      22   ,                                         Token type: Separator                                                    
Shift                99                                                             The parser shifted to state 99                                           
Token Read           99       8       0       minerals (micronutrients)             Token type: Text                                                         
Reduce               70                   (22) ::= , ,                              <separator> ::= Separator Separator                                      
Shift                14                                                             The parser shifted to state 14                                           
Token Read           14       8      29   ;                                         Token type: Terminator                                                   
Reduce               20                   (23) ::=     minerals (micronutrients)    <text-chunk> ::= Text                                                    
Reduce               19                   (24) ::= (23)                             <text> ::= <text-chunk>                                                  
Reduce              101                   (25) ::= (24)                             <item> ::= <text>                                                        
Reduce               40                   (26) ::= (21) (22) (25)                   <item-or-expression-list> ::= <item> <separator> <item>                  
Shift                36                                                             The parser shifted to state 36                                           
Token Read           36       8      30   ;                                         Token type: Terminator                                                   
Shift                65                                                             The parser shifted to state 65                                           
Token Read           65       9       0                                             Token type: EOF                                                          
Reduce               72                   (27) ::= ; ;                              <terminator> ::= Terminator Terminator                                   
Reduce               22                   (28) ::= (17) (18) (26) (27)              <expression> ::= <item> <producer> <item-or-expression-list> <terminator>
Reduce               16                   (29) ::= (14) (28)                        <expression-list> ::= <expression> <expression>                          
Reduce               18                   (30) ::= (29)                             <scripture> ::= <expression-list>                                        
Accept               18                                                                                                                                      



========================================
Source Code (between the arrows)
========================================

🡆fabrics ->        //dude;

    wool fabrics, /* comment <*/
/* ->Comments, man */    cotton fabrics;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  +--<item> ::= <text>
|  |  |  +--<text> ::= <text-chunk>
|  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  +--fabrics 
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  +--<item> ::= <text>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--    wool fabrics
|  |  |  +--,
|  |  |  +--<item> ::= <text>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--    cotton fabrics
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                   Description                                                            
---------------   -----   -----   -----   ---------------------------   -----------------------------------------------------------------------
Token Read            0       0       0   fabrics                       Token type: Text                                                       
Shift                10                                                 The parser shifted to state 10                                         
Token Read           10       0       8   -                             Token type: Hyphen                                                     
Reduce               16                   (1) ::= fabrics               <text-chunk> ::= Text                                                  
Reduce               15                   (2) ::= (1)                   <text> ::= <text-chunk>                                                
Reduce               13                   (3) ::= (2)                   <item> ::= <text>                                                      
Shift                20                                                 The parser shifted to state 20                                         
Token Read           20       0       9   >                             Token type: RightArrow                                                 
Shift                24                                                 The parser shifted to state 24                                         
Token Read           24       2       0       wool fabrics              Token type: Text                                                       
Reduce               21                   (4) ::= - >                   <producer> ::= Hyphen RightArrow                                       
Shift                10                                                 The parser shifted to state 10                                         
Token Read           10       2      16   ,                             Token type: Separator                                                  
Reduce               16                   (5) ::=     wool fabrics      <text-chunk> ::= Text                                                  
Reduce               15                   (6) ::= (5)                   <text> ::= <text-chunk>                                                
Reduce               27                   (7) ::= (6)                   <item> ::= <text>                                                      
Shift                33                                                 The parser shifted to state 33                                         
Token Read           33       3      21       cotton fabrics            Token type: Text                                                       
Shift                10                                                 The parser shifted to state 10                                         
Token Read           10       3      39   ;                             Token type: Terminator                                                 
Reduce               16                   (8) ::=     cotton fabrics    <text-chunk> ::= Text                                                  
Reduce               15                   (9) ::= (8)                   <text> ::= <text-chunk>                                                
Reduce               37                   (10) ::= (9)                  <item> ::= <text>                                                      
Reduce               29                   (11) ::= (7) , (10)           <item-or-expression-list> ::= <item> Separator <item>                  
Shift                35                                                 The parser shifted to state 35                                         
Token Read           35       4       0                                 Token type: EOF                                                        
Reduce               11                   (12) ::= (3) (4) (11) ;       <expression> ::= <item> <producer> <item-or-expression-list> Terminator
Reduce               14                   (13) ::= (12)                 <scripture> ::= <expression>                                           
Accept               14                                                                                                                        



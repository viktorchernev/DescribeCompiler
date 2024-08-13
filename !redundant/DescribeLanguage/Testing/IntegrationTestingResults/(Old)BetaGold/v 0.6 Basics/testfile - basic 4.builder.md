========================================
Source Code (between the arrows)
========================================

🡆fabrics ->

    wool fabrics,
    cotton fabrics,
    silk fabrics,
    synthetic fabrics;
🡄

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
|  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  +--<item> ::= <text>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--    wool fabrics
|  |  |  +--,
|  |  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  |  +--<item> ::= <text>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    cotton fabrics
|  |  |  |  +--,
|  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    silk fabrics
|  |  |  |  |  +--,
|  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    synthetic fabrics
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                       Description                                                             
---------------   -----   -----   -----   -------------------------------   ------------------------------------------------------------------------
Token Read            0       0       0   fabrics                           Token type: Text                                                        
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       0       8   -                                 Token type: Hyphen                                                      
Reduce               16                   (1) ::= fabrics                   <text-chunk> ::= Text                                                   
Reduce               15                   (2) ::= (1)                       <text> ::= <text-chunk>                                                 
Reduce               13                   (3) ::= (2)                       <item> ::= <text>                                                       
Shift                20                                                     The parser shifted to state 20                                          
Token Read           20       0       9   >                                 Token type: RightArrow                                                  
Shift                24                                                     The parser shifted to state 24                                          
Token Read           24       2       0       wool fabrics                  Token type: Text                                                        
Reduce               21                   (4) ::= - >                       <producer> ::= Hyphen RightArrow                                        
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       2      16   ,                                 Token type: Separator                                                   
Reduce               16                   (5) ::=     wool fabrics          <text-chunk> ::= Text                                                   
Reduce               15                   (6) ::= (5)                       <text> ::= <text-chunk>                                                 
Reduce               27                   (7) ::= (6)                       <item> ::= <text>                                                       
Shift                33                                                     The parser shifted to state 33                                          
Token Read           33       3       0       cotton fabrics                Token type: Text                                                        
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       3      18   ,                                 Token type: Separator                                                   
Reduce               16                   (8) ::=     cotton fabrics        <text-chunk> ::= Text                                                   
Reduce               15                   (9) ::= (8)                       <text> ::= <text-chunk>                                                 
Reduce               37                   (10) ::= (9)                      <item> ::= <text>                                                       
Shift                33                                                     The parser shifted to state 33                                          
Token Read           33       4       0       silk fabrics                  Token type: Text                                                        
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       4      16   ,                                 Token type: Separator                                                   
Reduce               16                   (11) ::=     silk fabrics         <text-chunk> ::= Text                                                   
Reduce               15                   (12) ::= (11)                     <text> ::= <text-chunk>                                                 
Reduce               37                   (13) ::= (12)                     <item> ::= <text>                                                       
Shift                33                                                     The parser shifted to state 33                                          
Token Read           33       5       0       synthetic fabrics             Token type: Text                                                        
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       5      21   ;                                 Token type: Terminator                                                  
Reduce               16                   (14) ::=     synthetic fabrics    <text-chunk> ::= Text                                                   
Reduce               15                   (15) ::= (14)                     <text> ::= <text-chunk>                                                 
Reduce               37                   (16) ::= (15)                     <item> ::= <text>                                                       
Reduce               38                   (17) ::= (13) , (16)              <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               38                   (18) ::= (10) , (17)              <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               29                   (19) ::= (7) , (18)               <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                35                                                     The parser shifted to state 35                                          
Token Read           35       7       0                                     Token type: EOF                                                         
Reduce               11                   (20) ::= (3) (4) (19) ;           <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               14                   (21) ::= (20)                     <scripture> ::= <expression>                                            
Accept               14                                                                                                                             



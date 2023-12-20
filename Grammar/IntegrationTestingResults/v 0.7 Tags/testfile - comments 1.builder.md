========================================
Source Code (between the arrows)
========================================

🡆fabrics <KvtgGtnv> -> //comment here

    wool fabrics <rUEqmXfk>,
    cotton fabrics <wpra8mUV>,
    silk fabrics <VFoIEr0T>,
    synthetic fabrics <oI5DOuPh>;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  +--<item> ::= <text> <tag>
|  |  |  +--<text> ::= <text-chunk>
|  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  +--fabrics 
|  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  +--<
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--KvtgGtnv
|  |  |  |  +-->
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  +--<item> ::= <text> <tag>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--    wool fabrics 
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--rUEqmXfk
|  |  |  |  |  +-->
|  |  |  +--,
|  |  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    cotton fabrics 
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--wpra8mUV
|  |  |  |  |  |  +-->
|  |  |  |  +--,
|  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    silk fabrics 
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--VFoIEr0T
|  |  |  |  |  |  |  +-->
|  |  |  |  |  +--,
|  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    synthetic fabrics 
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--oI5DOuPh
|  |  |  |  |  |  |  +-->
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                        Description                                                             
---------------   -----   -----   -----   --------------------------------   ------------------------------------------------------------------------
Token Read            0       0       0   fabrics                            Token type: Text                                                        
Shift                11                                                      The parser shifted to state 11                                          
Token Read           11       0       8   <                                  Token type: LeftArrow                                                   
Reduce               18                   (1) ::= fabrics                    <text-chunk> ::= Text                                                   
Reduce               17                   (2) ::= (1)                        <text> ::= <text-chunk>                                                 
Shift                10                                                      The parser shifted to state 10                                          
Token Read           10       0       9   KvtgGtnv                           Token type: Text                                                        
Shift                11                                                      The parser shifted to state 11                                          
Token Read           11       0      17   >                                  Token type: RightArrow                                                  
Reduce               18                   (3) ::= KvtgGtnv                   <text-chunk> ::= Text                                                   
Reduce               20                   (4) ::= (3)                        <text> ::= <text-chunk>                                                 
Shift                29                                                      The parser shifted to state 29                                          
Token Read           29       0      19   -                                  Token type: Hyphen                                                      
Reduce               26                   (5) ::= < (4) >                    <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               14                   (6) ::= (2) (5)                    <item> ::= <text> <tag>                                                 
Shift                23                                                      The parser shifted to state 23                                          
Token Read           23       0      20   >                                  Token type: RightArrow                                                  
Shift                30                                                      The parser shifted to state 30                                          
Token Read           30       2       0       wool fabrics                   Token type: Text                                                        
Reduce               24                   (7) ::= - >                        <producer> ::= Hyphen RightArrow                                        
Shift                11                                                      The parser shifted to state 11                                          
Token Read           11       2      17   <                                  Token type: LeftArrow                                                   
Reduce               18                   (8) ::=     wool fabrics           <text-chunk> ::= Text                                                   
Reduce               17                   (9) ::= (8)                        <text> ::= <text-chunk>                                                 
Shift                10                                                      The parser shifted to state 10                                          
Token Read           10       2      18   rUEqmXfk                           Token type: Text                                                        
Shift                11                                                      The parser shifted to state 11                                          
Token Read           11       2      26   >                                  Token type: RightArrow                                                  
Reduce               18                   (10) ::= rUEqmXfk                  <text-chunk> ::= Text                                                   
Reduce               20                   (11) ::= (10)                      <text> ::= <text-chunk>                                                 
Shift                29                                                      The parser shifted to state 29                                          
Token Read           29       2      27   ,                                  Token type: Separator                                                   
Reduce               26                   (12) ::= < (11) >                  <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (13) ::= (9) (12)                  <item> ::= <text> <tag>                                                 
Shift                39                                                      The parser shifted to state 39                                          
Token Read           39       3       0       cotton fabrics                 Token type: Text                                                        
Shift                11                                                      The parser shifted to state 11                                          
Token Read           11       3      19   <                                  Token type: LeftArrow                                                   
Reduce               18                   (14) ::=     cotton fabrics        <text-chunk> ::= Text                                                   
Reduce               17                   (15) ::= (14)                      <text> ::= <text-chunk>                                                 
Shift                10                                                      The parser shifted to state 10                                          
Token Read           10       3      20   wpra8mUV                           Token type: Text                                                        
Shift                11                                                      The parser shifted to state 11                                          
Token Read           11       3      28   >                                  Token type: RightArrow                                                  
Reduce               18                   (16) ::= wpra8mUV                  <text-chunk> ::= Text                                                   
Reduce               20                   (17) ::= (16)                      <text> ::= <text-chunk>                                                 
Shift                29                                                      The parser shifted to state 29                                          
Token Read           29       3      29   ,                                  Token type: Separator                                                   
Reduce               26                   (18) ::= < (17) >                  <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (19) ::= (15) (18)                 <item> ::= <text> <tag>                                                 
Shift                39                                                      The parser shifted to state 39                                          
Token Read           39       4       0       silk fabrics                   Token type: Text                                                        
Shift                11                                                      The parser shifted to state 11                                          
Token Read           11       4      17   <                                  Token type: LeftArrow                                                   
Reduce               18                   (20) ::=     silk fabrics          <text-chunk> ::= Text                                                   
Reduce               17                   (21) ::= (20)                      <text> ::= <text-chunk>                                                 
Shift                10                                                      The parser shifted to state 10                                          
Token Read           10       4      18   VFoIEr0T                           Token type: Text                                                        
Shift                11                                                      The parser shifted to state 11                                          
Token Read           11       4      26   >                                  Token type: RightArrow                                                  
Reduce               18                   (22) ::= VFoIEr0T                  <text-chunk> ::= Text                                                   
Reduce               20                   (23) ::= (22)                      <text> ::= <text-chunk>                                                 
Shift                29                                                      The parser shifted to state 29                                          
Token Read           29       4      27   ,                                  Token type: Separator                                                   
Reduce               26                   (24) ::= < (23) >                  <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (25) ::= (21) (24)                 <item> ::= <text> <tag>                                                 
Shift                39                                                      The parser shifted to state 39                                          
Token Read           39       5       0       synthetic fabrics              Token type: Text                                                        
Shift                11                                                      The parser shifted to state 11                                          
Token Read           11       5      22   <                                  Token type: LeftArrow                                                   
Reduce               18                   (26) ::=     synthetic fabrics     <text-chunk> ::= Text                                                   
Reduce               17                   (27) ::= (26)                      <text> ::= <text-chunk>                                                 
Shift                10                                                      The parser shifted to state 10                                          
Token Read           10       5      23   oI5DOuPh                           Token type: Text                                                        
Shift                11                                                      The parser shifted to state 11                                          
Token Read           11       5      31   >                                  Token type: RightArrow                                                  
Reduce               18                   (28) ::= oI5DOuPh                  <text-chunk> ::= Text                                                   
Reduce               20                   (29) ::= (28)                      <text> ::= <text-chunk>                                                 
Shift                29                                                      The parser shifted to state 29                                          
Token Read           29       5      32   ;                                  Token type: Terminator                                                  
Reduce               26                   (30) ::= < (29) >                  <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (31) ::= (27) (30)                 <item> ::= <text> <tag>                                                 
Reduce               44                   (32) ::= (25) , (31)               <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               44                   (33) ::= (19) , (32)               <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               35                   (34) ::= (13) , (33)               <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                41                                                      The parser shifted to state 41                                          
Token Read           41       6       0                                      Token type: EOF                                                         
Reduce               12                   (35) ::= (6) (7) (34) ;            <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               15                   (36) ::= (35)                      <scripture> ::= <expression>                                            
Accept               15                                                                                                                              



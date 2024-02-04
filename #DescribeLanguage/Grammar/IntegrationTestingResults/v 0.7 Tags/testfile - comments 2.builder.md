========================================
Source Code (between the arrows)
========================================

🡆fabrics <aXLBEer9> -> //comment here

    /* wool fabrics <VevA2Eh3>, */
    cotton fabrics <evhAIQx4>,
    silk fabrics <h0e5wwEY>,
    synthetic fabrics <WryZrSIJ>;🡄

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
|  |  |  |  |  |  +--aXLBEer9
|  |  |  |  +-->
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  +--<item> ::= <text> <tag>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--    cotton fabrics 
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--evhAIQx4
|  |  |  |  |  +-->
|  |  |  +--,
|  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    silk fabrics 
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--h0e5wwEY
|  |  |  |  |  |  +-->
|  |  |  |  +--,
|  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    synthetic fabrics 
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--WryZrSIJ
|  |  |  |  |  |  +-->
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
Token Read           10       0       9   aXLBEer9                           Token type: Text                                                        
Shift                11                                                      The parser shifted to state 11                                          
Token Read           11       0      17   >                                  Token type: RightArrow                                                  
Reduce               18                   (3) ::= aXLBEer9                   <text-chunk> ::= Text                                                   
Reduce               20                   (4) ::= (3)                        <text> ::= <text-chunk>                                                 
Shift                29                                                      The parser shifted to state 29                                          
Token Read           29       0      19   -                                  Token type: Hyphen                                                      
Reduce               26                   (5) ::= < (4) >                    <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               14                   (6) ::= (2) (5)                    <item> ::= <text> <tag>                                                 
Shift                23                                                      The parser shifted to state 23                                          
Token Read           23       0      20   >                                  Token type: RightArrow                                                  
Shift                30                                                      The parser shifted to state 30                                          
Token Read           30       3       0       cotton fabrics                 Token type: Text                                                        
Reduce               24                   (7) ::= - >                        <producer> ::= Hyphen RightArrow                                        
Shift                11                                                      The parser shifted to state 11                                          
Token Read           11       3      19   <                                  Token type: LeftArrow                                                   
Reduce               18                   (8) ::=     cotton fabrics         <text-chunk> ::= Text                                                   
Reduce               17                   (9) ::= (8)                        <text> ::= <text-chunk>                                                 
Shift                10                                                      The parser shifted to state 10                                          
Token Read           10       3      20   evhAIQx4                           Token type: Text                                                        
Shift                11                                                      The parser shifted to state 11                                          
Token Read           11       3      28   >                                  Token type: RightArrow                                                  
Reduce               18                   (10) ::= evhAIQx4                  <text-chunk> ::= Text                                                   
Reduce               20                   (11) ::= (10)                      <text> ::= <text-chunk>                                                 
Shift                29                                                      The parser shifted to state 29                                          
Token Read           29       3      29   ,                                  Token type: Separator                                                   
Reduce               26                   (12) ::= < (11) >                  <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (13) ::= (9) (12)                  <item> ::= <text> <tag>                                                 
Shift                39                                                      The parser shifted to state 39                                          
Token Read           39       4       0       silk fabrics                   Token type: Text                                                        
Shift                11                                                      The parser shifted to state 11                                          
Token Read           11       4      17   <                                  Token type: LeftArrow                                                   
Reduce               18                   (14) ::=     silk fabrics          <text-chunk> ::= Text                                                   
Reduce               17                   (15) ::= (14)                      <text> ::= <text-chunk>                                                 
Shift                10                                                      The parser shifted to state 10                                          
Token Read           10       4      18   h0e5wwEY                           Token type: Text                                                        
Shift                11                                                      The parser shifted to state 11                                          
Token Read           11       4      26   >                                  Token type: RightArrow                                                  
Reduce               18                   (16) ::= h0e5wwEY                  <text-chunk> ::= Text                                                   
Reduce               20                   (17) ::= (16)                      <text> ::= <text-chunk>                                                 
Shift                29                                                      The parser shifted to state 29                                          
Token Read           29       4      27   ,                                  Token type: Separator                                                   
Reduce               26                   (18) ::= < (17) >                  <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (19) ::= (15) (18)                 <item> ::= <text> <tag>                                                 
Shift                39                                                      The parser shifted to state 39                                          
Token Read           39       5       0       synthetic fabrics              Token type: Text                                                        
Shift                11                                                      The parser shifted to state 11                                          
Token Read           11       5      22   <                                  Token type: LeftArrow                                                   
Reduce               18                   (20) ::=     synthetic fabrics     <text-chunk> ::= Text                                                   
Reduce               17                   (21) ::= (20)                      <text> ::= <text-chunk>                                                 
Shift                10                                                      The parser shifted to state 10                                          
Token Read           10       5      23   WryZrSIJ                           Token type: Text                                                        
Shift                11                                                      The parser shifted to state 11                                          
Token Read           11       5      31   >                                  Token type: RightArrow                                                  
Reduce               18                   (22) ::= WryZrSIJ                  <text-chunk> ::= Text                                                   
Reduce               20                   (23) ::= (22)                      <text> ::= <text-chunk>                                                 
Shift                29                                                      The parser shifted to state 29                                          
Token Read           29       5      32   ;                                  Token type: Terminator                                                  
Reduce               26                   (24) ::= < (23) >                  <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (25) ::= (21) (24)                 <item> ::= <text> <tag>                                                 
Reduce               44                   (26) ::= (19) , (25)               <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               35                   (27) ::= (13) , (26)               <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                41                                                      The parser shifted to state 41                                          
Token Read           41       6       0                                      Token type: EOF                                                         
Reduce               12                   (28) ::= (6) (7) (27) ;            <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               15                   (29) ::= (28)                      <scripture> ::= <expression>                                            
Accept               15                                                                                                                              



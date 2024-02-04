========================================
Source Code (between the arrows)
========================================

🡆fabrics <aXLBEer9> -> //comment here [https://www.notube.com/watch?v=hTui12lKus]

    /* wool [] fabrics [https://www.notube.com/watch?v=hTui12lKus] {}{}{} <VevA2Eh3>, */
    cotton fabrics <evhAIQx4>,
    silk fabrics <h0e5wwEY> []{},
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
|  |  |  |  +--<item> ::= <text> <tag> Link Decorator
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    silk fabrics 
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--h0e5wwEY
|  |  |  |  |  |  +-->
|  |  |  |  |  +--[]
|  |  |  |  |  +--{}
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
Shift                14                                                      The parser shifted to state 14                                          
Token Read           14       0       8   <                                  Token type: LeftArrow                                                   
Reduce               20                   (1) ::= fabrics                    <text-chunk> ::= Text                                                   
Reduce               19                   (2) ::= (1)                        <text> ::= <text-chunk>                                                 
Shift                27                                                      The parser shifted to state 27                                          
Token Read           27       0       9   aXLBEer9                           Token type: Text                                                        
Shift                14                                                      The parser shifted to state 14                                          
Token Read           14       0      17   >                                  Token type: RightArrow                                                  
Reduce               20                   (3) ::= aXLBEer9                   <text-chunk> ::= Text                                                   
Reduce               45                   (4) ::= (3)                        <text> ::= <text-chunk>                                                 
Shift                71                                                      The parser shifted to state 71                                          
Token Read           71       0      19   -                                  Token type: Hyphen                                                      
Reduce               31                   (5) ::= < (4) >                    <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               17                   (6) ::= (2) (5)                    <item> ::= <text> <tag>                                                 
Shift                24                                                      The parser shifted to state 24                                          
Token Read           24       0      20   >                                  Token type: RightArrow                                                  
Shift                34                                                      The parser shifted to state 34                                          
Token Read           34       3       0       cotton fabrics                 Token type: Text                                                        
Reduce               25                   (7) ::= - >                        <producer> ::= Hyphen RightArrow                                        
Shift                14                                                      The parser shifted to state 14                                          
Token Read           14       3      19   <                                  Token type: LeftArrow                                                   
Reduce               20                   (8) ::=     cotton fabrics         <text-chunk> ::= Text                                                   
Reduce               19                   (9) ::= (8)                        <text> ::= <text-chunk>                                                 
Shift                27                                                      The parser shifted to state 27                                          
Token Read           27       3      20   evhAIQx4                           Token type: Text                                                        
Shift                14                                                      The parser shifted to state 14                                          
Token Read           14       3      28   >                                  Token type: RightArrow                                                  
Reduce               20                   (10) ::= evhAIQx4                  <text-chunk> ::= Text                                                   
Reduce               45                   (11) ::= (10)                      <text> ::= <text-chunk>                                                 
Shift                71                                                      The parser shifted to state 71                                          
Token Read           71       3      29   ,                                  Token type: Separator                                                   
Reduce               31                   (12) ::= < (11) >                  <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               37                   (13) ::= (9) (12)                  <item> ::= <text> <tag>                                                 
Shift                64                                                      The parser shifted to state 64                                          
Token Read           64       4       0       silk fabrics                   Token type: Text                                                        
Shift                14                                                      The parser shifted to state 14                                          
Token Read           14       4      17   <                                  Token type: LeftArrow                                                   
Reduce               20                   (14) ::=     silk fabrics          <text-chunk> ::= Text                                                   
Reduce               19                   (15) ::= (14)                      <text> ::= <text-chunk>                                                 
Shift                27                                                      The parser shifted to state 27                                          
Token Read           27       4      18   h0e5wwEY                           Token type: Text                                                        
Shift                14                                                      The parser shifted to state 14                                          
Token Read           14       4      26   >                                  Token type: RightArrow                                                  
Reduce               20                   (16) ::= h0e5wwEY                  <text-chunk> ::= Text                                                   
Reduce               45                   (17) ::= (16)                      <text> ::= <text-chunk>                                                 
Shift                71                                                      The parser shifted to state 71                                          
Token Read           71       4      28   []                                 Token type: Link                                                        
Reduce               31                   (18) ::= < (17) >                  <tag> ::= LeftArrow <text> RightArrow                                   
Shift                58                                                      The parser shifted to state 58                                          
Token Read           58       4      30   {}                                 Token type: Decorator                                                   
Shift                86                                                      The parser shifted to state 86                                          
Token Read           86       4      32   ,                                  Token type: Separator                                                   
Reduce               93                   (19) ::= (15) (18) [] {}           <item> ::= <text> <tag> Link Decorator                                  
Shift                64                                                      The parser shifted to state 64                                          
Token Read           64       5       0       synthetic fabrics              Token type: Text                                                        
Shift                14                                                      The parser shifted to state 14                                          
Token Read           14       5      22   <                                  Token type: LeftArrow                                                   
Reduce               20                   (20) ::=     synthetic fabrics     <text-chunk> ::= Text                                                   
Reduce               19                   (21) ::= (20)                      <text> ::= <text-chunk>                                                 
Shift                27                                                      The parser shifted to state 27                                          
Token Read           27       5      23   WryZrSIJ                           Token type: Text                                                        
Shift                14                                                      The parser shifted to state 14                                          
Token Read           14       5      31   >                                  Token type: RightArrow                                                  
Reduce               20                   (22) ::= WryZrSIJ                  <text-chunk> ::= Text                                                   
Reduce               45                   (23) ::= (22)                      <text> ::= <text-chunk>                                                 
Shift                71                                                      The parser shifted to state 71                                          
Token Read           71       5      32   ;                                  Token type: Terminator                                                  
Reduce               31                   (24) ::= < (23) >                  <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               93                   (25) ::= (21) (24)                 <item> ::= <text> <tag>                                                 
Reduce               94                   (26) ::= (19) , (25)               <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               39                   (27) ::= (13) , (26)               <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                66                                                      The parser shifted to state 66                                          
Token Read           66       6       0                                      Token type: EOF                                                         
Reduce               15                   (28) ::= (6) (7) (27) ;            <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               18                   (29) ::= (28)                      <scripture> ::= <expression>                                            
Accept               18                                                                                                                              



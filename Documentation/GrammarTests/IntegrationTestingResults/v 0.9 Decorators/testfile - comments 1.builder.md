========================================
Source Code (between the arrows)
========================================

🡆fabrics <KvtgGtnv>[] -> //comment here [https://www.notube.com/watch?v=hTui12lKus] {decorator} 

    wool fabrics <rUEqmXfk>[https://www.notube.com/watch?v=hTui12lKus] {decorator},
    cotton fabrics [https://www.notube.com/watch?v=hTui12lKus]{decorator}<wpra8mUV>,
    silk fabrics <VFoIEr0T>[],
    synthetic fabrics <oI5DOuPh>;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  +--<item> ::= <text> <tag> Link
|  |  |  +--<text> ::= <text-chunk>
|  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  +--fabrics 
|  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  +--<
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--KvtgGtnv
|  |  |  |  +-->
|  |  |  +--[]
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  +--<item> ::= <text> <tag> Link Decorator
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--    wool fabrics 
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--rUEqmXfk
|  |  |  |  |  +-->
|  |  |  |  +--[https://www.notube.com/watch?v=hTui12lKus]
|  |  |  |  +--{decorator}
|  |  |  +--,
|  |  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  |  +--<item> ::= <text> Link Decorator <tag>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    cotton fabrics 
|  |  |  |  |  +--[https://www.notube.com/watch?v=hTui12lKus]
|  |  |  |  |  +--{decorator}
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--wpra8mUV
|  |  |  |  |  |  +-->
|  |  |  |  +--,
|  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  +--<item> ::= <text> <tag> Link
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    silk fabrics 
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--VFoIEr0T
|  |  |  |  |  |  |  +-->
|  |  |  |  |  |  +--[]
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

Parse Action      State    Line     Col   Parse Value                                                                   Description                                                             
---------------   -----   -----   -----   ---------------------------------------------------------------------------   ------------------------------------------------------------------------
Token Read            0       0       0   fabrics                                                                       Token type: Text                                                        
Shift                14                                                                                                 The parser shifted to state 14                                          
Token Read           14       0       8   <                                                                             Token type: LeftArrow                                                   
Reduce               20                   (1) ::= fabrics                                                               <text-chunk> ::= Text                                                   
Reduce               19                   (2) ::= (1)                                                                   <text> ::= <text-chunk>                                                 
Shift                27                                                                                                 The parser shifted to state 27                                          
Token Read           27       0       9   KvtgGtnv                                                                      Token type: Text                                                        
Shift                14                                                                                                 The parser shifted to state 14                                          
Token Read           14       0      17   >                                                                             Token type: RightArrow                                                  
Reduce               20                   (3) ::= KvtgGtnv                                                              <text-chunk> ::= Text                                                   
Reduce               45                   (4) ::= (3)                                                                   <text> ::= <text-chunk>                                                 
Shift                71                                                                                                 The parser shifted to state 71                                          
Token Read           71       0      18   []                                                                            Token type: Link                                                        
Reduce               31                   (5) ::= < (4) >                                                               <tag> ::= LeftArrow <text> RightArrow                                   
Shift                58                                                                                                 The parser shifted to state 58                                          
Token Read           58       0      21   -                                                                             Token type: Hyphen                                                      
Reduce               17                   (6) ::= (2) (5) []                                                            <item> ::= <text> <tag> Link                                            
Shift                24                                                                                                 The parser shifted to state 24                                          
Token Read           24       0      22   >                                                                             Token type: RightArrow                                                  
Shift                34                                                                                                 The parser shifted to state 34                                          
Token Read           34       2       0       wool fabrics                                                              Token type: Text                                                        
Reduce               25                   (7) ::= - >                                                                   <producer> ::= Hyphen RightArrow                                        
Shift                14                                                                                                 The parser shifted to state 14                                          
Token Read           14       2      17   <                                                                             Token type: LeftArrow                                                   
Reduce               20                   (8) ::=     wool fabrics                                                      <text-chunk> ::= Text                                                   
Reduce               19                   (9) ::= (8)                                                                   <text> ::= <text-chunk>                                                 
Shift                27                                                                                                 The parser shifted to state 27                                          
Token Read           27       2      18   rUEqmXfk                                                                      Token type: Text                                                        
Shift                14                                                                                                 The parser shifted to state 14                                          
Token Read           14       2      26   >                                                                             Token type: RightArrow                                                  
Reduce               20                   (10) ::= rUEqmXfk                                                             <text-chunk> ::= Text                                                   
Reduce               45                   (11) ::= (10)                                                                 <text> ::= <text-chunk>                                                 
Shift                71                                                                                                 The parser shifted to state 71                                          
Token Read           71       2      27   [https://www.notube.com/watch?v=hTui12lKus]                                   Token type: Link                                                        
Reduce               31                   (12) ::= < (11) >                                                             <tag> ::= LeftArrow <text> RightArrow                                   
Shift                58                                                                                                 The parser shifted to state 58                                          
Token Read           58       2      71   {decorator}                                                                   Token type: Decorator                                                   
Shift                86                                                                                                 The parser shifted to state 86                                          
Token Read           86       2      82   ,                                                                             Token type: Separator                                                   
Reduce               37                   (13) ::= (9) (12) [https://www.notube.com/watch?v=hTui12lKus] {decorator}     <item> ::= <text> <tag> Link Decorator                                  
Shift                64                                                                                                 The parser shifted to state 64                                          
Token Read           64       3       0       cotton fabrics                                                            Token type: Text                                                        
Shift                14                                                                                                 The parser shifted to state 14                                          
Token Read           14       3      19   [https://www.notube.com/watch?v=hTui12lKus]                                   Token type: Link                                                        
Reduce               20                   (14) ::=     cotton fabrics                                                   <text-chunk> ::= Text                                                   
Reduce               19                   (15) ::= (14)                                                                 <text> ::= <text-chunk>                                                 
Shift                28                                                                                                 The parser shifted to state 28                                          
Token Read           28       3      62   {decorator}                                                                   Token type: Decorator                                                   
Shift                46                                                                                                 The parser shifted to state 46                                          
Token Read           46       3      73   <                                                                             Token type: LeftArrow                                                   
Shift                27                                                                                                 The parser shifted to state 27                                          
Token Read           27       3      74   wpra8mUV                                                                      Token type: Text                                                        
Shift                14                                                                                                 The parser shifted to state 14                                          
Token Read           14       3      82   >                                                                             Token type: RightArrow                                                  
Reduce               20                   (16) ::= wpra8mUV                                                             <text-chunk> ::= Text                                                   
Reduce               45                   (17) ::= (16)                                                                 <text> ::= <text-chunk>                                                 
Shift                71                                                                                                 The parser shifted to state 71                                          
Token Read           71       3      83   ,                                                                             Token type: Separator                                                   
Reduce               72                   (18) ::= < (17) >                                                             <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               93                   (19) ::= (15) [https://www.notube.com/watch?v=hTui12lKus] {decorator} (18)    <item> ::= <text> Link Decorator <tag>                                  
Shift                64                                                                                                 The parser shifted to state 64                                          
Token Read           64       4       0       silk fabrics                                                              Token type: Text                                                        
Shift                14                                                                                                 The parser shifted to state 14                                          
Token Read           14       4      17   <                                                                             Token type: LeftArrow                                                   
Reduce               20                   (20) ::=     silk fabrics                                                     <text-chunk> ::= Text                                                   
Reduce               19                   (21) ::= (20)                                                                 <text> ::= <text-chunk>                                                 
Shift                27                                                                                                 The parser shifted to state 27                                          
Token Read           27       4      18   VFoIEr0T                                                                      Token type: Text                                                        
Shift                14                                                                                                 The parser shifted to state 14                                          
Token Read           14       4      26   >                                                                             Token type: RightArrow                                                  
Reduce               20                   (22) ::= VFoIEr0T                                                             <text-chunk> ::= Text                                                   
Reduce               45                   (23) ::= (22)                                                                 <text> ::= <text-chunk>                                                 
Shift                71                                                                                                 The parser shifted to state 71                                          
Token Read           71       4      27   []                                                                            Token type: Link                                                        
Reduce               31                   (24) ::= < (23) >                                                             <tag> ::= LeftArrow <text> RightArrow                                   
Shift                58                                                                                                 The parser shifted to state 58                                          
Token Read           58       4      29   ,                                                                             Token type: Separator                                                   
Reduce               93                   (25) ::= (21) (24) []                                                         <item> ::= <text> <tag> Link                                            
Shift                64                                                                                                 The parser shifted to state 64                                          
Token Read           64       5       0       synthetic fabrics                                                         Token type: Text                                                        
Shift                14                                                                                                 The parser shifted to state 14                                          
Token Read           14       5      22   <                                                                             Token type: LeftArrow                                                   
Reduce               20                   (26) ::=     synthetic fabrics                                                <text-chunk> ::= Text                                                   
Reduce               19                   (27) ::= (26)                                                                 <text> ::= <text-chunk>                                                 
Shift                27                                                                                                 The parser shifted to state 27                                          
Token Read           27       5      23   oI5DOuPh                                                                      Token type: Text                                                        
Shift                14                                                                                                 The parser shifted to state 14                                          
Token Read           14       5      31   >                                                                             Token type: RightArrow                                                  
Reduce               20                   (28) ::= oI5DOuPh                                                             <text-chunk> ::= Text                                                   
Reduce               45                   (29) ::= (28)                                                                 <text> ::= <text-chunk>                                                 
Shift                71                                                                                                 The parser shifted to state 71                                          
Token Read           71       5      32   ;                                                                             Token type: Terminator                                                  
Reduce               31                   (30) ::= < (29) >                                                             <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               93                   (31) ::= (27) (30)                                                            <item> ::= <text> <tag>                                                 
Reduce               94                   (32) ::= (25) , (31)                                                          <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               94                   (33) ::= (19) , (32)                                                          <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               39                   (34) ::= (13) , (33)                                                          <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                66                                                                                                 The parser shifted to state 66                                          
Token Read           66       6       0                                                                                 Token type: EOF                                                         
Reduce               15                   (35) ::= (6) (7) (34) ;                                                       <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               18                   (36) ::= (35)                                                                 <scripture> ::= <expression>                                            
Accept               18                                                                                                                                                                         



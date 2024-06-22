========================================
Source Code (between the arrows)
========================================

🡆fabrics <KvtgGtnv>[] -> //comment here [https://www.notube.com/watch?v=hTui12lKus]

    wool fabrics <rUEqmXfk>[https://www.notube.com/watch?v=hTui12lKus],
    cotton fabrics [https://www.notube.com/watch?v=hTui12lKus]<wpra8mUV>,
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
|  |  |  +--<item> ::= <text> <tag> Link
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
|  |  |  +--,
|  |  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  |  +--<item> ::= <text> Link <tag>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    cotton fabrics 
|  |  |  |  |  +--[https://www.notube.com/watch?v=hTui12lKus]
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

Parse Action      State    Line     Col   Parse Value                                                       Description                                                             
---------------   -----   -----   -----   ---------------------------------------------------------------   ------------------------------------------------------------------------
Token Read            0       0       0   fabrics                                                           Token type: Text                                                        
Shift                12                                                                                     The parser shifted to state 12                                          
Token Read           12       0       8   <                                                                 Token type: LeftArrow                                                   
Reduce               18                   (1) ::= fabrics                                                   <text-chunk> ::= Text                                                   
Reduce               17                   (2) ::= (1)                                                       <text> ::= <text-chunk>                                                 
Shift                24                                                                                     The parser shifted to state 24                                          
Token Read           24       0       9   KvtgGtnv                                                          Token type: Text                                                        
Shift                12                                                                                     The parser shifted to state 12                                          
Token Read           12       0      17   >                                                                 Token type: RightArrow                                                  
Reduce               18                   (3) ::= KvtgGtnv                                                  <text-chunk> ::= Text                                                   
Reduce               36                   (4) ::= (3)                                                       <text> ::= <text-chunk>                                                 
Shift                49                                                                                     The parser shifted to state 49                                          
Token Read           49       0      18   []                                                                Token type: Link                                                        
Reduce               27                   (5) ::= < (4) >                                                   <tag> ::= LeftArrow <text> RightArrow                                   
Shift                41                                                                                     The parser shifted to state 41                                          
Token Read           41       0      21   -                                                                 Token type: Hyphen                                                      
Reduce               15                   (6) ::= (2) (5) []                                                <item> ::= <text> <tag> Link                                            
Shift                22                                                                                     The parser shifted to state 22                                          
Token Read           22       0      22   >                                                                 Token type: RightArrow                                                  
Shift                30                                                                                     The parser shifted to state 30                                          
Token Read           30       2       0       wool fabrics                                                  Token type: Text                                                        
Reduce               23                   (7) ::= - >                                                       <producer> ::= Hyphen RightArrow                                        
Shift                12                                                                                     The parser shifted to state 12                                          
Token Read           12       2      17   <                                                                 Token type: LeftArrow                                                   
Reduce               18                   (8) ::=     wool fabrics                                          <text-chunk> ::= Text                                                   
Reduce               17                   (9) ::= (8)                                                       <text> ::= <text-chunk>                                                 
Shift                24                                                                                     The parser shifted to state 24                                          
Token Read           24       2      18   rUEqmXfk                                                          Token type: Text                                                        
Shift                12                                                                                     The parser shifted to state 12                                          
Token Read           12       2      26   >                                                                 Token type: RightArrow                                                  
Reduce               18                   (10) ::= rUEqmXfk                                                 <text-chunk> ::= Text                                                   
Reduce               36                   (11) ::= (10)                                                     <text> ::= <text-chunk>                                                 
Shift                49                                                                                     The parser shifted to state 49                                          
Token Read           49       2      27   [https://www.notube.com/watch?v=hTui12lKus]                       Token type: Link                                                        
Reduce               27                   (12) ::= < (11) >                                                 <tag> ::= LeftArrow <text> RightArrow                                   
Shift                41                                                                                     The parser shifted to state 41                                          
Token Read           41       2      70   ,                                                                 Token type: Separator                                                   
Reduce               33                   (13) ::= (9) (12) [https://www.notube.com/watch?v=hTui12lKus]     <item> ::= <text> <tag> Link                                            
Shift                46                                                                                     The parser shifted to state 46                                          
Token Read           46       3       0       cotton fabrics                                                Token type: Text                                                        
Shift                12                                                                                     The parser shifted to state 12                                          
Token Read           12       3      19   [https://www.notube.com/watch?v=hTui12lKus]                       Token type: Link                                                        
Reduce               18                   (14) ::=     cotton fabrics                                       <text-chunk> ::= Text                                                   
Reduce               17                   (15) ::= (14)                                                     <text> ::= <text-chunk>                                                 
Shift                25                                                                                     The parser shifted to state 25                                          
Token Read           25       3      62   <                                                                 Token type: LeftArrow                                                   
Shift                24                                                                                     The parser shifted to state 24                                          
Token Read           24       3      63   wpra8mUV                                                          Token type: Text                                                        
Shift                12                                                                                     The parser shifted to state 12                                          
Token Read           12       3      71   >                                                                 Token type: RightArrow                                                  
Reduce               18                   (16) ::= wpra8mUV                                                 <text-chunk> ::= Text                                                   
Reduce               36                   (17) ::= (16)                                                     <text> ::= <text-chunk>                                                 
Shift                49                                                                                     The parser shifted to state 49                                          
Token Read           49       3      72   ,                                                                 Token type: Separator                                                   
Reduce               39                   (18) ::= < (17) >                                                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               51                   (19) ::= (15) [https://www.notube.com/watch?v=hTui12lKus] (18)    <item> ::= <text> Link <tag>                                            
Shift                46                                                                                     The parser shifted to state 46                                          
Token Read           46       4       0       silk fabrics                                                  Token type: Text                                                        
Shift                12                                                                                     The parser shifted to state 12                                          
Token Read           12       4      17   <                                                                 Token type: LeftArrow                                                   
Reduce               18                   (20) ::=     silk fabrics                                         <text-chunk> ::= Text                                                   
Reduce               17                   (21) ::= (20)                                                     <text> ::= <text-chunk>                                                 
Shift                24                                                                                     The parser shifted to state 24                                          
Token Read           24       4      18   VFoIEr0T                                                          Token type: Text                                                        
Shift                12                                                                                     The parser shifted to state 12                                          
Token Read           12       4      26   >                                                                 Token type: RightArrow                                                  
Reduce               18                   (22) ::= VFoIEr0T                                                 <text-chunk> ::= Text                                                   
Reduce               36                   (23) ::= (22)                                                     <text> ::= <text-chunk>                                                 
Shift                49                                                                                     The parser shifted to state 49                                          
Token Read           49       4      27   []                                                                Token type: Link                                                        
Reduce               27                   (24) ::= < (23) >                                                 <tag> ::= LeftArrow <text> RightArrow                                   
Shift                41                                                                                     The parser shifted to state 41                                          
Token Read           41       4      29   ,                                                                 Token type: Separator                                                   
Reduce               51                   (25) ::= (21) (24) []                                             <item> ::= <text> <tag> Link                                            
Shift                46                                                                                     The parser shifted to state 46                                          
Token Read           46       5       0       synthetic fabrics                                             Token type: Text                                                        
Shift                12                                                                                     The parser shifted to state 12                                          
Token Read           12       5      22   <                                                                 Token type: LeftArrow                                                   
Reduce               18                   (26) ::=     synthetic fabrics                                    <text-chunk> ::= Text                                                   
Reduce               17                   (27) ::= (26)                                                     <text> ::= <text-chunk>                                                 
Shift                24                                                                                     The parser shifted to state 24                                          
Token Read           24       5      23   oI5DOuPh                                                          Token type: Text                                                        
Shift                12                                                                                     The parser shifted to state 12                                          
Token Read           12       5      31   >                                                                 Token type: RightArrow                                                  
Reduce               18                   (28) ::= oI5DOuPh                                                 <text-chunk> ::= Text                                                   
Reduce               36                   (29) ::= (28)                                                     <text> ::= <text-chunk>                                                 
Shift                49                                                                                     The parser shifted to state 49                                          
Token Read           49       5      32   ;                                                                 Token type: Terminator                                                  
Reduce               27                   (30) ::= < (29) >                                                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               51                   (31) ::= (27) (30)                                                <item> ::= <text> <tag>                                                 
Reduce               52                   (32) ::= (25) , (31)                                              <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               52                   (33) ::= (19) , (32)                                              <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               35                   (34) ::= (13) , (33)                                              <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                48                                                                                     The parser shifted to state 48                                          
Token Read           48       6       0                                                                     Token type: EOF                                                         
Reduce               13                   (35) ::= (6) (7) (34) ;                                           <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               16                   (36) ::= (35)                                                     <scripture> ::= <expression>                                            
Accept               16                                                                                                                                                             



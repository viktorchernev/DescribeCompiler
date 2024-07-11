========================================
Source Code (between the arrows)
========================================

🡆fabrics <qJobcYNC> -> //comment here

    wool fabrics <WmtITd8B>[https://www.notube.com/watch?v=hTui12lKus],
    cotton fabrics <KGkvDUZH>[https://www.notube.com/watch?v=hTui12lKus],
    silk fabrics <BbiZz4Ie>[https://www.notube.com/watch?v=hTui12lKus],
    synthetic fabrics <gCWv1P46>[https://www.notube.com/watch?v=hTui12lKus];

//comment last🡄

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
|  |  |  |  |  |  +--qJobcYNC
|  |  |  |  +-->
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
|  |  |  |  |  |  |  +--WmtITd8B
|  |  |  |  |  +-->
|  |  |  |  +--[https://www.notube.com/watch?v=hTui12lKus]
|  |  |  +--,
|  |  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  |  +--<item> ::= <text> <tag> Link
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    cotton fabrics 
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--KGkvDUZH
|  |  |  |  |  |  +-->
|  |  |  |  |  +--[https://www.notube.com/watch?v=hTui12lKus]
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
|  |  |  |  |  |  |  |  |  +--BbiZz4Ie
|  |  |  |  |  |  |  +-->
|  |  |  |  |  |  +--[https://www.notube.com/watch?v=hTui12lKus]
|  |  |  |  |  +--,
|  |  |  |  |  +--<item> ::= <text> <tag> Link
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    synthetic fabrics 
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--gCWv1P46
|  |  |  |  |  |  |  +-->
|  |  |  |  |  |  +--[https://www.notube.com/watch?v=hTui12lKus]
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
Token Read           24       0       9   qJobcYNC                                                          Token type: Text                                                        
Shift                12                                                                                     The parser shifted to state 12                                          
Token Read           12       0      17   >                                                                 Token type: RightArrow                                                  
Reduce               18                   (3) ::= qJobcYNC                                                  <text-chunk> ::= Text                                                   
Reduce               36                   (4) ::= (3)                                                       <text> ::= <text-chunk>                                                 
Shift                49                                                                                     The parser shifted to state 49                                          
Token Read           49       0      19   -                                                                 Token type: Hyphen                                                      
Reduce               27                   (5) ::= < (4) >                                                   <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               15                   (6) ::= (2) (5)                                                   <item> ::= <text> <tag>                                                 
Shift                22                                                                                     The parser shifted to state 22                                          
Token Read           22       0      20   >                                                                 Token type: RightArrow                                                  
Shift                30                                                                                     The parser shifted to state 30                                          
Token Read           30       2       0       wool fabrics                                                  Token type: Text                                                        
Reduce               23                   (7) ::= - >                                                       <producer> ::= Hyphen RightArrow                                        
Shift                12                                                                                     The parser shifted to state 12                                          
Token Read           12       2      17   <                                                                 Token type: LeftArrow                                                   
Reduce               18                   (8) ::=     wool fabrics                                          <text-chunk> ::= Text                                                   
Reduce               17                   (9) ::= (8)                                                       <text> ::= <text-chunk>                                                 
Shift                24                                                                                     The parser shifted to state 24                                          
Token Read           24       2      18   WmtITd8B                                                          Token type: Text                                                        
Shift                12                                                                                     The parser shifted to state 12                                          
Token Read           12       2      26   >                                                                 Token type: RightArrow                                                  
Reduce               18                   (10) ::= WmtITd8B                                                 <text-chunk> ::= Text                                                   
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
Token Read           12       3      19   <                                                                 Token type: LeftArrow                                                   
Reduce               18                   (14) ::=     cotton fabrics                                       <text-chunk> ::= Text                                                   
Reduce               17                   (15) ::= (14)                                                     <text> ::= <text-chunk>                                                 
Shift                24                                                                                     The parser shifted to state 24                                          
Token Read           24       3      20   KGkvDUZH                                                          Token type: Text                                                        
Shift                12                                                                                     The parser shifted to state 12                                          
Token Read           12       3      28   >                                                                 Token type: RightArrow                                                  
Reduce               18                   (16) ::= KGkvDUZH                                                 <text-chunk> ::= Text                                                   
Reduce               36                   (17) ::= (16)                                                     <text> ::= <text-chunk>                                                 
Shift                49                                                                                     The parser shifted to state 49                                          
Token Read           49       3      29   [https://www.notube.com/watch?v=hTui12lKus]                       Token type: Link                                                        
Reduce               27                   (18) ::= < (17) >                                                 <tag> ::= LeftArrow <text> RightArrow                                   
Shift                41                                                                                     The parser shifted to state 41                                          
Token Read           41       3      72   ,                                                                 Token type: Separator                                                   
Reduce               51                   (19) ::= (15) (18) [https://www.notube.com/watch?v=hTui12lKus]    <item> ::= <text> <tag> Link                                            
Shift                46                                                                                     The parser shifted to state 46                                          
Token Read           46       4       0       silk fabrics                                                  Token type: Text                                                        
Shift                12                                                                                     The parser shifted to state 12                                          
Token Read           12       4      17   <                                                                 Token type: LeftArrow                                                   
Reduce               18                   (20) ::=     silk fabrics                                         <text-chunk> ::= Text                                                   
Reduce               17                   (21) ::= (20)                                                     <text> ::= <text-chunk>                                                 
Shift                24                                                                                     The parser shifted to state 24                                          
Token Read           24       4      18   BbiZz4Ie                                                          Token type: Text                                                        
Shift                12                                                                                     The parser shifted to state 12                                          
Token Read           12       4      26   >                                                                 Token type: RightArrow                                                  
Reduce               18                   (22) ::= BbiZz4Ie                                                 <text-chunk> ::= Text                                                   
Reduce               36                   (23) ::= (22)                                                     <text> ::= <text-chunk>                                                 
Shift                49                                                                                     The parser shifted to state 49                                          
Token Read           49       4      27   [https://www.notube.com/watch?v=hTui12lKus]                       Token type: Link                                                        
Reduce               27                   (24) ::= < (23) >                                                 <tag> ::= LeftArrow <text> RightArrow                                   
Shift                41                                                                                     The parser shifted to state 41                                          
Token Read           41       4      70   ,                                                                 Token type: Separator                                                   
Reduce               51                   (25) ::= (21) (24) [https://www.notube.com/watch?v=hTui12lKus]    <item> ::= <text> <tag> Link                                            
Shift                46                                                                                     The parser shifted to state 46                                          
Token Read           46       5       0       synthetic fabrics                                             Token type: Text                                                        
Shift                12                                                                                     The parser shifted to state 12                                          
Token Read           12       5      22   <                                                                 Token type: LeftArrow                                                   
Reduce               18                   (26) ::=     synthetic fabrics                                    <text-chunk> ::= Text                                                   
Reduce               17                   (27) ::= (26)                                                     <text> ::= <text-chunk>                                                 
Shift                24                                                                                     The parser shifted to state 24                                          
Token Read           24       5      23   gCWv1P46                                                          Token type: Text                                                        
Shift                12                                                                                     The parser shifted to state 12                                          
Token Read           12       5      31   >                                                                 Token type: RightArrow                                                  
Reduce               18                   (28) ::= gCWv1P46                                                 <text-chunk> ::= Text                                                   
Reduce               36                   (29) ::= (28)                                                     <text> ::= <text-chunk>                                                 
Shift                49                                                                                     The parser shifted to state 49                                          
Token Read           49       5      32   [https://www.notube.com/watch?v=hTui12lKus]                       Token type: Link                                                        
Reduce               27                   (30) ::= < (29) >                                                 <tag> ::= LeftArrow <text> RightArrow                                   
Shift                41                                                                                     The parser shifted to state 41                                          
Token Read           41       5      75   ;                                                                 Token type: Terminator                                                  
Reduce               51                   (31) ::= (27) (30) [https://www.notube.com/watch?v=hTui12lKus]    <item> ::= <text> <tag> Link                                            
Reduce               52                   (32) ::= (25) , (31)                                              <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               52                   (33) ::= (19) , (32)                                              <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               35                   (34) ::= (13) , (33)                                              <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                48                                                                                     The parser shifted to state 48                                          
Token Read           48       8       0                                                                     Token type: EOF                                                         
Reduce               13                   (35) ::= (6) (7) (34) ;                                           <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               16                   (36) ::= (35)                                                     <scripture> ::= <expression>                                            
Accept               16                                                                                                                                                             



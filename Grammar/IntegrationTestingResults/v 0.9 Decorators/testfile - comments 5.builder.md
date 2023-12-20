========================================
Source Code (between the arrows)
========================================

🡆fabrics <xpXWehDW> [https://www.notube.com/watch?v=hTui12lKus]-> //comment here {decorator}

    wool fabrics <TcD3LcoW>,
    cotton fabrics[https://www.notube.com/watch?v=hTui12lKus] <thZBzyNc>,
    silk fabrics <dOlQGMJ4>[https://www.notube.com/watch?v=hTui12lKus],
    synthetic fabrics <Ln7Y7Dme>[https://www.notube.com/watch?v=hTui12lKus];//comment last🡄

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
|  |  |  |  |  |  +--xpXWehDW
|  |  |  |  +-->
|  |  |  +--[https://www.notube.com/watch?v=hTui12lKus]
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
|  |  |  |  |  |  |  +--TcD3LcoW
|  |  |  |  |  +-->
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
|  |  |  |  |  |  |  |  +--thZBzyNc
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
|  |  |  |  |  |  |  |  |  +--dOlQGMJ4
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
|  |  |  |  |  |  |  |  |  +--Ln7Y7Dme
|  |  |  |  |  |  |  +-->
|  |  |  |  |  |  +--[https://www.notube.com/watch?v=hTui12lKus]
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                                                       Description                                                             
---------------   -----   -----   -----   ---------------------------------------------------------------   ------------------------------------------------------------------------
Token Read            0       0       0   fabrics                                                           Token type: Text                                                        
Shift                14                                                                                     The parser shifted to state 14                                          
Token Read           14       0       8   <                                                                 Token type: LeftArrow                                                   
Reduce               20                   (1) ::= fabrics                                                   <text-chunk> ::= Text                                                   
Reduce               19                   (2) ::= (1)                                                       <text> ::= <text-chunk>                                                 
Shift                27                                                                                     The parser shifted to state 27                                          
Token Read           27       0       9   xpXWehDW                                                          Token type: Text                                                        
Shift                14                                                                                     The parser shifted to state 14                                          
Token Read           14       0      17   >                                                                 Token type: RightArrow                                                  
Reduce               20                   (3) ::= xpXWehDW                                                  <text-chunk> ::= Text                                                   
Reduce               45                   (4) ::= (3)                                                       <text> ::= <text-chunk>                                                 
Shift                71                                                                                     The parser shifted to state 71                                          
Token Read           71       0      19   [https://www.notube.com/watch?v=hTui12lKus]                       Token type: Link                                                        
Reduce               31                   (5) ::= < (4) >                                                   <tag> ::= LeftArrow <text> RightArrow                                   
Shift                58                                                                                     The parser shifted to state 58                                          
Token Read           58       0      62   -                                                                 Token type: Hyphen                                                      
Reduce               17                   (6) ::= (2) (5) [https://www.notube.com/watch?v=hTui12lKus]       <item> ::= <text> <tag> Link                                            
Shift                24                                                                                     The parser shifted to state 24                                          
Token Read           24       0      63   >                                                                 Token type: RightArrow                                                  
Shift                34                                                                                     The parser shifted to state 34                                          
Token Read           34       2       0       wool fabrics                                                  Token type: Text                                                        
Reduce               25                   (7) ::= - >                                                       <producer> ::= Hyphen RightArrow                                        
Shift                14                                                                                     The parser shifted to state 14                                          
Token Read           14       2      17   <                                                                 Token type: LeftArrow                                                   
Reduce               20                   (8) ::=     wool fabrics                                          <text-chunk> ::= Text                                                   
Reduce               19                   (9) ::= (8)                                                       <text> ::= <text-chunk>                                                 
Shift                27                                                                                     The parser shifted to state 27                                          
Token Read           27       2      18   TcD3LcoW                                                          Token type: Text                                                        
Shift                14                                                                                     The parser shifted to state 14                                          
Token Read           14       2      26   >                                                                 Token type: RightArrow                                                  
Reduce               20                   (10) ::= TcD3LcoW                                                 <text-chunk> ::= Text                                                   
Reduce               45                   (11) ::= (10)                                                     <text> ::= <text-chunk>                                                 
Shift                71                                                                                     The parser shifted to state 71                                          
Token Read           71       2      27   ,                                                                 Token type: Separator                                                   
Reduce               31                   (12) ::= < (11) >                                                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               37                   (13) ::= (9) (12)                                                 <item> ::= <text> <tag>                                                 
Shift                64                                                                                     The parser shifted to state 64                                          
Token Read           64       3       0       cotton fabrics                                                Token type: Text                                                        
Shift                14                                                                                     The parser shifted to state 14                                          
Token Read           14       3      18   [https://www.notube.com/watch?v=hTui12lKus]                       Token type: Link                                                        
Reduce               20                   (14) ::=     cotton fabrics                                       <text-chunk> ::= Text                                                   
Reduce               19                   (15) ::= (14)                                                     <text> ::= <text-chunk>                                                 
Shift                28                                                                                     The parser shifted to state 28                                          
Token Read           28       3      62   <                                                                 Token type: LeftArrow                                                   
Shift                27                                                                                     The parser shifted to state 27                                          
Token Read           27       3      63   thZBzyNc                                                          Token type: Text                                                        
Shift                14                                                                                     The parser shifted to state 14                                          
Token Read           14       3      71   >                                                                 Token type: RightArrow                                                  
Reduce               20                   (16) ::= thZBzyNc                                                 <text-chunk> ::= Text                                                   
Reduce               45                   (17) ::= (16)                                                     <text> ::= <text-chunk>                                                 
Shift                71                                                                                     The parser shifted to state 71                                          
Token Read           71       3      72   ,                                                                 Token type: Separator                                                   
Reduce               50                   (18) ::= < (17) >                                                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               93                   (19) ::= (15) [https://www.notube.com/watch?v=hTui12lKus] (18)    <item> ::= <text> Link <tag>                                            
Shift                64                                                                                     The parser shifted to state 64                                          
Token Read           64       4       0       silk fabrics                                                  Token type: Text                                                        
Shift                14                                                                                     The parser shifted to state 14                                          
Token Read           14       4      17   <                                                                 Token type: LeftArrow                                                   
Reduce               20                   (20) ::=     silk fabrics                                         <text-chunk> ::= Text                                                   
Reduce               19                   (21) ::= (20)                                                     <text> ::= <text-chunk>                                                 
Shift                27                                                                                     The parser shifted to state 27                                          
Token Read           27       4      18   dOlQGMJ4                                                          Token type: Text                                                        
Shift                14                                                                                     The parser shifted to state 14                                          
Token Read           14       4      26   >                                                                 Token type: RightArrow                                                  
Reduce               20                   (22) ::= dOlQGMJ4                                                 <text-chunk> ::= Text                                                   
Reduce               45                   (23) ::= (22)                                                     <text> ::= <text-chunk>                                                 
Shift                71                                                                                     The parser shifted to state 71                                          
Token Read           71       4      27   [https://www.notube.com/watch?v=hTui12lKus]                       Token type: Link                                                        
Reduce               31                   (24) ::= < (23) >                                                 <tag> ::= LeftArrow <text> RightArrow                                   
Shift                58                                                                                     The parser shifted to state 58                                          
Token Read           58       4      70   ,                                                                 Token type: Separator                                                   
Reduce               93                   (25) ::= (21) (24) [https://www.notube.com/watch?v=hTui12lKus]    <item> ::= <text> <tag> Link                                            
Shift                64                                                                                     The parser shifted to state 64                                          
Token Read           64       5       0       synthetic fabrics                                             Token type: Text                                                        
Shift                14                                                                                     The parser shifted to state 14                                          
Token Read           14       5      22   <                                                                 Token type: LeftArrow                                                   
Reduce               20                   (26) ::=     synthetic fabrics                                    <text-chunk> ::= Text                                                   
Reduce               19                   (27) ::= (26)                                                     <text> ::= <text-chunk>                                                 
Shift                27                                                                                     The parser shifted to state 27                                          
Token Read           27       5      23   Ln7Y7Dme                                                          Token type: Text                                                        
Shift                14                                                                                     The parser shifted to state 14                                          
Token Read           14       5      31   >                                                                 Token type: RightArrow                                                  
Reduce               20                   (28) ::= Ln7Y7Dme                                                 <text-chunk> ::= Text                                                   
Reduce               45                   (29) ::= (28)                                                     <text> ::= <text-chunk>                                                 
Shift                71                                                                                     The parser shifted to state 71                                          
Token Read           71       5      32   [https://www.notube.com/watch?v=hTui12lKus]                       Token type: Link                                                        
Reduce               31                   (30) ::= < (29) >                                                 <tag> ::= LeftArrow <text> RightArrow                                   
Shift                58                                                                                     The parser shifted to state 58                                          
Token Read           58       5      75   ;                                                                 Token type: Terminator                                                  
Reduce               93                   (31) ::= (27) (30) [https://www.notube.com/watch?v=hTui12lKus]    <item> ::= <text> <tag> Link                                            
Reduce               94                   (32) ::= (25) , (31)                                              <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               94                   (33) ::= (19) , (32)                                              <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               39                   (34) ::= (13) , (33)                                              <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                66                                                                                     The parser shifted to state 66                                          
Token Read           66       6       0                                                                     Token type: EOF                                                         
Reduce               15                   (35) ::= (6) (7) (34) ;                                           <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               18                   (36) ::= (35)                                                     <scripture> ::= <expression>                                            
Accept               18                                                                                                                                                             



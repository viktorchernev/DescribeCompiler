========================================
Source Code (between the arrows)
========================================

🡆fabrics [https://en.test.org/wiki/List_of_fabrics] <QpeudYXy> ->

	wool fabrics [https://en.test.org/wiki/Wool] {}<54vHCQwI>,
	cotton fabrics [https://en.test.org/wiki/Cotton]{} <Ll0bDtIQ>,
	silk fabrics {}[https://en.test.org/wiki/Silk]<6huM44Hm>,
	synthetic fabrics{} [https://en.test.org/wiki/Synthetic]<oAgVUPi0>;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  +--<item> ::= <text> Link <tag>
|  |  |  +--<text> ::= <text-chunk>
|  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  +--fabrics 
|  |  |  +--[https://en.test.org/wiki/List_of_fabrics]
|  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  +--<
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--QpeudYXy
|  |  |  |  +-->
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  +--<item> ::= <text> Link Decorator <tag>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--    wool fabrics 
|  |  |  |  +--[https://en.test.org/wiki/Wool]
|  |  |  |  +--{}
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--54vHCQwI
|  |  |  |  |  +-->
|  |  |  +--,
|  |  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  |  +--<item> ::= <text> Link Decorator <tag>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    cotton fabrics 
|  |  |  |  |  +--[https://en.test.org/wiki/Cotton]
|  |  |  |  |  +--{}
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--Ll0bDtIQ
|  |  |  |  |  |  +-->
|  |  |  |  +--,
|  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  +--<item> ::= <text> Decorator Link <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    silk fabrics 
|  |  |  |  |  |  +--{}
|  |  |  |  |  |  +--[https://en.test.org/wiki/Silk]
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--6huM44Hm
|  |  |  |  |  |  |  +-->
|  |  |  |  |  +--,
|  |  |  |  |  +--<item> ::= <text> Decorator Link <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    synthetic fabrics
|  |  |  |  |  |  +--{}
|  |  |  |  |  |  +--[https://en.test.org/wiki/Synthetic]
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--oAgVUPi0
|  |  |  |  |  |  |  +-->
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                                                   Description                                                             
---------------   -----   -----   -----   -----------------------------------------------------------   ------------------------------------------------------------------------
Token Read            0       0       0   fabrics                                                       Token type: Text                                                        
Shift                14                                                                                 The parser shifted to state 14                                          
Token Read           14       0       8   [https://en.test.org/wiki/List_of_fabrics]                    Token type: Link                                                        
Reduce               20                   (1) ::= fabrics                                               <text-chunk> ::= Text                                                   
Reduce               19                   (2) ::= (1)                                                   <text> ::= <text-chunk>                                                 
Shift                28                                                                                 The parser shifted to state 28                                          
Token Read           28       0      51   <                                                             Token type: LeftArrow                                                   
Shift                27                                                                                 The parser shifted to state 27                                          
Token Read           27       0      52   QpeudYXy                                                      Token type: Text                                                        
Shift                14                                                                                 The parser shifted to state 14                                          
Token Read           14       0      60   >                                                             Token type: RightArrow                                                  
Reduce               20                   (3) ::= QpeudYXy                                              <text-chunk> ::= Text                                                   
Reduce               45                   (4) ::= (3)                                                   <text> ::= <text-chunk>                                                 
Shift                71                                                                                 The parser shifted to state 71                                          
Token Read           71       0      62   -                                                             Token type: Hyphen                                                      
Reduce               50                   (5) ::= < (4) >                                               <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               17                   (6) ::= (2) [https://en.test.org/wiki/List_of_fabrics] (5)    <item> ::= <text> Link <tag>                                            
Shift                24                                                                                 The parser shifted to state 24                                          
Token Read           24       0      63   >                                                             Token type: RightArrow                                                  
Shift                34                                                                                 The parser shifted to state 34                                          
Token Read           34       2       0       wool fabrics                                              Token type: Text                                                        
Reduce               25                   (7) ::= - >                                                   <producer> ::= Hyphen RightArrow                                        
Shift                14                                                                                 The parser shifted to state 14                                          
Token Read           14       2      17   [https://en.test.org/wiki/Wool]                               Token type: Link                                                        
Reduce               20                   (8) ::=     wool fabrics                                      <text-chunk> ::= Text                                                   
Reduce               19                   (9) ::= (8)                                                   <text> ::= <text-chunk>                                                 
Shift                28                                                                                 The parser shifted to state 28                                          
Token Read           28       2      49   {}                                                            Token type: Decorator                                                   
Shift                46                                                                                 The parser shifted to state 46                                          
Token Read           46       2      51   <                                                             Token type: LeftArrow                                                   
Shift                27                                                                                 The parser shifted to state 27                                          
Token Read           27       2      52   54vHCQwI                                                      Token type: Text                                                        
Shift                14                                                                                 The parser shifted to state 14                                          
Token Read           14       2      60   >                                                             Token type: RightArrow                                                  
Reduce               20                   (10) ::= 54vHCQwI                                             <text-chunk> ::= Text                                                   
Reduce               45                   (11) ::= (10)                                                 <text> ::= <text-chunk>                                                 
Shift                71                                                                                 The parser shifted to state 71                                          
Token Read           71       2      61   ,                                                             Token type: Separator                                                   
Reduce               72                   (12) ::= < (11) >                                             <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               37                   (13) ::= (9) [https://en.test.org/wiki/Wool] {} (12)          <item> ::= <text> Link Decorator <tag>                                  
Shift                64                                                                                 The parser shifted to state 64                                          
Token Read           64       3       0       cotton fabrics                                            Token type: Text                                                        
Shift                14                                                                                 The parser shifted to state 14                                          
Token Read           14       3      19   [https://en.test.org/wiki/Cotton]                             Token type: Link                                                        
Reduce               20                   (14) ::=     cotton fabrics                                   <text-chunk> ::= Text                                                   
Reduce               19                   (15) ::= (14)                                                 <text> ::= <text-chunk>                                                 
Shift                28                                                                                 The parser shifted to state 28                                          
Token Read           28       3      52   {}                                                            Token type: Decorator                                                   
Shift                46                                                                                 The parser shifted to state 46                                          
Token Read           46       3      55   <                                                             Token type: LeftArrow                                                   
Shift                27                                                                                 The parser shifted to state 27                                          
Token Read           27       3      56   Ll0bDtIQ                                                      Token type: Text                                                        
Shift                14                                                                                 The parser shifted to state 14                                          
Token Read           14       3      64   >                                                             Token type: RightArrow                                                  
Reduce               20                   (16) ::= Ll0bDtIQ                                             <text-chunk> ::= Text                                                   
Reduce               45                   (17) ::= (16)                                                 <text> ::= <text-chunk>                                                 
Shift                71                                                                                 The parser shifted to state 71                                          
Token Read           71       3      65   ,                                                             Token type: Separator                                                   
Reduce               72                   (18) ::= < (17) >                                             <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               93                   (19) ::= (15) [https://en.test.org/wiki/Cotton] {} (18)       <item> ::= <text> Link Decorator <tag>                                  
Shift                64                                                                                 The parser shifted to state 64                                          
Token Read           64       4       0       silk fabrics                                              Token type: Text                                                        
Shift                14                                                                                 The parser shifted to state 14                                          
Token Read           14       4      17   {}                                                            Token type: Decorator                                                   
Reduce               20                   (20) ::=     silk fabrics                                     <text-chunk> ::= Text                                                   
Reduce               19                   (21) ::= (20)                                                 <text> ::= <text-chunk>                                                 
Shift                26                                                                                 The parser shifted to state 26                                          
Token Read           26       4      19   [https://en.test.org/wiki/Silk]                               Token type: Link                                                        
Shift                41                                                                                 The parser shifted to state 41                                          
Token Read           41       4      50   <                                                             Token type: LeftArrow                                                   
Shift                27                                                                                 The parser shifted to state 27                                          
Token Read           27       4      51   6huM44Hm                                                      Token type: Text                                                        
Shift                14                                                                                 The parser shifted to state 14                                          
Token Read           14       4      59   >                                                             Token type: RightArrow                                                  
Reduce               20                   (22) ::= 6huM44Hm                                             <text-chunk> ::= Text                                                   
Reduce               45                   (23) ::= (22)                                                 <text> ::= <text-chunk>                                                 
Shift                71                                                                                 The parser shifted to state 71                                          
Token Read           71       4      60   ,                                                             Token type: Separator                                                   
Reduce               67                   (24) ::= < (23) >                                             <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               93                   (25) ::= (21) {} [https://en.test.org/wiki/Silk] (24)         <item> ::= <text> Decorator Link <tag>                                  
Shift                64                                                                                 The parser shifted to state 64                                          
Token Read           64       5       0       synthetic fabrics                                         Token type: Text                                                        
Shift                14                                                                                 The parser shifted to state 14                                          
Token Read           14       5      21   {}                                                            Token type: Decorator                                                   
Reduce               20                   (26) ::=     synthetic fabrics                                <text-chunk> ::= Text                                                   
Reduce               19                   (27) ::= (26)                                                 <text> ::= <text-chunk>                                                 
Shift                26                                                                                 The parser shifted to state 26                                          
Token Read           26       5      24   [https://en.test.org/wiki/Synthetic]                          Token type: Link                                                        
Shift                41                                                                                 The parser shifted to state 41                                          
Token Read           41       5      60   <                                                             Token type: LeftArrow                                                   
Shift                27                                                                                 The parser shifted to state 27                                          
Token Read           27       5      61   oAgVUPi0                                                      Token type: Text                                                        
Shift                14                                                                                 The parser shifted to state 14                                          
Token Read           14       5      69   >                                                             Token type: RightArrow                                                  
Reduce               20                   (28) ::= oAgVUPi0                                             <text-chunk> ::= Text                                                   
Reduce               45                   (29) ::= (28)                                                 <text> ::= <text-chunk>                                                 
Shift                71                                                                                 The parser shifted to state 71                                          
Token Read           71       5      70   ;                                                             Token type: Terminator                                                  
Reduce               67                   (30) ::= < (29) >                                             <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               93                   (31) ::= (27) {} [https://en.test.org/wiki/Synthetic] (30)    <item> ::= <text> Decorator Link <tag>                                  
Reduce               94                   (32) ::= (25) , (31)                                          <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               94                   (33) ::= (19) , (32)                                          <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               39                   (34) ::= (13) , (33)                                          <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                66                                                                                 The parser shifted to state 66                                          
Token Read           66       6       0                                                                 Token type: EOF                                                         
Reduce               15                   (35) ::= (6) (7) (34) ;                                       <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               18                   (36) ::= (35)                                                 <scripture> ::= <expression>                                            
Accept               18                                                                                                                                                         



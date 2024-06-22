========================================
Source Code (between the arrows)
========================================

🡆fabrics [https://en.test.org/wiki/List_of_fabrics] <QpeudYXy> ->

	wool fabrics [https://en.test.org/wiki/Wool] <54vHCQwI>,
	cotton fabrics [https://en.test.org/wiki/Cotton] <Ll0bDtIQ>,
	silk fabrics [https://en.test.org/wiki/Silk]<6huM44Hm>,
	synthetic fabrics [https://en.test.org/wiki/Synthetic]<oAgVUPi0>;🡄

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
|  |  |  +--<item> ::= <text> Link <tag>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--    wool fabrics 
|  |  |  |  +--[https://en.test.org/wiki/Wool]
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--54vHCQwI
|  |  |  |  |  +-->
|  |  |  +--,
|  |  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  |  +--<item> ::= <text> Link <tag>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    cotton fabrics 
|  |  |  |  |  +--[https://en.test.org/wiki/Cotton]
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--Ll0bDtIQ
|  |  |  |  |  |  +-->
|  |  |  |  +--,
|  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  +--<item> ::= <text> Link <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    silk fabrics 
|  |  |  |  |  |  +--[https://en.test.org/wiki/Silk]
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--6huM44Hm
|  |  |  |  |  |  |  +-->
|  |  |  |  |  +--,
|  |  |  |  |  +--<item> ::= <text> Link <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    synthetic fabrics 
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
Shift                12                                                                                 The parser shifted to state 12                                          
Token Read           12       0       8   [https://en.test.org/wiki/List_of_fabrics]                    Token type: Link                                                        
Reduce               18                   (1) ::= fabrics                                               <text-chunk> ::= Text                                                   
Reduce               17                   (2) ::= (1)                                                   <text> ::= <text-chunk>                                                 
Shift                25                                                                                 The parser shifted to state 25                                          
Token Read           25       0      51   <                                                             Token type: LeftArrow                                                   
Shift                24                                                                                 The parser shifted to state 24                                          
Token Read           24       0      52   QpeudYXy                                                      Token type: Text                                                        
Shift                12                                                                                 The parser shifted to state 12                                          
Token Read           12       0      60   >                                                             Token type: RightArrow                                                  
Reduce               18                   (3) ::= QpeudYXy                                              <text-chunk> ::= Text                                                   
Reduce               36                   (4) ::= (3)                                                   <text> ::= <text-chunk>                                                 
Shift                49                                                                                 The parser shifted to state 49                                          
Token Read           49       0      62   -                                                             Token type: Hyphen                                                      
Reduce               39                   (5) ::= < (4) >                                               <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               15                   (6) ::= (2) [https://en.test.org/wiki/List_of_fabrics] (5)    <item> ::= <text> Link <tag>                                            
Shift                22                                                                                 The parser shifted to state 22                                          
Token Read           22       0      63   >                                                             Token type: RightArrow                                                  
Shift                30                                                                                 The parser shifted to state 30                                          
Token Read           30       2       0       wool fabrics                                              Token type: Text                                                        
Reduce               23                   (7) ::= - >                                                   <producer> ::= Hyphen RightArrow                                        
Shift                12                                                                                 The parser shifted to state 12                                          
Token Read           12       2      17   [https://en.test.org/wiki/Wool]                               Token type: Link                                                        
Reduce               18                   (8) ::=     wool fabrics                                      <text-chunk> ::= Text                                                   
Reduce               17                   (9) ::= (8)                                                   <text> ::= <text-chunk>                                                 
Shift                25                                                                                 The parser shifted to state 25                                          
Token Read           25       2      49   <                                                             Token type: LeftArrow                                                   
Shift                24                                                                                 The parser shifted to state 24                                          
Token Read           24       2      50   54vHCQwI                                                      Token type: Text                                                        
Shift                12                                                                                 The parser shifted to state 12                                          
Token Read           12       2      58   >                                                             Token type: RightArrow                                                  
Reduce               18                   (10) ::= 54vHCQwI                                             <text-chunk> ::= Text                                                   
Reduce               36                   (11) ::= (10)                                                 <text> ::= <text-chunk>                                                 
Shift                49                                                                                 The parser shifted to state 49                                          
Token Read           49       2      59   ,                                                             Token type: Separator                                                   
Reduce               39                   (12) ::= < (11) >                                             <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (13) ::= (9) [https://en.test.org/wiki/Wool] (12)             <item> ::= <text> Link <tag>                                            
Shift                46                                                                                 The parser shifted to state 46                                          
Token Read           46       3       0       cotton fabrics                                            Token type: Text                                                        
Shift                12                                                                                 The parser shifted to state 12                                          
Token Read           12       3      19   [https://en.test.org/wiki/Cotton]                             Token type: Link                                                        
Reduce               18                   (14) ::=     cotton fabrics                                   <text-chunk> ::= Text                                                   
Reduce               17                   (15) ::= (14)                                                 <text> ::= <text-chunk>                                                 
Shift                25                                                                                 The parser shifted to state 25                                          
Token Read           25       3      53   <                                                             Token type: LeftArrow                                                   
Shift                24                                                                                 The parser shifted to state 24                                          
Token Read           24       3      54   Ll0bDtIQ                                                      Token type: Text                                                        
Shift                12                                                                                 The parser shifted to state 12                                          
Token Read           12       3      62   >                                                             Token type: RightArrow                                                  
Reduce               18                   (16) ::= Ll0bDtIQ                                             <text-chunk> ::= Text                                                   
Reduce               36                   (17) ::= (16)                                                 <text> ::= <text-chunk>                                                 
Shift                49                                                                                 The parser shifted to state 49                                          
Token Read           49       3      63   ,                                                             Token type: Separator                                                   
Reduce               39                   (18) ::= < (17) >                                             <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               51                   (19) ::= (15) [https://en.test.org/wiki/Cotton] (18)          <item> ::= <text> Link <tag>                                            
Shift                46                                                                                 The parser shifted to state 46                                          
Token Read           46       4       0       silk fabrics                                              Token type: Text                                                        
Shift                12                                                                                 The parser shifted to state 12                                          
Token Read           12       4      17   [https://en.test.org/wiki/Silk]                               Token type: Link                                                        
Reduce               18                   (20) ::=     silk fabrics                                     <text-chunk> ::= Text                                                   
Reduce               17                   (21) ::= (20)                                                 <text> ::= <text-chunk>                                                 
Shift                25                                                                                 The parser shifted to state 25                                          
Token Read           25       4      48   <                                                             Token type: LeftArrow                                                   
Shift                24                                                                                 The parser shifted to state 24                                          
Token Read           24       4      49   6huM44Hm                                                      Token type: Text                                                        
Shift                12                                                                                 The parser shifted to state 12                                          
Token Read           12       4      57   >                                                             Token type: RightArrow                                                  
Reduce               18                   (22) ::= 6huM44Hm                                             <text-chunk> ::= Text                                                   
Reduce               36                   (23) ::= (22)                                                 <text> ::= <text-chunk>                                                 
Shift                49                                                                                 The parser shifted to state 49                                          
Token Read           49       4      58   ,                                                             Token type: Separator                                                   
Reduce               39                   (24) ::= < (23) >                                             <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               51                   (25) ::= (21) [https://en.test.org/wiki/Silk] (24)            <item> ::= <text> Link <tag>                                            
Shift                46                                                                                 The parser shifted to state 46                                          
Token Read           46       5       0       synthetic fabrics                                         Token type: Text                                                        
Shift                12                                                                                 The parser shifted to state 12                                          
Token Read           12       5      22   [https://en.test.org/wiki/Synthetic]                          Token type: Link                                                        
Reduce               18                   (26) ::=     synthetic fabrics                                <text-chunk> ::= Text                                                   
Reduce               17                   (27) ::= (26)                                                 <text> ::= <text-chunk>                                                 
Shift                25                                                                                 The parser shifted to state 25                                          
Token Read           25       5      58   <                                                             Token type: LeftArrow                                                   
Shift                24                                                                                 The parser shifted to state 24                                          
Token Read           24       5      59   oAgVUPi0                                                      Token type: Text                                                        
Shift                12                                                                                 The parser shifted to state 12                                          
Token Read           12       5      67   >                                                             Token type: RightArrow                                                  
Reduce               18                   (28) ::= oAgVUPi0                                             <text-chunk> ::= Text                                                   
Reduce               36                   (29) ::= (28)                                                 <text> ::= <text-chunk>                                                 
Shift                49                                                                                 The parser shifted to state 49                                          
Token Read           49       5      68   ;                                                             Token type: Terminator                                                  
Reduce               39                   (30) ::= < (29) >                                             <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               51                   (31) ::= (27) [https://en.test.org/wiki/Synthetic] (30)       <item> ::= <text> Link <tag>                                            
Reduce               52                   (32) ::= (25) , (31)                                          <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               52                   (33) ::= (19) , (32)                                          <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               35                   (34) ::= (13) , (33)                                          <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                48                                                                                 The parser shifted to state 48                                          
Token Read           48       6       0                                                                 Token type: EOF                                                         
Reduce               13                   (35) ::= (6) (7) (34) ;                                       <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               16                   (36) ::= (35)                                                 <scripture> ::= <expression>                                            
Accept               16                                                                                                                                                         



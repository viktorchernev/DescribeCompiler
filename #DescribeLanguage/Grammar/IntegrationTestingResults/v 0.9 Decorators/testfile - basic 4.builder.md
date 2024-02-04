========================================
Source Code (between the arrows)
========================================

🡆fabrics<wIcCuax5>[https://www.notube.com/watch?v=hTui12lKus]->

    wool fabrics[https://www.notube.com/watch?v=hTui12lKus]<C92Mf6yV>,
	
    cotton fabrics<TxW3Yetp> {color | green}
	[https://www.notube.com/watch?v=hTui12lKus]
	[https://www.notube.com/watch?v=hTui12lKus],

    silk fabrics<08yGbnMX>,
    synthetic fabrics<7MZTHLMY>;
🡄

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
|  |  |  |  |  |  +--wIcCuax5
|  |  |  |  +-->
|  |  |  +--[https://www.notube.com/watch?v=hTui12lKus]
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  +--<item> ::= <text> Link <tag>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--    wool fabrics
|  |  |  |  +--[https://www.notube.com/watch?v=hTui12lKus]
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--C92Mf6yV
|  |  |  |  |  +-->
|  |  |  +--,
|  |  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  |  +--<item> ::= <text> <tag> Decorator <links>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    cotton fabrics
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--TxW3Yetp
|  |  |  |  |  |  +-->
|  |  |  |  |  +--{color | green}
|  |  |  |  |  +--<links> ::= Link Link
|  |  |  |  |  |  +--[https://www.notube.com/watch?v=hTui12lKus]
|  |  |  |  |  |  +--[https://www.notube.com/watch?v=hTui12lKus]
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
|  |  |  |  |  |  |  |  |  +--08yGbnMX
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
|  |  |  |  |  |  |  |  |  +--7MZTHLMY
|  |  |  |  |  |  |  +-->
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                                                                                         Description                                                             
---------------   -----   -----   -----   -------------------------------------------------------------------------------------------------   ------------------------------------------------------------------------
Token Read            0       0       0   fabrics                                                                                             Token type: Text                                                        
Shift                14                                                                                                                       The parser shifted to state 14                                          
Token Read           14       0       7   <                                                                                                   Token type: LeftArrow                                                   
Reduce               20                   (1) ::= fabrics                                                                                     <text-chunk> ::= Text                                                   
Reduce               19                   (2) ::= (1)                                                                                         <text> ::= <text-chunk>                                                 
Shift                27                                                                                                                       The parser shifted to state 27                                          
Token Read           27       0       8   wIcCuax5                                                                                            Token type: Text                                                        
Shift                14                                                                                                                       The parser shifted to state 14                                          
Token Read           14       0      16   >                                                                                                   Token type: RightArrow                                                  
Reduce               20                   (3) ::= wIcCuax5                                                                                    <text-chunk> ::= Text                                                   
Reduce               45                   (4) ::= (3)                                                                                         <text> ::= <text-chunk>                                                 
Shift                71                                                                                                                       The parser shifted to state 71                                          
Token Read           71       0      17   [https://www.notube.com/watch?v=hTui12lKus]                                                         Token type: Link                                                        
Reduce               31                   (5) ::= < (4) >                                                                                     <tag> ::= LeftArrow <text> RightArrow                                   
Shift                58                                                                                                                       The parser shifted to state 58                                          
Token Read           58       0      60   -                                                                                                   Token type: Hyphen                                                      
Reduce               17                   (6) ::= (2) (5) [https://www.notube.com/watch?v=hTui12lKus]                                         <item> ::= <text> <tag> Link                                            
Shift                24                                                                                                                       The parser shifted to state 24                                          
Token Read           24       0      61   >                                                                                                   Token type: RightArrow                                                  
Shift                34                                                                                                                       The parser shifted to state 34                                          
Token Read           34       2       0       wool fabrics                                                                                    Token type: Text                                                        
Reduce               25                   (7) ::= - >                                                                                         <producer> ::= Hyphen RightArrow                                        
Shift                14                                                                                                                       The parser shifted to state 14                                          
Token Read           14       2      16   [https://www.notube.com/watch?v=hTui12lKus]                                                         Token type: Link                                                        
Reduce               20                   (8) ::=     wool fabrics                                                                            <text-chunk> ::= Text                                                   
Reduce               19                   (9) ::= (8)                                                                                         <text> ::= <text-chunk>                                                 
Shift                28                                                                                                                       The parser shifted to state 28                                          
Token Read           28       2      59   <                                                                                                   Token type: LeftArrow                                                   
Shift                27                                                                                                                       The parser shifted to state 27                                          
Token Read           27       2      60   C92Mf6yV                                                                                            Token type: Text                                                        
Shift                14                                                                                                                       The parser shifted to state 14                                          
Token Read           14       2      68   >                                                                                                   Token type: RightArrow                                                  
Reduce               20                   (10) ::= C92Mf6yV                                                                                   <text-chunk> ::= Text                                                   
Reduce               45                   (11) ::= (10)                                                                                       <text> ::= <text-chunk>                                                 
Shift                71                                                                                                                       The parser shifted to state 71                                          
Token Read           71       2      69   ,                                                                                                   Token type: Separator                                                   
Reduce               50                   (12) ::= < (11) >                                                                                   <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               37                   (13) ::= (9) [https://www.notube.com/watch?v=hTui12lKus] (12)                                       <item> ::= <text> Link <tag>                                            
Shift                64                                                                                                                       The parser shifted to state 64                                          
Token Read           64       4       0       cotton fabrics                                                                                  Token type: Text                                                        
Shift                14                                                                                                                       The parser shifted to state 14                                          
Token Read           14       4      18   <                                                                                                   Token type: LeftArrow                                                   
Reduce               20                   (14) ::=     cotton fabrics                                                                         <text-chunk> ::= Text                                                   
Reduce               19                   (15) ::= (14)                                                                                       <text> ::= <text-chunk>                                                 
Shift                27                                                                                                                       The parser shifted to state 27                                          
Token Read           27       4      19   TxW3Yetp                                                                                            Token type: Text                                                        
Shift                14                                                                                                                       The parser shifted to state 14                                          
Token Read           14       4      27   >                                                                                                   Token type: RightArrow                                                  
Reduce               20                   (16) ::= TxW3Yetp                                                                                   <text-chunk> ::= Text                                                   
Reduce               45                   (17) ::= (16)                                                                                       <text> ::= <text-chunk>                                                 
Shift                71                                                                                                                       The parser shifted to state 71                                          
Token Read           71       4      29   {color | green}                                                                                     Token type: Decorator                                                   
Reduce               31                   (18) ::= < (17) >                                                                                   <tag> ::= LeftArrow <text> RightArrow                                   
Shift                57                                                                                                                       The parser shifted to state 57                                          
Token Read           57       5       4   [https://www.notube.com/watch?v=hTui12lKus]                                                         Token type: Link                                                        
Shift                84                                                                                                                       The parser shifted to state 84                                          
Token Read           84       6       4   [https://www.notube.com/watch?v=hTui12lKus]                                                         Token type: Link                                                        
Shift                47                                                                                                                       The parser shifted to state 47                                          
Token Read           47       6      47   ,                                                                                                   Token type: Separator                                                   
Reduce               85                   (19) ::= [https://www.notube.com/watch?v=hTui12lKus] [https://www.notube.com/watch?v=hTui12lKus]    <links> ::= Link Link                                                   
Reduce               93                   (20) ::= (15) (18) {color | green} (19)                                                             <item> ::= <text> <tag> Decorator <links>                               
Shift                64                                                                                                                       The parser shifted to state 64                                          
Token Read           64       8       0       silk fabrics                                                                                    Token type: Text                                                        
Shift                14                                                                                                                       The parser shifted to state 14                                          
Token Read           14       8      16   <                                                                                                   Token type: LeftArrow                                                   
Reduce               20                   (21) ::=     silk fabrics                                                                           <text-chunk> ::= Text                                                   
Reduce               19                   (22) ::= (21)                                                                                       <text> ::= <text-chunk>                                                 
Shift                27                                                                                                                       The parser shifted to state 27                                          
Token Read           27       8      17   08yGbnMX                                                                                            Token type: Text                                                        
Shift                14                                                                                                                       The parser shifted to state 14                                          
Token Read           14       8      25   >                                                                                                   Token type: RightArrow                                                  
Reduce               20                   (23) ::= 08yGbnMX                                                                                   <text-chunk> ::= Text                                                   
Reduce               45                   (24) ::= (23)                                                                                       <text> ::= <text-chunk>                                                 
Shift                71                                                                                                                       The parser shifted to state 71                                          
Token Read           71       8      26   ,                                                                                                   Token type: Separator                                                   
Reduce               31                   (25) ::= < (24) >                                                                                   <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               93                   (26) ::= (22) (25)                                                                                  <item> ::= <text> <tag>                                                 
Shift                64                                                                                                                       The parser shifted to state 64                                          
Token Read           64       9       0       synthetic fabrics                                                                               Token type: Text                                                        
Shift                14                                                                                                                       The parser shifted to state 14                                          
Token Read           14       9      21   <                                                                                                   Token type: LeftArrow                                                   
Reduce               20                   (27) ::=     synthetic fabrics                                                                      <text-chunk> ::= Text                                                   
Reduce               19                   (28) ::= (27)                                                                                       <text> ::= <text-chunk>                                                 
Shift                27                                                                                                                       The parser shifted to state 27                                          
Token Read           27       9      22   7MZTHLMY                                                                                            Token type: Text                                                        
Shift                14                                                                                                                       The parser shifted to state 14                                          
Token Read           14       9      30   >                                                                                                   Token type: RightArrow                                                  
Reduce               20                   (29) ::= 7MZTHLMY                                                                                   <text-chunk> ::= Text                                                   
Reduce               45                   (30) ::= (29)                                                                                       <text> ::= <text-chunk>                                                 
Shift                71                                                                                                                       The parser shifted to state 71                                          
Token Read           71       9      31   ;                                                                                                   Token type: Terminator                                                  
Reduce               31                   (31) ::= < (30) >                                                                                   <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               93                   (32) ::= (28) (31)                                                                                  <item> ::= <text> <tag>                                                 
Reduce               94                   (33) ::= (26) , (32)                                                                                <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               94                   (34) ::= (20) , (33)                                                                                <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               39                   (35) ::= (13) , (34)                                                                                <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                66                                                                                                                       The parser shifted to state 66                                          
Token Read           66      11       0                                                                                                       Token type: EOF                                                         
Reduce               15                   (36) ::= (6) (7) (35) ;                                                                             <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               18                   (37) ::= (36)                                                                                       <scripture> ::= <expression>                                            
Accept               18                                                                                                                                                                                               



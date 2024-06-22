========================================
Source Code (between the arrows)
========================================

🡆fabrics<wIcCuax5>[https://www.notube.com/watch?v=hTui12lKus]->

    wool fabrics[https://www.notube.com/watch?v=hTui12lKus]<C92Mf6yV>,
	
    cotton fabrics<TxW3Yetp>
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
|  |  |  |  +--<item> ::= <text> <tag> <links>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    cotton fabrics
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--TxW3Yetp
|  |  |  |  |  |  +-->
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
Shift                12                                                                                                                       The parser shifted to state 12                                          
Token Read           12       0       7   <                                                                                                   Token type: LeftArrow                                                   
Reduce               18                   (1) ::= fabrics                                                                                     <text-chunk> ::= Text                                                   
Reduce               17                   (2) ::= (1)                                                                                         <text> ::= <text-chunk>                                                 
Shift                24                                                                                                                       The parser shifted to state 24                                          
Token Read           24       0       8   wIcCuax5                                                                                            Token type: Text                                                        
Shift                12                                                                                                                       The parser shifted to state 12                                          
Token Read           12       0      16   >                                                                                                   Token type: RightArrow                                                  
Reduce               18                   (3) ::= wIcCuax5                                                                                    <text-chunk> ::= Text                                                   
Reduce               36                   (4) ::= (3)                                                                                         <text> ::= <text-chunk>                                                 
Shift                49                                                                                                                       The parser shifted to state 49                                          
Token Read           49       0      17   [https://www.notube.com/watch?v=hTui12lKus]                                                         Token type: Link                                                        
Reduce               27                   (5) ::= < (4) >                                                                                     <tag> ::= LeftArrow <text> RightArrow                                   
Shift                41                                                                                                                       The parser shifted to state 41                                          
Token Read           41       0      60   -                                                                                                   Token type: Hyphen                                                      
Reduce               15                   (6) ::= (2) (5) [https://www.notube.com/watch?v=hTui12lKus]                                         <item> ::= <text> <tag> Link                                            
Shift                22                                                                                                                       The parser shifted to state 22                                          
Token Read           22       0      61   >                                                                                                   Token type: RightArrow                                                  
Shift                30                                                                                                                       The parser shifted to state 30                                          
Token Read           30       2       0       wool fabrics                                                                                    Token type: Text                                                        
Reduce               23                   (7) ::= - >                                                                                         <producer> ::= Hyphen RightArrow                                        
Shift                12                                                                                                                       The parser shifted to state 12                                          
Token Read           12       2      16   [https://www.notube.com/watch?v=hTui12lKus]                                                         Token type: Link                                                        
Reduce               18                   (8) ::=     wool fabrics                                                                            <text-chunk> ::= Text                                                   
Reduce               17                   (9) ::= (8)                                                                                         <text> ::= <text-chunk>                                                 
Shift                25                                                                                                                       The parser shifted to state 25                                          
Token Read           25       2      59   <                                                                                                   Token type: LeftArrow                                                   
Shift                24                                                                                                                       The parser shifted to state 24                                          
Token Read           24       2      60   C92Mf6yV                                                                                            Token type: Text                                                        
Shift                12                                                                                                                       The parser shifted to state 12                                          
Token Read           12       2      68   >                                                                                                   Token type: RightArrow                                                  
Reduce               18                   (10) ::= C92Mf6yV                                                                                   <text-chunk> ::= Text                                                   
Reduce               36                   (11) ::= (10)                                                                                       <text> ::= <text-chunk>                                                 
Shift                49                                                                                                                       The parser shifted to state 49                                          
Token Read           49       2      69   ,                                                                                                   Token type: Separator                                                   
Reduce               39                   (12) ::= < (11) >                                                                                   <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (13) ::= (9) [https://www.notube.com/watch?v=hTui12lKus] (12)                                       <item> ::= <text> Link <tag>                                            
Shift                46                                                                                                                       The parser shifted to state 46                                          
Token Read           46       4       0       cotton fabrics                                                                                  Token type: Text                                                        
Shift                12                                                                                                                       The parser shifted to state 12                                          
Token Read           12       4      18   <                                                                                                   Token type: LeftArrow                                                   
Reduce               18                   (14) ::=     cotton fabrics                                                                         <text-chunk> ::= Text                                                   
Reduce               17                   (15) ::= (14)                                                                                       <text> ::= <text-chunk>                                                 
Shift                24                                                                                                                       The parser shifted to state 24                                          
Token Read           24       4      19   TxW3Yetp                                                                                            Token type: Text                                                        
Shift                12                                                                                                                       The parser shifted to state 12                                          
Token Read           12       4      27   >                                                                                                   Token type: RightArrow                                                  
Reduce               18                   (16) ::= TxW3Yetp                                                                                   <text-chunk> ::= Text                                                   
Reduce               36                   (17) ::= (16)                                                                                       <text> ::= <text-chunk>                                                 
Shift                49                                                                                                                       The parser shifted to state 49                                          
Token Read           49       5       4   [https://www.notube.com/watch?v=hTui12lKus]                                                         Token type: Link                                                        
Reduce               27                   (18) ::= < (17) >                                                                                   <tag> ::= LeftArrow <text> RightArrow                                   
Shift                41                                                                                                                       The parser shifted to state 41                                          
Token Read           41       6       4   [https://www.notube.com/watch?v=hTui12lKus]                                                         Token type: Link                                                        
Shift                37                                                                                                                       The parser shifted to state 37                                          
Token Read           37       6      47   ,                                                                                                   Token type: Separator                                                   
Reduce               42                   (19) ::= [https://www.notube.com/watch?v=hTui12lKus] [https://www.notube.com/watch?v=hTui12lKus]    <links> ::= Link Link                                                   
Reduce               51                   (20) ::= (15) (18) (19)                                                                             <item> ::= <text> <tag> <links>                                         
Shift                46                                                                                                                       The parser shifted to state 46                                          
Token Read           46       8       0       silk fabrics                                                                                    Token type: Text                                                        
Shift                12                                                                                                                       The parser shifted to state 12                                          
Token Read           12       8      16   <                                                                                                   Token type: LeftArrow                                                   
Reduce               18                   (21) ::=     silk fabrics                                                                           <text-chunk> ::= Text                                                   
Reduce               17                   (22) ::= (21)                                                                                       <text> ::= <text-chunk>                                                 
Shift                24                                                                                                                       The parser shifted to state 24                                          
Token Read           24       8      17   08yGbnMX                                                                                            Token type: Text                                                        
Shift                12                                                                                                                       The parser shifted to state 12                                          
Token Read           12       8      25   >                                                                                                   Token type: RightArrow                                                  
Reduce               18                   (23) ::= 08yGbnMX                                                                                   <text-chunk> ::= Text                                                   
Reduce               36                   (24) ::= (23)                                                                                       <text> ::= <text-chunk>                                                 
Shift                49                                                                                                                       The parser shifted to state 49                                          
Token Read           49       8      26   ,                                                                                                   Token type: Separator                                                   
Reduce               27                   (25) ::= < (24) >                                                                                   <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               51                   (26) ::= (22) (25)                                                                                  <item> ::= <text> <tag>                                                 
Shift                46                                                                                                                       The parser shifted to state 46                                          
Token Read           46       9       0       synthetic fabrics                                                                               Token type: Text                                                        
Shift                12                                                                                                                       The parser shifted to state 12                                          
Token Read           12       9      21   <                                                                                                   Token type: LeftArrow                                                   
Reduce               18                   (27) ::=     synthetic fabrics                                                                      <text-chunk> ::= Text                                                   
Reduce               17                   (28) ::= (27)                                                                                       <text> ::= <text-chunk>                                                 
Shift                24                                                                                                                       The parser shifted to state 24                                          
Token Read           24       9      22   7MZTHLMY                                                                                            Token type: Text                                                        
Shift                12                                                                                                                       The parser shifted to state 12                                          
Token Read           12       9      30   >                                                                                                   Token type: RightArrow                                                  
Reduce               18                   (29) ::= 7MZTHLMY                                                                                   <text-chunk> ::= Text                                                   
Reduce               36                   (30) ::= (29)                                                                                       <text> ::= <text-chunk>                                                 
Shift                49                                                                                                                       The parser shifted to state 49                                          
Token Read           49       9      31   ;                                                                                                   Token type: Terminator                                                  
Reduce               27                   (31) ::= < (30) >                                                                                   <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               51                   (32) ::= (28) (31)                                                                                  <item> ::= <text> <tag>                                                 
Reduce               52                   (33) ::= (26) , (32)                                                                                <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               52                   (34) ::= (20) , (33)                                                                                <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               35                   (35) ::= (13) , (34)                                                                                <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                48                                                                                                                       The parser shifted to state 48                                          
Token Read           48      11       0                                                                                                       Token type: EOF                                                         
Reduce               13                   (36) ::= (6) (7) (35) ;                                                                             <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               16                   (37) ::= (36)                                                                                       <scripture> ::= <expression>                                            
Accept               16                                                                                                                                                                                               



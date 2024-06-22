========================================
Source Code (between the arrows)
========================================

🡆fabric     s 	<TSbLGnNG> ->

	wool   fabrics	 <QWVZ3pp9> ,
	cotton\, fabrics textiles   <75NTfebY>,
    silk\-\>fabrics <Sqs0lm7S>,
    syntic 		fabrics <GcZEI9gy>;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  +--<item> ::= <text> <tag>
|  |  |  +--<text> ::= <text-chunk>
|  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  +--fabric     s    
|  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  +--<
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--TSbLGnNG
|  |  |  |  +-->
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  +--<item> ::= <text> <tag>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--   wool   fabrics   
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--QWVZ3pp9
|  |  |  |  |  +-->
|  |  |  +--,
|  |  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--   cotton
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeSeparator
|  |  |  |  |  |  |  |  |  +--\,
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +-- fabrics textiles   
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--75NTfebY
|  |  |  |  |  |  +-->
|  |  |  |  +--,
|  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--    silk
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeHyphen
|  |  |  |  |  |  |  |  |  |  +--\-
|  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeRightArrow
|  |  |  |  |  |  |  |  |  |  |  +--\>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  +--fabrics 
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--Sqs0lm7S
|  |  |  |  |  |  |  +-->
|  |  |  |  |  +--,
|  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    syntic        fabrics 
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--GcZEI9gy
|  |  |  |  |  |  |  +-->
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                            Description                                                             
---------------   -----   -----   -----   ------------------------------------   ------------------------------------------------------------------------
Token Read            0       0       0   fabric     s                           Token type: Text                                                        
Shift                11                                                          The parser shifted to state 11                                          
Token Read           11       0      16   <                                      Token type: LeftArrow                                                   
Reduce               18                   (1) ::= fabric     s                   <text-chunk> ::= Text                                                   
Reduce               17                   (2) ::= (1)                            <text> ::= <text-chunk>                                                 
Shift                10                                                          The parser shifted to state 10                                          
Token Read           10       0      17   TSbLGnNG                               Token type: Text                                                        
Shift                11                                                          The parser shifted to state 11                                          
Token Read           11       0      25   >                                      Token type: RightArrow                                                  
Reduce               18                   (3) ::= TSbLGnNG                       <text-chunk> ::= Text                                                   
Reduce               20                   (4) ::= (3)                            <text> ::= <text-chunk>                                                 
Shift                29                                                          The parser shifted to state 29                                          
Token Read           29       0      27   -                                      Token type: Hyphen                                                      
Reduce               26                   (5) ::= < (4) >                        <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               14                   (6) ::= (2) (5)                        <item> ::= <text> <tag>                                                 
Shift                23                                                          The parser shifted to state 23                                          
Token Read           23       0      28   >                                      Token type: RightArrow                                                  
Shift                30                                                          The parser shifted to state 30                                          
Token Read           30       0      29      wool   fabrics                      Token type: Text                                                        
Reduce               24                   (7) ::= - >                            <producer> ::= Hyphen RightArrow                                        
Shift                11                                                          The parser shifted to state 11                                          
Token Read           11       0      49   <                                      Token type: LeftArrow                                                   
Reduce               18                   (8) ::=    wool   fabrics              <text-chunk> ::= Text                                                   
Reduce               17                   (9) ::= (8)                            <text> ::= <text-chunk>                                                 
Shift                10                                                          The parser shifted to state 10                                          
Token Read           10       0      50   QWVZ3pp9                               Token type: Text                                                        
Shift                11                                                          The parser shifted to state 11                                          
Token Read           11       0      58   >                                      Token type: RightArrow                                                  
Reduce               18                   (10) ::= QWVZ3pp9                      <text-chunk> ::= Text                                                   
Reduce               20                   (11) ::= (10)                          <text> ::= <text-chunk>                                                 
Shift                29                                                          The parser shifted to state 29                                          
Token Read           29       0      60   ,                                      Token type: Separator                                                   
Reduce               26                   (12) ::= < (11) >                      <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (13) ::= (9) (12)                      <item> ::= <text> <tag>                                                 
Shift                39                                                          The parser shifted to state 39                                          
Token Read           39       0      61      cotton                              Token type: Text                                                        
Shift                11                                                          The parser shifted to state 11                                          
Token Read           11       0      70   \,                                     Token type: EscapeSeparator                                             
Reduce               18                   (14) ::=    cotton                     <text-chunk> ::= Text                                                   
Shift                 7                                                          The parser shifted to state 7                                           
Token Read            7       0      72    fabrics textiles                      Token type: Text                                                        
Reduce               27                   (15) ::= \,                            <text-chunk> ::= EscapeSeparator                                        
Shift                11                                                          The parser shifted to state 11                                          
Token Read           11       0      92   <                                      Token type: LeftArrow                                                   
Reduce               27                   (16) ::=  fabrics textiles             <text-chunk> ::= Text                                                   
Reduce               28                   (17) ::= (15) (16)                     <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               19                   (18) ::= (14) (17)                     <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (19) ::= (18)                          <text> ::= <text-chunk-list>                                            
Shift                10                                                          The parser shifted to state 10                                          
Token Read           10       0      93   75NTfebY                               Token type: Text                                                        
Shift                11                                                          The parser shifted to state 11                                          
Token Read           11       0     101   >                                      Token type: RightArrow                                                  
Reduce               18                   (20) ::= 75NTfebY                      <text-chunk> ::= Text                                                   
Reduce               20                   (21) ::= (20)                          <text> ::= <text-chunk>                                                 
Shift                29                                                          The parser shifted to state 29                                          
Token Read           29       0     102   ,                                      Token type: Separator                                                   
Reduce               26                   (22) ::= < (21) >                      <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (23) ::= (19) (22)                     <item> ::= <text> <tag>                                                 
Shift                39                                                          The parser shifted to state 39                                          
Token Read           39       0     103       silk                               Token type: Text                                                        
Shift                11                                                          The parser shifted to state 11                                          
Token Read           11       0     111   \-                                     Token type: EscapeHyphen                                                
Reduce               18                   (24) ::=     silk                      <text-chunk> ::= Text                                                   
Shift                 4                                                          The parser shifted to state 4                                           
Token Read            4       0     113   \>                                     Token type: EscapeRightArrow                                            
Reduce               27                   (25) ::= \-                            <text-chunk> ::= EscapeHyphen                                           
Shift                 6                                                          The parser shifted to state 6                                           
Token Read            6       0     115   fabrics                                Token type: Text                                                        
Reduce               27                   (26) ::= \>                            <text-chunk> ::= EscapeRightArrow                                       
Shift                11                                                          The parser shifted to state 11                                          
Token Read           11       0     123   <                                      Token type: LeftArrow                                                   
Reduce               27                   (27) ::= fabrics                       <text-chunk> ::= Text                                                   
Reduce               28                   (28) ::= (26) (27)                     <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               28                   (29) ::= (25) (28)                     <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               19                   (30) ::= (24) (29)                     <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (31) ::= (30)                          <text> ::= <text-chunk-list>                                            
Shift                10                                                          The parser shifted to state 10                                          
Token Read           10       0     124   Sqs0lm7S                               Token type: Text                                                        
Shift                11                                                          The parser shifted to state 11                                          
Token Read           11       0     132   >                                      Token type: RightArrow                                                  
Reduce               18                   (32) ::= Sqs0lm7S                      <text-chunk> ::= Text                                                   
Reduce               20                   (33) ::= (32)                          <text> ::= <text-chunk>                                                 
Shift                29                                                          The parser shifted to state 29                                          
Token Read           29       0     133   ,                                      Token type: Separator                                                   
Reduce               26                   (34) ::= < (33) >                      <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (35) ::= (31) (34)                     <item> ::= <text> <tag>                                                 
Shift                39                                                          The parser shifted to state 39                                          
Token Read           39       0     134       syntic        fabrics              Token type: Text                                                        
Shift                11                                                          The parser shifted to state 11                                          
Token Read           11       0     160   <                                      Token type: LeftArrow                                                   
Reduce               18                   (36) ::=     syntic        fabrics     <text-chunk> ::= Text                                                   
Reduce               17                   (37) ::= (36)                          <text> ::= <text-chunk>                                                 
Shift                10                                                          The parser shifted to state 10                                          
Token Read           10       0     161   GcZEI9gy                               Token type: Text                                                        
Shift                11                                                          The parser shifted to state 11                                          
Token Read           11       0     169   >                                      Token type: RightArrow                                                  
Reduce               18                   (38) ::= GcZEI9gy                      <text-chunk> ::= Text                                                   
Reduce               20                   (39) ::= (38)                          <text> ::= <text-chunk>                                                 
Shift                29                                                          The parser shifted to state 29                                          
Token Read           29       0     170   ;                                      Token type: Terminator                                                  
Reduce               26                   (40) ::= < (39) >                      <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (41) ::= (37) (40)                     <item> ::= <text> <tag>                                                 
Reduce               44                   (42) ::= (35) , (41)                   <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               44                   (43) ::= (23) , (42)                   <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               35                   (44) ::= (13) , (43)                   <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                41                                                          The parser shifted to state 41                                          
Token Read           41       1       0                                          Token type: EOF                                                         
Reduce               12                   (45) ::= (6) (7) (44) ;                <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               15                   (46) ::= (45)                          <scripture> ::= <expression>                                            
Accept               15                                                                                                                                  



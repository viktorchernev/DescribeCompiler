========================================
Source Code (between the arrows)
========================================

🡆fabric     s    <sJZOzSdo>	->

	<UlJXGWLS>wool   fabrics	,
	cotton\, fabrics textiles  \<<d4\<jKusMe>,
    silk\-\>fabrics <Bgx8M6B1\<\>>,
    syntic 		fabrics <7vbW9VSB>;🡄

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
|  |  |  |  |  |  +--sJZOzSdo
|  |  |  |  +-->
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  +--<item> ::= <tag> <text>
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--UlJXGWLS
|  |  |  |  |  +-->
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--wool   fabrics    
|  |  |  +--,
|  |  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    cotton
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeSeparator
|  |  |  |  |  |  |  |  |  +--\,
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +-- fabrics textiles  
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeLeftArrow
|  |  |  |  |  |  |  |  |  |  +--\<
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--d4
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeLeftArrow
|  |  |  |  |  |  |  |  |  |  +--\<
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--jKusMe
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
|  |  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--Bgx8M6B1
|  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeLeftArrow
|  |  |  |  |  |  |  |  |  |  |  +--\<
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeRightArrow
|  |  |  |  |  |  |  |  |  |  |  +--\>
|  |  |  |  |  |  |  +-->
|  |  |  |  |  +--,
|  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    syntic      fabrics 
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--7vbW9VSB
|  |  |  |  |  |  |  +-->
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                          Description                                                             
---------------   -----   -----   -----   ----------------------------------   ------------------------------------------------------------------------
Token Read            0       0       0   fabric     s                         Token type: Text                                                        
Shift                11                                                        The parser shifted to state 11                                          
Token Read           11       0      16   <                                    Token type: LeftArrow                                                   
Reduce               18                   (1) ::= fabric     s                 <text-chunk> ::= Text                                                   
Reduce               17                   (2) ::= (1)                          <text> ::= <text-chunk>                                                 
Shift                10                                                        The parser shifted to state 10                                          
Token Read           10       0      17   sJZOzSdo                             Token type: Text                                                        
Shift                11                                                        The parser shifted to state 11                                          
Token Read           11       0      25   >                                    Token type: RightArrow                                                  
Reduce               18                   (3) ::= sJZOzSdo                     <text-chunk> ::= Text                                                   
Reduce               20                   (4) ::= (3)                          <text> ::= <text-chunk>                                                 
Shift                29                                                        The parser shifted to state 29                                          
Token Read           29       0      28   -                                    Token type: Hyphen                                                      
Reduce               26                   (5) ::= < (4) >                      <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               14                   (6) ::= (2) (5)                      <item> ::= <text> <tag>                                                 
Shift                23                                                        The parser shifted to state 23                                          
Token Read           23       0      29   >                                    Token type: RightArrow                                                  
Shift                30                                                        The parser shifted to state 30                                          
Token Read           30       2       4   <                                    Token type: LeftArrow                                                   
Reduce               24                   (7) ::= - >                          <producer> ::= Hyphen RightArrow                                        
Shift                10                                                        The parser shifted to state 10                                          
Token Read           10       2       5   UlJXGWLS                             Token type: Text                                                        
Shift                11                                                        The parser shifted to state 11                                          
Token Read           11       2      13   >                                    Token type: RightArrow                                                  
Reduce               18                   (8) ::= UlJXGWLS                     <text-chunk> ::= Text                                                   
Reduce               20                   (9) ::= (8)                          <text> ::= <text-chunk>                                                 
Shift                29                                                        The parser shifted to state 29                                          
Token Read           29       2      14   wool   fabrics                       Token type: Text                                                        
Reduce               16                   (10) ::= < (9) >                     <tag> ::= LeftArrow <text> RightArrow                                   
Shift                11                                                        The parser shifted to state 11                                          
Token Read           11       2      32   ,                                    Token type: Separator                                                   
Reduce               18                   (11) ::= wool   fabrics              <text-chunk> ::= Text                                                   
Reduce               25                   (12) ::= (11)                        <text> ::= <text-chunk>                                                 
Reduce               33                   (13) ::= (10) (12)                   <item> ::= <tag> <text>                                                 
Shift                39                                                        The parser shifted to state 39                                          
Token Read           39       3       0       cotton                           Token type: Text                                                        
Shift                11                                                        The parser shifted to state 11                                          
Token Read           11       3      10   \,                                   Token type: EscapeSeparator                                             
Reduce               18                   (14) ::=     cotton                  <text-chunk> ::= Text                                                   
Shift                 7                                                        The parser shifted to state 7                                           
Token Read            7       3      12    fabrics textiles                    Token type: Text                                                        
Reduce               27                   (15) ::= \,                          <text-chunk> ::= EscapeSeparator                                        
Shift                11                                                        The parser shifted to state 11                                          
Token Read           11       3      31   \<                                   Token type: EscapeLeftArrow                                             
Reduce               27                   (16) ::=  fabrics textiles           <text-chunk> ::= Text                                                   
Shift                 5                                                        The parser shifted to state 5                                           
Token Read            5       3      33   <                                    Token type: LeftArrow                                                   
Reduce               27                   (17) ::= \<                          <text-chunk> ::= EscapeLeftArrow                                        
Reduce               28                   (18) ::= (16) (17)                   <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               28                   (19) ::= (15) (18)                   <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               19                   (20) ::= (14) (19)                   <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (21) ::= (20)                        <text> ::= <text-chunk-list>                                            
Shift                10                                                        The parser shifted to state 10                                          
Token Read           10       3      34   d4                                   Token type: Text                                                        
Shift                11                                                        The parser shifted to state 11                                          
Token Read           11       3      36   \<                                   Token type: EscapeLeftArrow                                             
Reduce               18                   (22) ::= d4                          <text-chunk> ::= Text                                                   
Shift                 5                                                        The parser shifted to state 5                                           
Token Read            5       3      38   jKusMe                               Token type: Text                                                        
Reduce               27                   (23) ::= \<                          <text-chunk> ::= EscapeLeftArrow                                        
Shift                11                                                        The parser shifted to state 11                                          
Token Read           11       3      44   >                                    Token type: RightArrow                                                  
Reduce               27                   (24) ::= jKusMe                      <text-chunk> ::= Text                                                   
Reduce               28                   (25) ::= (23) (24)                   <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               19                   (26) ::= (22) (25)                   <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               20                   (27) ::= (26)                        <text> ::= <text-chunk-list>                                            
Shift                29                                                        The parser shifted to state 29                                          
Token Read           29       3      45   ,                                    Token type: Separator                                                   
Reduce               26                   (28) ::= < (27) >                    <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (29) ::= (21) (28)                   <item> ::= <text> <tag>                                                 
Shift                39                                                        The parser shifted to state 39                                          
Token Read           39       4       0       silk                             Token type: Text                                                        
Shift                11                                                        The parser shifted to state 11                                          
Token Read           11       4       8   \-                                   Token type: EscapeHyphen                                                
Reduce               18                   (30) ::=     silk                    <text-chunk> ::= Text                                                   
Shift                 4                                                        The parser shifted to state 4                                           
Token Read            4       4      10   \>                                   Token type: EscapeRightArrow                                            
Reduce               27                   (31) ::= \-                          <text-chunk> ::= EscapeHyphen                                           
Shift                 6                                                        The parser shifted to state 6                                           
Token Read            6       4      12   fabrics                              Token type: Text                                                        
Reduce               27                   (32) ::= \>                          <text-chunk> ::= EscapeRightArrow                                       
Shift                11                                                        The parser shifted to state 11                                          
Token Read           11       4      20   <                                    Token type: LeftArrow                                                   
Reduce               27                   (33) ::= fabrics                     <text-chunk> ::= Text                                                   
Reduce               28                   (34) ::= (32) (33)                   <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               28                   (35) ::= (31) (34)                   <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               19                   (36) ::= (30) (35)                   <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (37) ::= (36)                        <text> ::= <text-chunk-list>                                            
Shift                10                                                        The parser shifted to state 10                                          
Token Read           10       4      21   Bgx8M6B1                             Token type: Text                                                        
Shift                11                                                        The parser shifted to state 11                                          
Token Read           11       4      29   \<                                   Token type: EscapeLeftArrow                                             
Reduce               18                   (38) ::= Bgx8M6B1                    <text-chunk> ::= Text                                                   
Shift                 5                                                        The parser shifted to state 5                                           
Token Read            5       4      31   \>                                   Token type: EscapeRightArrow                                            
Reduce               27                   (39) ::= \<                          <text-chunk> ::= EscapeLeftArrow                                        
Shift                 6                                                        The parser shifted to state 6                                           
Token Read            6       4      33   >                                    Token type: RightArrow                                                  
Reduce               27                   (40) ::= \>                          <text-chunk> ::= EscapeRightArrow                                       
Reduce               28                   (41) ::= (39) (40)                   <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               19                   (42) ::= (38) (41)                   <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               20                   (43) ::= (42)                        <text> ::= <text-chunk-list>                                            
Shift                29                                                        The parser shifted to state 29                                          
Token Read           29       4      34   ,                                    Token type: Separator                                                   
Reduce               26                   (44) ::= < (43) >                    <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (45) ::= (37) (44)                   <item> ::= <text> <tag>                                                 
Shift                39                                                        The parser shifted to state 39                                          
Token Read           39       5       0       syntic      fabrics              Token type: Text                                                        
Shift                11                                                        The parser shifted to state 11                                          
Token Read           11       5      24   <                                    Token type: LeftArrow                                                   
Reduce               18                   (46) ::=     syntic      fabrics     <text-chunk> ::= Text                                                   
Reduce               17                   (47) ::= (46)                        <text> ::= <text-chunk>                                                 
Shift                10                                                        The parser shifted to state 10                                          
Token Read           10       5      25   7vbW9VSB                             Token type: Text                                                        
Shift                11                                                        The parser shifted to state 11                                          
Token Read           11       5      33   >                                    Token type: RightArrow                                                  
Reduce               18                   (48) ::= 7vbW9VSB                    <text-chunk> ::= Text                                                   
Reduce               20                   (49) ::= (48)                        <text> ::= <text-chunk>                                                 
Shift                29                                                        The parser shifted to state 29                                          
Token Read           29       5      34   ;                                    Token type: Terminator                                                  
Reduce               26                   (50) ::= < (49) >                    <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (51) ::= (47) (50)                   <item> ::= <text> <tag>                                                 
Reduce               44                   (52) ::= (45) , (51)                 <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               44                   (53) ::= (29) , (52)                 <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               35                   (54) ::= (13) , (53)                 <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                41                                                        The parser shifted to state 41                                          
Token Read           41       6       0                                        Token type: EOF                                                         
Reduce               12                   (55) ::= (6) (7) (54) ;              <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               15                   (56) ::= (55)                        <scripture> ::= <expression>                                            
Accept               15                                                                                                                                



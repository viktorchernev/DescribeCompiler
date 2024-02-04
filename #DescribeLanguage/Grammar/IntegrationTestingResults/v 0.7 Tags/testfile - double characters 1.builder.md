Cannot be parsed without preprocessing by the Describe Compiler preprocessor
The preprocessor has a bug with the hyphen here "<f75CKWhl->"
========================================
Source Code (between the arrows)
========================================

🡆fa - br-ics- <45mns0l-O>->

    wool-fabrics <-5g1GJyFS>,
    -cotton fabrics <f75CKWhl->,
    - silk - fabrics <68Es--hujI>,
    synthetic fabrics- <mWa4QdRm>;🡄

========================================
Preprocessed (between the arrows)
========================================

🡆fa \- br\-ics\- <45mns0l\-O>->

    wool\-fabrics <\-5g1GJyFS>,
    \-cotton fabrics <f75CKWhl->,
    \- silk \- fabrics <68Es\-\-hujI>,
    synthetic fabrics\- <mWa4QdRm>;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression-list> Terminator
|  |  +--<item> ::= <text> <tag>
|  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--fa 
|  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  +--<text-chunk> ::= EscapeHyphen
|  |  |  |  |  |  |  +--\-
|  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +-- br
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeHyphen
|  |  |  |  |  |  |  |  |  +--\-
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--ics
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeHyphen
|  |  |  |  |  |  |  |  |  |  +--\-
|  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  +--<
|  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--45mns0l
|  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= EscapeHyphen
|  |  |  |  |  |  |  |  +--\-
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--O
|  |  |  |  +-->
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  +--<item> ::= <text> <tag>
|  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    wool
|  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= EscapeHyphen
|  |  |  |  |  |  |  |  +--\-
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--fabrics 
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= EscapeHyphen
|  |  |  |  |  |  |  |  +--\-
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--5g1GJyFS
|  |  |  |  |  +-->
|  |  |  +--,
|  |  |  +--<item-or-expression-list> ::= <item> Separator <item-or-expression-list>
|  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= EscapeHyphen
|  |  |  |  |  |  |  |  +--\-
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--cotton fabrics 
|  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  +--<
|  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--f75CKWhl
|  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeHyphen
|  |  |  |  |  |  |  |  |  +--\-
|  |  |  |  |  |  +-->
|  |  |  |  +--,
|  |  |  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeHyphen
|  |  |  |  |  |  |  |  |  +--\-
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +-- silk 
|  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeHyphen
|  |  |  |  |  |  |  |  |  |  |  +--\-
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  +-- fabrics 
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  +--68Es
|  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk-list>
|  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeHyphen
|  |  |  |  |  |  |  |  |  |  |  +--\-
|  |  |  |  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeHyphen
|  |  |  |  |  |  |  |  |  |  |  |  +--\-
|  |  |  |  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  |  |  |  +--hujI
|  |  |  |  |  |  |  +-->
|  |  |  |  |  +--,
|  |  |  |  |  +--<item> ::= <text> <tag>
|  |  |  |  |  |  +--<text> ::= <text-chunk-list>
|  |  |  |  |  |  |  +--<text-chunk-list> ::= <text-chunk> <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--    synthetic fabrics
|  |  |  |  |  |  |  |  +--<text-chunk> ::= EscapeHyphen
|  |  |  |  |  |  |  |  |  +--\-
|  |  |  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  |  |  +--<
|  |  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  |  +--mWa4QdRm
|  |  |  |  |  |  |  +-->
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                       Description                                                             
---------------   -----   -----   -----   -------------------------------   ------------------------------------------------------------------------
Token Read            0       0       0   fa                                Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       0       3   \-                                Token type: EscapeHyphen                                                
Reduce               18                   (1) ::= fa                        <text-chunk> ::= Text                                                   
Shift                 4                                                     The parser shifted to state 4                                           
Token Read            4       0       5    br                               Token type: Text                                                        
Reduce               27                   (2) ::= \-                        <text-chunk> ::= EscapeHyphen                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       0       8   \-                                Token type: EscapeHyphen                                                
Reduce               27                   (3) ::=  br                       <text-chunk> ::= Text                                                   
Shift                 4                                                     The parser shifted to state 4                                           
Token Read            4       0      10   ics                               Token type: Text                                                        
Reduce               27                   (4) ::= \-                        <text-chunk> ::= EscapeHyphen                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       0      13   \-                                Token type: EscapeHyphen                                                
Reduce               27                   (5) ::= ics                       <text-chunk> ::= Text                                                   
Shift                 4                                                     The parser shifted to state 4                                           
Token Read            4       0      16   <                                 Token type: LeftArrow                                                   
Reduce               27                   (6) ::= \-                        <text-chunk> ::= EscapeHyphen                                           
Reduce               28                   (7) ::= (5) (6)                   <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               28                   (8) ::= (4) (7)                   <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (9) ::= (3) (8)                   <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               28                   (10) ::= (2) (9)                  <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               19                   (11) ::= (1) (10)                 <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (12) ::= (11)                     <text> ::= <text-chunk-list>                                            
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       0      17   45mns0l                           Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       0      24   \-                                Token type: EscapeHyphen                                                
Reduce               18                   (13) ::= 45mns0l                  <text-chunk> ::= Text                                                   
Shift                 4                                                     The parser shifted to state 4                                           
Token Read            4       0      26   O                                 Token type: Text                                                        
Reduce               27                   (14) ::= \-                       <text-chunk> ::= EscapeHyphen                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       0      27   >                                 Token type: RightArrow                                                  
Reduce               27                   (15) ::= O                        <text-chunk> ::= Text                                                   
Reduce               28                   (16) ::= (14) (15)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               19                   (17) ::= (13) (16)                <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               20                   (18) ::= (17)                     <text> ::= <text-chunk-list>                                            
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       0      28   -                                 Token type: Hyphen                                                      
Reduce               26                   (19) ::= < (18) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               14                   (20) ::= (12) (19)                <item> ::= <text> <tag>                                                 
Shift                23                                                     The parser shifted to state 23                                          
Token Read           23       0      29   >                                 Token type: RightArrow                                                  
Shift                30                                                     The parser shifted to state 30                                          
Token Read           30       2       0       wool                          Token type: Text                                                        
Reduce               24                   (21) ::= - >                      <producer> ::= Hyphen RightArrow                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       2       8   \-                                Token type: EscapeHyphen                                                
Reduce               18                   (22) ::=     wool                 <text-chunk> ::= Text                                                   
Shift                 4                                                     The parser shifted to state 4                                           
Token Read            4       2      10   fabrics                           Token type: Text                                                        
Reduce               27                   (23) ::= \-                       <text-chunk> ::= EscapeHyphen                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       2      18   <                                 Token type: LeftArrow                                                   
Reduce               27                   (24) ::= fabrics                  <text-chunk> ::= Text                                                   
Reduce               28                   (25) ::= (23) (24)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               19                   (26) ::= (22) (25)                <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (27) ::= (26)                     <text> ::= <text-chunk-list>                                            
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       2      19   \-                                Token type: EscapeHyphen                                                
Shift                 4                                                     The parser shifted to state 4                                           
Token Read            4       2      21   5g1GJyFS                          Token type: Text                                                        
Reduce               18                   (28) ::= \-                       <text-chunk> ::= EscapeHyphen                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       2      29   >                                 Token type: RightArrow                                                  
Reduce               27                   (29) ::= 5g1GJyFS                 <text-chunk> ::= Text                                                   
Reduce               19                   (30) ::= (28) (29)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               20                   (31) ::= (30)                     <text> ::= <text-chunk-list>                                            
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       2      30   ,                                 Token type: Separator                                                   
Reduce               26                   (32) ::= < (31) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               33                   (33) ::= (27) (32)                <item> ::= <text> <tag>                                                 
Shift                39                                                     The parser shifted to state 39                                          
Token Read           39       3       4   \-                                Token type: EscapeHyphen                                                
Shift                 4                                                     The parser shifted to state 4                                           
Token Read            4       3       6   cotton fabrics                    Token type: Text                                                        
Reduce               18                   (34) ::= \-                       <text-chunk> ::= EscapeHyphen                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       3      21   <                                 Token type: LeftArrow                                                   
Reduce               27                   (35) ::= cotton fabrics           <text-chunk> ::= Text                                                   
Reduce               19                   (36) ::= (34) (35)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               17                   (37) ::= (36)                     <text> ::= <text-chunk-list>                                            
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       3      22   f75CKWhl                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       3      30   \-                                Token type: EscapeHyphen                                                
Reduce               18                   (38) ::= f75CKWhl                 <text-chunk> ::= Text                                                   
Shift                 4                                                     The parser shifted to state 4                                           
Token Read            4       3      32   >                                 Token type: RightArrow                                                  
Reduce               27                   (39) ::= \-                       <text-chunk> ::= EscapeHyphen                                           
Reduce               19                   (40) ::= (38) (39)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               20                   (41) ::= (40)                     <text> ::= <text-chunk-list>                                            
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       3      33   ,                                 Token type: Separator                                                   
Reduce               26                   (42) ::= < (41) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (43) ::= (37) (42)                <item> ::= <text> <tag>                                                 
Shift                39                                                     The parser shifted to state 39                                          
Token Read           39       4       4   \-                                Token type: EscapeHyphen                                                
Shift                 4                                                     The parser shifted to state 4                                           
Token Read            4       4       6    silk                             Token type: Text                                                        
Reduce               18                   (44) ::= \-                       <text-chunk> ::= EscapeHyphen                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       4      12   \-                                Token type: EscapeHyphen                                                
Reduce               27                   (45) ::=  silk                    <text-chunk> ::= Text                                                   
Shift                 4                                                     The parser shifted to state 4                                           
Token Read            4       4      14    fabrics                          Token type: Text                                                        
Reduce               27                   (46) ::= \-                       <text-chunk> ::= EscapeHyphen                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       4      23   <                                 Token type: LeftArrow                                                   
Reduce               27                   (47) ::=  fabrics                 <text-chunk> ::= Text                                                   
Reduce               28                   (48) ::= (46) (47)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               28                   (49) ::= (45) (48)                <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               19                   (50) ::= (44) (49)                <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               17                   (51) ::= (50)                     <text> ::= <text-chunk-list>                                            
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       4      24   68Es                              Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       4      28   \-                                Token type: EscapeHyphen                                                
Reduce               18                   (52) ::= 68Es                     <text-chunk> ::= Text                                                   
Shift                 4                                                     The parser shifted to state 4                                           
Token Read            4       4      30   \-                                Token type: EscapeHyphen                                                
Reduce               27                   (53) ::= \-                       <text-chunk> ::= EscapeHyphen                                           
Shift                 4                                                     The parser shifted to state 4                                           
Token Read            4       4      32   hujI                              Token type: Text                                                        
Reduce               27                   (54) ::= \-                       <text-chunk> ::= EscapeHyphen                                           
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       4      36   >                                 Token type: RightArrow                                                  
Reduce               27                   (55) ::= hujI                     <text-chunk> ::= Text                                                   
Reduce               28                   (56) ::= (54) (55)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               28                   (57) ::= (53) (56)                <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               19                   (58) ::= (52) (57)                <text-chunk-list> ::= <text-chunk> <text-chunk-list>                    
Reduce               20                   (59) ::= (58)                     <text> ::= <text-chunk-list>                                            
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       4      37   ,                                 Token type: Separator                                                   
Reduce               26                   (60) ::= < (59) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (61) ::= (51) (60)                <item> ::= <text> <tag>                                                 
Shift                39                                                     The parser shifted to state 39                                          
Token Read           39       5       0       synthetic fabrics             Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       5      21   \-                                Token type: EscapeHyphen                                                
Reduce               18                   (62) ::=     synthetic fabrics    <text-chunk> ::= Text                                                   
Shift                 4                                                     The parser shifted to state 4                                           
Token Read            4       5      24   <                                 Token type: LeftArrow                                                   
Reduce               27                   (63) ::= \-                       <text-chunk> ::= EscapeHyphen                                           
Reduce               19                   (64) ::= (62) (63)                <text-chunk-list> ::= <text-chunk> <text-chunk>                         
Reduce               17                   (65) ::= (64)                     <text> ::= <text-chunk-list>                                            
Shift                10                                                     The parser shifted to state 10                                          
Token Read           10       5      25   mWa4QdRm                          Token type: Text                                                        
Shift                11                                                     The parser shifted to state 11                                          
Token Read           11       5      33   >                                 Token type: RightArrow                                                  
Reduce               18                   (66) ::= mWa4QdRm                 <text-chunk> ::= Text                                                   
Reduce               20                   (67) ::= (66)                     <text> ::= <text-chunk>                                                 
Shift                29                                                     The parser shifted to state 29                                          
Token Read           29       5      34   ;                                 Token type: Terminator                                                  
Reduce               26                   (68) ::= < (67) >                 <tag> ::= LeftArrow <text> RightArrow                                   
Reduce               43                   (69) ::= (65) (68)                <item> ::= <text> <tag>                                                 
Reduce               44                   (70) ::= (61) , (69)              <item-or-expression-list> ::= <item> Separator <item>                   
Reduce               44                   (71) ::= (43) , (70)              <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Reduce               35                   (72) ::= (33) , (71)              <item-or-expression-list> ::= <item> Separator <item-or-expression-list>
Shift                41                                                     The parser shifted to state 41                                          
Token Read           41       6       0                                     Token type: EOF                                                         
Reduce               12                   (73) ::= (20) (21) (72) ;         <expression> ::= <item> <producer> <item-or-expression-list> Terminator 
Reduce               15                   (74) ::= (73)                     <scripture> ::= <expression>                                            
Accept               15                                                                                                                             



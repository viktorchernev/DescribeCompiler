========================================
Source Code (between the arrows)
========================================

🡆fabrics <QuvD4gqX> ->        //dude;

    wool fabrics <VBsu8OpW>, /* comment <*/
/* ->Comments, man */    <0RdNAvNs> cotton fabrics;🡄

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
|  |  |  |  |  |  +--QuvD4gqX
|  |  |  |  +-->
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <item> Separator <item>
|  |  |  +--<item> ::= <text> <tag>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--    wool fabrics 
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--VBsu8OpW
|  |  |  |  |  +-->
|  |  |  +--,
|  |  |  +--<item> ::= <tag> <text>
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--0RdNAvNs
|  |  |  |  |  +-->
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +-- cotton fabrics
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                  Description                                                            
---------------   -----   -----   -----   --------------------------   -----------------------------------------------------------------------
Token Read            0       0       0   fabrics                      Token type: Text                                                       
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       0       8   <                            Token type: LeftArrow                                                  
Reduce               18                   (1) ::= fabrics              <text-chunk> ::= Text                                                  
Reduce               17                   (2) ::= (1)                  <text> ::= <text-chunk>                                                
Shift                10                                                The parser shifted to state 10                                         
Token Read           10       0       9   QuvD4gqX                     Token type: Text                                                       
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       0      17   >                            Token type: RightArrow                                                 
Reduce               18                   (3) ::= QuvD4gqX             <text-chunk> ::= Text                                                  
Reduce               20                   (4) ::= (3)                  <text> ::= <text-chunk>                                                
Shift                29                                                The parser shifted to state 29                                         
Token Read           29       0      19   -                            Token type: Hyphen                                                     
Reduce               26                   (5) ::= < (4) >              <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               14                   (6) ::= (2) (5)              <item> ::= <text> <tag>                                                
Shift                23                                                The parser shifted to state 23                                         
Token Read           23       0      20   >                            Token type: RightArrow                                                 
Shift                30                                                The parser shifted to state 30                                         
Token Read           30       2       0       wool fabrics             Token type: Text                                                       
Reduce               24                   (7) ::= - >                  <producer> ::= Hyphen RightArrow                                       
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       2      17   <                            Token type: LeftArrow                                                  
Reduce               18                   (8) ::=     wool fabrics     <text-chunk> ::= Text                                                  
Reduce               17                   (9) ::= (8)                  <text> ::= <text-chunk>                                                
Shift                10                                                The parser shifted to state 10                                         
Token Read           10       2      18   VBsu8OpW                     Token type: Text                                                       
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       2      26   >                            Token type: RightArrow                                                 
Reduce               18                   (10) ::= VBsu8OpW            <text-chunk> ::= Text                                                  
Reduce               20                   (11) ::= (10)                <text> ::= <text-chunk>                                                
Shift                29                                                The parser shifted to state 29                                         
Token Read           29       2      27   ,                            Token type: Separator                                                  
Reduce               26                   (12) ::= < (11) >            <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               33                   (13) ::= (9) (12)            <item> ::= <text> <tag>                                                
Shift                39                                                The parser shifted to state 39                                         
Token Read           39       3      25   <                            Token type: LeftArrow                                                  
Shift                10                                                The parser shifted to state 10                                         
Token Read           10       3      26   0RdNAvNs                     Token type: Text                                                       
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       3      34   >                            Token type: RightArrow                                                 
Reduce               18                   (14) ::= 0RdNAvNs            <text-chunk> ::= Text                                                  
Reduce               20                   (15) ::= (14)                <text> ::= <text-chunk>                                                
Shift                29                                                The parser shifted to state 29                                         
Token Read           29       3      35    cotton fabrics              Token type: Text                                                       
Reduce               16                   (16) ::= < (15) >            <tag> ::= LeftArrow <text> RightArrow                                  
Shift                11                                                The parser shifted to state 11                                         
Token Read           11       3      50   ;                            Token type: Terminator                                                 
Reduce               18                   (17) ::=  cotton fabrics     <text-chunk> ::= Text                                                  
Reduce               25                   (18) ::= (17)                <text> ::= <text-chunk>                                                
Reduce               43                   (19) ::= (16) (18)           <item> ::= <tag> <text>                                                
Reduce               35                   (20) ::= (13) , (19)         <item-or-expression-list> ::= <item> Separator <item>                  
Shift                41                                                The parser shifted to state 41                                         
Token Read           41       4       0                                Token type: EOF                                                        
Reduce               12                   (21) ::= (6) (7) (20) ;      <expression> ::= <item> <producer> <item-or-expression-list> Terminator
Reduce               15                   (22) ::= (21)                <scripture> ::= <expression>                                           
Accept               15                                                                                                                       



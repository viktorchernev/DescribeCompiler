========================================
Source Code (between the arrows)
========================================

🡆fabrics <QuvD4gqX> ->        //dude;

    wool fabrics <VBsu8OpW>, /* comment <*/
/* ->Comments, man [https://www.notube.com/watch?v=hTui12lKus] */     cotton fabrics <0RdNAvNs> [https://www.notube.com/watch?v=hTui12lKus];🡄

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
|  |  |  +--<item> ::= <text> <tag> Link
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--     cotton fabrics 
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--0RdNAvNs
|  |  |  |  |  +-->
|  |  |  |  +--[https://www.notube.com/watch?v=hTui12lKus]
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                                                       Description                                                            
---------------   -----   -----   -----   ---------------------------------------------------------------   -----------------------------------------------------------------------
Token Read            0       0       0   fabrics                                                           Token type: Text                                                       
Shift                12                                                                                     The parser shifted to state 12                                         
Token Read           12       0       8   <                                                                 Token type: LeftArrow                                                  
Reduce               18                   (1) ::= fabrics                                                   <text-chunk> ::= Text                                                  
Reduce               17                   (2) ::= (1)                                                       <text> ::= <text-chunk>                                                
Shift                24                                                                                     The parser shifted to state 24                                         
Token Read           24       0       9   QuvD4gqX                                                          Token type: Text                                                       
Shift                12                                                                                     The parser shifted to state 12                                         
Token Read           12       0      17   >                                                                 Token type: RightArrow                                                 
Reduce               18                   (3) ::= QuvD4gqX                                                  <text-chunk> ::= Text                                                  
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
Token Read           24       2      18   VBsu8OpW                                                          Token type: Text                                                       
Shift                12                                                                                     The parser shifted to state 12                                         
Token Read           12       2      26   >                                                                 Token type: RightArrow                                                 
Reduce               18                   (10) ::= VBsu8OpW                                                 <text-chunk> ::= Text                                                  
Reduce               36                   (11) ::= (10)                                                     <text> ::= <text-chunk>                                                
Shift                49                                                                                     The parser shifted to state 49                                         
Token Read           49       2      27   ,                                                                 Token type: Separator                                                  
Reduce               27                   (12) ::= < (11) >                                                 <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               33                   (13) ::= (9) (12)                                                 <item> ::= <text> <tag>                                                
Shift                46                                                                                     The parser shifted to state 46                                         
Token Read           46       3      65        cotton fabrics                                               Token type: Text                                                       
Shift                12                                                                                     The parser shifted to state 12                                         
Token Read           12       3      85   <                                                                 Token type: LeftArrow                                                  
Reduce               18                   (14) ::=      cotton fabrics                                      <text-chunk> ::= Text                                                  
Reduce               17                   (15) ::= (14)                                                     <text> ::= <text-chunk>                                                
Shift                24                                                                                     The parser shifted to state 24                                         
Token Read           24       3      86   0RdNAvNs                                                          Token type: Text                                                       
Shift                12                                                                                     The parser shifted to state 12                                         
Token Read           12       3      94   >                                                                 Token type: RightArrow                                                 
Reduce               18                   (16) ::= 0RdNAvNs                                                 <text-chunk> ::= Text                                                  
Reduce               36                   (17) ::= (16)                                                     <text> ::= <text-chunk>                                                
Shift                49                                                                                     The parser shifted to state 49                                         
Token Read           49       3      96   [https://www.notube.com/watch?v=hTui12lKus]                       Token type: Link                                                       
Reduce               27                   (18) ::= < (17) >                                                 <tag> ::= LeftArrow <text> RightArrow                                  
Shift                41                                                                                     The parser shifted to state 41                                         
Token Read           41       3     139   ;                                                                 Token type: Terminator                                                 
Reduce               51                   (19) ::= (15) (18) [https://www.notube.com/watch?v=hTui12lKus]    <item> ::= <text> <tag> Link                                           
Reduce               35                   (20) ::= (13) , (19)                                              <item-or-expression-list> ::= <item> Separator <item>                  
Shift                48                                                                                     The parser shifted to state 48                                         
Token Read           48       4       0                                                                     Token type: EOF                                                        
Reduce               13                   (21) ::= (6) (7) (20) ;                                           <expression> ::= <item> <producer> <item-or-expression-list> Terminator
Reduce               16                   (22) ::= (21)                                                     <scripture> ::= <expression>                                           
Accept               16                                                                                                                                                            



========================================
Source Code (between the arrows)
========================================

🡆fabrics <QuvD4gqX> ->        //dude;

    wool fabrics <VBsu8OpW>, /* comment <*/
/* -> {decorator} Comments, man [https://www.notube.com/watch?v=hTui12lKus] */     cotton fabrics <0RdNAvNs> {dec} [https://www.notube.com/watch?v=hTui12lKus];🡄

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
|  |  |  +--<item> ::= <text> <tag> Decorator Link
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--     cotton fabrics 
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--0RdNAvNs
|  |  |  |  |  +-->
|  |  |  |  +--{dec}
|  |  |  |  +--[https://www.notube.com/watch?v=hTui12lKus]
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                                                             Description                                                            
---------------   -----   -----   -----   ---------------------------------------------------------------------   -----------------------------------------------------------------------
Token Read            0       0       0   fabrics                                                                 Token type: Text                                                       
Shift                14                                                                                           The parser shifted to state 14                                         
Token Read           14       0       8   <                                                                       Token type: LeftArrow                                                  
Reduce               20                   (1) ::= fabrics                                                         <text-chunk> ::= Text                                                  
Reduce               19                   (2) ::= (1)                                                             <text> ::= <text-chunk>                                                
Shift                27                                                                                           The parser shifted to state 27                                         
Token Read           27       0       9   QuvD4gqX                                                                Token type: Text                                                       
Shift                14                                                                                           The parser shifted to state 14                                         
Token Read           14       0      17   >                                                                       Token type: RightArrow                                                 
Reduce               20                   (3) ::= QuvD4gqX                                                        <text-chunk> ::= Text                                                  
Reduce               45                   (4) ::= (3)                                                             <text> ::= <text-chunk>                                                
Shift                71                                                                                           The parser shifted to state 71                                         
Token Read           71       0      19   -                                                                       Token type: Hyphen                                                     
Reduce               31                   (5) ::= < (4) >                                                         <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               17                   (6) ::= (2) (5)                                                         <item> ::= <text> <tag>                                                
Shift                24                                                                                           The parser shifted to state 24                                         
Token Read           24       0      20   >                                                                       Token type: RightArrow                                                 
Shift                34                                                                                           The parser shifted to state 34                                         
Token Read           34       2       0       wool fabrics                                                        Token type: Text                                                       
Reduce               25                   (7) ::= - >                                                             <producer> ::= Hyphen RightArrow                                       
Shift                14                                                                                           The parser shifted to state 14                                         
Token Read           14       2      17   <                                                                       Token type: LeftArrow                                                  
Reduce               20                   (8) ::=     wool fabrics                                                <text-chunk> ::= Text                                                  
Reduce               19                   (9) ::= (8)                                                             <text> ::= <text-chunk>                                                
Shift                27                                                                                           The parser shifted to state 27                                         
Token Read           27       2      18   VBsu8OpW                                                                Token type: Text                                                       
Shift                14                                                                                           The parser shifted to state 14                                         
Token Read           14       2      26   >                                                                       Token type: RightArrow                                                 
Reduce               20                   (10) ::= VBsu8OpW                                                       <text-chunk> ::= Text                                                  
Reduce               45                   (11) ::= (10)                                                           <text> ::= <text-chunk>                                                
Shift                71                                                                                           The parser shifted to state 71                                         
Token Read           71       2      27   ,                                                                       Token type: Separator                                                  
Reduce               31                   (12) ::= < (11) >                                                       <tag> ::= LeftArrow <text> RightArrow                                  
Reduce               37                   (13) ::= (9) (12)                                                       <item> ::= <text> <tag>                                                
Shift                64                                                                                           The parser shifted to state 64                                         
Token Read           64       3      78        cotton fabrics                                                     Token type: Text                                                       
Shift                14                                                                                           The parser shifted to state 14                                         
Token Read           14       3      98   <                                                                       Token type: LeftArrow                                                  
Reduce               20                   (14) ::=      cotton fabrics                                            <text-chunk> ::= Text                                                  
Reduce               19                   (15) ::= (14)                                                           <text> ::= <text-chunk>                                                
Shift                27                                                                                           The parser shifted to state 27                                         
Token Read           27       3      99   0RdNAvNs                                                                Token type: Text                                                       
Shift                14                                                                                           The parser shifted to state 14                                         
Token Read           14       3     107   >                                                                       Token type: RightArrow                                                 
Reduce               20                   (16) ::= 0RdNAvNs                                                       <text-chunk> ::= Text                                                  
Reduce               45                   (17) ::= (16)                                                           <text> ::= <text-chunk>                                                
Shift                71                                                                                           The parser shifted to state 71                                         
Token Read           71       3     109   {dec}                                                                   Token type: Decorator                                                  
Reduce               31                   (18) ::= < (17) >                                                       <tag> ::= LeftArrow <text> RightArrow                                  
Shift                57                                                                                           The parser shifted to state 57                                         
Token Read           57       3     115   [https://www.notube.com/watch?v=hTui12lKus]                             Token type: Link                                                       
Shift                84                                                                                           The parser shifted to state 84                                         
Token Read           84       3     158   ;                                                                       Token type: Terminator                                                 
Reduce               93                   (19) ::= (15) (18) {dec} [https://www.notube.com/watch?v=hTui12lKus]    <item> ::= <text> <tag> Decorator Link                                 
Reduce               39                   (20) ::= (13) , (19)                                                    <item-or-expression-list> ::= <item> Separator <item>                  
Shift                66                                                                                           The parser shifted to state 66                                         
Token Read           66       4       0                                                                           Token type: EOF                                                        
Reduce               15                   (21) ::= (6) (7) (20) ;                                                 <expression> ::= <item> <producer> <item-or-expression-list> Terminator
Reduce               18                   (22) ::= (21)                                                           <scripture> ::= <expression>                                           
Accept               18                                                                                                                                                                  



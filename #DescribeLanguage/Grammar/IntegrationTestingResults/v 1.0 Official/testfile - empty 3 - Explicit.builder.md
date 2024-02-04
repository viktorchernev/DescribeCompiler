========================================
Source Code (between the arrows)
========================================

🡆fabrics ->> ;;🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <terminator>
|  |  +--<item> ::= <text>
|  |  |  +--<text> ::= <text-chunk>
|  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  +--fabrics 
|  |  +--<producer> ::= Hyphen RightArrow RightArrow
|  |  |  +---
|  |  |  +-->
|  |  |  +-->
|  |  +--<terminator> ::= Terminator Terminator
|  |  |  +--;
|  |  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value            Description                                    
---------------   -----   -----   -----   --------------------   -----------------------------------------------
Token Read            0       0       0   fabrics                Token type: Text                               
Shift                14                                          The parser shifted to state 14                 
Token Read           14       0       8   -                      Token type: Hyphen                             
Reduce               20                   (1) ::= fabrics        <text-chunk> ::= Text                          
Reduce               19                   (2) ::= (1)            <text> ::= <text-chunk>                        
Reduce               17                   (3) ::= (2)            <item> ::= <text>                              
Shift                24                                          The parser shifted to state 24                 
Token Read           24       0       9   >                      Token type: RightArrow                         
Shift                35                                          The parser shifted to state 35                 
Token Read           35       0      10   >                      Token type: RightArrow                         
Shift                64                                          The parser shifted to state 64                 
Token Read           64       0      12   ;                      Token type: Terminator                         
Reduce               25                   (4) ::= - > >          <producer> ::= Hyphen RightArrow RightArrow    
Shift                36                                          The parser shifted to state 36                 
Token Read           36       0      13   ;                      Token type: Terminator                         
Shift                65                                          The parser shifted to state 65                 
Token Read           65       1       0                          Token type: EOF                                
Reduce               41                   (5) ::= ; ;            <terminator> ::= Terminator Terminator         
Reduce               15                   (6) ::= (3) (4) (5)    <expression> ::= <item> <producer> <terminator>
Reduce               18                   (7) ::= (6)            <scripture> ::= <expression>                   
Accept               18                                                                                         



========================================
Source Code (between the arrows)
========================================

🡆fabrics [https://www.notube.com/watch?v=hTui12lKus]-> 
	
	synthetic fabrics <i1NLckN6> [https://www.notube.com/watch?v=hTui12lKus];🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression> Terminator
|  |  +--<item> ::= <text> Link
|  |  |  +--<text> ::= <text-chunk>
|  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  +--fabrics 
|  |  |  +--[https://www.notube.com/watch?v=hTui12lKus]
|  |  +--<producer> ::= Hyphen RightArrow
|  |  |  +---
|  |  |  +-->
|  |  +--<item-or-expression> ::= <item>
|  |  |  +--<item> ::= <text> <tag> Link
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--    synthetic fabrics 
|  |  |  |  +--<tag> ::= LeftArrow <text> RightArrow
|  |  |  |  |  +--<
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--i1NLckN6
|  |  |  |  |  +-->
|  |  |  |  +--[https://www.notube.com/watch?v=hTui12lKus]
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                                                     Description                                                       
---------------   -----   -----   -----   -------------------------------------------------------------   ------------------------------------------------------------------
Token Read            0       0       0   fabrics                                                         Token type: Text                                                  
Shift                12                                                                                   The parser shifted to state 12                                    
Token Read           12       0       8   [https://www.notube.com/watch?v=hTui12lKus]                     Token type: Link                                                  
Reduce               18                   (1) ::= fabrics                                                 <text-chunk> ::= Text                                             
Reduce               17                   (2) ::= (1)                                                     <text> ::= <text-chunk>                                           
Shift                25                                                                                   The parser shifted to state 25                                    
Token Read           25       0      51   -                                                               Token type: Hyphen                                                
Reduce               15                   (3) ::= (2) [https://www.notube.com/watch?v=hTui12lKus]         <item> ::= <text> Link                                            
Shift                22                                                                                   The parser shifted to state 22                                    
Token Read           22       0      52   >                                                               Token type: RightArrow                                            
Shift                30                                                                                   The parser shifted to state 30                                    
Token Read           30       2       0       synthetic fabrics                                           Token type: Text                                                  
Reduce               23                   (4) ::= - >                                                     <producer> ::= Hyphen RightArrow                                  
Shift                12                                                                                   The parser shifted to state 12                                    
Token Read           12       2      22   <                                                               Token type: LeftArrow                                             
Reduce               18                   (5) ::=     synthetic fabrics                                   <text-chunk> ::= Text                                             
Reduce               17                   (6) ::= (5)                                                     <text> ::= <text-chunk>                                           
Shift                24                                                                                   The parser shifted to state 24                                    
Token Read           24       2      23   i1NLckN6                                                        Token type: Text                                                  
Shift                12                                                                                   The parser shifted to state 12                                    
Token Read           12       2      31   >                                                               Token type: RightArrow                                            
Reduce               18                   (7) ::= i1NLckN6                                                <text-chunk> ::= Text                                             
Reduce               36                   (8) ::= (7)                                                     <text> ::= <text-chunk>                                           
Shift                49                                                                                   The parser shifted to state 49                                    
Token Read           49       2      33   [https://www.notube.com/watch?v=hTui12lKus]                     Token type: Link                                                  
Reduce               27                   (9) ::= < (8) >                                                 <tag> ::= LeftArrow <text> RightArrow                             
Shift                41                                                                                   The parser shifted to state 41                                    
Token Read           41       2      76   ;                                                               Token type: Terminator                                            
Reduce               33                   (10) ::= (6) (9) [https://www.notube.com/watch?v=hTui12lKus]    <item> ::= <text> <tag> Link                                      
Reduce               34                   (11) ::= (10)                                                   <item-or-expression> ::= <item>                                   
Shift                47                                                                                   The parser shifted to state 47                                    
Token Read           47       3       0                                                                   Token type: EOF                                                   
Reduce               13                   (12) ::= (3) (4) (11) ;                                         <expression> ::= <item> <producer> <item-or-expression> Terminator
Reduce               16                   (13) ::= (12)                                                   <scripture> ::= <expression>                                      
Accept               16                                                                                                                                                     



========================================
Source Code (between the arrows)
========================================

🡆fabrics [https://www.notube.com/watch?v=hTui12lKus]-> 
	
	synthetic fabrics 
	<i1NLckN6> 
	[https://www.notube.com/watch?v=hTui12lKus]
	{
		info | more info here
	}
	;🡄

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
|  |  |  +--<item> ::= <text> <tag> Link Decorator
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
|  |  |  |  +--{{CR}{LF}        info | more info here{CR}{LF}    }
|  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                                                                                                         Description                                                       
---------------   -----   -----   -----   -----------------------------------------------------------------------------------------------------------------   ------------------------------------------------------------------
Token Read            0       0       0   fabrics                                                                                                             Token type: Text                                                  
Shift                14                                                                                                                                       The parser shifted to state 14                                    
Token Read           14       0       8   [https://www.notube.com/watch?v=hTui12lKus]                                                                         Token type: Link                                                  
Reduce               20                   (1) ::= fabrics                                                                                                     <text-chunk> ::= Text                                             
Reduce               19                   (2) ::= (1)                                                                                                         <text> ::= <text-chunk>                                           
Shift                28                                                                                                                                       The parser shifted to state 28                                    
Token Read           28       0      51   -                                                                                                                   Token type: Hyphen                                                
Reduce               17                   (3) ::= (2) [https://www.notube.com/watch?v=hTui12lKus]                                                             <item> ::= <text> Link                                            
Shift                24                                                                                                                                       The parser shifted to state 24                                    
Token Read           24       0      52   >                                                                                                                   Token type: RightArrow                                            
Shift                34                                                                                                                                       The parser shifted to state 34                                    
Token Read           34       2       0       synthetic fabrics                                                                                               Token type: Text                                                  
Reduce               25                   (4) ::= - >                                                                                                         <producer> ::= Hyphen RightArrow                                  
Shift                14                                                                                                                                       The parser shifted to state 14                                    
Token Read           14       3       4   <                                                                                                                   Token type: LeftArrow                                             
Reduce               20                   (5) ::=     synthetic fabrics                                                                                       <text-chunk> ::= Text                                             
Reduce               19                   (6) ::= (5)                                                                                                         <text> ::= <text-chunk>                                           
Shift                27                                                                                                                                       The parser shifted to state 27                                    
Token Read           27       3       5   i1NLckN6                                                                                                            Token type: Text                                                  
Shift                14                                                                                                                                       The parser shifted to state 14                                    
Token Read           14       3      13   >                                                                                                                   Token type: RightArrow                                            
Reduce               20                   (7) ::= i1NLckN6                                                                                                    <text-chunk> ::= Text                                             
Reduce               45                   (8) ::= (7)                                                                                                         <text> ::= <text-chunk>                                           
Shift                71                                                                                                                                       The parser shifted to state 71                                    
Token Read           71       4       4   [https://www.notube.com/watch?v=hTui12lKus]                                                                         Token type: Link                                                  
Reduce               31                   (9) ::= < (8) >                                                                                                     <tag> ::= LeftArrow <text> RightArrow                             
Shift                58                                                                                                                                       The parser shifted to state 58                                    
Token Read           58       5       4   {{CR}{LF}        info | more info here{CR}{LF}    }                                                                 Token type: Decorator                                             
Shift                86                                                                                                                                       The parser shifted to state 86                                    
Token Read           86       8       4   ;                                                                                                                   Token type: Terminator                                            
Reduce               37                   (10) ::= (6) (9) [https://www.notube.com/watch?v=hTui12lKus] {{CR}{LF}        info | more info here{CR}{LF}    }    <item> ::= <text> <tag> Link Decorator                            
Reduce               38                   (11) ::= (10)                                                                                                       <item-or-expression> ::= <item>                                   
Shift                65                                                                                                                                       The parser shifted to state 65                                    
Token Read           65       9       0                                                                                                                       Token type: EOF                                                   
Reduce               15                   (12) ::= (3) (4) (11) ;                                                                                             <expression> ::= <item> <producer> <item-or-expression> Terminator
Reduce               18                   (13) ::= (12)                                                                                                       <scripture> ::= <expression>                                      
Accept               18                                                                                                                                                                                                         



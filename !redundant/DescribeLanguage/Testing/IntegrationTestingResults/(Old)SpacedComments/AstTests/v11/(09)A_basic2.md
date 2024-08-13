========================================
Source Code (between the arrows)
========================================

🡆fabrics [https://www.notube.com/watch?v=hTui12lKus]-> 
	
	synthetic fabrics https://some-link/
	<i1NLckN6> 
	[https://www.notube.com/watch?v=hTui12lKus]
	{
		info | more info here
	}
	;🡄

========================================
Derived Source Code (between the arrows)
========================================

🡆fabrics [https://www.notube.com/watch?v=hTui12lKus]-> 
	
	synthetic fabrics https://some-link/
	<i1NLckN6> 
	[https://www.notube.com/watch?v=hTui12lKus]
	{
		info | more info here
	}
	;🡄

========================================
Abstract Syntax Tree
========================================

Scripture : 

    filename - "Tests.Integration.Parser.TestFiles.TestFilesFor09.A_basic2.ds"
    namespace - NULL
    Exception - NULL

    Expression : 
    
        titleItem - Item : 
            
                tilde - NULL
                text - AstLeafNode/Text :  "fabrics [https://www.notube.com/watch?v=hTui12lKus]" 
                tag - NULL
                links - NULL
                decorators - NULL
            
        productionArrow - AstLeafNode/ProductionArrow :  "->"  " \r\n\t\r\n\t"
    
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "synthetic fabrics https://some-link/\r\n\t<i1NLckN6> \r\n\t[https://www.notube.com/watch?v=hTui12lKus]\r\n\t{\r\n\t\tinfo | more info here\r\n\t}"  "\r\n\t"
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ";" 
            
    
========================================
Abstract Syntax Tree (JSON)
========================================

{"filename":"Tests.Integration.Parser.TestFiles.TestFilesFor09.A_basic2.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"fabrics [https://www.notube.com/watch?v=hTui12lKus]","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":" \r\n\t\r\n\t"},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"synthetic fabrics https://some-link/\r\n\t<i1NLckN6> \r\n\t[https://www.notube.com/watch?v=hTui12lKus]\r\n\t{\r\n\t\tinfo | more info here\r\n\t}","leadingTrivia":"","trailingTrivia":"\r\n\t"},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":";","leadingTrivia":"","trailingTrivia":""}}]}],"exception":null}
========================================
Source Code (between the arrows)
========================================

🡆fabrics -> 
	
	synthetic fabrics <i1NLckN6>;🡄

========================================
Derived Source Code (between the arrows)
========================================

🡆fabrics -> 
	
	synthetic fabrics <i1NLckN6>;🡄

========================================
Abstract Syntax Tree
========================================

Scripture : 

    filename - "Tests.Integration.Parser.TestFiles.TestFilesFor07.A_basic2.ds"
    namespace - NULL
    Exception - NULL

    Expression : 
    
        titleItem - Item : 
            
                tilde - NULL
                text - AstLeafNode/Text :  "fabrics"  " "
                tag - NULL
                links - NULL
                decorators - NULL
            
        productionArrow - AstLeafNode/ProductionArrow :  "->"  " \r\n\t\r\n\t"
    
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "synthetic fabrics <i1NLckN6>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ";" 
            
    
========================================
Abstract Syntax Tree (JSON)
========================================

{"filename":"Tests.Integration.Parser.TestFiles.TestFilesFor07.A_basic2.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"fabrics","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":" \r\n\t\r\n\t"},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"synthetic fabrics <i1NLckN6>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":";","leadingTrivia":"","trailingTrivia":""}}]}],"exception":null}
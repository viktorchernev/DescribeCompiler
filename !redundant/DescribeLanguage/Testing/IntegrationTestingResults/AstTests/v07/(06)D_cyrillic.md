========================================
Source Code (between the arrows)
========================================

🡆платове ->

	вълнени платове,
	памучни платове,
	копринени платове,
	синтетични платове;🡄

========================================
Derived Source Code (between the arrows)
========================================

🡆платове ->

	вълнени платове,
	памучни платове,
	копринени платове,
	синтетични платове;🡄

========================================
Abstract Syntax Tree
========================================

Scripture : 

    filename - "Tests.Integration.Parser.TestFiles.TestFilesFor06.D_cyrillic.ds"
    namespace - NULL
    Exception - NULL

    Expression : 
    
        titleItem - Item : 
            
                tilde - NULL
                text - AstLeafNode/Text :  "платове"  " "
                tag - NULL
                links - NULL
                decorators - NULL
            
        productionArrow - AstLeafNode/ProductionArrow :  "->"  "\r\n\r\n\t"
    
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "вълнени платове" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Separator :  ","  "\r\n\t"
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "памучни платове" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Separator :  ","  "\r\n\t"
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "копринени платове" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Separator :  ","  "\r\n\t"
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "синтетични платове" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Terminator :  ";" 
            
    
========================================
Abstract Syntax Tree (JSON)
========================================

{"filename":"Tests.Integration.Parser.TestFiles.TestFilesFor06.D_cyrillic.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"платове","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":"\r\n\r\n\t"},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"вълнени платове","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Separator","text":",","leadingTrivia":"","trailingTrivia":"\r\n\t"}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"памучни платове","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Separator","text":",","leadingTrivia":"","trailingTrivia":"\r\n\t"}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"копринени платове","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Separator","text":",","leadingTrivia":"","trailingTrivia":"\r\n\t"}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"синтетични платове","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Terminator","text":";","leadingTrivia":"","trailingTrivia":""}}]}],"exception":null}
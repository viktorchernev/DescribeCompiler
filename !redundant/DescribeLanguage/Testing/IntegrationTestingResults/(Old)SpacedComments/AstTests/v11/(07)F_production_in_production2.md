========================================
Source Code (between the arrows)
========================================

🡆macronutrients <eQxYylc3> ->

    water <tdgS8qBO>,
	fiber <OpdFntBx> ->

        what <MLUxjdg8>,
        not <qkVgxZIs>;
;
🡄

========================================
Derived Source Code (between the arrows)
========================================

🡆macronutrients <eQxYylc3> ->

    water <tdgS8qBO>,
	fiber <OpdFntBx> ->

        what <MLUxjdg8>,
        not <qkVgxZIs>;
;
🡄

========================================
Abstract Syntax Tree
========================================

Scripture : 

    filename - "Tests.Integration.Parser.TestFiles.TestFilesFor07.F_production_in_production2.ds"
    namespace - NULL
    Exception - NULL

    Expression : 
    
        titleItem - Item : 
            
                tilde - NULL
                text - AstLeafNode/Text :  "macronutrients <eQxYylc3>"  " "
                tag - NULL
                links - NULL
                decorators - NULL
            
        productionArrow - AstLeafNode/ProductionArrow :  "->"  "\r\n\r\n    "
    
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "water <tdgS8qBO>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n\t"
            
        line - ExpressionLine : 
            
                body - Expression : 
                    
                        titleItem - Item : 
                            
                                tilde - NULL
                                text - AstLeafNode/Text :  "fiber <OpdFntBx>"  " "
                                tag - NULL
                                links - NULL
                                decorators - NULL
                            
                        productionArrow - AstLeafNode/ProductionArrow :  "->"  "\r\n\r\n        "
                    
                        line - ExpressionLine : 
                            
                                body - Item : 
                                    
                                        tilde - NULL
                                        text - AstLeafNode/Text :  "what <MLUxjdg8>" 
                                        tag - NULL
                                        links - NULL
                                        decorators - NULL
                                    
                                punctuation - AstLeafNode/Text :  ","  "\r\n        "
                            
                        line - ExpressionLine : 
                            
                                body - Item : 
                                    
                                        tilde - NULL
                                        text - AstLeafNode/Text :  "not <qkVgxZIs>" 
                                        tag - NULL
                                        links - NULL
                                        decorators - NULL
                                    
                                punctuation - AstLeafNode/Text :  ";"  "\n"
                            
                    
                punctuation - AstLeafNode/Text :  ";"  "\n"
            
    
========================================
Abstract Syntax Tree (JSON)
========================================

{"filename":"Tests.Integration.Parser.TestFiles.TestFilesFor07.F_production_in_production2.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"macronutrients <eQxYylc3>","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":"\r\n\r\n    "},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"water <tdgS8qBO>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n\t"}},{"body":{"title":{"tilde":null,"text":{"leafType":"Text","text":"fiber <OpdFntBx>","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":"\r\n\r\n        "},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"what <MLUxjdg8>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n        "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"not <qkVgxZIs>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":";","leadingTrivia":"","trailingTrivia":"\n"}}]},"punctuation":{"leafType":"Text","text":";","leadingTrivia":"","trailingTrivia":"\n"}}]}],"exception":null}
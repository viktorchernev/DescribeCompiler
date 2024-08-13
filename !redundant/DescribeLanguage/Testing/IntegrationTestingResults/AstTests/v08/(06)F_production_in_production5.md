========================================
Source Code (between the arrows)
========================================

🡆macronutrients ->

	water,
    salt,
    fiber ->

        what,
        not;
	
	science ->
		
		math,
		informathics,
		medicine;;🡄

========================================
Derived Source Code (between the arrows)
========================================

🡆macronutrients ->

	water,
    salt,
    fiber ->

        what,
        not;
	
	science ->
		
		math,
		informathics,
		medicine;;🡄

========================================
Abstract Syntax Tree
========================================

Scripture : 

    filename - "Tests.Integration.Parser.TestFiles.TestFilesFor06.F_production_in_production5.ds"
    namespace - NULL
    Exception - NULL

    Expression : 
    
        titleItem - Item : 
            
                tilde - NULL
                text - AstLeafNode/Text :  "macronutrients"  " "
                tag - NULL
                links - NULL
                decorators - NULL
            
        productionArrow - AstLeafNode/ProductionArrow :  "->"  "\r\n\r\n\t"
    
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "water" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n    "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "salt" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n    "
            
        line - ExpressionLine : 
            
                body - Expression : 
                    
                        titleItem - Item : 
                            
                                tilde - NULL
                                text - AstLeafNode/Text :  "fiber"  " "
                                tag - NULL
                                links - NULL
                                decorators - NULL
                            
                        productionArrow - AstLeafNode/ProductionArrow :  "->"  "\r\n\r\n        "
                    
                        line - ExpressionLine : 
                            
                                body - Item : 
                                    
                                        tilde - NULL
                                        text - AstLeafNode/Text :  "what" 
                                        tag - NULL
                                        links - NULL
                                        decorators - NULL
                                    
                                punctuation - AstLeafNode/Text :  ","  "\r\n        "
                            
                        line - ExpressionLine : 
                            
                                body - Item : 
                                    
                                        tilde - NULL
                                        text - AstLeafNode/Text :  "not" 
                                        tag - NULL
                                        links - NULL
                                        decorators - NULL
                                    
                                punctuation - AstLeafNode/Text :  ";"  "\r\n\t\r\n\t"
                            
                    
                punctuation - NULL
            
        line - ExpressionLine : 
            
                body - Expression : 
                    
                        titleItem - Item : 
                            
                                tilde - NULL
                                text - AstLeafNode/Text :  "science"  " "
                                tag - NULL
                                links - NULL
                                decorators - NULL
                            
                        productionArrow - AstLeafNode/ProductionArrow :  "->"  "\r\n\t\t\r\n\t\t"
                    
                        line - ExpressionLine : 
                            
                                body - Item : 
                                    
                                        tilde - NULL
                                        text - AstLeafNode/Text :  "math" 
                                        tag - NULL
                                        links - NULL
                                        decorators - NULL
                                    
                                punctuation - AstLeafNode/Text :  ","  "\r\n\t\t"
                            
                        line - ExpressionLine : 
                            
                                body - Item : 
                                    
                                        tilde - NULL
                                        text - AstLeafNode/Text :  "informathics" 
                                        tag - NULL
                                        links - NULL
                                        decorators - NULL
                                    
                                punctuation - AstLeafNode/Text :  ","  "\r\n\t\t"
                            
                        line - ExpressionLine : 
                            
                                body - Item : 
                                    
                                        tilde - NULL
                                        text - AstLeafNode/Text :  "medicine" 
                                        tag - NULL
                                        links - NULL
                                        decorators - NULL
                                    
                                punctuation - AstLeafNode/Text :  ";" 
                            
                    
                punctuation - AstLeafNode/Text :  ";" 
            
    
========================================
Abstract Syntax Tree (JSON)
========================================

{"filename":"Tests.Integration.Parser.TestFiles.TestFilesFor06.F_production_in_production5.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"macronutrients","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":"\r\n\r\n\t"},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"water","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"salt","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n    "}},{"body":{"title":{"tilde":null,"text":{"leafType":"Text","text":"fiber","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":"\r\n\r\n        "},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"what","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n        "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"not","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":";","leadingTrivia":"","trailingTrivia":"\r\n\t\r\n\t"}}]},"punctuation":null},{"body":{"title":{"tilde":null,"text":{"leafType":"Text","text":"science","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":"\r\n\t\t\r\n\t\t"},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"math","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n\t\t"}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"informathics","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n\t\t"}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"medicine","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":";","leadingTrivia":"","trailingTrivia":""}}]},"punctuation":{"leafType":"Text","text":";","leadingTrivia":"","trailingTrivia":""}}]}],"exception":null}
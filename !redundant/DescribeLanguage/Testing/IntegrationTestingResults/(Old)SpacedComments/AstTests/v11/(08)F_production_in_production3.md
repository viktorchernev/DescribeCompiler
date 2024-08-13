========================================
Source Code (between the arrows)
========================================

🡆macronutrients <oVs6tsnU> ->

    water <9Y9uFDwu>,
	fiber <PALnQoTQ>[http://testlink.com/] ->

        what [http://testlink.com/]<6hlYVfaz>,
        not [http://testlink.com/]<gubSBEDe>;

	somth else [http://testlink.com/]<hAyLdw3m>;🡄

========================================
Derived Source Code (between the arrows)
========================================

🡆macronutrients <oVs6tsnU> ->

    water <9Y9uFDwu>,
	fiber <PALnQoTQ>[http://testlink.com/] ->

        what [http://testlink.com/]<6hlYVfaz>,
        not [http://testlink.com/]<gubSBEDe>;

	somth else [http://testlink.com/]<hAyLdw3m>;🡄

========================================
Abstract Syntax Tree
========================================

Scripture : 

    filename - "Tests.Integration.Parser.TestFiles.TestFilesFor08.F_production_in_production3.ds"
    namespace - NULL
    Exception - NULL

    Expression : 
    
        titleItem - Item : 
            
                tilde - NULL
                text - AstLeafNode/Text :  "macronutrients <oVs6tsnU>"  " "
                tag - NULL
                links - NULL
                decorators - NULL
            
        productionArrow - AstLeafNode/ProductionArrow :  "->"  "\r\n\r\n    "
    
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "water <9Y9uFDwu>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n\t"
            
        line - ExpressionLine : 
            
                body - Expression : 
                    
                        titleItem - Item : 
                            
                                tilde - NULL
                                text - AstLeafNode/Text :  "fiber <PALnQoTQ>[http://testlink.com/]"  " "
                                tag - NULL
                                links - NULL
                                decorators - NULL
                            
                        productionArrow - AstLeafNode/ProductionArrow :  "->"  "\r\n\r\n        "
                    
                        line - ExpressionLine : 
                            
                                body - Item : 
                                    
                                        tilde - NULL
                                        text - AstLeafNode/Text :  "what [http://testlink.com/]<6hlYVfaz>" 
                                        tag - NULL
                                        links - NULL
                                        decorators - NULL
                                    
                                punctuation - AstLeafNode/Text :  ","  "\r\n        "
                            
                        line - ExpressionLine : 
                            
                                body - Item : 
                                    
                                        tilde - NULL
                                        text - AstLeafNode/Text :  "not [http://testlink.com/]<gubSBEDe>" 
                                        tag - NULL
                                        links - NULL
                                        decorators - NULL
                                    
                                punctuation - AstLeafNode/Text :  ";"  "\r\n\r\n\t"
                            
                    
                punctuation - NULL
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "somth else [http://testlink.com/]<hAyLdw3m>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ";" 
            
    
========================================
Abstract Syntax Tree (JSON)
========================================

{"filename":"Tests.Integration.Parser.TestFiles.TestFilesFor08.F_production_in_production3.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"macronutrients <oVs6tsnU>","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":"\r\n\r\n    "},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"water <9Y9uFDwu>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n\t"}},{"body":{"title":{"tilde":null,"text":{"leafType":"Text","text":"fiber <PALnQoTQ>[http://testlink.com/]","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":"\r\n\r\n        "},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"what [http://testlink.com/]<6hlYVfaz>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n        "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"not [http://testlink.com/]<gubSBEDe>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":";","leadingTrivia":"","trailingTrivia":"\r\n\r\n\t"}}]},"punctuation":null},{"body":{"tilde":null,"text":{"leafType":"Text","text":"somth else [http://testlink.com/]<hAyLdw3m>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":";","leadingTrivia":"","trailingTrivia":""}}]}],"exception":null}
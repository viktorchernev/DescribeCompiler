========================================
Source Code (between the arrows)
========================================

🡆macronutrients <Zcm0y9mS> ->

    fiber <ZxMvmqeZ>,
    water <xePTheNI>;

micronutrients <l7qy3zi2>->

    vitamins (ABCDEK) <6Nq8AWj7>,
    minerals (micronutrients) <jG4U9bwg>;🡄

========================================
Derived Source Code (between the arrows)
========================================

🡆macronutrients <Zcm0y9mS> ->

    fiber <ZxMvmqeZ>,
    water <xePTheNI>;

micronutrients <l7qy3zi2>->

    vitamins (ABCDEK) <6Nq8AWj7>,
    minerals (micronutrients) <jG4U9bwg>;🡄

========================================
Abstract Syntax Tree
========================================

Scripture : 

    filename - "Tests.Integration.Parser.TestFiles.TestFilesFor07.A_twoRoots.ds"
    namespace - NULL
    Exception - NULL

    Expression : 
    
        titleItem - Item : 
            
                tilde - NULL
                text - AstLeafNode/Text :  "macronutrients <Zcm0y9mS>"  " "
                tag - NULL
                links - NULL
                decorators - NULL
            
        productionArrow - AstLeafNode/ProductionArrow :  "->"  "\n\n    "
    
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "fiber <ZxMvmqeZ>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\n    "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "water <xePTheNI>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ";"  "\n\n"
            
    
    Expression : 
    
        titleItem - Item : 
            
                tilde - NULL
                text - AstLeafNode/Text :  "micronutrients <l7qy3zi2>" 
                tag - NULL
                links - NULL
                decorators - NULL
            
        productionArrow - AstLeafNode/ProductionArrow :  "->"  "\n\n    "
    
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "vitamins (ABCDEK) <6Nq8AWj7>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\n    "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "minerals (micronutrients) <jG4U9bwg>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ";" 
            
    
========================================
Abstract Syntax Tree (JSON)
========================================

{"filename":"Tests.Integration.Parser.TestFiles.TestFilesFor07.A_twoRoots.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"macronutrients <Zcm0y9mS>","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":"\n\n    "},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"fiber <ZxMvmqeZ>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"water <xePTheNI>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":";","leadingTrivia":"","trailingTrivia":"\n\n"}}]},{"title":{"tilde":null,"text":{"leafType":"Text","text":"micronutrients <l7qy3zi2>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":"\n\n    "},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"vitamins (ABCDEK) <6Nq8AWj7>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"minerals (micronutrients) <jG4U9bwg>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":";","leadingTrivia":"","trailingTrivia":""}}]}],"exception":null}
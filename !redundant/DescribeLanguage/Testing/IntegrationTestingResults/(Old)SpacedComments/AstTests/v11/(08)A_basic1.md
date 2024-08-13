========================================
Source Code (between the arrows)
========================================

🡆fabrics [https://en.test.org/wiki/List_of_fabrics] <QpeudYXy> ->

	wool fabrics [https://en.test.org/wiki/Wool | wikipedia] <54vHCQwI>,
	cotton fabrics [https://en.test.org/wiki/Cotton] <Ll0bDtIQ>,
	silk fabrics [https://en.test.org/wiki/Silk | test.org]<6huM44Hm>,
	synthetic fabrics [https://en.test.org/wiki/Synthetic]<oAgVUPi0>;🡄

========================================
Derived Source Code (between the arrows)
========================================

🡆fabrics [https://en.test.org/wiki/List_of_fabrics] <QpeudYXy> ->

	wool fabrics [https://en.test.org/wiki/Wool | wikipedia] <54vHCQwI>,
	cotton fabrics [https://en.test.org/wiki/Cotton] <Ll0bDtIQ>,
	silk fabrics [https://en.test.org/wiki/Silk | test.org]<6huM44Hm>,
	synthetic fabrics [https://en.test.org/wiki/Synthetic]<oAgVUPi0>;🡄

========================================
Abstract Syntax Tree
========================================

Scripture : 

    filename - "Tests.Integration.Parser.TestFiles.TestFilesFor08.A_basic1.ds"
    namespace - NULL
    Exception - NULL

    Expression : 
    
        titleItem - Item : 
            
                tilde - NULL
                text - AstLeafNode/Text :  "fabrics [https://en.test.org/wiki/List_of_fabrics] <QpeudYXy>"  " "
                tag - NULL
                links - NULL
                decorators - NULL
            
        productionArrow - AstLeafNode/ProductionArrow :  "->"  "\r\n\r\n\t"
    
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "wool fabrics [https://en.test.org/wiki/Wool | wikipedia] <54vHCQwI>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n\t"
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "cotton fabrics [https://en.test.org/wiki/Cotton] <Ll0bDtIQ>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n\t"
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "silk fabrics [https://en.test.org/wiki/Silk | test.org]<6huM44Hm>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n\t"
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "synthetic fabrics [https://en.test.org/wiki/Synthetic]<oAgVUPi0>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ";" 
            
    
========================================
Abstract Syntax Tree (JSON)
========================================

{"filename":"Tests.Integration.Parser.TestFiles.TestFilesFor08.A_basic1.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"fabrics [https://en.test.org/wiki/List_of_fabrics] <QpeudYXy>","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":"\r\n\r\n\t"},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"wool fabrics [https://en.test.org/wiki/Wool | wikipedia] <54vHCQwI>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n\t"}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"cotton fabrics [https://en.test.org/wiki/Cotton] <Ll0bDtIQ>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n\t"}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"silk fabrics [https://en.test.org/wiki/Silk | test.org]<6huM44Hm>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n\t"}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"synthetic fabrics [https://en.test.org/wiki/Synthetic]<oAgVUPi0>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":";","leadingTrivia":"","trailingTrivia":""}}]}],"exception":null}
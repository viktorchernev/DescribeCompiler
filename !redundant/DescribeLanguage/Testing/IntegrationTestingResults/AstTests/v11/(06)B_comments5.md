========================================
Source Code (between the arrows)
========================================

🡆fabrics -> // comment here

    wool fabrics,
    cotton fabrics,
    silk fabrics,
    synthetic fabrics;// comment last🡄

========================================
Derived Source Code (between the arrows)
========================================

🡆fabrics -> // comment here

    wool fabrics,
    cotton fabrics,
    silk fabrics,
    synthetic fabrics;// comment last🡄

========================================
Abstract Syntax Tree
========================================

Scripture : 

    filename - "Tests.Integration.Parser.TestFiles.TestFilesFor06.B_comments5.ds"
    namespace - NULL
    Exception - NULL

    Expression : 
    
        titleItem - Item : 
            
                tilde - NULL
                text - AstLeafNode/Text :  "fabrics"  " "
                tag - NULL
                links - NULL
                decorators - NULL
            
        productionArrow - AstLeafNode/ProductionArrow :  "-> // comment here"  "\r\n\r\n    "
    
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "wool fabrics" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n    "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "cotton fabrics" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n    "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "silk fabrics" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n    "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "synthetic fabrics" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ";// comment last" 
            
    
========================================
Abstract Syntax Tree (JSON)
========================================

{"filename":"Tests.Integration.Parser.TestFiles.TestFilesFor06.B_comments5.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"fabrics","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"-> // comment here","leadingTrivia":"","trailingTrivia":"\r\n\r\n    "},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"wool fabrics","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"cotton fabrics","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"silk fabrics","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"synthetic fabrics","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":";// comment last","leadingTrivia":"","trailingTrivia":""}}]}],"exception":null}
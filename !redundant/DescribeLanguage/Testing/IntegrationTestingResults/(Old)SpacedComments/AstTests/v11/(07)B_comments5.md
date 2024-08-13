========================================
Source Code (between the arrows)
========================================

🡆fabrics <xpXWehDW> -> // comment here

    wool fabrics <TcD3LcoW>,
    cotton fabrics <thZBzyNc>,
    silk fabrics <dOlQGMJ4>,
    synthetic fabrics <Ln7Y7Dme>;// comment last🡄

========================================
Derived Source Code (between the arrows)
========================================

🡆fabrics <xpXWehDW> -> // comment here

    wool fabrics <TcD3LcoW>,
    cotton fabrics <thZBzyNc>,
    silk fabrics <dOlQGMJ4>,
    synthetic fabrics <Ln7Y7Dme>;// comment last🡄

========================================
Abstract Syntax Tree
========================================

Scripture : 

    filename - "Tests.Integration.Parser.TestFiles.TestFilesFor07.B_comments5.ds"
    namespace - NULL
    Exception - NULL

    Expression : 
    
        titleItem - Item : 
            
                tilde - NULL
                text - AstLeafNode/Text :  "fabrics <xpXWehDW>"  " "
                tag - NULL
                links - NULL
                decorators - NULL
            
        productionArrow - AstLeafNode/ProductionArrow :  "-> // comment here"  "\r\n\r\n    "
    
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "wool fabrics <TcD3LcoW>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n    "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "cotton fabrics <thZBzyNc>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n    "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "silk fabrics <dOlQGMJ4>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n    "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "synthetic fabrics <Ln7Y7Dme>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ";// comment last" 
            
    
========================================
Abstract Syntax Tree (JSON)
========================================

{"filename":"Tests.Integration.Parser.TestFiles.TestFilesFor07.B_comments5.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"fabrics <xpXWehDW>","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"-> // comment here","leadingTrivia":"","trailingTrivia":"\r\n\r\n    "},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"wool fabrics <TcD3LcoW>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"cotton fabrics <thZBzyNc>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"silk fabrics <dOlQGMJ4>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"synthetic fabrics <Ln7Y7Dme>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":";// comment last","leadingTrivia":"","trailingTrivia":""}}]}],"exception":null}
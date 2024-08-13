========================================
Source Code (between the arrows)
========================================

🡆fabrics <qJobcYNC> -> // comment here

    wool fabrics <WmtITd8B>,
    cotton fabrics <KGkvDUZH>,
    silk fabrics <BbiZz4Ie>,
    synthetic fabrics <gCWv1P46>;

// comment last🡄

========================================
Derived Source Code (between the arrows)
========================================

🡆fabrics <qJobcYNC> -> // comment here

    wool fabrics <WmtITd8B>,
    cotton fabrics <KGkvDUZH>,
    silk fabrics <BbiZz4Ie>,
    synthetic fabrics <gCWv1P46>;

🡄

========================================
Abstract Syntax Tree
========================================

Scripture : 

    filename - "Tests.Integration.Parser.TestFiles.TestFilesFor07.B_comments4.ds"
    namespace - NULL
    Exception - NULL

    Expression : 
    
        titleItem - Item : 
            
                tilde - NULL
                text - AstLeafNode/Text :  "fabrics <qJobcYNC>"  " "
                tag - NULL
                links - NULL
                decorators - NULL
            
        productionArrow - AstLeafNode/ProductionArrow :  "-> // comment here"  "\r\n\r\n    "
    
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "wool fabrics <WmtITd8B>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n    "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "cotton fabrics <KGkvDUZH>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n    "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "silk fabrics <BbiZz4Ie>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n    "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "synthetic fabrics <gCWv1P46>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ";"  "\r\n\r\n"
            
    
========================================
Abstract Syntax Tree (JSON)
========================================

{"filename":"Tests.Integration.Parser.TestFiles.TestFilesFor07.B_comments4.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"fabrics <qJobcYNC>","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"-> // comment here","leadingTrivia":"","trailingTrivia":"\r\n\r\n    "},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"wool fabrics <WmtITd8B>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"cotton fabrics <KGkvDUZH>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"silk fabrics <BbiZz4Ie>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"synthetic fabrics <gCWv1P46>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":";","leadingTrivia":"","trailingTrivia":"\r\n\r\n"}}]}],"exception":null}
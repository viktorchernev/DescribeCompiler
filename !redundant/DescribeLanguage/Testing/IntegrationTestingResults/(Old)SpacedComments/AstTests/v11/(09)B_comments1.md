========================================
Source Code (between the arrows)
========================================

🡆fabrics <KvtgGtnv>[] -> // comment here [https://www.notube.com/watch?v=hTui12lKus] {decorator} 

    wool fabrics <rUEqmXfk>[https://www.notube.com/watch?v=hTui12lKus] {decorator},
    cotton fabrics [https://www.notube.com/watch?v=hTui12lKus]{decorator}<wpra8mUV>,
    silk fabrics <VFoIEr0T>[],
    synthetic fabrics <oI5DOuPh>;🡄

========================================
Derived Source Code (between the arrows)
========================================

🡆fabrics <KvtgGtnv>[] -> // comment here [https://www.notube.com/watch?v=hTui12lKus] {decorator} 

    wool fabrics <rUEqmXfk>[https://www.notube.com/watch?v=hTui12lKus] {decorator},
    cotton fabrics [https://www.notube.com/watch?v=hTui12lKus]{decorator}<wpra8mUV>,
    silk fabrics <VFoIEr0T>[],
    synthetic fabrics <oI5DOuPh>;🡄

========================================
Abstract Syntax Tree
========================================

Scripture : 

    filename - "Tests.Integration.Parser.TestFiles.TestFilesFor09.B_comments1.ds"
    namespace - NULL
    Exception - NULL

    Expression : 
    
        titleItem - Item : 
            
                tilde - NULL
                text - AstLeafNode/Text :  "fabrics <KvtgGtnv>[]"  " "
                tag - NULL
                links - NULL
                decorators - NULL
            
        productionArrow - AstLeafNode/ProductionArrow :  "-> // comment here [https://www.notube.com/watch?v=hTui12lKus] {decorator}"  " \r\n\r\n    "
    
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "wool fabrics <rUEqmXfk>[https://www.notube.com/watch?v=hTui12lKus] {decorator}" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n    "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "cotton fabrics [https://www.notube.com/watch?v=hTui12lKus]{decorator}<wpra8mUV>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n    "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "silk fabrics <VFoIEr0T>[]" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n    "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "synthetic fabrics <oI5DOuPh>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ";" 
            
    
========================================
Abstract Syntax Tree (JSON)
========================================

{"filename":"Tests.Integration.Parser.TestFiles.TestFilesFor09.B_comments1.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"fabrics <KvtgGtnv>[]","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"-> // comment here [https://www.notube.com/watch?v=hTui12lKus] {decorator}","leadingTrivia":"","trailingTrivia":" \r\n\r\n    "},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"wool fabrics <rUEqmXfk>[https://www.notube.com/watch?v=hTui12lKus] {decorator}","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"cotton fabrics [https://www.notube.com/watch?v=hTui12lKus]{decorator}<wpra8mUV>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"silk fabrics <VFoIEr0T>[]","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"synthetic fabrics <oI5DOuPh>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":";","leadingTrivia":"","trailingTrivia":""}}]}],"exception":null}
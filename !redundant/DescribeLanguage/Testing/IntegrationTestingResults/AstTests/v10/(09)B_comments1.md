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

🡆fabrics <KvtgGtnv>-> // comment here [https://www.notube.com/watch?v=hTui12lKus] {decorator} 

    wool fabrics <rUEqmXfk>,
    cotton fabrics <wpra8mUV>,
    silk fabrics <VFoIEr0T>,
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
                text - AstLeafNode/Text :  "fabrics"  " "
                tag - ""<" "KvtgGtnv"  ">""
                links - NULL
                decorators - NULL
            
        productionArrow - AstLeafNode/ProductionArrow :  "-> // comment here [https://www.notube.com/watch?v=hTui12lKus] {decorator}"  " \r\n\r\n    "
    
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "wool fabrics"  " "
                        tag - ""<" "rUEqmXfk"  ">""
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n    "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "cotton fabrics"  " "
                        tag - ""<" "wpra8mUV"  ">""
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n    "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "silk fabrics"  " "
                        tag - ""<" "VFoIEr0T"  ">""
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n    "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "synthetic fabrics"  " "
                        tag - ""<" "oI5DOuPh"  ">""
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ";" 
            
    
========================================
Abstract Syntax Tree (JSON)
========================================

{"filename":"Tests.Integration.Parser.TestFiles.TestFilesFor09.B_comments1.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"fabrics","leadingTrivia":"","trailingTrivia":" "},"tag":{"openBracket":{"leafType":"OpenTag","text":"<","leadingTrivia":"","trailingTrivia":""},"id":{"leafType":"Text","text":"KvtgGtnv","leadingTrivia":"","trailingTrivia":""},"closeBracket":{"leafType":"CloseTag","text":">","leadingTrivia":"","trailingTrivia":""}},"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"-> // comment here [https://www.notube.com/watch?v=hTui12lKus] {decorator}","leadingTrivia":"","trailingTrivia":" \r\n\r\n    "},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"wool fabrics","leadingTrivia":"","trailingTrivia":" "},"tag":{"openBracket":{"leafType":"OpenTag","text":"<","leadingTrivia":"","trailingTrivia":""},"id":{"leafType":"Text","text":"rUEqmXfk","leadingTrivia":"","trailingTrivia":""},"closeBracket":{"leafType":"CloseTag","text":">","leadingTrivia":"","trailingTrivia":""}},"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"cotton fabrics","leadingTrivia":"","trailingTrivia":" "},"tag":{"openBracket":{"leafType":"OpenTag","text":"<","leadingTrivia":"","trailingTrivia":""},"id":{"leafType":"Text","text":"wpra8mUV","leadingTrivia":"","trailingTrivia":""},"closeBracket":{"leafType":"CloseTag","text":">","leadingTrivia":"","trailingTrivia":""}},"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"silk fabrics","leadingTrivia":"","trailingTrivia":" "},"tag":{"openBracket":{"leafType":"OpenTag","text":"<","leadingTrivia":"","trailingTrivia":""},"id":{"leafType":"Text","text":"VFoIEr0T","leadingTrivia":"","trailingTrivia":""},"closeBracket":{"leafType":"CloseTag","text":">","leadingTrivia":"","trailingTrivia":""}},"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"synthetic fabrics","leadingTrivia":"","trailingTrivia":" "},"tag":{"openBracket":{"leafType":"OpenTag","text":"<","leadingTrivia":"","trailingTrivia":""},"id":{"leafType":"Text","text":"oI5DOuPh","leadingTrivia":"","trailingTrivia":""},"closeBracket":{"leafType":"CloseTag","text":">","leadingTrivia":"","trailingTrivia":""}},"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":";","leadingTrivia":"","trailingTrivia":""}}]}],"exception":null}
========================================
Source Code (between the arrows)
========================================

🡆fabrics <QuvD4gqX> ->        // dude;

    wool fabrics <VBsu8OpW>, /* comment <*/
/* -> {decorator} Comments, man [https://www.notube.com/watch?v=hTui12lKus] */     cotton fabrics <0RdNAvNs> {dec} [https://www.notube.com/watch?v=hTui12lKus];🡄

========================================
Derived Source Code (between the arrows)
========================================

🡆fabrics <QuvD4gqX> ->        // dude;

    wool fabrics <VBsu8OpW>, /* comment <*/
cotton fabrics <0RdNAvNs> {dec} [https://www.notube.com/watch?v=hTui12lKus];🡄

========================================
Abstract Syntax Tree
========================================

Scripture : 

    filename - "Tests.Integration.Parser.TestFiles.TestFilesFor09.B_comments3.ds"
    namespace - NULL
    Exception - NULL

    Expression : 
    
        titleItem - Item : 
            
                tilde - NULL
                text - AstLeafNode/Text :  "fabrics <QuvD4gqX>"  " "
                tag - NULL
                links - NULL
                decorators - NULL
            
        productionArrow - AstLeafNode/ProductionArrow :  "->        // dude;"  "\r\n\r\n    "
    
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "wool fabrics <VBsu8OpW>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ", /* comment <*/"  "\r\n"
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "cotton fabrics <0RdNAvNs> {dec} [https://www.notube.com/watch?v=hTui12lKus]" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ";" 
            
    
========================================
Abstract Syntax Tree (JSON)
========================================

{"filename":"Tests.Integration.Parser.TestFiles.TestFilesFor09.B_comments3.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"fabrics <QuvD4gqX>","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->        // dude;","leadingTrivia":"","trailingTrivia":"\r\n\r\n    "},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"wool fabrics <VBsu8OpW>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":", /* comment <*/","leadingTrivia":"","trailingTrivia":"\r\n"}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"cotton fabrics <0RdNAvNs> {dec} [https://www.notube.com/watch?v=hTui12lKus]","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":";","leadingTrivia":"","trailingTrivia":""}}]}],"exception":null}
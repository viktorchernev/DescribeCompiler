========================================
Source Code (between the arrows)
========================================

🡆fabrics <QuvD4gqX> ->        // dude;

    wool fabrics <VBsu8OpW>, /* comment <*/
/* ->Comments, man [https://www.notube.com/watch?v=hTui12lKus] */     cotton fabrics <0RdNAvNs> [https://www.notube.com/watch?v=hTui12lKus];🡄

========================================
Derived Source Code (between the arrows)
========================================

🡆fabrics <QuvD4gqX> ->        wool fabrics <VBsu8OpW>, cotton fabrics <0RdNAvNs> ;🡄

========================================
Abstract Syntax Tree
========================================

Scripture : 

    filename - "Tests.Integration.Parser.TestFiles.TestFilesFor08.B_comments3.ds"
    namespace - NULL
    Exception - NULL

    Expression : 
    
        titleItem - Item : 
            
                tilde - NULL
                text - AstLeafNode/Text :  "fabrics"  " "
                tag - ""<" "QuvD4gqX"  "> ""
                links - NULL
                decorators - NULL
            
        productionArrow - AstLeafNode/ProductionArrow :  "->"  "        "
    
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "wool fabrics"  " "
                        tag - ""<" "VBsu8OpW"  ">""
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  " "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "cotton fabrics"  " "
                        tag - ""<" "0RdNAvNs"  "> ""
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ";" 
            
    
========================================
Abstract Syntax Tree (JSON)
========================================

{"filename":"Tests.Integration.Parser.TestFiles.TestFilesFor08.B_comments3.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"fabrics","leadingTrivia":"","trailingTrivia":" "},"tag":{"openBracket":{"leafType":"OpenTag","text":"<","leadingTrivia":"","trailingTrivia":""},"id":{"leafType":"Text","text":"QuvD4gqX","leadingTrivia":"","trailingTrivia":""},"closeBracket":{"leafType":"CloseTag","text":">","leadingTrivia":"","trailingTrivia":" "}},"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":"        "},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"wool fabrics","leadingTrivia":"","trailingTrivia":" "},"tag":{"openBracket":{"leafType":"OpenTag","text":"<","leadingTrivia":"","trailingTrivia":""},"id":{"leafType":"Text","text":"VBsu8OpW","leadingTrivia":"","trailingTrivia":""},"closeBracket":{"leafType":"CloseTag","text":">","leadingTrivia":"","trailingTrivia":""}},"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":" "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"cotton fabrics","leadingTrivia":"","trailingTrivia":" "},"tag":{"openBracket":{"leafType":"OpenTag","text":"<","leadingTrivia":"","trailingTrivia":""},"id":{"leafType":"Text","text":"0RdNAvNs","leadingTrivia":"","trailingTrivia":""},"closeBracket":{"leafType":"CloseTag","text":">","leadingTrivia":"","trailingTrivia":" "}},"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":";","leadingTrivia":"","trailingTrivia":""}}]}],"exception":null}
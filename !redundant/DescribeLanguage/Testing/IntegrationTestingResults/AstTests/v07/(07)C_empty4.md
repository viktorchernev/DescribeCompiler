========================================
Source Code (between the arrows)
========================================

🡆fabrics
<SIrifQYp>
-> 

;🡄

========================================
Derived Source Code (between the arrows)
========================================

🡆fabrics
<SIrifQYp>
-> 

;🡄

========================================
Abstract Syntax Tree
========================================

Scripture : 

    filename - "Tests.Integration.Parser.TestFiles.TestFilesFor07.C_empty4.ds"
    namespace - NULL
    Exception - NULL

    Expression : 
    
        titleItem - Item : 
            
                tilde - NULL
                text - AstLeafNode/Text :  "fabrics"  "\r\n"
                tag - ""<" "SIrifQYp"  ">\r\n""
                links - NULL
                decorators - NULL
            
        productionArrow - AstLeafNode/ProductionArrow :  "->"  " \r\n\r\n"
    
        line - ExpressionLine : 
            
                body - NULL
                punctuation - AstLeafNode/Terminator :  ";" 
            
    
========================================
Abstract Syntax Tree (JSON)
========================================

{"filename":"Tests.Integration.Parser.TestFiles.TestFilesFor07.C_empty4.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"fabrics","leadingTrivia":"","trailingTrivia":"\r\n"},"tag":{"openBracket":{"leafType":"OpenTag","text":"<","leadingTrivia":"","trailingTrivia":""},"id":{"leafType":"Text","text":"SIrifQYp","leadingTrivia":"","trailingTrivia":""},"closeBracket":{"leafType":"CloseTag","text":">","leadingTrivia":"","trailingTrivia":"\r\n"}},"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":" \r\n\r\n"},"lines":[{"body":null,"punctuation":{"leafType":"Terminator","text":";","leadingTrivia":"","trailingTrivia":""}}]}],"exception":null}
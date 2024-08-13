========================================
Source Code (between the arrows)
========================================

🡆fabrics [https://en.test.org/wiki/List_of_fabrics] <QpeudYXy> ->

	http://fabrics.com wool [https://en.test.org/wiki/Wool] {}<54vHCQwI>,
	cotton fabrics [https://en.test.org/wiki/Cotton]{} <Ll0bDtIQ>,
	silk http://fabrics.com/index.html fabrics {}[https://en.test.org/wiki/Silk]<6huM44Hm>,
	synthetic fabrics{} [https://en.test.org/wiki/Synthetic]<oAgVUPi0>;🡄

========================================
Derived Source Code (between the arrows)
========================================

🡆fabrics <QpeudYXy> ->

	http://fabrics.com wool <54vHCQwI>,
	cotton fabrics <Ll0bDtIQ>,
	silk http://fabrics.com/index.html fabrics <6huM44Hm>,
	synthetic fabrics<oAgVUPi0>;🡄

========================================
Abstract Syntax Tree
========================================

Scripture : 

    filename - "Tests.Integration.Parser.TestFiles.TestFilesFor09.A_basic1.ds"
    namespace - NULL
    Exception - NULL

    Expression : 
    
        titleItem - Item : 
            
                tilde - NULL
                text - AstLeafNode/Text :  "fabrics"  " "
                tag - ""<" "QpeudYXy"  "> ""
                links - NULL
                decorators - NULL
            
        productionArrow - AstLeafNode/ProductionArrow :  "->"  "\r\n\r\n\t"
    
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "http://fabrics.com wool"  " "
                        tag - ""<" "54vHCQwI"  ">""
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n\t"
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "cotton fabrics"  " "
                        tag - ""<" "Ll0bDtIQ"  ">""
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n\t"
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "silk http://fabrics.com/index.html fabrics"  " "
                        tag - ""<" "6huM44Hm"  ">""
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n\t"
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "synthetic fabrics" 
                        tag - ""<" "oAgVUPi0"  ">""
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ";" 
            
    
========================================
Abstract Syntax Tree (JSON)
========================================

{"filename":"Tests.Integration.Parser.TestFiles.TestFilesFor09.A_basic1.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"fabrics","leadingTrivia":"","trailingTrivia":" "},"tag":{"openBracket":{"leafType":"OpenTag","text":"<","leadingTrivia":"","trailingTrivia":""},"id":{"leafType":"Text","text":"QpeudYXy","leadingTrivia":"","trailingTrivia":""},"closeBracket":{"leafType":"CloseTag","text":">","leadingTrivia":"","trailingTrivia":" "}},"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":"\r\n\r\n\t"},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"http://fabrics.com wool","leadingTrivia":"","trailingTrivia":" "},"tag":{"openBracket":{"leafType":"OpenTag","text":"<","leadingTrivia":"","trailingTrivia":""},"id":{"leafType":"Text","text":"54vHCQwI","leadingTrivia":"","trailingTrivia":""},"closeBracket":{"leafType":"CloseTag","text":">","leadingTrivia":"","trailingTrivia":""}},"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n\t"}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"cotton fabrics","leadingTrivia":"","trailingTrivia":" "},"tag":{"openBracket":{"leafType":"OpenTag","text":"<","leadingTrivia":"","trailingTrivia":""},"id":{"leafType":"Text","text":"Ll0bDtIQ","leadingTrivia":"","trailingTrivia":""},"closeBracket":{"leafType":"CloseTag","text":">","leadingTrivia":"","trailingTrivia":""}},"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n\t"}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"silk http://fabrics.com/index.html fabrics","leadingTrivia":"","trailingTrivia":" "},"tag":{"openBracket":{"leafType":"OpenTag","text":"<","leadingTrivia":"","trailingTrivia":""},"id":{"leafType":"Text","text":"6huM44Hm","leadingTrivia":"","trailingTrivia":""},"closeBracket":{"leafType":"CloseTag","text":">","leadingTrivia":"","trailingTrivia":""}},"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n\t"}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"synthetic fabrics","leadingTrivia":"","trailingTrivia":""},"tag":{"openBracket":{"leafType":"OpenTag","text":"<","leadingTrivia":"","trailingTrivia":""},"id":{"leafType":"Text","text":"oAgVUPi0","leadingTrivia":"","trailingTrivia":""},"closeBracket":{"leafType":"CloseTag","text":">","leadingTrivia":"","trailingTrivia":""}},"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":";","leadingTrivia":"","trailingTrivia":""}}]}],"exception":null}
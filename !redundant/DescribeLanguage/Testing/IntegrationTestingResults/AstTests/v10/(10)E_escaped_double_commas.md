========================================
Source Code (between the arrows)
========================================

🡆fabrics ->

	wool\,,fabrics,
	cotton\,, fabrics,
	silk ,\,fabrics,
	synthetic ,\, fabrics;🡄

========================================
Derived Source Code (between the arrows)
========================================

🡆fabrics ->

	wool\,,fabrics,
	cotton\,, fabrics,
	silk ,\,fabrics,
	synthetic ,\, fabrics;🡄

========================================
Abstract Syntax Tree
========================================

Scripture : 

    filename - "Tests.Integration.Parser.TestFiles.TestFilesFor10.E_escaped_double_commas.ds"
    namespace - NULL
    Exception - NULL

    Expression : 
    
        titleItem - Item : 
            
                tilde - NULL
                text - AstLeafNode/Text :  "fabrics"  " "
                tag - NULL
                links - NULL
                decorators - NULL
            
        productionArrow - AstLeafNode/ProductionArrow :  "->"  "\r\n\r\n\t"
    
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "wool\,,fabrics" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n\t"
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "cotton\,, fabrics" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n\t"
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "silk ,\,fabrics" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n\t"
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "synthetic ,\, fabrics" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ";" 
            
    
========================================
Abstract Syntax Tree (JSON)
========================================

{"filename":"Tests.Integration.Parser.TestFiles.TestFilesFor10.E_escaped_double_commas.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"fabrics","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":"\r\n\r\n\t"},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"wool\\,,fabrics","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n\t"}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"cotton\\,, fabrics","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n\t"}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"silk ,\\,fabrics","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n\t"}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"synthetic ,\\, fabrics","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":";","leadingTrivia":"","trailingTrivia":""}}]}],"exception":null}
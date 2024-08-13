========================================
Source Code (between the arrows)
========================================

🡆fabrics -> /* comment *//* comment */
/* comment */

	wool fabrics,
	cotton fabrics, /*comment*/
	/* comment */
	silk fabrics,
	synthetic fabrics; /* comment *//* comment */🡄

========================================
Derived Source Code (between the arrows)
========================================

🡆fabrics -> /* comment *//* comment */
/* comment */

	wool fabrics,
	cotton fabrics, /*comment*/
	/* comment */
	silk fabrics,
	synthetic fabrics; /* comment *//* comment */🡄

========================================
Abstract Syntax Tree
========================================

Scripture : 

    filename - "Tests.Integration.Parser.TestFiles.TestFilesFor10.C_multiple_block_comments.ds"
    namespace - NULL
    Exception - NULL

    Expression : 
    
        titleItem - Item : 
            
                tilde - NULL
                text - AstLeafNode/Text :  "fabrics"  " "
                tag - NULL
                links - NULL
                decorators - NULL
            
        productionArrow - AstLeafNode/ProductionArrow :  "-> /* comment *//* comment */\r\n/* comment */"  "\r\n\r\n\t"
    
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "wool fabrics" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n\t"
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "cotton fabrics" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ", /*comment*/\r\n\t/* comment */"  "\r\n\t"
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "silk fabrics" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n\t"
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "synthetic fabrics" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  "; /* comment *//* comment */" 
            
    
========================================
Abstract Syntax Tree (JSON)
========================================

{"filename":"Tests.Integration.Parser.TestFiles.TestFilesFor10.C_multiple_block_comments.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"fabrics","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"-> /* comment *//* comment */\r\n/* comment */","leadingTrivia":"","trailingTrivia":"\r\n\r\n\t"},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"wool fabrics","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n\t"}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"cotton fabrics","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":", /*comment*/\r\n\t/* comment */","leadingTrivia":"","trailingTrivia":"\r\n\t"}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"silk fabrics","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n\t"}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"synthetic fabrics","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":"; /* comment *//* comment */","leadingTrivia":"","trailingTrivia":""}}]}],"exception":null}
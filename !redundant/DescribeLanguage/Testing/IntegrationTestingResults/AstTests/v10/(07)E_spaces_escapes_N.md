========================================
Source Code (between the arrows)
========================================

🡆fabric     s 	<TSbLGnNG> ->

	wool   fabrics	 <QWVZ3pp9> ,
	cotton\, fabrics textiles   <75NTfebY>,
    silk\-\>fabrics <Sqs0lm7S>,
    syntic 		fabrics <GcZEI9gy>;🡄

========================================
Derived Source Code (between the arrows)
========================================

🡆fabric     s 	<TSbLGnNG> ->

	wool   fabrics	 <QWVZ3pp9> ,
	cotton\, fabrics textiles   <75NTfebY>,
    silk\-\>fabrics <Sqs0lm7S>,
    syntic 		fabrics <GcZEI9gy>;🡄

========================================
Abstract Syntax Tree
========================================

Scripture : 

    filename - "Tests.Integration.Parser.TestFiles.TestFilesFor07.E_spaces_escapes_N.ds"
    namespace - NULL
    Exception - NULL

    Expression : 
    
        titleItem - Item : 
            
                tilde - NULL
                text - AstLeafNode/Text :  "fabric     s"  " \t"
                tag - ""<" "TSbLGnNG"  "> ""
                links - NULL
                decorators - NULL
            
        productionArrow - AstLeafNode/ProductionArrow :  "->"  "\n\n\t"
    
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "wool   fabrics"  "\t "
                        tag - ""<" "QWVZ3pp9"  "> ""
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\n\t"
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "cotton\, fabrics textiles"  "   "
                        tag - ""<" "75NTfebY"  ">""
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\n    "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "silk\-\>fabrics"  " "
                        tag - ""<" "Sqs0lm7S"  ">""
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\n    "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "syntic \t\tfabrics"  " "
                        tag - ""<" "GcZEI9gy"  ">""
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ";" 
            
    
========================================
Abstract Syntax Tree (JSON)
========================================

{"filename":"Tests.Integration.Parser.TestFiles.TestFilesFor07.E_spaces_escapes_N.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"fabric     s","leadingTrivia":"","trailingTrivia":" \t"},"tag":{"openBracket":{"leafType":"OpenTag","text":"<","leadingTrivia":"","trailingTrivia":""},"id":{"leafType":"Text","text":"TSbLGnNG","leadingTrivia":"","trailingTrivia":""},"closeBracket":{"leafType":"CloseTag","text":">","leadingTrivia":"","trailingTrivia":" "}},"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":"\n\n\t"},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"wool   fabrics","leadingTrivia":"","trailingTrivia":"\t "},"tag":{"openBracket":{"leafType":"OpenTag","text":"<","leadingTrivia":"","trailingTrivia":""},"id":{"leafType":"Text","text":"QWVZ3pp9","leadingTrivia":"","trailingTrivia":""},"closeBracket":{"leafType":"CloseTag","text":">","leadingTrivia":"","trailingTrivia":" "}},"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\n\t"}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"cotton\\, fabrics textiles","leadingTrivia":"","trailingTrivia":"   "},"tag":{"openBracket":{"leafType":"OpenTag","text":"<","leadingTrivia":"","trailingTrivia":""},"id":{"leafType":"Text","text":"75NTfebY","leadingTrivia":"","trailingTrivia":""},"closeBracket":{"leafType":"CloseTag","text":">","leadingTrivia":"","trailingTrivia":""}},"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"silk\\-\\>fabrics","leadingTrivia":"","trailingTrivia":" "},"tag":{"openBracket":{"leafType":"OpenTag","text":"<","leadingTrivia":"","trailingTrivia":""},"id":{"leafType":"Text","text":"Sqs0lm7S","leadingTrivia":"","trailingTrivia":""},"closeBracket":{"leafType":"CloseTag","text":">","leadingTrivia":"","trailingTrivia":""}},"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"syntic \t\tfabrics","leadingTrivia":"","trailingTrivia":" "},"tag":{"openBracket":{"leafType":"OpenTag","text":"<","leadingTrivia":"","trailingTrivia":""},"id":{"leafType":"Text","text":"GcZEI9gy","leadingTrivia":"","trailingTrivia":""},"closeBracket":{"leafType":"CloseTag","text":">","leadingTrivia":"","trailingTrivia":""}},"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":";","leadingTrivia":"","trailingTrivia":""}}]}],"exception":null}
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
                text - AstLeafNode/Text :  "fabric     s \t<TSbLGnNG>"  " "
                tag - NULL
                links - NULL
                decorators - NULL
            
        productionArrow - AstLeafNode/ProductionArrow :  "->"  "\n\n\t"
    
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "wool   fabrics\t <QWVZ3pp9>"  " "
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\n\t"
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "cotton\, fabrics textiles   <75NTfebY>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\n    "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "silk\-\>fabrics <Sqs0lm7S>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\n    "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "syntic \t\tfabrics <GcZEI9gy>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ";" 
            
    
========================================
Abstract Syntax Tree (JSON)
========================================

{"filename":"Tests.Integration.Parser.TestFiles.TestFilesFor07.E_spaces_escapes_N.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"fabric     s \t<TSbLGnNG>","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":"\n\n\t"},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"wool   fabrics\t <QWVZ3pp9>","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\n\t"}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"cotton\\, fabrics textiles   <75NTfebY>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"silk\\-\\>fabrics <Sqs0lm7S>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"syntic \t\tfabrics <GcZEI9gy>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":";","leadingTrivia":"","trailingTrivia":""}}]}],"exception":null}
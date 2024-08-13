========================================
Source Code (between the arrows)
========================================

🡆fabric     s    <sJZOzSdo>	->

	wool   fabrics	<UlJXGWLS> ,
	cotton\, fabrics textiles  \<<d4jKusMe>,
    silk\->fabrics <Bgx8/M6B1>,
    syntic 		fabrics <7vb\\W9VSB>;🡄

========================================
Derived Source Code (between the arrows)
========================================

🡆fabric     s    <sJZOzSdo>	->

	wool   fabrics	<UlJXGWLS> ,
	cotton\, fabrics textiles  \<<d4jKusMe>,
    silk\->fabrics <Bgx8/M6B1>,
    syntic 		fabrics <7vb\\W9VSB>;🡄

========================================
Abstract Syntax Tree
========================================

Scripture : 

    filename - "Tests.Integration.Parser.TestFiles.TestFilesFor07.E_spaces_escapes_RN.ds"
    namespace - NULL
    Exception - NULL

    Expression : 
    
        titleItem - Item : 
            
                tilde - NULL
                text - AstLeafNode/Text :  "fabric     s    <sJZOzSdo>"  "\t"
                tag - NULL
                links - NULL
                decorators - NULL
            
        productionArrow - AstLeafNode/ProductionArrow :  "->"  "\r\n\r\n\t"
    
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "wool   fabrics\t<UlJXGWLS>"  " "
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n\t"
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "cotton\, fabrics textiles  \<<d4jKusMe>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n    "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "silk\->fabrics <Bgx8/M6B1>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ","  "\r\n    "
            
        line - ExpressionLine : 
            
                body - Item : 
                    
                        tilde - NULL
                        text - AstLeafNode/Text :  "syntic \t\tfabrics <7vb\\W9VSB>" 
                        tag - NULL
                        links - NULL
                        decorators - NULL
                    
                punctuation - AstLeafNode/Text :  ";" 
            
    
========================================
Abstract Syntax Tree (JSON)
========================================

{"filename":"Tests.Integration.Parser.TestFiles.TestFilesFor07.E_spaces_escapes_RN.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"fabric     s    <sJZOzSdo>","leadingTrivia":"","trailingTrivia":"\t"},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":"\r\n\r\n\t"},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"wool   fabrics\t<UlJXGWLS>","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n\t"}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"cotton\\, fabrics textiles  \\<<d4jKusMe>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"silk\\->fabrics <Bgx8/M6B1>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":",","leadingTrivia":"","trailingTrivia":"\r\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"syntic \t\tfabrics <7vb\\\\W9VSB>","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Text","text":";","leadingTrivia":"","trailingTrivia":""}}]}],"exception":null}
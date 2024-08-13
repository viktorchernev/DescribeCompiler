========================================
Source Code (between the arrows)
========================================

🡆fabrics ->

	wool fabrics <<someid>>,
	cotton fabrics <<someid>> ,
	silk fabrics<<someid>> ,
	synthetic fabrics;🡄

========================================
Parse Tree
========================================
DescribeUnfold

    .AllFiles
    .ParsedFiles
    .FailedFiles

    .PrimaryProductions
        "ZYRBLL10" 

    .Productions
        "ZYRBLL10" -> "someid", "someid", "someid", "782UERIJ";

    .Translations
        "ZYRBLL10" - "fabrics"
        "someid" - "silk fabrics"
        "782UERIJ" - "synthetic fabrics"

    .Links
        "ZYRBLL10" - 
        "someid" - 
        "782UERIJ" - 

    .Decorators
        "ZYRBLL10" - 
        "someid" - 
        "782UERIJ" - 

    .Tildes
        "ZYRBLL10" -> 


    .ProdidFile
        "ZYRBLL10" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tags.ds"

    .ItemidFile
        "ZYRBLL10" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tags.ds"
        "someid" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tags.ds"
            "someid" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tags.ds"
            "someid" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tags.ds"
        "782UERIJ" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tags.ds"


========================================
Source Code (between the arrows)
========================================

🡆fabrics ->

	~ wool fabrics <<someid>>,
	~ cotton fabrics <<someid2>> ,

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
        "W4CF8CDT" 

    .Productions
        "W4CF8CDT" -> "someid", "4YTVWPBO";

    .Translations
        "W4CF8CDT" - "fabrics"
        "someid" - "silk fabrics"
        "someid2" - "cotton fabrics"
        "4YTVWPBO" - "synthetic fabrics"

    .Links
        "W4CF8CDT" - 
        "someid" - 
        "someid2" - 
        "4YTVWPBO" - 

    .Decorators
        "W4CF8CDT" - 
        "someid" - 
        "someid2" - 
        "4YTVWPBO" - 

    .Tildes
        "W4CF8CDT" -> "someid", "someid2";


    .ProdidFile
        "W4CF8CDT" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tilde.ds"

    .ItemidFile
        "W4CF8CDT" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tilde.ds"
        "someid" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tilde.ds"
            "someid" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tilde.ds"
        "someid2" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tilde.ds"
        "4YTVWPBO" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tilde.ds"


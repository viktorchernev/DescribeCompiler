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
        "SGWZEKW7" 

    .Productions
        "SGWZEKW7" -> "someid", "HRY6CCTG";

    .Translations
        "SGWZEKW7" - "fabrics"
        "someid" - "silk fabrics"
        "someid2" - "cotton fabrics"
        "HRY6CCTG" - "synthetic fabrics"

    .Links
        "SGWZEKW7" - 
        "someid" - 
        "someid2" - 
        "HRY6CCTG" - 

    .Decorators
        "SGWZEKW7" - 
        "someid" - 
        "someid2" - 
        "HRY6CCTG" - 

    .Tildes
        "SGWZEKW7" -> "someid", "someid2";


    .ProdidFile
        "SGWZEKW7" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tilde.ds"

    .ItemidFile
        "SGWZEKW7" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tilde.ds"
        "someid" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tilde.ds"
            "someid" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tilde.ds"
        "someid2" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tilde.ds"
        "HRY6CCTG" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tilde.ds"


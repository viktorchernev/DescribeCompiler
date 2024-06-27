========================================
Source Code (between the arrows)
========================================

🡆fabrics ->

	wool < fabrics <<someid>>,
	cotton >fabrics <<someid>> ,
	silk fabrics<<someid>> ,
	synthetic<>fabrics;🡄

========================================
Parse Tree
========================================
DescribeUnfold

    .AllFiles
    .ParsedFiles
    .FailedFiles

    .PrimaryProductions
        "WOAXI4VV" 

    .Productions
        "WOAXI4VV" -> "someid", "someid", "someid", "DDT208E8";

    .Translations
        "WOAXI4VV" - "fabrics"
        "someid" - "silk fabrics"
        "DDT208E8" - "synthetic<>fabrics"

    .Links
        "WOAXI4VV" - 
        "someid" - 
        "DDT208E8" - 

    .Decorators
        "WOAXI4VV" - 
        "someid" - 
        "DDT208E8" - 

    .Tildes
        "WOAXI4VV" -> 


    .ProdidFile
        "WOAXI4VV" - "DescribeParser.IntegrationTests.TestFiles.TestFilesFor11.A_tags2.ds"

    .ItemidFile
        "WOAXI4VV" - "DescribeParser.IntegrationTests.TestFiles.TestFilesFor11.A_tags2.ds"
        "someid" - "DescribeParser.IntegrationTests.TestFiles.TestFilesFor11.A_tags2.ds"
            "someid" - "DescribeParser.IntegrationTests.TestFiles.TestFilesFor11.A_tags2.ds"
            "someid" - "DescribeParser.IntegrationTests.TestFiles.TestFilesFor11.A_tags2.ds"
        "DDT208E8" - "DescribeParser.IntegrationTests.TestFiles.TestFilesFor11.A_tags2.ds"


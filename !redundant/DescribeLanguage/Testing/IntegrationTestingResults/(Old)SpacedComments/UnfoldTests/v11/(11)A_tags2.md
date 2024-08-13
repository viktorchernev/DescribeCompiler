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
        "TR8M22P4" 

    .Productions
        "TR8M22P4" -> "someid", "someid", "someid", "5GI3568H";

    .Translations
        "TR8M22P4" - "fabrics"
        "someid" - "silk fabrics"
        "5GI3568H" - "synthetic<>fabrics"

    .Links
        "TR8M22P4" - 
        "someid" - 
        "5GI3568H" - 

    .Decorators
        "TR8M22P4" - 
        "someid" - 
        "5GI3568H" - 

    .Tildes
        "TR8M22P4" -> 


    .ProdidFile
        "TR8M22P4" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tags2.ds"

    .ItemidFile
        "TR8M22P4" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tags2.ds"
        "someid" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tags2.ds"
            "someid" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tags2.ds"
            "someid" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tags2.ds"
        "5GI3568H" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tags2.ds"


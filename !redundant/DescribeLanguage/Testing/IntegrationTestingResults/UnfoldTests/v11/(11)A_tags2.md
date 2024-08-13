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
        "VXZDM0T4" 

    .Productions
        "VXZDM0T4" -> "someid", "someid", "someid", "OCMMV4CS";

    .Translations
        "VXZDM0T4" - "fabrics"
        "someid" - "silk fabrics"
        "OCMMV4CS" - "synthetic<>fabrics"

    .Links
        "VXZDM0T4" - 
        "someid" - 
        "OCMMV4CS" - 

    .Decorators
        "VXZDM0T4" - 
        "someid" - 
        "OCMMV4CS" - 

    .Tildes
        "VXZDM0T4" -> 


    .ProdidFile
        "VXZDM0T4" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tags2.ds"

    .ItemidFile
        "VXZDM0T4" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tags2.ds"
        "someid" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tags2.ds"
            "someid" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tags2.ds"
            "someid" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tags2.ds"
        "OCMMV4CS" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_tags2.ds"


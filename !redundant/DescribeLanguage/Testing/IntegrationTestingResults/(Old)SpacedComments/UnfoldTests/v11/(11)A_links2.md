========================================
Source Code (between the arrows)
========================================

🡆fabrics ->

	wool [fabrics [[http://someurl.net]],
	cotton ] fabrics,
	silk ][ fabrics[[http://otherurl.net]] ,
	synthetic [] fabrics [[http://url.net]] ;🡄

========================================
Parse Tree
========================================
DescribeUnfold

    .AllFiles
    .ParsedFiles
    .FailedFiles

    .PrimaryProductions
        "VPV17GOC" 

    .Productions
        "VPV17GOC" -> "E06WE5T0", "5BG7DD2G", "93TQQ0M3", "NRDRJ5HD";

    .Translations
        "VPV17GOC" - "fabrics"
        "E06WE5T0" - "wool [fabrics"
        "5BG7DD2G" - "cotton ] fabrics"
        "93TQQ0M3" - "silk ][ fabrics"
        "NRDRJ5HD" - "synthetic [] fabrics"

    .Links
        "VPV17GOC" - 
        "E06WE5T0" - "http://someurl.net"
        "5BG7DD2G" - 
        "93TQQ0M3" - "http://otherurl.net"
        "NRDRJ5HD" - "http://url.net"

    .Decorators
        "VPV17GOC" - 
        "E06WE5T0" - 
        "5BG7DD2G" - 
        "93TQQ0M3" - 
        "NRDRJ5HD" - 

    .Tildes
        "VPV17GOC" -> 


    .ProdidFile
        "VPV17GOC" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_links2.ds"

    .ItemidFile
        "VPV17GOC" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_links2.ds"
        "E06WE5T0" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_links2.ds"
        "5BG7DD2G" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_links2.ds"
        "93TQQ0M3" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_links2.ds"
        "NRDRJ5HD" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_links2.ds"


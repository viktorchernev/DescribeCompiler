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
        "D91DSOY4" 

    .Productions
        "D91DSOY4" -> "CA6RRQ22", "CBPC2MRR", "46D2SDDR", "SZ83155W";

    .Translations
        "D91DSOY4" - "fabrics"
        "CA6RRQ22" - "wool [fabrics"
        "CBPC2MRR" - "cotton ] fabrics"
        "46D2SDDR" - "silk ][ fabrics"
        "SZ83155W" - "synthetic [] fabrics"

    .Links
        "D91DSOY4" - 
        "CA6RRQ22" - "http://someurl.net"
        "CBPC2MRR" - 
        "46D2SDDR" - "http://otherurl.net"
        "SZ83155W" - "http://url.net"

    .Decorators
        "D91DSOY4" - 
        "CA6RRQ22" - 
        "CBPC2MRR" - 
        "46D2SDDR" - 
        "SZ83155W" - 

    .Tildes
        "D91DSOY4" -> 


    .ProdidFile
        "D91DSOY4" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_links2.ds"

    .ItemidFile
        "D91DSOY4" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_links2.ds"
        "CA6RRQ22" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_links2.ds"
        "CBPC2MRR" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_links2.ds"
        "46D2SDDR" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_links2.ds"
        "SZ83155W" - "Tests.Integration.Parser.TestFiles.TestFilesFor11.A_links2.ds"


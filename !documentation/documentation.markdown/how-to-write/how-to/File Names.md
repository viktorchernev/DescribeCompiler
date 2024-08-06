---
layout: page
title: Describe - File names
permalink: /language/how-to-write-file-names/
exclude: true
---
<br>Like other programming languages, Describe has file extensions associated with different files. Some file prefixes might also be utilized as well.


### Extensions
A list of file extensions related to the Describe language and the Describe compiler follows:

* <span style="color:blue">**_.ds_** ```someFile.ds```</span><br>
```.ds``` or ```.DS```, by convention, is the extension for describe source files. It stands for "Describe Scripture". By default, the compiler will read only files with those extensions, and ignore others. 

* <span style="color:blue">**_.dr_** ```someDraftFile.dr```</span><br>
Also by convention, source files that are not ready to be compiled (aka draft files) are named with the ```.dr``` or ```.DR``` extension, which stands for "Describe dRaft", and are omitted by the compiler.

* <span style="color:blue">**_.dart_** ```someArtifact.dart```</span><br>
```.dart``` or ```.DART``` stands for "Describe ARTifact". Those are artifact files for the compiler.

* <span style="color:blue">**_.dart_** ```someSecret.denc```</span><br>
```.denc``` or ```.DENC``` stands for "Describe ENCrypted". Those files are Describe source code files that have been encrypted.


### Prefixes

* <span style="color:blue">**_@_** ```@someSource.ds```</span><br>
"At" symbol might indicate that the source file is a root one.

* <span style="color:blue">**_#_** ```#someSource.ds```</span><br>
hash symbol (aka octothorpe) might indicate that source file is encrypted.

<br>
### Links
[Next](/language/how-to-write-tildes)<br>
[Prev](/language/how-to-write-dot-notation)

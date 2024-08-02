---
layout: page
title: Describe Compiler CLI - Arguments
permalink: /technical/cli/arguments/
exclude: true
---
### IO
<span style="color:blue">```internal static bool readInputArgument(string arg, int argindex)```</span><br>
Read input file or folder<br>
<span style="color:orange">arg</span> - The argument raw text<br>
<span style="color:orange">argindex</span> - The index of the argument (for logging purposes)<br>
<span style="color:orange">returns</span> - True if successful<br>


<span style="color:blue">```internal static bool readInputFileArgument(string arg, int argindex)```</span><br>
Read input file<br>
<span style="color:orange">arg</span> - The argument raw text<br>
<span style="color:orange">argindex</span> - The index of the argument (for logging purposes)<br>
<span style="color:orange">returns</span> - True if successful<br>


<span style="color:blue">```internal static bool readInputFolderArgument(string arg, int argindex)```</span><br>
Read input folder<br>
<span style="color:orange">arg</span> - The argument raw text<br>
<span style="color:orange">argindex</span> - The index of the argument (for logging purposes)<br>
<span style="color:orange">returns</span> - True if successful<br>


<span style="color:blue">```internal static bool readOutputArgument(string arg, int argindex)```</span><br>
Read output file or folder<br>
<span style="color:orange">arg</span> - The argument raw text<br>
<span style="color:orange">argindex</span> - The index of the argument (for logging purposes)<br>
<span style="color:orange">returns</span> - True if successful<br>


<span style="color:blue">```internal static bool readOutputFileArgument(string arg, int argindex)```</span><br>
Read output file<br>
<span style="color:orange">arg</span> - The argument raw text<br>
<span style="color:orange">argindex</span> - The index of the argument (for logging purposes)<br>
<span style="color:orange">returns</span> - True if successful<br>


<span style="color:blue">```internal static bool readOutputFolderArgument(string arg, int argindex)```</span><br>
Read output folder<br>
<span style="color:orange">arg</span> - The argument raw text<br>
<span style="color:orange">argindex</span> - The index of the argument (for logging purposes)<br>
<span style="color:orange">returns</span> - True if successful<br>

### More IO
<span style="color:blue">```internal static bool readLogfileArgument(string arg, int argindex)```</span><br>
Path to a log file to output logs to<br>
<span style="color:orange">arg</span> - The argument raw text<br>
<span style="color:orange">argindex</span> - The index of the argument (for logging purposes)<br>
<span style="color:orange">returns</span> - True if successful<br>


<span style="color:blue">```internal static bool readArtifactsArgument(string arg, int argindex)```</span><br>
Read "artifacts" argument<br>
<span style="color:orange">arg</span> - The argument raw text<br>
<span style="color:orange">argindex</span> - The index of the argument (for logging purposes)<br>
<span style="color:orange">returns</span> - True if successful<br>


<span style="color:blue">```internal static bool readArtifactsPathArgument(string arg, int argindex)```</span><br>
Path to folder to use for storing and retrieving artifacts<br>
<span style="color:orange">arg</span> - The argument raw text<br>
<span style="color:orange">argindex</span> - The index of the argument (for logging purposes)<br>
<span style="color:orange">returns</span> - True if successful<br>


### Options
<span style="color:blue">```internal static bool readDsonlyArgument(string arg, int argindex)```</span><br>
Read "dsonly" argument<br>
<span style="color:orange">arg</span> - The argument raw text<br>
<span style="color:orange">argindex</span> - The index of the argument (for logging purposes)<br>
<span style="color:orange">returns</span> - True if successful<br>


<span style="color:blue">```internal static bool readVerbosityArgument(string arg, int argindex)```</span><br>
Read "verbosity" argument<br>
<span style="color:orange">arg</span> - The argument raw text<br>
<span style="color:orange">argindex</span> - The index of the argument (for logging purposes)<br>
<span style="color:orange">returns</span> - True if successful<br>


<span style="color:blue">```internal static bool readOnerrorArgument(string arg, int argindex)```</span><br>
Read "onerror" argument<br>
<span style="color:orange">arg</span> - The argument raw text<br>
<span style="color:orange">argindex</span> - The index of the argument (for logging purposes)<br>
<span style="color:orange">returns</span> - True if successful<br>


<span style="color:blue">```internal static bool readToponlyArgument(string arg, int argindex)```</span><br>
Read "toponly" argument<br>
<span style="color:orange">arg</span> - The argument raw text<br>
<span style="color:orange">argindex</span> - The index of the argument (for logging purposes)<br>
<span style="color:orange">returns</span> - True if successful<br>


<span style="color:blue">```internal static bool readTemplateArgument(string arg, int argindex)```</span><br>
Read "template" argument<br>
<span style="color:orange">arg</span> - The argument raw text<br>
<span style="color:orange">argindex</span> - The index of the argument (for logging purposes)<br>
<span style="color:orange">returns</span> - True if successful<br>
---
layout: page
title: Describe Compiler CLI
permalink: /technical/cli/datnik/
exclude: true
---
### IO
<span style="color:blue">```public static string input```</span> - The input file or folder

<span style="color:blue">```public static bool isInputDir```</span> - Wether the input is a file or a folder.

<span style="color:blue">```public static string output```</span> - The output file or folder.

<span style="color:blue">```public static bool isOutputDir```</span> - Wether the output is a file or a folder.

<span style="color:blue">```public static bool topOnly```</span> - When parsing a folder, weather to parse files in top directory only or parse files in child directories as well.

<span style="color:blue">```public static bool dsOnly```</span> - Weather to omit files that are not Describe source files (".DS").

### Results
<span style="color:blue">```public static LogVerbosity verbosity```</span> - The verbosity for the parser.

<span style="color:blue">```public static bool requireSuccess```</span> - Weather the compiler should stop after encountering an error or add the file to the list of failed files and continue with the next one.

### Templating
<span style="color:blue">```public static string templateName```</span> - The name of the template for the parser.

<span style="color:blue">```public static string templatePath```</span> - The path of the template for the parser.

<span style="color:blue">```public static bool isInternal```</span> - Weather the template set is internal or external.

### Logs
<span style="color:blue">```public static string logFilePath```</span> - Path to an external log file.

<span style="color:blue">```public static bool logToFile```</span> - Weather to output logs to an external file.

### Artifacts
<span style="color:blue">```public static ArtifactMode artifactMode```</span> - Weather to and how to use artifacts.

<span style="color:blue">```public static string artifactsFolderPath```</span> - Path to artifacts folder.
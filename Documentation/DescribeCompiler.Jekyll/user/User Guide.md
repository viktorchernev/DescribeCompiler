---
layout: page
title: User guide
permalink: /user-guide/
---
usage: <span style="color:blue">```DescribeCompilerCLI help | -h```</span>

Display help message

<hr><br>
usage: <span style="color:blue">```DescribeCompilerCLI parse-file PARSE_PATH RESULT_PATH [ template=(TEMPLATE_NAME|TEMPLATE_PATH) ] [ verbosity=<verb> | log-verbosity=<verb> ] [ artifacts=<verb> [artifacts-path=ARTIFACTS_PATH ]] [ logfile=LOG_PATH ]```</span>

<span style="color:orange">template</span> - the name (inbuilt) or path (external) of the template set to use PARSE_PATH - the path of the file to parse<br>
<span style="color:orange">RESULT_PATH</span> - the path of the file to write the result to (existing file or not)<br>
<span style="color:orange">verbosity</span> - set the log verbosity of the parser (default is high): "l", "low", "m", "medium", "h", "high"<br>
<span style="color:orange">log-verbosity</span> - can be used instead of verbosity<br>
<span style="color:orange">artifacts</span> - weather to use artifacts (default is no): "m", "makeonly", "t", "takeonly", "u", "use", "n", "no"<br> 
<span style="color:orange">ARTIFACTS_PATH</span> - specify path of directory to store artifacts in<br>
<span style="color:orange">LOG_PATH</span> - specify path of directory or file to output logs to<br>

<hr><br>
usage: <span style="color:blue">```DescribeCompilerCLI parse-folder PARSE_PATH RESULT_PATH [ template=(TEMPLATE_NAME|TEMPLATE_PATH) ] [ dsonly[=true|=false] ] [ toponly[=true|=false] ] [ verbosity=<verb> | log-verbosity=<verb> ] [ onerror=<verb> ] [ artifacts=<verb> [artifacts-path=ARTIFACTS_PATH ]] [ logfile=LOG_PATH ]```</span>

<span style="color:orange">template</span> - the name (inbuild) or path (external) of the template set to use PARSE_PATH - the path of the file to parse<br> 
<span style="color:orange">RESULT_PATH</span> - the path of the folder to write the result to (existing or not)<br>
<span style="color:orange">dsonly</span> - weather to omit files that are not Describe source files (".DS"). (default is true): "true", "false"<br>
<span style="color:orange">toponly</span> - weather to parse files in child directories or not. (default is false): "true", "false"<br>
<span style="color:orange">verbosity</span> - set the log verbosity of the parser (default is high): "l", "low", "m", "medium", "h", "high"<br>
<span style="color:orange">log-verbosity</span> - can be used instead of verbosity<br>
<span style="color:orange">onerror</span> - what to do when there is an error in source code. (default is stop): "stop", "ignore"<br>
<span style="color:orange">artifacts</span> - weather to use artifacts (default is no): "m", "makeonly", "t", "takeonly", "u", "use", "n", "no"<br> 
<span style="color:orange">ARTIFACTS_PATH</span> - specify path of directory to store artifacts in<br>
<span style="color:orange">LOG_PATH</span> - specify path of directory or file to output logs to<br>
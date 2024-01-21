# Describe Compiler user guide

Describe is a domain specific language used to write and maintain complex data lists that are compiled on demand to html, xaml, xml, sql, json and any other language needed. 

Describe is licensed under the GNU Affero General Public License v3.0. For more information visit https://github.com/viktorchernev/DescribeCompiler

## Usage

### help
The ```help``` command is pretty self explanatory. It outputs the about/usage message.
The shorthand ```-h``` can also be used for convenience. 

### parse-file
The ```parse-file``` command is used to parse a single file. The backus-naur syntax of the command looks like this: ```parse-file PARSE_PATH RESULT_PATH [ translator=(TARGET_LANGUAGE|TRANSLATOR_NAME) ] [ verbosity=<verb> | log-verbosity=<verb> ] [ artifacts=<verb> [artifacts-path=ARTIFACTS_PATH ]] [ logfile=LOG_PATH ]```. 

* PARSE_PATH - the path of the file to be parsed
* RESULT_PATH - the path of the file to write the result to. It might be an existing file that will be overwritten or not.
* translator - the translator to be used. The value might be the translator's name - like "JSON_COMMONER", or it can be the name of the language to translate to - like "JSON". By convention, every translator name is supposed to start with the name of the language it targets - like "JSON_COMMONER" or "HTML_PARACORD". The translator that will be selected will be the one that is named exactly with the provided name, or if such is not available, the one that starts with the provided value.
* verbosity - sets the log verbosity of the parser. There are 3 options here - ```high```, ```medium``` and ```low```. There are single letter shorthands as well - ```h```, ```m``` and ```l```. The default verbosity is high.
* log-verbosity - same as "verbosity"
* logfile - sets the path of a directory or file to output logs to. If this is not set, then logs won't be outputted to a file at all. If a directory is set as a value, logs will be outputted with timestamps in the filenames, so that they don't overwrite older logs but accumulate instead.
* artifacts - sets weather to use artifacts aka artifacts mode. ```makeonly``` or ```m``` for short will only produce artifacts but not consume them. ```takeonly``` or ```t``` will only consume artifacts when available, but will not produce them. ```use``` or ```u``` will both produce and consume artifacts, and ```no``` or ```n``` will not use artifacts at all. Default is no. ARTEFACTS ARE NOT IMPLEMENTED YET!
* artifacts-path - sets the path to the folder containig artifacts, when artifacts are being used. ARTEFACTS ARE NOT IMPLEMENTED YET!

### parse-folder
The ```parse-folder``` command is used to parse multiple source files in a folder. The backus-naur syntax of the command looks like this: ```parse-folder PARSE_PATH RESULT_PATH [ translator=(TARGET_LANGUAGE|TRANSLATOR_NAME) ] [ dsonly[=<verb>] ] [ toponly[=true|=false] ] [ verbosity=<verb> | log-verbosity=<verb> ] [ onerror=<verb> ] [ artifacts=<verb> [artifacts-path=ARTIFACTS_PATH ]] [ logfile=LOG_PATH ]```.
* PARSE_PATH - the path of the folder to be parsed
* RESULT_PATH - the path of the file to write the result to. It might be an existing file that will be overwritten or not.
* translator - the translator to be used. The value might be the translator's name - like "JSON_COMMONER", or it can be the name of the language to translate to - like "JSON". By convention, every translator name is supposed to start with the name of the language it targets - like "JSON_COMMONER" or "HTML_PARACORD". The translator that will be selected will be the one that is named exactly with the provided name, or if such is not available, the one that starts with the provided value.
* toponly - ```true``` or ```false```. Wether to parse files in child directories (and child of child, etc...) as well, or just the specified top directory. Default is ```false```.
* dsonly - ```true``` or ```false```. Wether to parse only ```.ds``` files, or try to parse other text files as well. Default is ```true```.
* verbosity - sets the log verbosity of the parser. There are 3 options here - ```high```, ```medium``` and ```low```. There are single letter shorthands as well - ```h```, ```m``` and ```l```. The default verbosity is high.
* log-verbosity - same as "verbosity"
* onerror - ```stop``` or ```ignore```. What to do when there is an error in some of the source files. Default is ```stop```.
* logfile - sets the path of a directory or file to output logs to. If this is not set, then logs won't be outputted to a file at all. If a directory is set as a value, logs will be outputted with timestamps in the filenames, so that they don't overwrite older logs but accumulate instead.
* artifacts - sets weather to use artifacts aka artifacts mode. ```makeonly``` or ```m``` for short will only produce artifacts but not consume them. ```takeonly``` or ```t``` will only consume artifacts when available, but will not produce them. ```use``` or ```u``` will both produce and consume artifacts, and ```no``` or ```n``` will not use artifacts at all. Default is no. ARTEFACTS ARE NOT IMPLEMENTED YET!
* artifacts-path - sets the path to the folder containig artifacts, when artifacts are being used. ARTEFACTS ARE NOT IMPLEMENTED YET!


## File extentions
* .ds - Describe source code file (<span style="color:blue">D</span>escribe <span style="color:blue">S</span>cripture)
* .dr - Describe source code draft file (describe <span style="color:blue">DR</span>aft)
* .denc - Describe source code encrypted file  (<span style="color:blue">D</span>escribe <span style="color:blue">ENC</span>rypted)
* .dart - Describe artifact file (<span style="color:blue">D</span>escribe <span style="color:blue">ART</span>ifact file)
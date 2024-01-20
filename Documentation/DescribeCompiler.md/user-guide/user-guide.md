# Describe Compiler user guide


## Usage

1. help
The ```help``` command is pretty self explanatory. It outputs the about/usage message.
The shorthand ```-h``` can also be used for convenience. 

2. parse-file
The ```parse-file``` command is used to parse a single file. The bakhus-naur syntax of the command looks like this: ```parse-file PARSE_PATH RESULT_PATH [ translator=(TARGET_LANGUAGE|TRANSLATOR_NAME) ] [ verbosity=<verb> | log-verbosity=<verb> ] [ artifacts=<verb> [artifacts-path=ARTIFACTS_PATH ]] [ logfile=LOG_PATH ]```. 

* PARSE_PATH - the path of the file to be parsed
* RESULT_PATH - the path of the file to write the result to. It might be an existing file that will be overwritten or not.
* translator - the translator to be used. The value might be the translator's name - like "JSON_COMMONER", or it can be the name of the language to translate to - like "JSON". By convention, every translator name is supposed to start with the name of the language it targets - like "JSON_COMMONER" or "HTML_PARACORD". The translator that will be selected will be the one that is named exactly with the provided name, or if such is not available, the one that starts with the provided value.
* verbosity - sets the log verbosity of the parser. There are 3 options here - ```high```, ```medium``` and ```low```. There are single letter shorthands as well - ```h```, ```m``` and ```l```. The default verbosity is high.
* log-verbosity - same as "verbosity"
* logfile - 

1. parse-folder

## File extentions
* .ds - Describe source code file (Describe Scripture)
* .dr - Describe source code draft file (describe DRaft)
* .denc - Describe source code encrypted file  (Describe ENCrypted)
* .dart - Describe artifact file (Describe ARTifact file)
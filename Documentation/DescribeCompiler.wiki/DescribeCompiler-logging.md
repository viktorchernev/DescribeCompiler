The describe compiler has an inbuilt logger that is responsible for logging runtime data.

***

### 1. Usage
There are 4 delegates, and the user is expected to provide his own methods and assign them to those: 
* `Action<string> LogError` - for logging fatal errors that terminate the current task,
* `Action<string> LogInfo` - for logging additional information that is not very important,
* `Action<string> LogParserInfo` - for logging Gold Parser actions and
* `Action<string> LogText` - for logging all else.

There is also the `string Log` property where all the log entries accumulate and it can be used to retrieve the log text, preferably after the compilation of the current task.

***

### 2. Verbosity
The logger also has verbosity level, represented by the `enum DescribeCompiler.LogVerbosity`. 
The values can be: 
* `LogVerbosity.Low`- for logging only filenames and fatal errors, 
* `LogVerbosity.Medium` - for logging few details for each file and few details about the task and 
* `LogVerbosity.High` - for full logs - including different details and parser actions.

The verbosity can be set in the constructor of the `DescribeCompiler` and by default it is set to Low. The verbosity can also be changed by setting by the `LogVerbosity Verbosity` property.

***

### 3. Log examples
* [[low verbosity example log | DescribeCompiler-logging-low-verbosity]]
* [[medium verbosity example log | DescribeCompiler-logging-medium-verbosity]]
* [[high verbosity example log | DescribeCompiler-logging-high-verbosity]]
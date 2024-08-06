---
layout: page
title: Describe Compilation - API
permalink: /language/how-to-compile/api
exclude: true
---
<br>The Describe Compiler API is a software library, containing the de facto compiler for the Describe Markup Language, as well as some translators for different target languages . It is a .Net dll that targets .Net Standard 2.0 and is licensed under the [AGPL v3](https://www.gnu.org/licenses/agpl-3.0) public license.

The Describe Compiler is very straight-forward to implement.

### 1. Add a reference
You can either download the [Visual Studio project](https://github.com/viktorchernev/DescribeCompiler/tree/master/DescribeCompiler.API) or the compiled dll file from the last release from [here](https://github.com/viktorchernev/DescribeCompiler/releases/), and reference it in your .Net project.

### 2. Create log handlers
Create handler methods that are used for logging data. This is how we are going to get output from the parser. In the example below, we are creating methods that will log data to the console in different colors.

```
//log text
private static void ConsoleLog(string text)
{
    Console.WriteLine(text);
}

//log info gray
private static void ConsoleLogInfo(string text)
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine(text);
    Console.ForegroundColor = ConsoleColor.White;
}

//log errors red
private static void ConsoleLogError(string text)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ForegroundColor = ConsoleColor.White;
}

//log parser data green
private static void ConsoleLogParseInfo(string text)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(text);
    Console.ForegroundColor = ConsoleColor.White;
}
```

### 3. Construct and set the compiler 
The constructor for the compiler takes verbosity and log handlers as optional arguments, so that the user does not need to set them one by one. Some or all of log handlers can be omitted and corresponding output won't be logged.

```
DescribeCompiler.DescribeCompiler compiler =
	new DescribeCompiler.DescribeCompiler(
		Datnik.verbosity,
		Messages.ConsoleLog,
		Messages.ConsoleLogError,
		Messages.ConsoleLogInfo,
		Messages.ConsoleLogParseInfo);

//settings
DescribeCompiler.DescribeCompiler.PARSE_TOP_DIRECTORY_ONLY = Datnik.topOnly;
DescribeCompiler.DescribeCompiler.PARSE_DS_ONLY = Datnik.dsOnly;
DescribeCompiler.DescribeCompiler.STOP_ON_ERROR = Datnik.requireSuccess;
```

### 4. Compile
The Describe compiler will populate a DescribeUnfold structure with data.

```
DescribeUnfold unfold = new DescribeUnfold();
bool result = compiler.ParseFolder(new DirectoryInfo(Datnik.input), unfold);
```

### 5. Translate
Construct a translator of a desired type and translate the populated DescribeUnfold structure.
If result is not ```null``` then the translation process was successful, so save the resulted string to file.

```
DescribeTranslator translator = 
	new JsonTranslator(
		Messages.ConsoleLog,
		Messages.ConsoleLogError,
		Messages.ConsoleLogInfo);

string result = translator.TranslateUnfold(unfold);
if (result != null)
{
	File.WriteAllText(@"C:\result\path\output.json", result);
}
```

<br>
### Links
[Describe Compilation](/language/how-to-compile)<br> 
[Use the CLI version](/language/how-to-compile/cli)<br>
[Use the AWS version](/language/how-to-compile/aws)<br>
[Back](/language/)

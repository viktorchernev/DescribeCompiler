### 1. How to use
The describe compiler API is very easy to use:

1. Add a reference to the project or DLL
2. Create your handlers that will be used for logging
3. Call the constructor in order to create the compiler class, passing your logging methods
4. Call `bool ParseFile(FileInfo fileInfo, out string html)` to get result

***

### 2. Example
Below is an example of using the compiler API as described above:

1. Create log handlers:  

`//log text`  
`private static void ConsoleLog(string text)`  
`{`  
`    Console.WriteLine(text);`  
`}`  
`//log info gray`  
`private static void ConsoleLogInfo(string text)`  
`{`  
`    Console.ForegroundColor = ConsoleColor.DarkGray;`  
`    Console.WriteLine(text);`  
`    Console.ForegroundColor = ConsoleColor.White;`  
`}`  
`//log errors red`  
`private static void ConsoleLogError(string text)`  
`{`  
`    Console.ForegroundColor = ConsoleColor.Red;`  
`    Console.WriteLine(text);`  
`    Console.ForegroundColor = ConsoleColor.White;`  
`}`  
`//log parser data green`  
`private static void ConsoleLogParseInfo(string text)`  
`{`  
`    Console.ForegroundColor = ConsoleColor.Green;`  
`    Console.WriteLine(text);`  
`    Console.ForegroundColor = ConsoleColor.White;`  
`}`  

2. Call constructor:

`DescribeCompiler.DescribeCompiler compiler = `  
`    new DescribeCompiler.DescribeCompiler(`  
`        ConsoleLog,`  
`        ConsoleLogError,`  
`        ConsoleLogInfo,`  
`        ConsoleLogParseInfo,`  
`        LogVerbosity.High);`  

3. Parse a file and save results:

`string html = "";`  
`compiler.ParseFile(new FileInfo(@"C:\Users\User\Desktop\Lists\0_root.ds"), out html);`  
`if(html != null)`  
`{`  
`    File.WriteAllText(@"C:\Users\User\Desktop\result.html", html);`  
`}`  
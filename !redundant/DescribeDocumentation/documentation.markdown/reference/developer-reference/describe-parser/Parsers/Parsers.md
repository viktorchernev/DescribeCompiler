---
layout: page
title: Parsers folder - DescribeParser.Parsers namespace
permalink: /language/reference/dev/tanspiler/parser/parsers/
exclude: true
---
<br>The Parser classes are used to, well, parse Describe source code. Those classes are generated automatically using the ANTLR 4 tool, that takes in a `.g4` grammar file and emits those C# source code files - only thing left for us is to add them to our project. Those classes will not be tested directly with unit-tests, as we trust the authors of ANTLR have done their job, as it is a state of the art tool. In fact, we don't even understand their innerworkings in details - we simply use them, and this is fine.

<br>
## Parser classes source files
There is a different set of classes for each version of the Describe language being parsed. Below is a file listing.
I want to note here that, when building those classes with the ANTLR tool, you can specify wether you want to build listeners or visitors, as those are two separate ways of interacting with the parser, resulting in two distinct design patterns being used. We are using visitors, as this is the favorable approach for a few reasons, but we have chosen to have the Listener classes built anyway, so users are able to implement their own listener, if need be.

```
ParsersFor06 / Describe06BaseListener.cs, Describe06Listener.cs, Describe06BaseVisitor.cs, Describe06Visitor.cs, Describe06Lexer.ce, Describe06Parser.cs
ParsersFor07 / Describe07BaseListener.cs, Describe07Listener.cs, Describe07BaseVisitor.cs, Describe07Visitor.cs, Describe07Lexer.ce, Describe07Parser.cs
ParsersFor08 / Describe08BaseListener.cs, Describe08Listener.cs, Describe08BaseVisitor.cs, Describe08Visitor.cs, Describe08Lexer.ce, Describe08Parser.cs
ParsersFor09 / Describe09BaseListener.cs, Describe09Listener.cs, Describe09BaseVisitor.cs, Describe09Visitor.cs, Describe09Lexer.ce, Describe09Parser.cs
ParsersFor10 / Describe10BaseListener.cs, Describe10Listener.cs, Describe10BaseVisitor.cs, Describe10Visitor.cs, Describe10Lexer.ce, Describe10Parser.cs
ParsersFor11 / Describe11BaseListener.cs, Describe11Listener.cs, Describe11BaseVisitor.cs, Describe11Visitor.cs, Describe11Lexer.ce, Describe11Parser.cs
```
	
We are not going to give a documentation of those classes here - anyone interested in that can read the book - "The Definitive ANTLR 4 Reference" or seek various online turorials and resources. We will simply give an example of basic usage of these classes, the way thhey are used in the DescribeParser project.
	
<br>
## A) Test Lexer 
```
//get source code to test
string text = File.ReadAllText(sourceCodeFilePath);

//construct parser
AntlrInputStream inputstream = new AntlrInputStream(text);
Describe06Lexer lexer = new Describe06Lexer(inputstream);
CommonTokenStream tokenstream = new CommonTokenStream(lexer);

//test lexer
tokenstream.Fill();
foreach (var token in tokenstream.GetTokens())
{
	int tokenType = token.Type;
	string tokenText = token.Text;
}
```

<br>
## B) Test Parser
```
//get source code to test
string text = File.ReadAllText(sourceCodeFilePath);

//construct parser
AntlrInputStream inputstream = new AntlrInputStream(text);
Describe06Lexer lexer = new Describe06Lexer(inputstream);
CommonTokenStream tokenstream = new CommonTokenStream(lexer);
Describe06Parser parser = new Describe06Parser(tokenstream);

//parse
Describe06Parser.ScriptureContext scriptureContext = parser.scripture();
// "scriptureContext" contains the actual parse tree. 
// We need a visitor to work with it, though

//visit
LogVisitor06 visitor = new LogVisitor06();
visitor.Visit(scriptureContext);
// The visitor does the rest of the work from here.
```

<br>
### Links
[Back](/language/reference/dev/tanspiler/parser/)
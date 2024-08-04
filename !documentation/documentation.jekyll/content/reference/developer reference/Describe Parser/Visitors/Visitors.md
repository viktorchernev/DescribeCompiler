---
layout: page
title: DescribeParser.Visitors namespace - Describe Visitors
permalink: /tanspiler/parser/visitors/
exclude: true
---
The Describe Visitor classes take the raw output from the DescribeParser(s) - that is, the parse tree, in the form of a `ParserRuleContext` and transform it in some way or do something with it. There are four types or visitors - Basic visitors, Log visitors, Unfold visitors and Ast visitors. Also, each version of the language has its own visitors, as you can see in the file listong below. 


### File listing

```
	ILogVisitor.cs
	IUnfoldVisitor.cs
	IAstVisitor.cs
	
	VisitorsFor06 / BasicVisitor06.cs, LogVisitor06.cs, UnfoldVisitor06.cs, AstVisitor06.cs
	VisitorsFor07 / BasicVisitor07.cs, LogVisitor07.cs, UnfoldVisitor07.cs, AstVisitor07.cs
	VisitorsFor08 / BasicVisitor08.cs, LogVisitor08.cs, UnfoldVisitor08.cs, AstVisitor08.cs
	VisitorsFor09 / BasicVisitor09.cs, LogVisitor09.cs, UnfoldVisitor09.cs, AstVisitor09.cs
	VisitorsFor10 / BasicVisitor10.cs, LogVisitor10.cs, UnfoldVisitor10.cs, AstVisitor10.cs
	VisitorsFor11 / BasicVisitor11.cs, LogVisitor11.cs, UnfoldVisitor11.cs, AstVisitor11.cs
```

## Types of visitors

The Unfold visitor is used to populate an Unfold object with the information within the parse tree. The information related to the source code representation, like line numbers, insignificant whitespaces, etc. is discarded, in this case, and the data is stored in this compact in-memory database object.

The Ast visitor, on the other hand, produces an AST tree from the parse tree. All the information, including the information related to the source code representation, like line numbers, insignificant whitespaces, etc. is preserved, as the AST can be used to work with source code.

The Log visitor simply draws a tree to the Console, and is used for testing purposes.

The Basic visitor classes are mostly for demonstrational purposes, and follow the standart ANTLR runtime visitor pattern. If you are goind to be developing a visitor for a Describe parser, you will do well to check out this visitor, as well as the Log visitor to begin with, as they use different design.


### Links
[Unfold Visitors - fill DescribeUnfold structure](/tanspiler/parser/visitors/unfold/)<br>
[Ast Visitors - create Abstract Syntax Tree](/tanspiler/parser/visitors/ast/)<br>
[Log Visitors - log parse result to console](/tanspiler/parser/visitors/log/)<br>
[Basic Visitors - mostly for educational purposes](/tanspiler/parser/visitors/basic/)<br>
[Back](/tanspiler/parser/)
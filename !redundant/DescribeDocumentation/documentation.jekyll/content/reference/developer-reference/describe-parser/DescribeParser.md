---
layout: page
title: DescribeParser
permalink: /language/reference/dev/tanspiler/parser/
exclude: true
---
<br>The DescribeParser project contains all the classes needed to parse Describe code. First of all, we can find lexers and parsers for different versions of the Describe language in the namespace `DescribeParser.Parsers`. Those lexers and parsers are generated with the ANTLR4 tool (.jar), and rely on the ANTLR runtime ([project antlr](/tanspiler/antlr/)). We neither unit-test them, nor care too much how they work internally, as the functionality is readily provided as is. After we use a lexer and a parser we have a context object, that is esentially the parse tree from the parse operation. We use the visitors in the `DescribeParser.Visitors` namespace to translate the root context class either to an Unfold structure, or to a real Abstract Syntax Tree (AST), which are housed in the `DescribeParser.Unfold` and `DescribeParser.Ast` namespaces, respectingly. 

Last but not least, we have the `IDescribeParseJob` interface and the `SimpleParseJob` class, used to store intermediate data during a parse operation.

[DescribeParser.Parsers namespace](/language/reference/dev/tanspiler/parser/parsers/)<br>
[DescribeParser.Visitors namespace](/language/reference/dev/tanspiler/parser/visitors/)<br>
[DescribeParser.Unfold namespace](/language/reference/dev/tanspiler/parser/unfold/)<br>
[DescribeParser.Ast namespace](/language/reference/dev/tanspiler/parser/ast/)<br>
[DescribeParser namespace - Job classes](/language/reference/dev/tanspiler/parser/job/)<br>


<br>
### Links
[Back](/language/reference/dev/)
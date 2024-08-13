---
layout: page
title: DescribeParser.Ast namespace - Abstract Syntax Tree
permalink: /language/reference/dev/tanspiler/parser/ast/
exclude: true
---
<br>The AST is series of classes that come together to represent an Abstract Syntax Tree from a Describe source code file. Unlike the DescribeUnfold, it does retain source-code related information, like source code position or whitespaces between different syntactical constructs, and can be used to reconstruct source code. We could say that, the AST is optimised for tasks where source code manipulation of highlighting is needed.
	
[Factory - The AstFactory is used to construct all of the types in the tree](/language/reference/dev/tanspiler/parser/ast/factory/)<br>
[Base - This folder contains the Base class, which is the abstract class AstNode, as well as few interfaces](/language/reference/dev/tanspiler/parser/ast/base/)<br>
[Leafs - The Tokens of the tree](/language/reference/dev/tanspiler/parser/ast/leafs/)<br>
[MinorBranches - TagNode, LinkNode and various DecoratorNode(s)](/language/reference/dev/tanspiler/parser/ast/minor-branches/)<br>
[MajorBranches - ScriptureNode, ExpressionNode and ItemNode](/language/reference/dev/tanspiler/parser/ast/major-branches/)<br>

<br>
### Links
[Back](/language/reference/dev/tanspiler/parser/)
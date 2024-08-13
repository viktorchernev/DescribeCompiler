---
layout: page
title: DescribeParser.Ast namespace - AstFactory
permalink: /language/reference/dev/tanspiler/parser/ast/factory/leaf/
exclude: true
---
<br>The AstFactory contains all the methods needed to construct Ast classes. Those classes have internal constructors, so the AstFactory is the only way to construct the objects of the Abstract Syntax Tree.


<br>
## 7. LeafNode - These methods constructs LeafNode objects
	
	
	`public static AstLeafNode CreateLeafNode(AstLeafType leaftype, string text, SourcePosition position)`
	`public static AstLeafNode CreateLeafNode(AstLeafType leaftype, string text, SourcePosition position, IAstBranchNode parent)`
	
	Creates a leaf node with the specified type, text, position, and optional parent node.
    leaftype - The type of the leaf node.
	text - The text content of the leaf node.
	position - The source position of the leaf node.
	parent - The parent node of the leaf node, if any. Default is null.
	RETURNS - A new instance of `AstLeafNode`.


	`public static AstLeafNode CreateLeafNode(AstLeafType leaftype, string text, string trailingTrivia, SourcePosition position)`
	`public static AstLeafNode CreateLeafNode(AstLeafType leaftype, string text, string trailingTrivia, SourcePosition position, IAstBranchNode parent)`

	Creates a leaf node with the specified type, text, trailing trivia, position, and optional parent node.
    leaftype - The type of the leaf node.
	text - The text content of the leaf node.
	trailingTrivia - The trailing trivia of the leaf node.
	position - The source position of the leaf node.
	parent - The parent node of the leaf node, if any. Default is null.
	RETURNS - A new instance of `AstLeafNode`.
	
	
	`public static AstLeafNode CreateLeafNode(AstLeafType leaftype, string text, string leadingTrivia, string trailingTrivia, SourcePosition position)`
	`public static AstLeafNode CreateLeafNode(AstLeafType leaftype, string text, string leadingTrivia, string trailingTrivia, SourcePosition position, IAstBranchNode parent)`

	Creates a leaf node with the specified type, text, trailing trivia, position, and optional parent node.
    leaftype - The type of the leaf node.
	text - The text content of the leaf node.
	leadingTrivia - The leading trivia of the leaf node.
	trailingTrivia - The trailing trivia of the leaf node.
	position - The source position of the leaf node.
	parent - The parent node of the leaf node, if any. Default is null.
	RETURNS - A new instance of `AstLeafNode`.


<br>
### Links
[Next](/language/reference/dev/tanspiler/parser/ast/factory/position/)<br>
[Back](/language/reference/dev/tanspiler/parser/ast/factory/decorator/)
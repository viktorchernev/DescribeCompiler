---
layout: page
title: DescribeParser.Ast namespace - AstFactory
permalink: /language/reference/dev/tanspiler/parser/ast/factory/link/
exclude: true
---
<br>The AstFactory contains all the methods needed to construct Ast classes. Those classes have internal constructors, so the AstFactory is the only way to construct the objects of the Abstract Syntax Tree.


<br>
## 5. LinkNode - These methods constructs LinkNode objects
	

	`public static AstLinkNode CreateLinkNode(AstLeafNode open, AstLeafNode url, AstLeafNode close)`
	`public static AstLinkNode CreateLinkNode(AstLeafNode open, AstLeafNode url, AstLeafNode close, IAstBranchNode parent)`
	Factory method to create instances of AstLinkNode.
	open - The open bracket of the Link object
	url - The url of the Link object
	close - The closing bracket of the Link object
	parent - The parent item
	RETURNS - New instance of AstLinkNode.


	`public static AstLinkNode CreateLinkNode(AstLeafNode open, AstLeafNode url, AstLeafNode title, AstLeafNode close)`
	`public static AstLinkNode CreateLinkNode(AstLeafNode open, AstLeafNode url, AstLeafNode title, AstLeafNode close, IAstBranchNode parent)`
	Factory method to create instances of AstLinkNode.
	open - The open bracket of the Link object
	url - The url of the Link object
	title - The Title of the Link object
	close - The closing bracket of the Link object
	parent - The parent item
	RETURNS - New instance of AstLinkNode.


	`public static AstLinkNode CreateLinkNode(AstLeafNode open, AstLeafNode url, AstLeafNode title, AstLeafNode letter, AstLeafNode close)`
	`public static AstLinkNode CreateLinkNode(AstLeafNode open, AstLeafNode url, AstLeafNode title, AstLeafNode letter, AstLeafNode close, IAstBranchNode parent)`
	Factory method to create instances of AstLinkNode.
	open - The open bracket of the Link object
	url - The url of the Link object
	title - The Title of the Link object
	letter - The Letter of the Link object
	close - The closing bracket of the Link object
	parent - The parent item
	RETURNS - New instance of AstLinkNode.


<br>
### Links
[Next](/language/reference/dev/tanspiler/parser/ast/factory/decorator/)<br>
[Back](/language/reference/dev/tanspiler/parser/ast/factory/tag/)
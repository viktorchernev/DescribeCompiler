---
layout: page
title: DescribeParser.Ast namespace - AstFactory
permalink: /tanspiler/parser/ast/factory/link/
exclude: true
---
The AstFactory contains all the methods needed to construct Ast classes. Those classes have internal constructors, so the AstFactory is the only way to construct the objects of the Abstract Syntax Tree.


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


### Links
[Next](/tanspiler/parser/ast/factory/tag/)<br>
[Back](/tanspiler/parser/ast/factory/decorator/)
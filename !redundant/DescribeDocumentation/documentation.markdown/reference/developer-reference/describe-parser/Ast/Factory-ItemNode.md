---
layout: page
title: DescribeParser.Ast namespace - AstFactory
permalink: /language/reference/dev/tanspiler/parser/ast/factory/item/
exclude: true
---
<br>The AstFactory contains all the methods needed to construct Ast classes. Those classes have internal constructors, so the AstFactory is the only way to construct the objects of the Abstract Syntax Tree.


<br>
## 3. ItemNode - These methods constructs ItemNode objects
	

	`public static AstItemNode CreateItemNode(AstLeafNode text)`
	`public static AstItemNode CreateItemNode(AstLeafNode text, IAstBranchNode parent)`
	Creates an `AstItemNode` with the specified text and optional parent.
	text - The text node of the item.
	parent - The optional parent node of the item.
	RETURNS - The created AstItemNode.


	`public static AstItemNode CreateItemNode(AstLeafNode text, AstTagNode tag)`
	`public static AstItemNode CreateItemNode(AstLeafNode text, AstTagNode tag, IAstBranchNode parent)`
	Creates an `AstItemNode` with the specified text, tag and optional parent.
	text - The text node of the item.
	tag - The tag node of the item.
	parent - The optional parent node of the item.
	RETURNS - The created AstItemNode.
	
	
	`public static AstItemNode CreateItemNode(AstLeafNode text, AstTagNode tag, List<AstLinkNode> links)`
	`public static AstItemNode CreateItemNode(AstLeafNode text, AstTagNode tag, List<AstLinkNode> links, IAstBranchNode parent)`
	Creates an `AstItemNode` with the specified text, tag, links and optional parent.
	text - The text node of the item.
	tag - The tag node of the item.
	links - The list of link nodes of the item.
	parent - The optional parent node of the item.
	RETURNS - The created AstItemNode.


	`public static AstItemNode CreateItemNode(AstLeafNode text, AstTagNode tag, List<AstLinkNode> links, List<AstDecoratorNode> decorators)`
	`public static AstItemNode CreateItemNode(AstLeafNode text, AstTagNode tag, List<AstLinkNode> links, List<AstDecoratorNode> decorators, IAstBranchNode parent)`
	Creates an `AstItemNode` with the specified text, tag, links, decorators and optional parent.
	text - The text node of the item.
	tag - The tag node of the item.
	links - The list of link nodes of the item.
	decorators - The list of decorator nodes of the item.
	parent - The optional parent node of the item.
	RETURNS - The created AstItemNode.


	`public static AstItemNode CreateItemNode(AstLeafNode tilde, AstLeafNode text)`
	`public static AstItemNode CreateItemNode(AstLeafNode tilde, AstLeafNode text, IAstBranchNode parent)`
	Creates an `AstItemNode` with the specified tilde, text, and optional parent.
	tilde - The tilde node of the item.
	text - The text node of the item.
	parent - The optional parent node of the item.
	RETURNS - The created AstItemNode.


	`public static AstItemNode CreateItemNode(AstLeafNode tilde, AstLeafNode text, AstTagNode tag)`
	`public static AstItemNode CreateItemNode(AstLeafNode tilde, AstLeafNode text, AstTagNode tag, IAstBranchNode parent)`
	Creates an `AstItemNode` with the specified tilde, text, tag and optional parent.
	tilde - The tilde node of the item.
	text - The text node of the item.
	tag - The tag node of the item.
	parent - The optional parent node of the item.
	RETURNS - The created AstItemNode.
	
	
	`public static AstItemNode CreateItemNode(AstLeafNode tilde, AstLeafNode text, AstTagNode tag, List<AstLinkNode> links)`
	`public static AstItemNode CreateItemNode(AstLeafNode tilde, AstLeafNode text, AstTagNode tag, List<AstLinkNode> links, IAstBranchNode parent)`
	Creates an `AstItemNode` with the specified , tilde, text, tag, links and optional parent.
	tilde - The tilde node of the item.
	text - The text node of the item.
	tag - The tag node of the item.
	links - The list of link nodes of the item.
	parent - The optional parent node of the item.
	RETURNS - The created AstItemNode.


	`public static AstItemNode CreateItemNode(AstLeafNode tilde, AstLeafNode text, AstTagNode tag, List<AstLinkNode> links, List<AstDecoratorNode> decorators)`
	`public static AstItemNode CreateItemNode(AstLeafNode tilde, AstLeafNode text, AstTagNode tag, List<AstLinkNode> links, List<AstDecoratorNode> decorators, IAstBranchNode parent)`
	Creates an `AstItemNode` with the specified tilde, text, tag, links, decorators and optional parent.
	tilde - The tilde node of the item.
	text - The text node of the item.
	tag - The tag node of the item.
	links - The list of link nodes of the item.
	decorators - The list of decorator nodes of the item.
	parent - The optional parent node of the item.
	RETURNS - The created AstItemNode.


<br>
### Links
[Next](/language/reference/dev/tanspiler/parser/ast/factory/tag/)<br>
[Back](/language/reference/dev/tanspiler/parser/ast/factory/expression/)
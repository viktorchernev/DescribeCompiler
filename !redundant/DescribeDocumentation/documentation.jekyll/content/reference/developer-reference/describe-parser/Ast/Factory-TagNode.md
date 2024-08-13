---
layout: page
title: DescribeParser.Ast namespace - AstFactory
permalink: /language/reference/dev/tanspiler/parser/ast/factory/tag/
exclude: true
---
<br>The AstFactory contains all the methods needed to construct Ast classes. Those classes have internal constructors, so the AstFactory is the only way to construct the objects of the Abstract Syntax Tree.


<br>
## 4. TagNode - These methods constructs TagNode objects
	
	
	`public static AstTagNode CreateTagNode(AstLeafNode open, AstLeafNode id, AstLeafNode close)`
	`public static AstTagNode CreateTagNode(AstLeafNode open, AstLeafNode id, AstLeafNode close, IAstBranchNode parent)`
	Factory method to create instances of AstTagNode.
	open - The open bracket of the Tag object.
	id - The id of the Tag object.
	close - The closing bracket of the Tag object.
	parent - The parent item
	RETURNS - New instance of AstTagNode.


<br>
### Links
[Next](/language/reference/dev/tanspiler/parser/ast/factory/link/)<br>
[Back](/language/reference/dev/tanspiler/parser/ast/factory/item/)
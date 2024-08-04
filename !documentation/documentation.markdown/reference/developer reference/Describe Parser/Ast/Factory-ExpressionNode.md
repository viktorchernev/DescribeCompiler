---
layout: page
title: DescribeParser.Ast namespace - AstFactory
permalink: /tanspiler/parser/ast/factory/expression/
exclude: true
---
The AstFactory contains all the methods needed to construct Ast classes. Those classes have internal constructors, so the AstFactory is the only way to construct the objects of the Abstract Syntax Tree.


## 2.1. ExpressionNode - These methods constructs ExpressionNode objects
	
	`public static AstExpressionNode CreateExpressionNode(AstItemNode titleItem, AstLeafNode arrow, AstExpressionLineNode line)`
	`public static AstExpressionNode CreateExpressionNode(AstItemNode titleItem, AstLeafNode arrow, AstExpressionLineNode line, IAstBranchNode parent)`
	Creates an `AstExpressionNode` with the specified title item, production arrow, and a single line.
	titleItem - The title item of the expression node.
	arrow - The production arrow of the expression node.
	line - The single line of the expression node.
	parent - The parent node, if any. Default is null.
    RETURNS - An `AstExpressionNode` with the specified title item, production arrow, and a single line.
 
 
 	`public static AstExpressionNode CreateExpressionNode(AstItemNode titleItem, AstLeafNode arrow, List<AstExpressionLineNode> lines)`
	`public static AstExpressionNode CreateExpressionNode(AstItemNode titleItem, AstLeafNode arrow, List<AstExpressionLineNode> lines, IAstBranchNode parent)`
	Creates an `AstExpressionNode` with the specified title item, production arrow, and a multiple lines.
	titleItem - The title item of the expression node.
	arrow - The production arrow of the expression node.
	lines - The list of lines for the expression node.
	parent - The parent node, if any. Default is null.
    RETURNS - An `AstExpressionNode` with the specified title item, production arrow, and a single line.
 
	
	
## 2.2. AstExpressionLineNode - These methods constructs AstExpressionLineNode objects
	
	`public static AstExpressionLineNode CreateExpressionLineNode(IAstBranchNode body)`
	`public static AstExpressionLineNode CreateExpressionLineNode(IAstBranchNode body, IAstBranchNode parent)`
	Creates an `AstExpressionLineNode` with the specified body.
	body - The body of the expression line node.
    parent - The parent node, if any. Default is null.
    RETURNS - An `AstExpressionLineNode` with the specified body.
	
	
	`public static AstExpressionLineNode CreateExpressionLineNode(AstLeafNode punctoation)`
	`public static AstExpressionLineNode CreateExpressionLineNode(AstLeafNode punctoation, IAstBranchNode parent)`
	Creates an `AstExpressionLineNode` with the specified punctuation.
	punctoation - The punctuation of the expression line node.
    parent - The parent node, if any. Default is null.
    RETURNS - An `AstExpressionLineNode` with the specified punctuation.
	
	
	`public static AstExpressionLineNode CreateExpressionLineNode(IAstBranchNode body, AstLeafNode punctoation)`
	`public static AstExpressionLineNode CreateExpressionLineNode(IAstBranchNode body, AstLeafNode punctoation, IAstBranchNode parent)`
	Creates an `AstExpressionLineNode` with the specified body and punctuation.
	body - The body of the expression line node.
    punctoation - The punctuation of the expression line node.
    parent - The parent node, if any. Default is null.
    RETURNS - An `AstExpressionLineNode` with the specified body and punctuation.


### Links
[Next](/tanspiler/parser/ast/factory/item/)<br>
[Back](/tanspiler/parser/ast/factory/scripture/)
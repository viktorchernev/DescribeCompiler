---
layout: page
title: DescribeParser.Ast namespace - AstFactory
permalink: /tanspiler/parser/ast/factory/decorator/
exclude: true
---
The AstFactory contains all the methods needed to construct Ast classes. Those classes have internal constructors, so the AstFactory is the only way to construct the objects of the Abstract Syntax Tree.


## 6. DecoratorNode - These methods constructs DecoratorNode objects
	


	`public static AstSimpleDecoratorNode CreateSimpleDecoratorNode(AstSimpleDecoratorType type, AstLeafNode open, AstLeafNode name, AstLeafNode close)`
	`public static AstSimpleDecoratorNode CreateSimpleDecoratorNode(AstSimpleDecoratorType type, AstLeafNode open, AstLeafNode name, AstLeafNode close, IAstBranchNode parent)`
	Creates an `AstSimpleDecoratorNode` with the specified type, open bracket, name, and close bracket.
    type - The type of the simple decorator.
	open - The open bracket node of the decorator.
	name - The name node of the decorator.
	close - The close bracket node of the decorator.
	parent - The parent node, if any. Default is null.
	RETURNS - An `AstSimpleDecoratorNode` with the specified type, open bracket, name, and close bracket.


	`public static AstSimpleDecoratorNode CreateSimpleDecoratorNode(AstLeafNode open, AstLeafNode name, AstLeafNode close)`
	`public static AstSimpleDecoratorNode CreateSimpleDecoratorNode(AstLeafNode open, AstLeafNode name, AstLeafNode close, IAstBranchNode parent)`
	Creates an `AstSimpleDecoratorNode` with the specified open bracket, name, and close bracket.
	open - The open bracket node of the decorator.
	name - The name node of the decorator.
	close - The close bracket node of the decorator.
	parent - The parent node, if any. Default is null.
	RETURNS - An `AstSimpleDecoratorNode` with the specified type, open bracket, name, and close bracket.
        

	`public static AstDoubleDecoratorNode CreateDoubleDecoratorNode(AstDoubleDecoratorType type, AstLeafNode open, AstLeafNode name, AstLeafNode value, AstLeafNode close)`
	`public static AstDoubleDecoratorNode CreateDoubleDecoratorNode(AstDoubleDecoratorType type, AstLeafNode open, AstLeafNode name, AstLeafNode value, AstLeafNode close,  IAstBranchNode parent)`
	Creates an `AstDoubleDecoratorNode` with the specified type, open bracket, name, value, and close bracket.
	type - The type of the double decorator.
	open - The open bracket node of the decorator.
	name - The name node of the decorator.
	value - The value node of the decorator.
	close - The close bracket node of the decorator.
	parent - The parent node, if any. Default is null.
	RETURNS - An `AstDoubleDecoratorNode` with the specified type, open bracket, name, value, and close bracket.
	
	
	`public static AstDoubleDecoratorNode CreateDoubleDecoratorNode(AstLeafNode open, AstLeafNode name, AstLeafNode value, AstLeafNode close)`
	`public static AstDoubleDecoratorNode CreateDoubleDecoratorNode(AstLeafNode open, AstLeafNode name, AstLeafNode value, AstLeafNode close, IAstBranchNode parent)`
	Creates an `AstDoubleDecoratorNode` with the specified open bracket, name, value, and close bracket.
    open - The open bracket node of the decorator.
	name - The name node of the decorator.
	value - The value node of the decorator.
	close - The close bracket node of the decorator.
	parent - The parent node, if any. Default is null.
	RETURNS - An `AstDoubleDecoratorNode` with the specified open bracket, name, value, and close bracket.
	
	
	`public static AstTripleDecoratorNode CreateTripleDecoratorNode(AstTripleDecoratorType type, AstLeafNode open, AstLeafNode category, AstLeafNode name, AstLeafNode value, AstLeafNode close)`
	`public static AstTripleDecoratorNode CreateTripleDecoratorNode(AstTripleDecoratorType type, AstLeafNode open, AstLeafNode category, AstLeafNode name, AstLeafNode value, AstLeafNode close, IAstBranchNode parent)`
	Creates an `AstTripleDecoratorNode` with the specified type, open bracket, category, name, value, and close bracket.
    type - The type of the triple decorator.
	open - The open bracket node of the decorator.
	category - The category node of the decorator.
	name - The name node of the decorator.
	value - The value node of the decorator.
	close - The close bracket node of the decorator.
	parent - The parent node, if any. Default is null.
	RETURNS - An `AstTripleDecoratorNode` with the specified type, open bracket, category, name, value, and close bracket.


	`public static AstTripleDecoratorNode CreateTripleDecoratorNode(AstLeafNode open, AstLeafNode category, AstLeafNode name, AstLeafNode value, AstLeafNode close)`
	`public static AstTripleDecoratorNode CreateTripleDecoratorNode(AstLeafNode open, AstLeafNode category, AstLeafNode name, AstLeafNode value, AstLeafNode close, IAstBranchNode parent)`
	Creates an `AstTripleDecoratorNode` with the specified type, open bracket, category, name, value, and close bracket.
    open - The open bracket node of the decorator.
	category - The category node of the decorator.
	name - The name node of the decorator.
	value - The value node of the decorator.
	close - The close bracket node of the decorator.
	parent - The parent node, if any. Default is null.
	RETURNS - An `AstTripleDecoratorNode` with the specified type, open bracket, category, name, value, and close bracket.


### Links
[Next](/tanspiler/parser/ast/factory/link/)<br>
[Back](/tanspiler/parser/ast/factory/leaf/)
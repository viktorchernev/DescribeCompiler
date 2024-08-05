---
layout: page
title: DescribeParser.Ast namespace - AstFactory
permalink: /tanspiler/parser/ast/factory/scripture/
exclude: true
---
The AstFactory contains all the methods needed to construct Ast classes. Those classes have internal constructors, so the AstFactory is the only way to construct the objects of the Abstract Syntax Tree.


## 1. Scripture - These methods construct AstScriptureNode(s)
	

	`public static AstScriptureNode CreateScriptureNode(List<AstExpressionNode> expressions)`
	`public static AstScriptureNode CreateScriptureNode(List<AstExpressionNode> expressions, Exception exception)`
	Creates a new instance of `AstScriptureNode` with the specified expressions and optional exception.
	expressions - The list of `AstExpressionNode` to be included in the scripture node.
	exception - The exception to be associated with the scripture node, if any. Default is `null`.
	RETURNS - A new instance of `AstScriptureNode"` with the specified expressions and exception.


	`public static AstScriptureNode CreateScriptureNode(AstExpressionNode expression)`
	`public static AstScriptureNode CreateScriptureNode(AstExpressionNode expression, Exception exception)`
	Creates a new instance of `AstScriptureNode` with the specified expression and optional exception.
	expression - The `AstExpressionNode` to be included in the scripture node.
	exception - The exception to be associated with the scripture node, if any. Default is `null`.
	RETURNS - A new instance of `AstScriptureNode"` with the specified expression and exception.


	`public static AstScriptureNode CreateScriptureNode(string filename, List<AstExpressionNode> expressions)`
	`public static AstScriptureNode CreateScriptureNode(string filename, List<AstExpressionNode> expressions, Exception exception)`
	Creates a new instance of `AstScriptureNode` with the specified filename, expressions and optional exception.
	filename - The filename to be associated with the scripture node.
	expressions - The list of `AstExpressionNode` to be included in the scripture node.
	exception - The exception to be associated with the scripture node, if any. Default is `null`.
	RETURNS - A new instance of `AstScriptureNode"` with the specified expressions and exception.


	`public static AstScriptureNode CreateScriptureNode(string filename, AstExpressionNode expression)`
	`public static AstScriptureNode CreateScriptureNode(string filename, AstExpressionNode expression, Exception exception)`
	Creates a new instance of `AstScriptureNode` with the specified filename, expression and optional exception.
	filename - The filename to be associated with the scripture node.
	expression - The `AstExpressionNode` to be included in the scripture node.
	exception - The exception to be associated with the scripture node, if any. Default is `null`.
	RETURNS - A new instance of `AstScriptureNode"` with the specified expression and exception.
	
	
	`public static AstScriptureNode CreateScriptureNode(string filename, string namespaceName, List<AstExpressionNode> expressions)`
	`public static AstScriptureNode CreateScriptureNode(string filename, string namespaceName, List<AstExpressionNode> expressions, Exception exception)`
	Creates a new instance of `AstScriptureNode` with the specified filename, namespace name, expressions and optional exception.
	filename - The filename to be associated with the scripture node.
	namespaceName - The namespace to be associated with the scripture node.
	expressions - The list of `AstExpressionNode` to be included in the scripture node.
	exception - The exception to be associated with the scripture node, if any. Default is `null`.
	RETURNS - A new instance of `AstScriptureNode"` with the specified expressions and exception.


	`public static AstScriptureNode CreateScriptureNode(string filename, string namespaceName, AstExpressionNode expression)`
	`public static AstScriptureNode CreateScriptureNode(string filename, string namespaceName, AstExpressionNode expression, Exception exception)`
	Creates a new instance of `AstScriptureNode` with the specified filename, namespace name, expression and optional exception.
	filename - The filename to be associated with the scripture node.
	namespaceName - The namespace to be associated with the scripture node.
	expression - The `AstExpressionNode` to be included in the scripture node.
	exception - The exception to be associated with the scripture node, if any. Default is `null`.
	RETURNS - A new instance of `AstScriptureNode"` with the specified expression and exception.


### Links
[Next](/tanspiler/parser/ast/factory/expression/)<br>
[Back](/tanspiler/parser/ast/factory/)
---
layout: page
title: DescribeParser.Visitors namespace - Basic Visitor for Describe 1.1
permalink: /tanspiler/parser/visitors/basic/v11/
exclude: true
---
## 1. BasicVisitor11

This visitor class is used to log to the console the result of a parse operation, in a sequential manner, leaving the order to the underlying ANTLR4 parser.

	Log - Gets or sets all the logs for this instance.
	LastError - Gets the last error for this instance. If there was an error, this string contains the message, and if there weren't any errors, this will be `null`.
	Ctor() - A constructor.

	`public override object VisitScripture(Describe11Parser.ScriptureContext context)`
	Visit a `Describe11Parser.ScriptureContext` object, and log it.
	context - A `ScriptureContext` object, produced by a parser. It is eqivalent to a parse tree.
	RETURNS - ?

	`public override object VisitTerminal(ITerminalNode node)`
	Visit an `ITerminalNode` object, and log it.
	node - The terminal object to visit. It is eqivalent to a token in the parse tree.
	RETURNS - ?

	`public override object VisitProducer(Describe11Parser.ProducerContext context)`
	Visit a `Describe11Parser.ProducerContext` object, and log it.
	context - A `ProducerContext` object, produced by a parser. It is eqivalent to a parse tree branch.
	RETURNS - ?

	`public override object VisitText_chunk(Describe11Parser.Text_chunkContext context)`
	Visit a `Describe11Parser.Text_chunkContext` object, and log it.
	context - A `Text_chunkContext` object, produced by a parser. It is eqivalent to a parse tree branch.
	RETURNS - ?

	`public override object VisitItem(Describe11Parser.ItemContext context)`
	Visit a `Describe11Parser.ItemContext` object, and log it.
	context - A `ItemContext` object, produced by a parser. It is eqivalent to a parse tree branch.
	RETURNS - ?

	`public override object VisitExpression(Describe11Parser.ExpressionContext context)`
	Visit a `Describe11Parser.ExpressionContext` object, and log it.
	context - A `ExpressionContext` object, produced by a parser. It is eqivalent to a parse tree branch.
	RETURNS - ?

	`public override object VisitExpression_list(Describe11Parser.Expression_listContext context)`
	Visit a `Describe11Parser.Expression_listContext` object, and log it.
	context - A `Expression_listContext` object, produced by a parser. It is eqivalent to a parse tree branch.
	RETURNS - ?

	`public override object VisitItem_or_expression_list(Describe11Parser.Item_or_expression_listContext context)`
	Visit a `Describe11Parser.Item_or_expression_listContext` object, and log it.
	context - A `Item_or_expression_listContext` object, produced by a parser. It is eqivalent to a parse tree branch.
	RETURNS - ?

	`public override object VisitItem_or_expression_part(Describe11Parser.Item_or_expression_partContext context)`
	Visit a `Describe11Parser.Item_or_expression_partContext` object, and log it.
	context - A `Item_or_expression_partContext` object, produced by a parser. It is eqivalent to a parse tree branch.
	RETURNS - ?


	LogVisitor11 : Describe11BaseVisitor<object>, ILogVisitor

		.public string Log                                          { get; set; }
		.public string LastError                                    { get; set; }

		.Ctor()

		.public override object VisitScripture(Describe11Parser.ScriptureContext context)
		.public override object VisitTerminal(ITerminalNode node)
		.public override object VisitProducer(Describe11Parser.ProducerContext context)
		.public override object VisitText_chunk(Describe11Parser.Text_chunkContext context)
		.public override object VisitItem(Describe11Parser.ItemContext context)
		.public override object VisitExpression(Describe11Parser.ExpressionContext context)
		.public override object VisitExpression_list(Describe11Parser.Expression_listContext context)
		.public override object VisitItem_or_expression_list(Describe11Parser.Item_or_expression_listContext context)
		.public override object VisitItem_or_expression_part(Describe11Parser.Item_or_expression_partContext context)


### Links
[Back](/tanspiler/parser/visitors/)
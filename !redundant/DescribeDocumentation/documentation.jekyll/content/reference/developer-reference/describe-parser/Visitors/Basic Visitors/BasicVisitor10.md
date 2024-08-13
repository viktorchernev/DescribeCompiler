---
layout: page
title: DescribeParser.Visitors namespace - Basic Visitor for Describe 1.0
permalink: /language/reference/dev/tanspiler/parser/visitors/basic/v10/
exclude: true
---
## 1. BasicVisitor10

This visitor class is used to log to the console the result of a parse operation, in a sequential manner, leaving the order to the underlying ANTLR4 parser.

	Log - Gets or sets all the logs for this instance.
	LastError - Gets the last error for this instance. If there was an error, this string contains the message, and if there weren't any errors, this will be `null`.
	Ctor() - A constructor.

	`public override object VisitScripture(Describe10Parser.ScriptureContext context)`
	Visit a `Describe10Parser.ScriptureContext` object, and log it.
	context - A `ScriptureContext` object, produced by a parser. It is equivalent to a parse tree.
	RETURNS - ?

	`public override object VisitTerminal(ITerminalNode node)`
	Visit an `ITerminalNode` object, and log it.
	node - The terminal object to visit. It is equivalent to a token in the parse tree.
	RETURNS - ?

	`public override object VisitProducer(Describe10Parser.ProducerContext context)`
	Visit a `Describe10Parser.ProducerContext` object, and log it.
	context - A `ProducerContext` object, produced by a parser. It is equivalent to a parse tree branch.
	RETURNS - ?

	`public override object VisitText_chunk(Describe10Parser.Text_chunkContext context)`
	Visit a `Describe10Parser.Text_chunkContext` object, and log it.
	context - A `Text_chunkContext` object, produced by a parser. It is equivalent to a parse tree branch.
	RETURNS - ?

	`public override object VisitItem(Describe10Parser.ItemContext context)`
	Visit a `Describe10Parser.ItemContext` object, and log it.
	context - A `ItemContext` object, produced by a parser. It is equivalent to a parse tree branch.
	RETURNS - ?

	`public override object VisitExpression(Describe10Parser.ExpressionContext context)`
	Visit a `Describe10Parser.ExpressionContext` object, and log it.
	context - A `ExpressionContext` object, produced by a parser. It is equivalent to a parse tree branch.
	RETURNS - ?

	`public override object VisitExpression_list(Describe10Parser.Expression_listContext context)`
	Visit a `Describe10Parser.Expression_listContext` object, and log it.
	context - A `Expression_listContext` object, produced by a parser. It is equivalent to a parse tree branch.
	RETURNS - ?

	`public override object VisitItem_or_expression_list(Describe10Parser.Item_or_expression_listContext context)`
	Visit a `Describe10Parser.Item_or_expression_listContext` object, and log it.
	context - A `Item_or_expression_listContext` object, produced by a parser. It is equivalent to a parse tree branch.
	RETURNS - ?

	`public override object VisitItem_or_expression_part(Describe10Parser.Item_or_expression_partContext context)`
	Visit a `Describe10Parser.Item_or_expression_partContext` object, and log it.
	context - A `Item_or_expression_partContext` object, produced by a parser. It is equivalent to a parse tree branch.
	RETURNS - ?


	LogVisitor10 : Describe10BaseVisitor<object>, ILogVisitor

		.public string Log                                          { get; set; }
		.public string LastError                                    { get; set; }

		.Ctor()

		.public override object VisitScripture(Describe10Parser.ScriptureContext context)
		.public override object VisitTerminal(ITerminalNode node)
		.public override object VisitProducer(Describe10Parser.ProducerContext context)
		.public override object VisitText_chunk(Describe10Parser.Text_chunkContext context)
		.public override object VisitItem(Describe10Parser.ItemContext context)
		.public override object VisitExpression(Describe10Parser.ExpressionContext context)
		.public override object VisitExpression_list(Describe10Parser.Expression_listContext context)
		.public override object VisitItem_or_expression_list(Describe10Parser.Item_or_expression_listContext context)
		.public override object VisitItem_or_expression_part(Describe10Parser.Item_or_expression_partContext context)


<br>
### Links
[Back](/language/reference/dev/tanspiler/parser/visitors/basic/)
Basic visitors - DescribeParser.Visitors namespace

	The Basic visitor classes are mostly for demonstrational purposes, and follow the standart ANTLR runtime visitor pattern. With the other visitors we either provide our `visitChildren` method or iterate through che children objects of each object ourselves. This way, we have control of the order in which each child is visited. However, with the Basic visitor we don't do that - we leave the default visiting pattern take controw of the execution flow. If you are goind to be developing a visitor for a Describe parser, you will do well to check out this visitor, as well as the Log visitor to begin with, as they use different design.
	
	That aside, this visitor, much like the Log Visitor, logs text to the console.
	
	1. LogVisitor08

		This visitor class is used to log to the console the result of a parse operation, in a sequential manner, leaving the order to the underlying ANTLR4 parser.
		Log - Gets or sets all the logs for this instance.
		LastError - Gets the last error for this instance. If there was an error, this string contains the message, and if there weren't any errors, this will be `null`.
		Ctor() - A constructor.
		
		`public override object VisitScripture(Describe08Parser.ScriptureContext context)`
		Visit a `Describe08Parser.ScriptureContext` object, and log it.
		context - A `ScriptureContext` object, produced by a parser. It is eqivalent to a parse tree.
		RETURNS - ?
		
		`public override object VisitTerminal(ITerminalNode node)`
		Visit an `ITerminalNode` object, and log it.
		node - The terminal object to visit. It is eqivalent to a token in the parse tree.
		RETURNS - ?

		`public override object VisitProducer(Describe08Parser.ProducerContext context)`
		Visit a `Describe08Parser.ProducerContext` object, and log it.
		context - A `ProducerContext` object, produced by a parser. It is eqivalent to a parse tree branch.
		RETURNS - ?
		
		`public override object VisitText_chunk(Describe08Parser.Text_chunkContext context)`
		Visit a `Describe08Parser.Text_chunkContext` object, and log it.
		context - A `Text_chunkContext` object, produced by a parser. It is eqivalent to a parse tree branch.
		RETURNS - ?
		
		`public override object VisitItem(Describe08Parser.ItemContext context)`
		Visit a `Describe08Parser.ItemContext` object, and log it.
		context - A `ItemContext` object, produced by a parser. It is eqivalent to a parse tree branch.
		RETURNS - ?
		
		`public override object VisitExpression(Describe08Parser.ExpressionContext context)`
		Visit a `Describe08Parser.ExpressionContext` object, and log it.
		context - A `ExpressionContext` object, produced by a parser. It is eqivalent to a parse tree branch.
		RETURNS - ?
		
		`public override object VisitExpression_list(Describe08Parser.Expression_listContext context)`
		Visit a `Describe08Parser.Expression_listContext` object, and log it.
		context - A `Expression_listContext` object, produced by a parser. It is eqivalent to a parse tree branch.
		RETURNS - ?
		
		`public override object VisitItem_or_expression_list(Describe08Parser.Item_or_expression_listContext context)`
		Visit a `Describe08Parser.Item_or_expression_listContext` object, and log it.
		context - A `Item_or_expression_listContext` object, produced by a parser. It is eqivalent to a parse tree branch.
		RETURNS - ?
		
		`public override object VisitItem_or_expression_part(Describe08Parser.Item_or_expression_partContext context)`
		Visit a `Describe08Parser.Item_or_expression_partContext` object, and log it.
		context - A `Item_or_expression_partContext` object, produced by a parser. It is eqivalent to a parse tree branch.
		RETURNS - ?
		
		
		LogVisitor08 : Describe08BaseVisitor<object>, ILogVisitor
		
			.public string Log											{ get; set; }
			.public string LastError									{ get; set; }
			
			.Ctor()
			
			.public override object VisitScripture(Describe08Parser.ScriptureContext context)
			.public override object VisitTerminal(ITerminalNode node)
			.public override object VisitProducer(Describe08Parser.ProducerContext context)
			.public override object VisitText_chunk(Describe08Parser.Text_chunkContext context)
			.public override object VisitItem(Describe08Parser.ItemContext context)
			.public override object VisitExpression(Describe08Parser.ExpressionContext context)
			.public override object VisitExpression_list(Describe08Parser.Expression_listContext context)
			.public override object VisitItem_or_expression_list(Describe08Parser.Item_or_expression_listContext context)
			.public override object VisitItem_or_expression_part(Describe08Parser.Item_or_expression_partContext context)
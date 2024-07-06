AstNodes - Ast / Leafs

	Those are the classes, or rather the class `AstLeafNode`, that represent terminals in the Syntax tree 
	(Not to be confused with Tokens in the parse tree which they not always translate one on one to).
	For all the terminals, we use `AstLeafNode`, and give it a different type.

	
	enum AstLeafType

		.Unknown
		.Text
		
		.ProductionArrow
		.Separator
		.Terminator,

		.OpenTag,
		.CloseTag,
		.OpenLink,
		.CloseLink,
		.OpenDecorator,
		.CloseDecorator,
	
	
	
	AstLeafNode : AstNode, IAstChildNode
	
		// Data
		.AstLeafType 							LeafType
		.string									Text
		.string? 								Trivia
		//.string?								LeadingTrivia
		
		// Properties
		.bool									HasTrivia
		
		// IAstChildNode
		:SourcePosition? 						Position
		:IAstBranchNode? 						Parent
		
		// AstNode
		:ToString()			->string
		:ToJson()			->string
		:ToCode()			->string
AstNodes - Ast / MajorBranches

	The major branches are branch nodes that contain only other branches, as well as leafs.
	Those are the Item, Expression, and the top-level node scripture, that represents a Describe source file.
	


AstItemNode : AstNode, IAstBranchNode, IAstChildNode

	// Vars
	.AstLeafNode? 									Tilde
	.AstLeafNode 									Text
	.AstTagNode? 									Tag
	.List<AstLinkNode>? 							Links
	.List<AstDecoratorNode>? 						Decorators
	
	// Properties
	.bool 											HasTag
	.bool 											HasLinks
    .bool 											HasDecorators
	
	// IAstBranchNode
	.List<AstLeafNode>								Leafs
	.List<object>									Children
	
	// IAstChildNode
	.SourcePosition? 								Position
	.IAstBranchNode? 								Parent

	// AstNode
	:ToString()			->string
	:ToJson()			->string
	:ToCode()			->string



AstExpressionNode : AstNode, IAstBranchNode, IAstChildNode

	// Vars
	.AstItemNode 										TitleItem
	.AstLeafNode 										ProductionArrow
	.List<AstExpressionLineNode> 						Lines
	
	// Properties
	.[int]				->AstExpressionLineNode
	.bool 												IsEmpty
	.bool 												IsMultyLined
	.int 												LinesCount
	
	// IAstBranchNode
	.List<AstLeafNode>									Leafs
	.List<object>										Children
	
	// IAstChildNode
	.SourcePosition? 									Position
	.IAstBranchNode? 									Parent

	// AstNode
	:ToString()			->string
	:ToJson()			->string
	:ToCode()			->string



AstExpressionLineNode : AstNode, IAstBranchNode, IAstChildNode

	// Vars
	.IAstBranchNode? 									Body
	.AstLeafNode? 										Punctuation
	
	// Properties
	.bool 												HasBody
	.bool 												HasPunctuation
	
	// IAstBranchNode
	.List<AstLeafNode>									Leafs
	.List<object>										Children
	
	// IAstChildNode
	.SourcePosition? 									Position
	.IAstBranchNode? 									Parent
	
	// AstNode
	:ToString()			->string
	:ToJson()			->string
	:ToCode()			->string



AstScriptureNode : AstNode, IAstBranchNode

	// Vars
	.string? 											FileName
	.string? 											Namespace
	.List<AstExpressionNode> 							Expressions
	.Exception											Exception
	
	// Properties
	.[int]				->AstExpressionNode
	.bool 												IsMultyExpression
	.int 												ExpressionCount
	.bool												HasException
	
	// IAstBranchNode
	.List<AstLeafNode>									Leafs
	.List<object>										Children
	
	// AstNode
	:ToString()			->string
	:ToJson()			->string
	:ToCode()			->string
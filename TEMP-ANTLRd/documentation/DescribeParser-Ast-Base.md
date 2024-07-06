AstNodes - Ast / Base

	These are the base classes and interfaces for the Abstract Syntax Tree.
	`SourcePosition` describes the position of the first and the last character in a Node.
	AstNode is the base class for all the Nodes in the abstract syntax tree. It implement the IAstNode interface.
	Every IAstNode - that is, every AstNode, that is every node in the abstract syntax tree should implement the appropriate methods
	thus being directly translateable to string representation, to JSON representation, and to source code.
	Finally, every node in the abstract syntax tree can be IAstChildNode and IAstBranchNode, and most are both, with the exception of
	the top-level and bottom level classes.


	IAstNode
		
		.ToString()			->string
		.ToJson()			->string
		.ToCode()			->string



	IAstChildNode : IAstNode

		.SourcePosition? 	-get				Position
		.IAstBranchNode? 	-get				Parent
		
		:ToString()			->string
		:ToJson()			->string
		:ToCode()			->string



	IAstBranchNode : IAstNode

		.List<AstLeafNode>	-get				Leafs
		.List<object>		-get				Children
		
		:ToString()			->string
		:ToJson()			->string
		:ToCode()			->string



	AstNode : IAstNode

		:ToString()			->string
		:ToJson()			->string
		:ToCode()			->string
		
	
	
	SourcePosition

		.int 									FirstIndex
		.int									FirstLine
		.int									FirstColumn

		.int 									LastIndex
		.int									LastLine
		.int									LastColumn
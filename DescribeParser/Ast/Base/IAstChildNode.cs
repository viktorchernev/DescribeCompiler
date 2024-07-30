namespace DescribeParser.Ast
{
    /// <summary>
    /// Represents a child node in an abstract syntax tree (AST).
    /// </summary>
    public interface IAstChildNode : IAstNode
    {
        /// <summary>
        /// Gets the position of the node within the source code.
        /// </summary>
        /// <value>
        /// A <see cref="SourcePosition"/> object representing the position of the node,
        /// or <c>null</c> if the position is not set.
        /// </value>
        public SourcePosition Position { get; set;  }

        /// <summary>
        /// Gets the parent node of this node.
        /// </summary>
        /// <value>
        /// An <see cref="IAstBranchNode"/> object representing the parent of this node,
        /// or <c>null</c> if the parent is not set.
        /// </value>
        public IAstBranchNode? Parent { get; set; }
    }
}

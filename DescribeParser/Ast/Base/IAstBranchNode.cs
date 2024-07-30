namespace DescribeParser.Ast
{
    /// <summary>
    /// Represents a branch node in an abstract syntax tree (AST).
    /// </summary>
    public interface IAstBranchNode : IAstNode
    {
        /// <summary>
        /// Gets the list of leaf nodes associated with this branch node.
        /// </summary>
        /// <value>
        /// A <see cref="List{AstLeafNode}"/> containing the leaf nodes.
        /// </value>
        public List<AstLeafNode> Leafs { get; }

        /// <summary>
        /// Gets the list of child nodes associated with this branch node.
        /// </summary>
        /// <value>
        /// A list of <see cref="object"/> containing the child nodes.
        /// </value>
        public List<object> Children { get; }
    }

    /// <summary>
    /// Represents a generic branch node in an abstract syntax tree (AST) that can contain children of a specified type.
    /// </summary>
    /// <typeparam name="T">The type of the children nodes.</typeparam>
    public interface IAstBranchNode<T> : IAstNode
    {
        /// <summary>
        /// Gets the list of leaf nodes associated with this branch node.
        /// </summary>
        /// <value>
        /// A <see cref="List{AstLeafNode}"/> containing the leaf nodes.
        /// </value>
        public List<AstLeafNode> Leafs { get; }

        /// <summary>
        /// Gets the list of child nodes of type <typeparamref name="T"/> associated with this branch node.
        /// </summary>
        /// <value>
        /// A <see cref="List{T}"/> containing the child nodes.
        /// </value>
        public List<T> Children { get; }
    }
}

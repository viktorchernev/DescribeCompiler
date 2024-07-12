namespace DescribeParser.Ast
{
    /// <summary>
    /// Specifies the type of a leaf node in an abstract syntax tree (AST).
    /// </summary>
    public enum AstLeafType
    {
        /// <summary>
        /// The type of the leaf node is unknown.
        /// </summary>
        Unknown,

        /// <summary>
        /// The leaf node represents text.
        /// </summary>
        Text,

        /// <summary>
        /// The leaf node represents tilde.
        /// </summary>
        Tilde,


        /// <summary>
        /// The leaf node represents a production arrow.
        /// </summary>
        ProductionArrow,

        /// <summary>
        /// The leaf node represents a separator.
        /// </summary>
        Separator,

        /// <summary>
        /// The leaf node represents a terminator.
        /// </summary>
        Terminator,



        /// <summary>
        /// The leaf node represents an opening Tag bracket.
        /// </summary>
        OpenTag,

        /// <summary>
        /// The leaf node represents a closing Tag bracket.
        /// </summary>
        CloseTag,

        /// <summary>
        /// The leaf node represents an opening Link bracket.
        /// </summary>
        OpenLink,

        /// <summary>
        /// The leaf node represents a closing Link bracket.
        /// </summary>
        CloseLink,

        /// <summary>
        /// The leaf node represents an opening Decorator bracket.
        /// </summary>
        OpenDecorator,

        /// <summary>
        /// The leaf node represents a closing Decorator bracket.
        /// </summary>
        CloseDecorator,
    }
}

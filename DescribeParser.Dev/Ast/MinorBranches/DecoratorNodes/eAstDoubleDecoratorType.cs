namespace DescribeParser.Ast
{
    /// <summary>
    /// Specifies the type of double decorator in an abstract syntax tree (AST).
    /// </summary>
    public enum AstDoubleDecoratorType
    {
        /// <summary>
        /// The type of the decorator node is unknown.
        /// </summary>
        Unknown,

        /// <summary>
        /// Represents a color decorator type.
        /// </summary>
        ColorDecorator,

        /// <summary>
        /// Represents a background color decorator type.
        /// </summary>
        BgColorDecorator,

        /// <summary>
        /// Represents a custom decorator type.
        /// </summary>
        CustomDecorator,

        /// <summary>
        /// Represents an enlist decorator type.
        /// </summary>
        EnlistDecorator
    }
}

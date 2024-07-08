using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    /// <summary>
    /// Specifies the type of simple decorator in an abstract syntax tree (AST).
    /// </summary>
    public enum AstSimpleDecoratorType
    {
        /// <summary>
        /// The type of the decorator node is unknown.
        /// </summary>
        Unknown,

        /// <summary>
        /// Represents an empty decorator type.
        /// </summary>
        EmptyDecorator,

        /// <summary>
        /// Represents a bold decorator type.
        /// </summary>
        BoldDecorator,

        /// <summary>
        /// Represents an italic decorator type.
        /// </summary>
        ItalicDecorator,

        /// <summary>
        /// Represents a striked-through decorator type.
        /// </summary>
        StrikedDecorator,

        /// <summary>
        /// Represents an underline decorator type.
        /// </summary>
        UnderlineDecorator,

        /// <summary>
        /// Represents a comment decorator type.
        /// </summary>
        CommentDecorator,

        /// <summary>
        /// Represents a new line comment decorator type.
        /// </summary>
        NlCommentDecorator
    }
}

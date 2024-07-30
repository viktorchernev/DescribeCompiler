using DescribeParser.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public static partial class AstFactory
    {
        /// <summary>
        /// Creates a new instance of <see cref="AstScriptureNode"/> with the specified expressions and optional exception.
        /// </summary>
        /// <param name="expressions">The list of <see cref="AstExpressionNode"/> to be included in the scripture node.</param>
        /// <param name="exception">The exception to be associated with the scripture node, if any. Default is <c>null</c>.</param>
        /// <returns>A new instance of <see cref="AstScriptureNode"/> with the specified expressions and exception.</returns>
        public static AstScriptureNode CreateScriptureNode(List<AstExpressionNode> expressions,
            Exception? exception = null)
        {
            // null checks
            ValidateAstNodeListP(expressions);

            // code
            AstScriptureNode scripture = new AstScriptureNode();

            scripture.FileName = null;
            scripture.Namespace = null;
            scripture.Expressions = expressions;
            scripture.Exception = exception;

            return scripture;
        }

        /// <summary>
        /// Creates a new instance of <see cref="AstScriptureNode"/> with the specified expression and optional exception.
        /// </summary>
        /// <param name="expression">The <see cref="AstExpressionNode"/> to be included in the scripture node.</param>
        /// <param name="exception">The exception to be associated with the scripture node, if any. Default is <c>null</c>.</param>
        /// <returns>A new instance of <see cref="AstScriptureNode"/> with the specified expression and exception.</returns>
        public static AstScriptureNode CreateScriptureNode(AstExpressionNode expression,
            Exception? exception = null)
        {
            // null checks
            ValidateAstChildNodeP(expression);

            // code
            AstScriptureNode scripture = new AstScriptureNode();

            scripture.FileName = null;
            scripture.Namespace = null;
            scripture.Expressions = new List<AstExpressionNode>() { expression };
            scripture.Exception = exception;

            return scripture;
        }

        /// <summary>
        /// Creates a new instance of <see cref="AstScriptureNode"/> with the specified filename, expressions, and optional exception.
        /// </summary>
        /// <param name="filename">The filename to be associated with the scripture node.</param>
        /// <param name="expressions">The list of <see cref="AstExpressionNode"/> to be included in the scripture node.</param>
        /// <param name="exception">The exception to be associated with the scripture node, if any. Default is <c>null</c>.</param>
        /// <returns>A new instance of <see cref="AstScriptureNode"/> with the specified filename, expressions, and exception.</returns>
        public static AstScriptureNode CreateScriptureNode(string? filename, 
            List<AstExpressionNode> expressions, Exception? exception = null)
        {
            // null checks
            ValidateAstNodeListP(expressions);

            // code
            AstScriptureNode scripture = new AstScriptureNode();

            scripture.FileName = filename;
            scripture.Namespace = null;
            scripture.Expressions = expressions;
            scripture.Exception = exception;

            return scripture;
        }

        /// <summary>
        /// Creates a new instance of <see cref="AstScriptureNode"/> with the specified filename, expression, and optional exception.
        /// </summary>
        /// <param name="filename">The filename to be associated with the scripture node.</param>
        /// <param name="expression">The <see cref="AstExpressionNode"/> to be included in the scripture node.</param>
        /// <param name="exception">The exception to be associated with the scripture node, if any. Default is <c>null</c>.</param>
        /// <returns>A new instance of <see cref="AstScriptureNode"/> with the specified filename, expression, and exception.</returns>
        public static AstScriptureNode CreateScriptureNode(string? filename, 
            AstExpressionNode expression, Exception? exception = null)
        {
            // null checks
            ValidateAstChildNodeP(expression);

            // code
            AstScriptureNode scripture = new AstScriptureNode();

            scripture.FileName = filename;
            scripture.Namespace = null;
            scripture.Expressions = new List<AstExpressionNode>() { expression };
            scripture.Exception = exception;

            return scripture;
        }

        /// <summary>
        /// Creates a new instance of <see cref="AstScriptureNode"/> with the specified filename, namespace, expressions, and optional exception.
        /// </summary>
        /// <param name="filename">The filename to be associated with the scripture node.</param>
        /// <param name="namespaceName">The namespace to be associated with the scripture node.</param>
        /// <param name="expressions">The list of <see cref="AstExpressionNode"/> to be included in the scripture node.</param>
        /// <param name="exception">The exception to be associated with the scripture node, if any. Default is <c>null</c>.</param>
        /// <returns>A new instance of <see cref="AstScriptureNode"/> with the specified filename, namespace, expressions, and exception.</returns>
        public static AstScriptureNode CreateScriptureNode(string? filename, string? namespaceName,
            List<AstExpressionNode> expressions, Exception? exception = null)
        {
            // null checks
            ValidateAstNodeListP(expressions);

            // code
            AstScriptureNode scripture = new AstScriptureNode();

            scripture.FileName = filename;
            scripture.Namespace = namespaceName;
            scripture.Expressions = expressions;
            scripture.Exception = exception;

            return scripture;
        }

        /// <summary>
        /// Creates a new instance of <see cref="AstScriptureNode"/> with the specified filename, namespace, expression, and optional exception.
        /// </summary>
        /// <param name="filename">The filename to be associated with the scripture node.</param>
        /// <param name="namespaceName">The namespace to be associated with the scripture node.</param>
        /// <param name="expression">The <see cref="AstExpressionNode"/> to be included in the scripture node.</param>
        /// <param name="exception">The exception to be associated with the scripture node, if any. Default is <c>null</c>.</param>
        /// <returns>A new instance of <see cref="AstScriptureNode"/> with the specified filename, namespace, expression, and exception.</returns>
        public static AstScriptureNode CreateScriptureNode(string? filename, string? namespaceName,
            AstExpressionNode expression, Exception? exception = null)
        {
            // null checks
            ValidateAstChildNodeP(expression);

            // code
            AstScriptureNode scripture = new AstScriptureNode();

            scripture.FileName = filename;
            scripture.Namespace = namespaceName;
            scripture.Expressions = new List<AstExpressionNode>() { expression };
            scripture.Exception = exception;

            return scripture;
        }
    }
}

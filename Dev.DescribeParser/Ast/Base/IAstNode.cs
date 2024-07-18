using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    /// <summary>
    /// Represents a node in an abstract syntax tree (AST).
    /// </summary>
    public interface IAstNode
    {
        /// <summary>
        /// Get a string representation of an AST object for logging purposes
        /// </summary>
        public string ToString();

        /// <summary>
        /// Get a JSON string representation of an AST object for logging purposes
        /// </summary>
        public string ToJson();

        /// <summary>
        /// Get a source code string representation of an AST object
        /// </summary>
        public string ToCode();
    }
}

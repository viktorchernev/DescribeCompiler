namespace DescribeParser.Ast
{
    /// <summary>
    /// Represents a branch node, that is also a child node, in an abstract syntax tree (AST).
    /// </summary>
    public interface IAstBranchChildNode : IAstNode, IAstBranchNode, IAstChildNode
    {
    }
}

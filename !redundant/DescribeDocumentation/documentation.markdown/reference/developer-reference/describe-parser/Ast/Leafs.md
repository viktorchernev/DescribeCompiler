---
layout: page
title: DescribeParser.Ast namespace - Abstract Syntax Tree
permalink: /language/reference/dev/tanspiler/parser/ast/leafs/
exclude: true
---
<br>Those are the classes, or rather the class `AstLeafNode`, that represent terminals in the Syntax tree (Not to be confused with Tokens in the parse tree which they not always translate one on one to). For all the terminals, we use `AstLeafNode`, and give it a different type.

<br>
## 1. AstLeafType

Specifies the type of a leaf node in an abstract syntax tree (AST).

        Unknown - The type of the leaf node is unknown.
        Text - The leaf node represents text.
        Tilde - The leaf node represents tilde.
        ProductionArrow - The leaf node represents a production arrow.
        Separator - The leaf node represents a separator.
        Terminator - The leaf node represents a terminator.
        OpenTag - The leaf node represents an opening Tag bracket.
        CloseTag - The leaf node represents a closing Tag bracket.
        OpenLink - The leaf node represents an opening Link bracket.
        CloseLink - The leaf node represents a closing Link bracket.
        OpenDecorator - The leaf node represents an opening Decorator bracket.
        CloseDecorator - The leaf node represents a closing Decorator bracket.

        public enum AstLeafType

            .Unknown
            .Text
            .Tilde

            .ProductionArrow
            .Separator
            .Terminator

            .OpenTag
            .CloseTag
            .OpenLink
            .CloseLink
            .OpenDecorator
            .CloseDecorator


<br>
## 2. AstLeafNode

Represents a leaf node in an abstract syntax tree (AST). This class has an internal constructor in order to prevent external instantiation, for which we use the AstFactory methods.

        AstLeafType -  Gets the type of the leaf node.
        Text - Gets the text associated with the leaf node.
        LeadingTrivia - Gets the leading trivia associated with the leaf node.
        TrailingTrivia - Gets the trailing trivia associated with the leaf node.
        HasTrivia - Gets a value indicating whether the `AstLeafNode` has additional trivia.
        HasLeadingTrivia - Gets a value indicating whether the `AstLeafNode` has leading trivia.
        HasTrailingTrivia - Gets a value indicating whether the `AstLeafNode` has trailing trivia.
        Position - Gets the position of this leaf node within the source code.
        Parent - Gets the parent branch node of this leaf node.
        ToString() - Returns a string representation of the `AstLeafNode`.
        ToJson() - Converts the `AstLeafNode` to a JSON string.
        ToCode() - Converts the `AstLeafNode` back to source code.


        public class AstLeafNode : AstNode, IAstChildNode

            // Vars
            .public AstLeafType LeafType                { get; internal set; }
            .public string Text                         { get; internal set; }
            .public string? LeadingTrivia               { get; internal set; }
            .public string? TrailingTrivia              { get; internal set; }

            // Properties
            .public bool HasTrivia                      { get; }
            .public bool HasLeadingTrivia               { get; }
            .public bool HasTrailingTrivia              { get; }

            // IAstChildNode
            .public SourcePosition? Position            { get; set; }
            .public IAstBranchNode? Parent              { get; set; }

            // AstNode
            .public override string ToString()
            .public override string ToJson()
            .public override string ToCode()


<br>
### Links
[Back](/language/reference/dev/tanspiler/parser/ast/)
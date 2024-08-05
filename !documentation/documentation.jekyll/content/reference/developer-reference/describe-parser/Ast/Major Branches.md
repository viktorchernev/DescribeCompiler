---
layout: page
title: DescribeParser.Ast namespace - Abstract Syntax Tree
permalink: /tanspiler/parser/ast/major-branches/
exclude: true
---
The major branches are branch nodes that contain only other branches, as well as leafs. Those are the Item, Expression, and the top-level node scripture, that represents a Describe source file.

## 1. AstScriptureNode

Represents an Ast Scripture object.
This class has an internal constructor in order to prevent external instantiation, for which we use the AstFactory methods.

        FileName - The string representing the filename of the Scripture object.
        Namespace - The string representing the base namespace of the Scripture object.
        Expressions - The List representing the Expression objects of this Scripture object.
        Exception - The Exception of this Scripture object - null if parsing was successful.

        `public AstExpressionNode this[int index]`
        You can index the `AstScriptureNode` with this indexer. You will be getting the `AstExpressionNode` from the Expressions list, at the specified index.
        index - The zero-based index of the expression to get.
        RETURNS - The `AstExpressionNode` at the specified index.
        EXCEPTION / IndexOutOfRangeException - Thrown if the index is less than 0 or greater than or equal to the number of expressions.

        IsMultyExpression - Wether this Scripture object has an multiple Expressions or a single one.
        ExpressionCount - Gets the Number of Expressions in this Scripture object.
        HasException - Wether this Scripture object has an Exception.
        Leafs - Gets all the Leaf Nodes contained in this Scripture object.
        Children - Gets all the direct descendant nodes of this Scripture object.
        ToString() - Returns a string representation of the `AstScriptureNode`.
        ToJson() - Converts the `AstScriptureNode` to a JSON string.
        ToCode() - Converts the `AstScriptureNode` back to source code.


        public class AstScriptureNode : AstNode, IAstBranchNode

            // Vars
            .public string? FileName                                { get; internal set; }
            .public string? Namespace                               { get; internal set; }
            .public List<AstExpressionNode> Expressions             { get; internal set; }
            .public Exception Exception                             { get; internal set; }

            // Properties
            .public AstExpressionNode this[int index]               { get; }
            .public bool IsMultyExpression                          { get; }
            .public int ExpressionCount                             { get; }
            .public bool HasException                               { get; }

            // AstBranchNode
            .public List<AstLeafNode> Leafs                         { get; }
            .public List<object> Children                           { get; }

            // AstNode
            .public override string ToString()
            .public override string ToJson()
            .public override string ToCode()


## 2. AstExpressionNode

Represents an Ast Expression object .
This class has an internal constructor in order to prevent external instantiation, for which we use the AstFactory methods.

        TitleItem - The Leaf Node representing the title symbol of the Expression object.
        ProductionArrow - The Leaf Node representing the production arrow symbol of the Expression object.
        Lines - The List representing the Expression Line objects of this Scripture object.

        `public AstExpressionLineNode this[int index]`
        You can index the `AstExpressionNode` with this indexer. You will be getting the `AstExpressionLineNode` from the Lines list, at the specified index.
        index - The zero-based index of the expression to get.
        RETURNS - The `AstExpressionLineNode` at the specified index.
        EXCEPTION / IndexOutOfRangeException - Thrown if the index is less than 0 or greater than or equal to the number of expressions.

        IsEmpty - Wether this Expression object has multiple Expression lines or not.
        IsMultyLined - Wether this Expression object has multiple Expression lines or not.
        LinesCount - Gets the Number of Lines in this Expression object.
        Leafs - Gets all the Leaf Nodes contained in this Expression object.
        Children - Gets all the direct descendant nodes of this Expression object.
        Position - Get the SourcePosition of this Expression object.
        Parent - Get the Parent of this Expression object.
        ToString() - Returns a string representation of the `AstExpressionNode`.
        ToJson() - Converts the `AstExpressionNode` to a JSON string.
        ToCode() - Converts the `AstExpressionNode` back to source code.


        public class AstExpressionNode : AstNode, IAstBranchNode, IAstChildNode
        
            // Vars
            .public AstItemNode TitleItem                           { get; internal set; }
            .public AstLeafNode ProductionArrow                     { get; internal set; }
            .public List<AstExpressionLineNode> Lines               { get; internal set; }

            // Properties
            .public AstExpressionLineNode this[int index]           { get; }
            .public bool IsEmpty                                    { get; }
            .public bool IsMultyLined                               { get; }
            .public int LinesCount                                  { get; }
        
            // AstBranchNode
            .public List<AstLeafNode> Leafs                         { get; }
            .public List<object> Children                           { get; }
            
            // IAstChildNode
            .public SourcePosition? Position                        { get; set; }
            .public IAstBranchNode? Parent                          { get; set; }

            // AstNode
            .public override string ToString()
            .public override string ToJson()
            .public override string ToCode()


## 2.1. AstExpressionLineNode

Represents an Ast ExpressionLine object.
This class has an internal constructor in order to prevent external instantiation, for which we use the AstFactory methods.

        Body - The Item Node or Expression Node representing the Body symbol of the Expression line object.
        Punctuation - The Leaf Node representing the punctuation symbol of the ExpressionLine object.
        HasBody - Wether this ExpressionLine has Body.
        HasPunctuation - Wether this ExpressionLine object has Punctuation.
        Leafs - Gets all the Leaf Nodes contained in this ExpressionLine object.
        Children - Gets all the direct descendant nodes of this ExpressionLine object.
        Position - Get the SourcePosition of this ExpressionLine object.
        Parent - Get the Parent of this ExpressionLine object.
        ToString() - Returns a string representation of the `AstExpressionLineNode`.
        ToJson() - Converts the `AstExpressionLineNode` to a JSON string.
        ToCode() - Converts the `AstExpressionLineNode` back to source code.


        public class AstExpressionLineNode : AstNode, IAstBranchNode, IAstChildNode

            // Vars
            .public IAstBranchNode? Body                            { get; internal set; }
            .public AstLeafNode? Punctuation                        { get; internal set; }

            // Properties
            .public bool HasBody                                    { get; }
            .public bool HasPunctuation                             { get; }

            // AstBranchNode
            .public List<AstLeafNode> Leafs                         { get; }
            .public List<object> Children                           { get; }

            // IAstChildNode
            .public SourcePosition? Position                        { get; set; }
            .public IAstBranchNode? Parent                          { get; set; }

            // AstNode
            .public override string ToString()
            .public override string ToJson()
            .public override string ToCode()


## 3. AstItemNode

Represents an Ast Item object.
This class has an internal constructor in order to prevent external instantiation, for which we use the AstFactory methods.

        Tilde - The Leaf Node representing the tilde symbol of the Item object.
        Text - The Leaf Node representing the text of the Item object.
        Tag - The Tag Node representing the Tag object of the Item object.
        Links - The List representing the Link objects of the Item object.
        Decorators - The List representing the Decorator objects of the Item object.
        HasTag - Wether the Item object has a Tag.
        HasLinks - Wether the Item object has Links.
        HasDecorators - Wether the Item object has Decorators.
        Leafs - Gets all the Leaf Nodes contained in this Item object.
        Children - Gets all the direct descendant nodes of this Item object.
        Position - Get the SourcePosition of this Item object.
        Parent - Get the Parent of this Item object.
        ToString() - Returns a string representation of the `AstItemNode`.
        ToJson() - Converts the `AstItemNode` to a JSON string.
        ToCode() - Converts the `AstItemNode` back to source code.

        public class AstItemNode : AstNode, IAstBranchNode, IAstChildNode

            // Vars
            .public AstLeafNode? Tilde                              { get; internal set; }
            .public AstLeafNode Text                                { get; internal set; }
            .public AstTagNode? Tag                                 { get; internal set; }
            .public List<AstLinkNode>? Links                        { get; internal set; }
            .public List<AstDecoratorNode>? Decorators              { get; internal set; }

            // Properties
            .public bool HasTag                                     { get; }
            .public bool HasLinks                                   { get; }
            .public bool HasDecorators                              { get; }

            // AstBranchNode
            .public List<AstLeafNode> Leafs                         { get; }
            .public List<object> Children                           { get; }

            // IAstChildNode
            .public SourcePosition? Position                        { get; set; }
            .public IAstBranchNode? Parent                          { get; set; }

            // AstNode
            .public override string ToString()
            .public override string ToJson()
            .public override string ToCode()


### Links
[Back](/tanspiler/parser/)
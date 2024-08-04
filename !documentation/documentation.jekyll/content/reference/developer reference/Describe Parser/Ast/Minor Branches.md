---
layout: page
title: DescribeParser.Ast namespace - Abstract Syntax Tree
permalink: /tanspiler/parser/ast/minor-branches/
exclude: true
---
The minor branches are branch nodes that contain only LeafNode-s. Those are the Tag(s), Link(s) and Decorator(s).


## 1. AstTagNode

Represents an Ast Tag object. This class has an internal constructor in order to prevent external instantiation, for which we use the AstFactory methods.

        OpenBracket - The Leaf Node representing the open bracket of the Tag object.
        Id - The Leaf Node representing the id of the Tag object.
        CloseBracket - The Leaf Node representing the closing bracket of the Tag object.
        Leafs - Get the Leaf Nodes that make the Tag object.
        Children - Get the Leaf Nodes that make the Tag object, as objects.
        Position - Gets the position of this tag node within the source code.
        Parent - Gets the parent branch node of this tag node.
        ToString() - Returns a string representation of the `AstTagNode`.
        ToJson() - Converts the `AstTagNode` to a JSON string.
        ToCode() - Converts the `AstTagNode` back to source code.

        public class AstTagNode : AstNode, IAstBranchNode, IAstChildNode

            // Values
            .public AstLeafNode OpenBracket                     { get; internal set; }
            .public AstLeafNode Id                              { get; internal set; }
            .public AstLeafNode CloseBracket                    { get; internal set; }

            // IAstBranchNode
            .public List<AstLeafNode> Leafs                     { get; }
            .public List<object> Children                       { get; }

            // IAstChildNode
            .public SourcePosition? Position                    { get; set; }
            .public IAstBranchNode? Parent                      { get; set; }

            // AstNode
            .public override string ToString()
            .public override string ToJson()
            .public override string ToCode()


## 2. AstLinkNode

Represents an Ast Link object.
This class has an internal constructor in order to prevent external instantiation, for which we use the AstFactory methods.

        OpenBracket - The Leaf Node representing the open bracket of the Link object.
        Url - The Leaf Node representing the URL of the Link object.
        Title - The Leaf Node representing the Title of the Link object.
        Letter - The Leaf Node representing the Letter of the Link object.
        CloseBracket - The Leaf Node representing the closing bracket of the Link object.
        HasTitle - Wether this Link object contains a Title.
        HasLetter - Wether this Link object contains a Letter
        Leafs - Get the Leaf Nodes that make the Link object.
        Children - Get the Leaf Nodes that make the Link object, as objects.
        Position - Gets the position of this link node within the source code.
        Parent - Gets the parent branch node of this link node.
        ToString() - Returns a string representation of the `AstLinkNode`.
        ToJson() - Converts the `AstLinkNode` to a JSON string.
        ToCode() - Converts the `AstLinkNode` back to source code.

        public class AstLinkNode : AstNode, IAstBranchNode, IAstChildNode

            // Values
            .public AstLeafNode OpenBracket                     { get; internal set; }
            .public AstLeafNode Url                             { get; internal set; }
            .public AstLeafNode? Title                          { get; internal set; }
            .public AstLeafNode? Letter                         { get; internal set; }
            .public AstLeafNode CloseBracket                    { get; internal set; }

            // Properties
            .public bool HasTitle                               { get; }
            .public bool HasLetter                              { get; }

            // IAstBranchNode
            .public List<AstLeafNode> Leafs                     { get; }
            .public List<object> Children                       { get; }

            // IAstChildNode
            .public SourcePosition? Position                    { get; set; }
            .public IAstBranchNode? Parent                      { get; set; }

            // AstNode
            .public override string ToString()
            .public override string ToJson()
            .public override string ToCode()


## 3. Decorators

## 3.1. AstDecoratorNode

Represents a decorator node in the abstract syntax tree (AST).
This class has an internal constructor in order to prevent external instantiation, for which we use the AstFactory methods.

            Leafs - Get or Set the Leaf Nodes that make the Decorator object.
            Children - Get the Leaf Nodes that make the Decorator object, as objects.
            Position - Gets the position of this decorator node within the source code.
            Parent - Gets the parent branch node of this decorator node.
            ToString() - Returns a string representation of the `AstDecoratorNode`.
            ToJson() - Converts the `AstDecoratorNode` to a JSON string.
            ToCode() - Converts the `AstDecoratorNode` back to source code.


            public abstract class AstDecoratorNode : AstNode, IAstBranchNode, IAstChildNode

                // IAstBranchNode
                .public List<AstLeafNode> Leafs                     { get; }
                .public List<object> Children                       { get; }

                // IAstChildNode
                .public SourcePosition? Position                    { get; set; }
                .public IAstBranchNode? Parent                      { get; set; }

                // AstNode
                .public override string ToString()
                .public override string ToJson()
                .public override string ToCode()


## 3.2. enum AstSimpleDecoratorType

Specifies the type of simple decorator in an abstract syntax tree (AST).

            Unknown - The type of the decorator node is unknown.
            EmptyDecorator - Represents an empty decorator type. 
            BoldDecorator - Represents a bold decorator type.
            ItalicDecorator - Represents an italic decorator type.
            StrikedDecorator - Represents a striked-through decorator type.
            UnderlineDecorator - Represents an underline decorator type.
            CommentDecorator - Represents a comment decorator type.
            NlCommentDecorator - Represents a new line comment decorator type.

            public enum AstSimpleDecoratorType

                .Unknown,
                .EmptyDecorator
                .BoldDecorator
                .ItalicDecorator
                .StrikedDecorator
                .UnderlineDecorator
                .CommentDecorator
                .NlCommentDecorator


## 3.3. AstSimpleDecoratorNode

Represents a simple decorator node - "{ Name }", in the abstract syntax tree (AST).
This class has an internal constructor in order to prevent external instantiation, for which we use the AstFactory methods.

            DecoratorType - Gets the type of the Simple Decorator node.
            OpenBracket - The Leaf Node representing the open bracket of the Simple Decorator object - "{ Name }".
            Name - The Leaf Node representing the Name of the Simple Decorator object - "{ Name }".
            CloseBracket - The Leaf Node representing the closing bracket of the Simple Decorator object - "{ Name }".
            Leafs - Get or Set the Leaf Nodes that make the Decorator object.
            Children - Get the Leaf Nodes that make the Decorator object, as objects.
            ToString() - Get a string representation of the Decorator object for logging purposes.
            ToJson() - Get a JSON string representation of the Decorator object.

            public class AstSimpleDecoratorNode : AstDecoratorNode

            // Vars
                .public AstSimpleDecoratorType DecoratorType        { get; internal set; }
                .public AstLeafNode OpenBracket                     { get; internal set; }
                .public AstLeafNode Name                            { get; internal set; }
                .public AstLeafNode CloseBracket                    { get; internal set; }
 
                // IAstBranchNode
                .public override List<AstLeafNode> Leafs            { get; }
                .public override List<object> Children              { get; }

                // AstNode
                .public override string ToString()
                .public override string ToJson()


## 3.4. enum AstDoubleDecoratorType

Specifies the type of double decorator in an abstract syntax tree (AST).

            Unknown - The type of the decorator node is unknown.
            ColorDecorator - Represents a color decorator type.
            BgColorDecorator - Represents a background color decorator type.
            CustomDecorator - Represents a custom decorator type.
            EnlistDecorator - Represents an enlist decorator type.

            public enum AstDoubleDecoratorType

                .Unknown
                .ColorDecorator
                .BgColorDecorator
                .CustomDecorator
                .EnlistDecorator


## 3.5. AstDoubleDecoratorNode

Represents a double decorator node - "{ Name | Value }", in the abstract syntax tree (AST).
This class has an internal constructor in order to prevent external instantiation, for which we use the AstFactory methods.

            DecoratorType - Gets the type of the Double Decorator node.
            OpenBracket - The Leaf Node representing the open bracket of the Double Decorator object - "{ Name | Value }".
            Name - The Leaf Node representing the Name of the Double Decorator object - "{ Name | Value }".
            Value - The Leaf Node representing the Value of the Double Decorator object - "{ Name | Value }".
            CloseBracket - The Leaf Node representing the closing bracket of the Double Decorator object - "{ Name | Value }".
            Leafs - Get or Set the Leaf Nodes that make the Decorator object.
            Children - Get the Leaf Nodes that make the Decorator object, as objects.
            ToString() - Get a string representation of the Decorator object for logging purposes.
            ToJson() - Get a JSON string representation of the Decorator object.

            public class AstDoubleDecoratorNode : AstDecoratorNode

                // Vars
                .public AstDoubleDecoratorType DecoratorType        { get; internal set; }
                .public AstLeafNode OpenBracket                     { get; internal set; }
                .public AstLeafNode Name                            { get; internal set; }
                .public AstLeafNode Value                           { get; internal set; }
                .public AstLeafNode CloseBracket                    { get; internal set; }

                // IAstBranchNode
                .public override List<AstLeafNode> Leafs            { get; }
                .public override List<object> Children              { get; }

                // AstNode
                .public override string ToString()
                .public override string ToJson()


## 3.6. enum AstTripleDecoratorType

Specifies the type of triple decorator in an abstract syntax tree (AST).

            Unknown - The type of the decorator node is unknown.
            CustomDoubleDecorator - Represents a custom double decorator type.

            public enum AstTripleDecoratorType

                .Unknown
                .CustomDoubleDecorator


## 3.7. AstTripleDecoratorNode

Represents a triple decorator node - "{ Category | Name | Value }", in the abstract syntax tree (AST).
This class has an internal constructor in order to prevent external instantiation, for which we use the AstFactory methods.

            DecoratorType - Gets the type of the Triple Decorator node.
            OpenBracket - The Leaf Node representing the open bracket of the Triple Decorator object - "{ Category | Name | Value }"
            Category - The Leaf Node representing the Category of the Triple Decorator object - "{ Category | Name | Value }"
            Name - The Leaf Node representing the Name of the Triple Decorator object - "{ Category | Name | Value }".
            Value - The Leaf Node representing the Value of the Triple Decorator object - "{ Category | Name | Value }".
            CloseBracket - The Leaf Node representing the closing bracket of the Triple Decorator object - "{ Category | Name | Value }".
            Leafs - Get or Set the Leaf Nodes that make the Decorator object.
            Children - Get the Leaf Nodes that make the Decorator object, as objects.
            ToString() - Get a string representation of the Decorator object for logging purposes.
            ToJson() - Get a JSON string representation of the Decorator object.

            public class AstDoubleDecoratorNode : AstDecoratorNode

                // Vars
                .public AstDoubleDecoratorType DecoratorType        { get; internal set; }
                .public AstLeafNode OpenBracket                     { get; internal set; }
                .public AstLeafNode Category                        { get; internal set; }
                .public AstLeafNode Name                            { get; internal set; }
                .public AstLeafNode Value                           { get; internal set; }
                .public AstLeafNode CloseBracket                    { get; internal set; }

                // IAstBranchNode
                .public override List<AstLeafNode> Leafs            { get; }
                .public override List<object> Children              { get; }

                // AstNode
                .public override string ToString()
                .public override string ToJson()


### Links
[Back](/tanspiler/parser/)
---
layout: page
title: DescribeParser.Ast namespace - Abstract Syntax Tree
permalink: /tanspiler/parser/ast/base/
exclude: true
---
The Base folder contains the base class and the interfaces for the members of the AST. These are the base classes and interfaces for the Abstract Syntax Tree. `SourcePosition` describes the position of the first and the last character in a Node. AstNode is the base class for all the Nodes in the abstract syntax tree. It implement the IAstNode interface. Every IAstNode - that is, every AstNode, that is every node in the abstract syntax tree should implement the appropriate methods thus being directly translateable to string representation, to JSON representation, and to source code. Finally, every node in the abstract syntax tree can be IAstChildNode and IAstBranchNode, and most are both, with the exception of the top-level and bottom level classes.

## 1. IAstNode

The IAstNode interface represents a node in an abstract syntax tree (AST).
        
        ToString() - Get a string representation of an AST object for logging purposes.
        ToJson() - Get a JSON string representation of an AST object for logging purposes.
        ToCode() - Get a source code string representation of an AST object.

        IAstNode
            .public string ToString()
            .public string ToJson()
            .public string ToCode()


## 2. AstNode

The base class for the AST
		
        ToString() - Get a string representation of an AST object for logging purposes.
        ToJson() - Get a JSON string representation of an AST object for logging purposes.
        ToCode() - Get a source code string representation of an AST object.

        `protected static string replaceWhitespaceE(string text)`
        Replaces new lines with escape characters in a string. Derived classes use this method in order to safely log strings.
        text - The unescaped text.
        RETURNS - an escaped string, containing symbols like '\n' instead of new line characters and '\t' instead of tab characters.


        public abstract class AstNode : IAstNode
            .public abstract new string ToString()
            .public abstract new string ToJson()
            .public abstract new string ToCode()
            
            .protected static string replaceWhitespaceE(string text)


## 3. IAstChildNode

Represents a child node in an abstract syntax tree (AST).
Being a child node means that a node is not the top level one, and has its place in the heirarchy, thus representing a chunk of the source code, and we want to know the position of that chunk, so that we can highlight it or replace/change it if needed.

        
        Position - Gets/sets the position of the node within the source code. A `SourcePosition` object representing the position of the node, or `null` if the position is not set.
        Parent - Gets/sets the parent node of this node. An `IAstBranchNode` object representing the parent of this node, or `null` if the parent is not set.

        public interface IAstChildNode : IAstNode
            .SourcePosition? Position               { get; set;  }
            .IAstBranchNode? Parent                 { get; set; }


## 4. SourcePosition

Represents an Ast SourcePosition object. 

        FirstIndex - The zero-based index in the source code string of the first character in this SourcePosition object.
        FirstLine - The zero-based line number in the source code of the first character in this SourcePosition object.
        FirstColumn - The zero-based column number in the current line, in the source code of the first character in this SourcePosition object.
        LastIndex - The zero-based index in the source code string of the last character in this SourcePosition object.
        LastLine - The zero-based line number in the source code of the last character in this SourcePosition object.
        LastColumn - The zero-based column number in the current line, in the source code of the last character in this SourcePosition object.

        public class SourcePosition
            .public int FirstIndex                  {get; internal set; }
            .public int FirstLine                   {get; internal set; }
            .public int FirstColumn                 {get; internal set; }
            .public int LastIndex                   {get; internal set; }
            .public int LastLine                    {get; internal set; }
            .public int LastColumn                  {get; internal set; }


## 5. IAstBranchNode

Represents a branch node in an abstract syntax tree (AST).
Branch nodes are nodes that contain other nodes. 

### 5.1. IAstBranchNode

    Leafs - Gets the list of leaf nodes associated with this branch node. A `List<AstLeafNode>` containing the leaf nodes.
    Children - Gets the list of child nodes associated with this branch node. A `List<object>` containing the child nodes.

    public interface IAstBranchNode : IAstNode
        .public List<AstLeafNode> Leafs         { get; }
        .public List<object> Children           { get; }


### 5.2. IAstBranchNode<T>

Represents a generic branch node in an abstract syntax tree (AST) that can contain children of a specified type.

    Leafs - Gets the list of leaf nodes associated with this branch node. A `List<AstLeafNode>` containing the leaf nodes.
    Children - Gets the list of child nodes of type `T` associated with this branch node. A `List<T>` containing the child nodes.

    public interface IAstBranchNode<T> : IAstNode
        .public List<AstLeafNode> Leafs         { get; }
        .public List<T> Children                { get; }


### Links
[Back](/tanspiler/parser/)
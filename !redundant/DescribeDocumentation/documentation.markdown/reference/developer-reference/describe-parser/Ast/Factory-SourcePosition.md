---
layout: page
title: DescribeParser.Ast namespace - AstFactory
permalink: /language/reference/dev/tanspiler/parser/ast/factory/position/
exclude: true
---
<br>The AstFactory contains all the methods needed to construct Ast classes. Those classes have internal constructors, so the AstFactory is the only way to construct the objects of the Abstract Syntax Tree.


<br>
## 8. SourcePosition - These methods constructs SourcePosition objects
	
	
	`public static SourcePosition CreateSourcePosition(int firstIndex, int firstLine, int firstColumn, int lastIndex, int lastLine, int lastColumn)`
	Creates a new `SourcePosition` with the specified parameters.
	firstIndex - The index of the first character.
	firstLine - The line number of the first character.
	firstColumn - The column number of the first character.
	lastIndex - The index of the last character.
	lastLine - The line number of the last character.
	lastColumn - The column number of the last character.
	RETURNS - A new `SourcePosition` object with the specified parameters.
	
	
	`public static SourcePosition CreateSourcePosition(SourcePosition position)`
	Creates a new `SourcePosition` by copying the values from an existing `SourcePosition`.
	position - The `SourcePosition` to copy.
    RETURNS - A new `SourcePosition` with the same values as the specified `position`.


	` public static SourcePosition CreateSourcePosition(SourcePosition position0, SourcePosition position1)`
	Creates a new `SourcePosition` by combining values from two existing `SourcePosition` instances.
	position0 - The `SourcePosition` to use for the first part of the range.
	position1 - The `SourcePosition` to use for the last part of the range.
    RETURNS - A new `SourcePosition` with the first values from `position0` and last values from `position1`.


	`public static SourcePosition CreateSourcePosition(params SourcePosition[] positions)`
	Creates a consolidated `SourcePosition` based on the provided array of positions.
	positions - An array of `SourcePosition` instances.
    RETURNS - A single `SourcePosition` that spans from the minimum first index to the maximum last index of the input positions.


<br>
### Links
[Next](/language/reference/dev/tanspiler/parser/ast/factory/)<br>
[Back](/language/reference/dev/tanspiler/parser/ast/factory/leaf/)
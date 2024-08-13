---
layout: page
title: DescribeParser.Visitors namespace - Ast Visitors
permalink: /language/reference/dev/tanspiler/parser/visitors/ast/
exclude: true
---
<br>The Ast visitor classes are used to build Abstract Syntax Trees form parse trees.

<br>
## 1. UniversalAstVisitor
An Ast visitor for all Describe Language versions in one class. Used to build Abstract Syntax Tree.

    Log - Gets or sets all the logs for this instance.
    LastError - Gets the last error for this instance. If there was an error, this string contains the message, and if there weren't any errors, this will be `null`.

    `public AstScriptureNode TranslateContext(ParserRuleContext context)`
    `public AstScriptureNode TranslateContext(ParserRuleContext context, string filename)`
    Determines the language version of the `ParserRuleContext` object by its type, and performs the translate action on it.
    context - The `ParserRuleContext` object to translate.
    RETURNS - true if successful, false if not.

    `public AstScriptureNode TranslateContext06(ParserRuleContext context)`
    `public AstScriptureNode TranslateContext06(ParserRuleContext context, string filename)`
    Translates the `ParserRuleContext` object using in AstVisitor06 (Describe v0.6).
    context - The `ParserRuleContext` object to translate.
    RETURNS - true if successful, false if not.

    `public AstScriptureNode TranslateContext07(ParserRuleContext context)`
    `public AstScriptureNode TranslateContext07(ParserRuleContext context, string filename)`
    Translates the `ParserRuleContext` object using in AstVisitor07 (Describe v0.7).
    context - The `ParserRuleContext` object to translate.
    RETURNS - true if successful, false if not.

    `public AstScriptureNode TranslateContext08(ParserRuleContext context)`
    `public AstScriptureNode TranslateContext08(ParserRuleContext context, string filename)`
    Translates the `ParserRuleContext` object using in AstVisitor08 (Describe v0.8).
    context - The `ParserRuleContext` object to translate.
    RETURNS - true if successful, false if not.

    `public AstScriptureNode TranslateContext09(ParserRuleContext context)`
    `public AstScriptureNode TranslateContext09(ParserRuleContext context, string filename)`
    Translates the `ParserRuleContext` object using in AstVisitor09 (Describe v0.9).
    context - The `ParserRuleContext` object to translate.
    RETURNS - true if successful, false if not.

    `public AstScriptureNode TranslateContext10(ParserRuleContext context)`
    `public AstScriptureNode TranslateContext10(ParserRuleContext context, string filename)`
    Translates the `ParserRuleContext` object using in AstVisitor10 (Describe v1.0).
    context - The `ParserRuleContext` object to translate.
    RETURNS - true if successful, false if not.

    `public AstScriptureNode TranslateContext11(ParserRuleContext context)`
    `public AstScriptureNode TranslateContext11(ParserRuleContext context, string filename)`
    Translates the `ParserRuleContext` object using AstVisitor11 (Describe v1.1).
    context - The `ParserRuleContext` object to translate.
    RETURNS - true if successful, false if not.


    public class UniversalAstVisitor
        .string Log                                                 { get; }
        .string LastError                                           { get; }

        .public AstScriptureNode TranslateContext(ParserRuleContext context, string filename = "")
        .public AstScriptureNode TranslateContext06(ParserRuleContext context, string filename = "")
        .public AstScriptureNode TranslateContext07(ParserRuleContext context, string filename = "")
        .public AstScriptureNode TranslateContext08(ParserRuleContext context, string filename = "")
        .public AstScriptureNode TranslateContext09(ParserRuleContext context, string filename = "")
        .public AstScriptureNode TranslateContext10(ParserRuleContext context, string filename = "")
        .public AstScriptureNode TranslateContext11(ParserRuleContext context, string filename = "")


<br>
## 2. AstVisitor06
An Ast visitor for Describe Language version 0.6. Used to build Abstract Syntax Trees.

    Log - Gets or sets all the logs for this instance.
    LastError - Gets the last error for this instance. If there was an error, this string contains the message, and if there weren't any errors, this will be `null`.

    `public AstScriptureNode TranslateContext(Describe06Parser.ScriptureContext context)`
    `public AstScriptureNode TranslateContext(Describe06Parser.ScriptureContext context, string filename)`
    Translate ANTLR4 parser parse tree (root `ScriptureContext` context) to an Abstract Syntax Tree.
    context - The `ParserRuleContext` - root context object to translate.
    RETURNS - The `AstScriptureNode` representing the syntax tree.


    public class UnfoldVisitor06
        .string Log                                                 { get; }
        .string LastError                                           { get; }

        .public bool TranslateContext(DescribeUnfold u, Describe06Parser.ScriptureContext context, string filename = "")


<br>
## 3. AstVisitor07
An Ast visitor for Describe Language version 0.7. Used to build Abstract Syntax Trees.

    Log - Gets or sets all the logs for this instance.
    LastError - Gets the last error for this instance. If there was an error, this string contains the message, and if there weren't any errors, this will be `null`.

    `public AstScriptureNode TranslateContext(Describe07Parser.ScriptureContext context)`
    `public AstScriptureNode TranslateContext(Describe07Parser.ScriptureContext context, string filename)`
    Translate ANTLR4 parser parse tree (root `ScriptureContext` context) to an Abstract Syntax Tree.
    context - The `ParserRuleContext` - root context object to translate.
    RETURNS - The `AstScriptureNode` representing the syntax tree.


    public class UnfoldVisitor07
        .string Log                                                 { get; }
        .string LastError                                           { get; }

        .public bool TranslateContext(DescribeUnfold u, Describe07Parser.ScriptureContext context, string filename = "")


<br>
## 4. AstVisitor08
An Ast visitor for Describe Language version 0.8. Used to build Abstract Syntax Trees.

    Log - Gets or sets all the logs for this instance.
    LastError - Gets the last error for this instance. If there was an error, this string contains the message, and if there weren't any errors, this will be `null`.

    `public AstScriptureNode TranslateContext(Describe08Parser.ScriptureContext context)`
    `public AstScriptureNode TranslateContext(Describe08Parser.ScriptureContext context, string filename)`
    Translate ANTLR4 parser parse tree (root `ScriptureContext` context) to an Abstract Syntax Tree.
    context - The `ParserRuleContext` - root context object to translate.
    RETURNS - The `AstScriptureNode` representing the syntax tree.


    public class UnfoldVisitor08
        .string Log                                                 { get; }
        .string LastError                                           { get; }

        .public bool TranslateContext(DescribeUnfold u, Describe08Parser.ScriptureContext context, string filename = "")


<br>
## 5. AstVisitor09
An Ast visitor for Describe Language version 0.9. Used to build Abstract Syntax Trees.

    Log - Gets or sets all the logs for this instance.
    LastError - Gets the last error for this instance. If there was an error, this string contains the message, and if there weren't any errors, this will be `null`.

    `public AstScriptureNode TranslateContext(Describe09Parser.ScriptureContext context)`
    `public AstScriptureNode TranslateContext(Describe09Parser.ScriptureContext context, string filename)`
    Translate ANTLR4 parser parse tree (root `ScriptureContext` context) to an Abstract Syntax Tree.
    context - The `ParserRuleContext` - root context object to translate.
    RETURNS - The `AstScriptureNode` representing the syntax tree.


    public class UnfoldVisitor09
        .string Log                                                 { get; }
        .string LastError                                           { get; }

        .public bool TranslateContext(DescribeUnfold u, Describe09Parser.ScriptureContext context, string filename = "")


<br>
## 6. AstVisitor10
An Ast visitor for Describe Language version 1.0. Used to build Abstract Syntax Trees.

    Log - Gets or sets all the logs for this instance.
    LastError - Gets the last error for this instance. If there was an error, this string contains the message, and if there weren't any errors, this will be `null`.

    `public AstScriptureNode TranslateContext(Describe10Parser.ScriptureContext context)`
    `public AstScriptureNode TranslateContext(Describe10Parser.ScriptureContext context, string filename)`
    Translate ANTLR4 parser parse tree (root `ScriptureContext` context) to an Abstract Syntax Tree.
    context - The `ParserRuleContext` - root context object to translate.
    RETURNS - The `AstScriptureNode` representing the syntax tree.


    public class UnfoldVisitor10
        .string Log                                                 { get; }
        .string LastError                                           { get; }

        .public bool TranslateContext(DescribeUnfold u, Describe10Parser.ScriptureContext context, string filename = "")


<br>
## 7. AstVisitor11
An Ast visitor for Describe Language version 1.1. Used to build Abstract Syntax Trees.

    Log - Gets or sets all the logs for this instance.
    LastError - Gets the last error for this instance. If there was an error, this string contains the message, and if there weren't any errors, this will be `null`.

    `public AstScriptureNode TranslateContext(Describe11Parser.ScriptureContext context)`
    `public AstScriptureNode TranslateContext(Describe11Parser.ScriptureContext context, string filename)`
    Translate ANTLR4 parser parse tree (root `ScriptureContext` context) to an Abstract Syntax Tree.
    context - The `ParserRuleContext` - root context object to translate.
    RETURNS - The `AstScriptureNode` representing the syntax tree.


    public class UnfoldVisitor11
        .string Log                                                 { get; }
        .string LastError                                           { get; }

        .public bool TranslateContext(DescribeUnfold u, Describe11Parser.ScriptureContext context, string filename = "")


<br>
### Links
[Back](/language/reference/dev/tanspiler/parser/visitors/)
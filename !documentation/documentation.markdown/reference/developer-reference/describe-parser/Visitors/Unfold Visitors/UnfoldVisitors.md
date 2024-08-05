---
layout: page
title: DescribeParser.Visitors namespace - Unfold Visitors
permalink: /tanspiler/parser/visitors/unfold/
exclude: true
---
The Unfold visitor classes are used to extract data from the parse tree contexts and store that data in a DescribeUnfold class, that is provided as an input parameter to the methods.


## 1. UniversalUnfoldVisitor
An Unfold visitor for all Describe Language versions in one class. Used to extract data and store it in a `DescribeUnfold`.

    Log - Gets or sets all the logs for this instance.
    LastError - Gets the last error for this instance. If there was an error, this string contains the message, and if there weren't any errors, this will be `null`.

    `public bool TranslateContext(DescribeUnfold u, ParserRuleContext context)`
    `public bool TranslateContext(DescribeUnfold u, ParserRuleContext context, string filename)`
    Determines the language version of the `ParserRuleContext` object by its type, and performs the translate action on it.
    u - The `DescribeUnfold` class that will be populated.
    context - The `ParserRuleContext` object to translate.
    RETURNS - true if successful, false if not.

    `public bool TranslateContext06(DescribeUnfold u, ParserRuleContext context)`
    `public bool TranslateContext06(DescribeUnfold u, ParserRuleContext context, string filename)`
    Translates the `ParserRuleContext` object using in UnfoldVisitor06 (Describe v0.6).
    u - The `DescribeUnfold` class that will be populated.
    context - The `ParserRuleContext` object to translate.
    RETURNS - true if successful, false if not.

    `public bool TranslateContext07(DescribeUnfold u, ParserRuleContext context)`
    `public bool TranslateContext07(DescribeUnfold u, ParserRuleContext context, string filename)`
    Translates the `ParserRuleContext` object using in UnfoldVisitor07 (Describe v0.7).
    u - The `DescribeUnfold` class that will be populated.
    context - The `ParserRuleContext` object to translate.
    RETURNS - true if successful, false if not.

    `public bool TranslateContext08(DescribeUnfold u, ParserRuleContext context)`
    `public bool TranslateContext08(DescribeUnfold u, ParserRuleContext context, string filename)`
    Translates the `ParserRuleContext` object using in UnfoldVisitor08 (Describe v0.8).
    u - The `DescribeUnfold` class that will be populated.
    context - The `ParserRuleContext` object to translate.
    RETURNS - true if successful, false if not.

    `public bool TranslateContext09(DescribeUnfold u, ParserRuleContext context)`
    `public bool TranslateContext09(DescribeUnfold u, ParserRuleContext context, string filename)`
    Translates the `ParserRuleContext` object using in UnfoldVisitor09 (Describe v0.9).
    u - The `DescribeUnfold` class that will be populated.
    context - The `ParserRuleContext` object to translate.
    RETURNS - true if successful, false if not.

    `public bool TranslateContext10(DescribeUnfold u, ParserRuleContext context)`
    `public bool TranslateContext10(DescribeUnfold u, ParserRuleContext context, string filename)`
    Translates the `ParserRuleContext` object using in UnfoldVisitor10 (Describe v1.0).
    u - The `DescribeUnfold` class that will be populated.
    context - The `ParserRuleContext` object to translate.
    RETURNS - true if successful, false if not.

    `public bool TranslateContext11(DescribeUnfold u, ParserRuleContext context)`
    `public bool TranslateContext11(DescribeUnfold u, ParserRuleContext context, string filename)`
    Translates the `ParserRuleContext` object using in UnfoldVisitor11 (Describe v1.1).
    u - The `DescribeUnfold` class that will be populated.
    context - The `ParserRuleContext` object to translate.
    RETURNS - true if successful, false if not.


    public class UniversalUnfoldVisitor
        .string Log                                                 { get; }
        .string LastError                                           { get; }

        .public bool TranslateContext(DescribeUnfold u, ParserRuleContext context, string filename = "")
        .public bool TranslateContext06(DescribeUnfold u, ParserRuleContext context, string filename = "")
        .public bool TranslateContext07(DescribeUnfold u, ParserRuleContext context, string filename = "")
        .public bool TranslateContext08(DescribeUnfold u, ParserRuleContext context, string filename = "")
        .public bool TranslateContext09(DescribeUnfold u, ParserRuleContext context, string filename = "")
        .public bool TranslateContext10(DescribeUnfold u, ParserRuleContext context, string filename = "")
        .public bool TranslateContext11(DescribeUnfold u, ParserRuleContext context, string filename = "")



## 2. UnfoldVisitor06
This visitor class is used extract data and store it in an `DescribeUnfold`. For Describe Language version 0.6

    Log - Gets or sets all the logs for this instance.
    LastError - Gets the last error for this instance. If there was an error, this string contains the message, and if there weren't any errors, this will be `null`.

    `public bool TranslateContext(DescribeUnfold u, Describe06Parser.ScriptureContext context)`
    `public bool TranslateContext(DescribeUnfold u, Describe06Parser.ScriptureContext context, string filename)`
    Translate ANTLR4 parser parse tree (root `ScriptureContext` context) to Unfold structure.
    u - The `DescribeUnfold` class that will be populated.
    context - The `ParserRuleContext` - root context object to translate.
    RETURNS - True if successful, false if not.


    public class UnfoldVisitor06
        .string Log                                                 { get; }
        .string LastError                                           { get; }

    .public bool TranslateContext(DescribeUnfold u, Describe06Parser.ScriptureContext context, string filename = "")



## 3. UnfoldVisitor07
This visitor class is used extract data and store it in an `DescribeUnfold`. For Describe Language version 0.7

    Log - Gets or sets all the logs for this instance.
    LastError - Gets the last error for this instance. If there was an error, this string contains the message, and if there weren't any errors, this will be `null`.

    `public bool TranslateContext(DescribeUnfold u, Describe07Parser.ScriptureContext context)`
    `public bool TranslateContext(DescribeUnfold u, Describe07Parser.ScriptureContext context, string filename)`
    Translate ANTLR4 parser parse tree (root `ScriptureContext` context) to Unfold structure.
    u - The `DescribeUnfold` class that will be populated.
    context - The `ParserRuleContext` - root context object to translate.
    RETURNS - True if successful, false if not.


    public class UnfoldVisitor06
        .string Log                                                 { get; }
        .string LastError                                           { get; }

        .public bool TranslateContext(DescribeUnfold u, Describe07Parser.ScriptureContext context, string filename = "")



## 4. UnfoldVisitor08
This visitor class is used extract data and store it in an `DescribeUnfold`. For Describe Language version 0.8

    Log - Gets or sets all the logs for this instance.
    LastError - Gets the last error for this instance. If there was an error, this string contains the message, and if there weren't any errors, this will be `null`.

    `public bool TranslateContext(DescribeUnfold u, Describe08Parser.ScriptureContext context)`
    `public bool TranslateContext(DescribeUnfold u, Describe08Parser.ScriptureContext context, string filename)`
    Translate ANTLR4 parser parse tree (root `ScriptureContext` context) to Unfold structure.
    u - The `DescribeUnfold` class that will be populated.
    context - The `ParserRuleContext` - root context object to translate.
    RETURNS - True if successful, false if not.


    public class UnfoldVisitor06
        .string Log                                                 { get; }
        .string LastError                                           { get; }

        .public bool TranslateContext(DescribeUnfold u, Describe08Parser.ScriptureContext context, string filename = "")



## 5. UnfoldVisitor09
This visitor class is used extract data and store it in an `DescribeUnfold`. For Describe Language version 0.9

    Log - Gets or sets all the logs for this instance.
    LastError - Gets the last error for this instance. If there was an error, this string contains the message, and if there weren't any errors, this will be `null`.

    `public bool TranslateContext(DescribeUnfold u, Describe09Parser.ScriptureContext context)`
    `public bool TranslateContext(DescribeUnfold u, Describe09Parser.ScriptureContext context, string filename)`
    Translate ANTLR4 parser parse tree (root `ScriptureContext` context) to Unfold structure.
    u - The `DescribeUnfold` class that will be populated.
    context - The `ParserRuleContext` - root context object to translate.
    RETURNS - True if successful, false if not.


    public class UnfoldVisitor09
        .string Log                                                 { get; }
        .string LastError                                           { get; }

        .public bool TranslateContext(DescribeUnfold u, Describe09Parser.ScriptureContext context, string filename = "")



## 6. UnfoldVisitor10
This visitor class is used extract data and store it in an `DescribeUnfold`. For Describe Language version 1.0

    Log - Gets or sets all the logs for this instance.
    LastError - Gets the last error for this instance. If there was an error, this string contains the message, and if there weren't any errors, this will be `null`.

    `public bool TranslateContext(DescribeUnfold u, Describe10Parser.ScriptureContext context)`
    `public bool TranslateContext(DescribeUnfold u, Describe10Parser.ScriptureContext context, string filename)`
    Translate ANTLR4 parser parse tree (root `ScriptureContext` context) to Unfold structure.
    u - The `DescribeUnfold` class that will be populated.
    context - The `ParserRuleContext` - root context object to translate.
    RETURNS - True if successful, false if not.


    public class UnfoldVisitor10
        .string Log                                                 { get; }
        .string LastError                                           { get; }

        .public bool TranslateContext(DescribeUnfold u, Describe10Parser.ScriptureContext context, string filename = "")



## 7. UnfoldVisitor11
This visitor class is used extract data and store it in an `DescribeUnfold`. For Describe Language version 1.1

    Log - Gets or sets all the logs for this instance.
    LastError - Gets the last error for this instance. If there was an error, this string contains the message, and if there weren't any errors, this will be `null`.

    `public bool TranslateContext(DescribeUnfold u, Describe11Parser.ScriptureContext context)`
    `public bool TranslateContext(DescribeUnfold u, Describe11Parser.ScriptureContext context, string filename)`
    Translate ANTLR4 parser parse tree (root `ScriptureContext` context) to Unfold structure.
    u - The `DescribeUnfold` class that will be populated.
    context - The `ParserRuleContext` - root context object to translate.
    RETURNS - True if successful, false if not.


    public class UnfoldVisitor11
        .string Log                                                 { get; }
        .string LastError                                           { get; }

        .public bool TranslateContext(DescribeUnfold u, Describe11Parser.ScriptureContext context, string filename = "")


### Links
[Back](/tanspiler/parser/visitors/)
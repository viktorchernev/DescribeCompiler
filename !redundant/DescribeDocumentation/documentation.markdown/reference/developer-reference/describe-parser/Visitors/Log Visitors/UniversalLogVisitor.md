---
layout: page
title: DescribeParser.Visitors namespace - Universal Log Visitor for Describe
permalink: /language/reference/dev/tanspiler/parser/visitors/log/universal/
exclude: true
---
## 1. UniversalLogVisitor
A Log visitor for all Describe Language versions in one class.

    Log - Gets or sets all the logs for this instance.
    LastError - Gets the last error for this instance. If there was an error, this string contains the message, and if there weren't any errors, this will be `null`.

    `public string VisitContext(ParserRuleContext context)`
    Visits a `ParserRuleContext`, determines the language version of the object by its type, and performs the appropriate visit action on it.
    context - The `ParserRuleContext` object to visit.
    RETURNS - "success' if successful, "error" if not.

    `public string VisitContext06(ParserRuleContext context)`
    Visits a `ParserRuleContext`, and performs the appropriate visit action on it.
    context - The `ParserRuleContext` object to visit.
    RETURNS - "success' if successful, "error" if not.

    `public string VisitContext07(ParserRuleContext context)`
    Visits a `ParserRuleContext`, and performs the appropriate visit action on it.
    context - The `ParserRuleContext` object to visit.
    RETURNS - "success' if successful, "error" if not.

    `public string VisitContext08(ParserRuleContext context)`
    Visits a `ParserRuleContext`, and performs the appropriate visit action on it.
    context - The `ParserRuleContext` object to visit.
    RETURNS - "success' if successful, "error" if not.

    `public string VisitContext09(ParserRuleContext context)`
    Visits a `ParserRuleContext`, and performs the appropriate visit action on it.
    context - The `ParserRuleContext` object to visit.
    RETURNS - "success' if successful, "error" if not.

    `public string VisitContext10(ParserRuleContext context)`
    Visits a `ParserRuleContext`, and performs the appropriate visit action on it.
    context - The `ParserRuleContext` object to visit.
    RETURNS - "success' if successful, "error" if not.

    `public string VisitContext11(ParserRuleContext context)`
    Visits a `ParserRuleContext`, and performs the appropriate visit action on it.
    context - The `ParserRuleContext` object to visit.
    RETURNS - "success' if successful, "error" if not.

    `public string VisitTerminal(ITerminalNode node)`
    Visits a `ITerminalNode`, in LogVisitor06.
    context - The `ITerminalNode` object to visit.
    RETURNS - "success' if successful, "error" if not.

    `public string VisitTerminal06(ITerminalNode node)`
    Visits a `ITerminalNode`, in LogVisitor06.
    context - The `ITerminalNode` object to visit.
    RETURNS - "success' if successful, "error" if not.

    `public string VisitTerminal07(ITerminalNode node)`
    Visits a `ITerminalNode`, in LogVisitor07.
    context - The `ITerminalNode` object to visit.
    RETURNS - "success' if successful, "error" if not.

    `public string VisitTerminal08(ITerminalNode node)`
    Visits a `ITerminalNode`, in LogVisitor08.
    context - The `ITerminalNode` object to visit.
    RETURNS - "success' if successful, "error" if not.

    `public string VisitTerminal09(ITerminalNode node)`
    Visits a `ITerminalNode`, in LogVisitor09.
    context - The `ITerminalNode` object to visit.
    RETURNS - "success' if successful, "error" if not.

    `public string VisitTerminal10(ITerminalNode node)`
    Visits a `ITerminalNode`, in LogVisitor10.
    context - The `ITerminalNode` object to visit.
    RETURNS - "success' if successful, "error" if not.

    `public string VisitTerminal11(ITerminalNode node)`
    Visits a `ITerminalNode`, in LogVisitor11.
    context - The `ITerminalNode` object to visit.
    RETURNS - "success' if successful, "error" if not.


    public class UniversalLogVisitor
        .string Log                                                 { get; }
        .string LastError                                           { get; }

        .public string VisitContext(ParserRuleContext context)
        .public string VisitContext06(ParserRuleContext context)
        .public string VisitContext07(ParserRuleContext context)
        .public string VisitContext08(ParserRuleContext context)
        .public string VisitContext09(ParserRuleContext context)
        .public string VisitContext10(ParserRuleContext context)
        .public string VisitContext11(ParserRuleContext context)

        .public string VisitTerminal(ITerminalNode node)
        .public string VisitTerminal06(ITerminalNode node)
        .public string VisitTerminal09(ITerminalNode node)
        .public string VisitTerminal08(ITerminalNode node)
        .public string VisitTerminal09(ITerminalNode node)
        .public string VisitTerminal10(ITerminalNode node)
        .public string VisitTerminal11(ITerminalNode node)


<br>
### Links
[Back](/language/reference/dev/tanspiler/parser/visitors/log/)
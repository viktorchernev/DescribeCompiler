---
layout: page
title: DescribeParser.Visitors namespace - Log Visitor for Describe 0.7
permalink: /tanspiler/parser/visitors/log/v07/
exclude: true
---
## 1. LogVisitor07

This visitor class is used to log to the console the result of a parse operation. 
This LogVisitor is for Describe version 0.7

    Log - Gets or sets all the logs for this instance.
    LastError - Gets the last error for this instance. If there was an error, this string contains the message, and if there weren't any errors, this will be `null`.

    `public override string VisitScripture(Describe07Parser.ScriptureContext context)`
    Visits the Scripture node in the Describe07 parse tree.
    context - The context of the Scripture node.
    RETURNS - A string indicating the success or failure of the visit.

    `public override string VisitTerminal(ITerminalNode node)`
    Visits a terminal node in the Describe07 parse tree.
    node - The terminal node to visit.
    RETURNS - A string indicating the success or failure of the visit.
    or failure 

    `public override string VisitProducer(Describe07Parser.ProducerContext context)`
    Visits the Producer node in the Describe07 parse tree.
    context - The context of the Producer node.
    RETURNS - A string indicating the success or failure of the visit.

    `public override string VisitText_chunk(Describe07Parser.Text_chunkContext context)`
    Visits the Text_chunk node in the Describe07 parse tree.
    context - The context of the Text_chunk node.
    RETURNS - A string indicating the success or failure of the visit.

    `public override string VisitItem(Describe07Parser.ItemContext context)
    Visits the Item node in the Describe07 parse tree.
    context - The context of the Item node.
    RETURNS - A string indicating the success or failure of the visit.

    `public override string VisitExpression(Describe07Parser.ExpressionContext context)`
    Visits the Expression node in the Describe07 parse tree.
    context - The context of the Expression node.
    RETURNS - A string indicating the success or failure of the visit.

    `public override string VisitExpression_list(Describe07Parser.Expression_listContext context)`
    Visits the Expression_list node in the Describe07 parse tree.
    context - The context of the Expression_list node.
    RETURNS - A string indicating the success or failure of the visit.

    `public override string VisitItem_or_expression_list(Describe07Parser.Item_or_expression_listContext context)`
    Visits the Item_or_expression_list node in the Describe07 parse tree.
    context - The context of the Item_or_expression_list node.
    RETURNS - A string indicating the success or failure of the visit.

    `public override string VisitItem_or_expression_part(Describe07Parser.Item_or_expression_partContext context)`
    Visits the Item_or_expression_part node in the Describe07 parse tree.
    context - The context of the Item_or_expression_part node.
    RETURNS - A string indicating the success or failure of the visit.


    LogVisitor07

        .string Log                                                 { get; }
        .string LastError                                           { get; }

        .public override string VisitScripture(Describe07Parser.ScriptureContext context)
        .public override string VisitTerminal(ITerminalNode node)
        .public override string VisitProducer(Describe07Parser.ProducerContext context)
        .public override string VisitText_chunk(Describe07Parser.Text_chunkContext context)
        .public override string VisitItem(Describe07Parser.ItemContext context)
        .public override string VisitExpression(Describe07Parser.ExpressionContext context)
        .public override string VisitExpression_list(Describe07Parser.Expression_listContext context)
        .public override string VisitItem_or_expression_list(Describe07Parser.Item_or_expression_listContext context)
        .public override string VisitItem_or_expression_part(Describe07Parser.Item_or_expression_partContext context)


### Links
[Back](/tanspiler/parser/visitors/log/)
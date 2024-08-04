---
layout: page
title: DescribeParser.Visitors namespace - Basic Visitors
permalink: /tanspiler/parser/visitors/basic/
exclude: true
---
The Basic visitor classes are mostly for demonstrational purposes, and follow the standart ANTLR runtime visitor pattern. With the other visitors we either provide our `visitChildren` method or iterate through che children objects of each object ourselves. This way, we have control of the order in which each child is visited. However, with the Basic visitor we don't do that - we leave the default visiting pattern take controw of the execution flow. If you are goind to be developing a visitor for a Describe parser, you will do well to check out this visitor, as well as the Log visitor to begin with, as they use different design.

That aside, this visitor, much like the Log Visitor, logs text to the console.


[Basic Visitor for Describe 0.6](/tanspiler/parser/visitors/basic/v06/)<br>
[Basic Visitor for Describe 0.7](/tanspiler/parser/visitors/basic/v07/)<br>
[Basic Visitor for Describe 0.8](/tanspiler/parser/visitors/basic/v08/)<br>
[Basic Visitor for Describe 0.9](/tanspiler/parser/visitors/basic/v09/)<br>
[Basic Visitor for Describe 1.0](/tanspiler/parser/visitors/basic/v10/)<br>
[Basic Visitor for Describe 1.1](/tanspiler/parser/visitors/basic/v11/)<br>


### Links
[Back](/tanspiler/parser/visitors/)
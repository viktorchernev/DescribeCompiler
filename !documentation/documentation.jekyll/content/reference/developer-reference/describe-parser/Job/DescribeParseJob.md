---
layout: page
title: DescribeParser namespace - Job classes
permalink: /tanspiler/parser/job/
exclude: true
---
The `IDescribeParseJob` interface describes a class, containing variables that are used by the Unfold Visitors during the translation process. The `SimpleParseJob` class is an implementation of this interface that the Unfold uses. However, users can device their own implementations that can be used for other parts of the transpilation process, by implementing the interface and reassigning in the `DescribeUnfold` class that will be used.
	
	
## 1. IDescribeParseJob interface

	Contains the intermediate data, used during a parse operation.
	InitialDir - Gets or sets the starting directory.
	LastNamespace - Gets or sets the current namespace we are in.
	LastFile - Gets or sets the current file we are in.

    public interface IDescribeParseJob
        .public string? InitialDir                                  { get; set; }
        .public string? LastNamespace                               { get; set; }
        .public string? LastFile                                    { get; set; }
	
	
	
## 2. SimpleParseJob class

	Contains the intermediate data, used during a parse operation.
	InitialDir - Gets or sets the starting directory.
	LastNamespace - Gets or sets the current namespace we are in.
	LastFile - Gets or sets the current file we are in.

    public class SimpleParseJob : IDescribeParseJob
        .public string? InitialDir                                  { get; set; }
        .public string? LastNamespace                               { get; set; }
        .public string? LastFile                                    { get; set; }


### Links
[Back](/tanspiler/parser/)
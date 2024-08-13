---
layout: page
title: DescribeUnfold - DescribeParser.Unfold namespace
permalink: /language/reference/dev/tanspiler/parser/unfold/
exclude: true
---
<br>The describe Unfold is a class that represents the information contained within Describe source code, be it a single file or multiple files. Unlike the AST, it does not retain source-code related information, like source code position or whitespaces between different syntactical constructs, and cannot be used to reconstruct the original source code. We could say that, the Unfold is optimised for tasks where only the actual data contaied in the source code matters.


<br>
## 1. DescribeDecorator

	The `DescribeDecorator` struct represents a decorator structure in the Describe language, containing name, value, and category information.
	Name - Gets or sets the name of the decorator.
	Value - Gets or sets the optional value of the decorator.
	Category - Gets or sets the optional category of the decorator.

	Nullable strings are an overhead both 1 byte in terms of memory and in execution time, as a check needs to be performed. However, they add clarity to the code and will be used, unless bottleneck issues arise.

	DescribeDecorator
        .string                 Name
        .string?                Value
        .string?                Category


<br>
## 2. DescribeLink

	The `DescribeLink` struct represents a link structure in the Describe language, containing URL, title, and letter information.
	Url - Gets or sets the URL of the link.
	Title - Gets or sets the optional title of the link.
	Letter - Gets or sets the optional letter associated with the link.

	DescribeLink
        .string                 Url
        .string?                Title
        .string?                Letter


<br>
## 3. DescribeUnfold
	
	The `DescribeUnfold` class represents the data structure for unfolded data with links and decorators.
	ParseJob - Gets or sets the parse job object for the Unfold. This class is used in the parsing process and does not need to be accessed directly.
	AllFiles - Gets or sets the list of all files that have been parsed or failed.
	ParsedFiles - Gets or sets the list of files that have been parsed successfully.
	FailedFiles - Gets or sets the list of files that have been parsed unsuccessfully.
	PrimaryProductions - Gets or sets the list of primary production IDs.
	Productions - Gets or sets the dictionary of productions (head item ID - body items ID's).
	Tildes - Gets or sets the dictionary of tildes (head item ID - body items ID's).
	Translations - Gets or sets the dictionary of translations (item ID - item Text).
	Links - Gets or sets the dictionary of links (item ID - links for that item).
	Decorators - Gets or sets the dictionary of decorators (item ID - decorators for that item).
	ItemidFile - Files that contain items (item ID - filenames for that item).
	ProdidFile - Files that contain productions (item ID - filenames for that production).
	INDENT - Gets or sets the indent used in the ToString() method.
	ToString() - Get a string representation of a `DescribeUnfold`. Used for logging.
	ToJson() - Get a json string representation of a `DescribeUnfold`. Used as means for serialization.

	`public void FromJson(string json)`
	Populate this `DescribeUnfold` object with values from json string. Used as means for deserialization.
	The JSON containing the values.

	We might implement a thread-safe version in the future, using thread-safe dictionaries and collections, such as `ConcurrentDictionary<TKey, TValue>` and `ConcurrentBag<T>`

	DescribeUnfold
        .IDescribeParseJob                             ParseJob

        .List<string>                                   AllFiles
        .List<string>                                   ParsedFiles
        .List<string>                                   FailedFiles

        .List<string>                                   PrimaryProductions
        .Dictionary<string, List<string>>               Productions
        .Dictionary<string, List<string>>               Tildes
        .Dictionary<string, string>                     Translations
        .Dictionary<string, List<DescribeLink>>         Links
        .Dictionary<string, List<DescribeDecorator>>    Decorators

        .Dictionary<string, List<string>>               ItemidFile
        .Dictionary<string, List<string>>               ProdidFile

        .string                                         INDENT
        .string ToString()
        .string ToJson()
        .FromJson(string json)


<br>
### Links
[Back](/language/reference/dev/tanspiler/parser/)
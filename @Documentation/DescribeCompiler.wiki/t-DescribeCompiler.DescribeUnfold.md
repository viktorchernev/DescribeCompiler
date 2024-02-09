The DescribeUnfold is a class that serves as an in-memory database, and plays the role of a syntax tree. The DescribeUnfold represents a parsed file, or a collection of parsed files. The unfold is what gets translated to the final output - HTML for example.

* `Dictionary<string, List<string>> Productions`  
This dictionary contains all the productions - keys are the ids of left hand side items, and values are lists of right hand side ids.  
  
* `List<string> PrimaryProductions`  
This list contains the ids of left hand side items of the productions that are primary - that meant that the construction of the HTML lists should start from those productions.  
  
* `Dictionary<string, string> Translations`  
This dictionary contains the items text literals - keys are the ids of items, and values are the text literals.

* `Dictionary<string, List<string>> Links`  
This dictionary contains the links for each item - keys are the ids of items, and values are the text of links.  

* `Dictionary<string, List<string>> Decorators`  
This dictionary contains the decorators for each item - keys are the ids of items, and values are the text of decorators.  
  
//TODO - files
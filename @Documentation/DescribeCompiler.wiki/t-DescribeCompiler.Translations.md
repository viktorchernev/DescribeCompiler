Translations is a static class used to convert the data in an `Unfold` structure (in-memory database) to the final HTML output. This is done by calling the method `TranslateUnfold`. The way this works is that `TranslateUnfold` and other private methods in the class retrieve html templates from embedded resources and substitute placeholder text in those templates with data from the unfold. Those templates reside in the "Translations" folder. If different output is desired, different Translations class should be implemented.    

`static string TranslateUnfold(DescribeUnfold u)`  
summary - Get html code from unfold  
parameter - "u" - The unfold to be translated  
returns - The generated html code  
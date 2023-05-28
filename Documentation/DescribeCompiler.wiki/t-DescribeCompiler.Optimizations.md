Optimizations is a static class used to convert the parse tree produced by the Gold parser engine (that is Gold parser reductions and Gold parser tokens) to a structure called the Unfold, which is in effect an in-memory database.  

* `static bool DoScripture(DescribeUnfold u, Reduction r, bool isPrimary = true)`  
summary - Translate Gold engine parse tree (root Reduction r) to Unfold structure.  
parameter - "u" - Unfold to be populated  
parameter - "r" - Root reduction aka the parse tree  
parameter - "isPrimary" - Wether this is the first file  
returns - True if successful, otherwise false
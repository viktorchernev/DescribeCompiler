Slash notation was the first addressing scheme used in the prototype of the describe language. It is no longer in use, and may or may not be returned to future versions of the language. The idea behind slash notation is to simply put the file name in the id of items that are in other files, using forward slashes as separators. However, there are a number of cons to this approach:

* produces long tag ids
* cross referencing requires implementation of `../../` up path
* very fragile - renaming or rearranging of files breaks lists
* not well suited for database integration  
  
### Links
[[Next|https://github.com/viktorchernev/DescribeCompiler/wiki/DescribeGrammar-filenames]]  
[[Prev|https://github.com/viktorchernev/DescribeCompiler/wiki/DescribeGrammar-dot-notation]]  

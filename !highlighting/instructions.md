XML files for Notepad++ highlighting are present in this folder, and I will add such files for other editors, when available. Meanwhile, you can use the instructions below to set the highlighting in your favorite editor manually - it shouldn't be too difficult, given it even supports defining user languages like that. You can use different colors if you like, of course.

However, such approach to highlighting is somewhat simplistic and will never work perfectly. It works well enough though, in the absence of proper highlighting plugins, this is the next best thing, and we don't have such plugins developed yet.

You can use visual styles you like - we prefer - green for comments, red for links, gray or greens on green background or magenta for decorators, deep blue for operators, possibly on contrasting yellow background. The instructions are given below:  

* Extensions to automatically apply language to are ".ds" - Describe source files and ".dr" - Describe draft files.
* Fold code on "->" and ";"
* Fold comments on "/*" and "*/"
* Allow folding of comments - yes
* Comment line - "//" and "\n"
* Comment delimited - "/*" and "*/"
* Operators - "->", "," and ";"
* Delimiter - "://" and "." - Hack for escaping slashes in URLs, otherwise they are treated as comments
* Delimiter - "{" and "}" - For decorators
* Delimiter - "<." and ">" - For public tags that utilize namespaces
* Delimiter - "<" and ">" - For tags
* Delimiter - "[" and "]" - For links
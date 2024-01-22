# Tech Home

Describe is a domain specific language used to write and maintain complex data lists that are compiled on demand to html, xaml, xml, sql, json and any other language needed. Describe is simple to use, intuitive and easy to master, and readily extendible. Second-brain apps and some websites are some of the use cases, although anything that someone would rather think about in terms of lists is a good candidate. Describe is developed to be the markup language behind a particular wiki type website for lists, called world of lists.

There is the infrastructure related to the website, and the one related to the language compiler. There are 4 distinct pieces of software related to the compiler:

DescribeCompilerApi - The actual compiler in a .net Dll. (FOSS - AGPL v3) DescribeCompilerCli - A CLI app that uses the API compiler and can be used to compile describe source files (FOSS - AGPL v3) 

DescribeCompilerDb - A CLI app that uses the API compiler and can be used to compile, manipulate and maintain the MySQL database of the website (Proprietary for the moment) 

GoldParserEngine - A rewrite of version 5.2 of the famous GOLD parser engine for .Net, on which the describe compiler is based (FOSS - AGPL v3)

* [[Describe Compiler API]]
* [[Describe Compiler CLI]]
* [[Describe Compiler AWS]]
* [[Gold Parser Engine]]
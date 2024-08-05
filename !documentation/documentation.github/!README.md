# *Describe Markup Language*  
![242452146-26dc5f4b-a676-41b8-837a-ac2fad29e556aa3](https://github.com/viktorchernev/DescribeCompiler/assets/72315339/b043a521-cdfc-494b-9267-f7a5d5d2dd06)

_Maintaining large data lists, made easy_  
  
  
![GitHub release (latest by date)](https://img.shields.io/github/v/release/viktorchernev/DescribeCompiler?color=green&logo=github)
[![License: AGPL v3](https://img.shields.io/badge/License-AGPL_v3-blue.svg)](https://www.gnu.org/licenses/agpl-3.0)

Describe is a markup language used to write and maintain complex data lists that are compiled on demand to html, xml, sql, json and any other language needed. Describe is simple to use, intuitive and easy to master, and readily extendible.


## How to
In order to run the `DescribeCompilerCLI.exe` you need a Windows PC with DotNet framework version 4.8 or higher. In order to reference the `DescribeCompilerAPI.dll` in your DotNet projects, you need to target DotNet framework version 4.8 or higher. There are no other dependencies. Also, be sure to check out our [wiki](https://github.com/viktorchernev/DescribeCompiler/wiki) for the complete documentation.  
  
### 0. Set up highlighting
In order to highlight Describe code, you can download the xml files for Notepad++ from the folder [Highlighting](https://github.com/viktorchernev/DescribeCompiler/tree/master/%23DescribeLanguage/Highlighting), or use the instructions provided in said folder to set up your preferred text editor.
  
### 1. Write Describe code  
Write a title of each list, followed by an arrow `->` and the elements, one on a line, separated by comma `,` and end with a semicolon `;`. Add `[links]` in square brackets, and `<tag>` items in order to piece lists together. Add additional data as `{decorators}` in curly brackets or as tilde inversions - `~`. For more info visit the [documentation](https://documentation.listiary.com/)/[github](https://github.com/viktorchernev/DescribeCompiler/wiki/Grammar-How-To) or explore Describe source codes and test cases in this [huge collection](https://library.listiary.com/)/[github](https://github.com/viktorchernev/DataLists/tree/master/Lists). 
  
![pic1a](https://github.com/viktorchernev/DescribeCompiler/assets/72315339/d5a71183-33ff-4e21-b6a1-db3ed7ac5967)


### 2a. [Compile (using CLI)](https://github.com/viktorchernev/DescribeCompiler/wiki/CliCompiler-how-to)  
Run the CLI compiler by specifying the target folder (or file) as first argument and output file (or folder) as second argument.  Add [options](https://github.com/viktorchernev/DescribeCompiler/wiki/CliCompiler-how-to) after that, if needed.  

![pic2a](https://github.com/viktorchernev/DescribeCompiler/assets/72315339/d8f6ac78-2cbc-4056-b560-16273474fa4d)

### 2b. [Compile (using API)](https://github.com/viktorchernev/DescribeCompiler/wiki/ApiCompiler-how-to)
### 2c. [Compile (using AWS)](https://github.com/viktorchernev/DescribeCompiler/wiki/AwsCompiler-how-to)


### 3. Result  
The final output will depend on the translator used - and you can easily write your own translator, or use the ones that are prebuilt for you. Here we are using a set of particular HTML templates to build a bare-bone website. The JSON translator is one of the particularly usefull ones. With that tanslator you produce JSON that can be consumed from web applications.
  
![pic3a](https://github.com/viktorchernev/DescribeCompiler/assets/72315339/36ae6997-82df-467e-b490-b7b9d63a860c)

## Get in touch  
- Use GitHub's issue reporter on the right
- Send me an email vchernev91@abv.bg (might take a few days)
- You can reach me on Viber as well: +359-885-18-05-86

## Releases
* 1.0 (Coming up soon)
* [0.9.3](https://github.com/viktorchernev/DescribeCompiler/releases/tag/0.9.3) (Support for Describe Language v1.0 - Official)  
* [0.9.2](https://github.com/viktorchernev/DescribeCompiler/releases/tag/0.9.2) (Added features and bugfixes)
* [0.9.1](https://github.com/viktorchernev/DescribeCompiler/releases/tag/0.9.1) (Refactoring, added features and bugfixes)
* [0.9](https://github.com/viktorchernev/DescribeCompiler/releases/tag/0.9) (Initial release - Open beta)

## Notes
* We currently have inbuilt translators for HTML and JSON. If you need to target other languages, you'd have to write your own translator - it is very easy. I will give updates here when more translators are available.

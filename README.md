# *Describe Markup Programming Language*  
![242452146-26dc5f4b-a676-41b8-837a-ac2fad29e556aa3](https://github.com/viktorchernev/DescribeCompiler/assets/72315339/b043a521-cdfc-494b-9267-f7a5d5d2dd06)

_Maintaining large data lists, made easy_  
  
  
![GitHub release (latest by date)](https://img.shields.io/github/v/release/viktorchernev/DescribeCompiler?color=green&logo=github)
[![License: AGPL v3](https://img.shields.io/badge/License-AGPL_v3-blue.svg)](https://www.gnu.org/licenses/agpl-3.0)

Describe is a domain specific language used to write and maintain complex data lists that are compiled on demand to html, xaml, xml, sql, json and any other language needed. Describe is simple to use, intuitive and easy to master, and readily extendible.


## How to
In order to run the `DescribeCompilerCLI.exe` you need a Windows PC with DotNet framework version 4.8 or higher. In order to reference the `DescribeCompilerAPI.dll` in your DotNet projects, you need to target DotNet framework version 4.8 or higher. Also, be sure to check out our [wiki](https://github.com/viktorchernev/DescribeCompiler/wiki) for the complete documentation.  
  
### 1. Write Describe code  
Write a title of each list, followed by an arrow `->` and the elements, one on a line, separated by comma `,` and end with a semicolon `;`. Add `[links]` in square brackets, and `<tag>` items in order to piece lists together. Add additional data as `{decorators}` in curly brackets. For more info visit the [documentation](https://github.com/viktorchernev/DescribeCompiler/wiki/Grammar-How-To) or explore Describe source codes and test cases in this [huge collection](https://github.com/viktorchernev/DataLists/tree/master/Lists).  
  
![pic1](https://github.com/viktorchernev/DescribeCompiler/assets/72315339/e1ec7895-d517-4936-ba09-2a0a52da333d)  

### 2a. Compile (using CLI)  
Run the CLI compiler by specifying the target folder (or file) as first argument and output file (or folder) as last argument.  Add [options](https://github.com/viktorchernev/DescribeCompiler/wiki/CliCompiler-how-to) in between, if needed.  

![pic2a](https://github.com/viktorchernev/DescribeCompiler/assets/72315339/d8f6ac78-2cbc-4056-b560-16273474fa4d)

### 2b. Compile (using API)
In order to [use the dll](https://github.com/viktorchernev/DescribeCompiler/wiki/ApiCompiler-how-to):
1. Add a reference to the project or DLL  
2. (OPTIONAL) Create your handlers that will be used for logging  
3. Call the constructor in order to create the compiler class, (passing your logging handlers if any)  
4. Call ParseFolder or ParseFile to get result:  

`using DescribeCompiler;`  
`DescribeCompiler compiler = new DescribeCompiler();`  
  
`string html = "";`  
`if(isdir == false) comp.ParseFile(new FileInfo(inputPath), out html);`  
`else comp.ParseFolder(new DirectoryInfo(inputPath), out html);`  
  
`if (html != null) File.WriteAllText(outputPath, html);`  


### 3. Result  
The final output will depend on the templates used - and you can easily write [your own templates](https://github.com/viktorchernev/DescribeCompiler/wiki/DescribeCompiler-templating), or use the ones that are prebuilt for you. Here we are using a set of particular HTML templates to build a bare-bone website (you can visit a live demo of this website [here](https://viktorchernev.github.io/Describe/)).  
  
![pic3a](https://github.com/viktorchernev/DescribeCompiler/assets/72315339/36ae6997-82df-467e-b490-b7b9d63a860c)

## Get in touch  
- Use GitHub's issue reporter on the right
- Send me an email vchernev91@abv.bg (might take a few days)
- You can reach me on Viber as well: +359-885-18-05-86

## Releases
* 0.9 Initial release (public beta)  

## Notes
* In those first beta releases, we currently only have that one HTML template set for demonstration purposes. If you are expecting a big variety of different designs and options - there aren't many yet, so you'd have to [write your own template set](https://github.com/viktorchernev/DescribeCompiler/wiki/DescribeCompiler-templating) - it is very easy, but still I feel the need to mention it, as I don't want anyone to feel misled. I will give updates here when more templates are available.
* In order to highlight Describe code, you can download the xml files for Notepad++ from the folder [Highlighting](https://github.com/viktorchernev/DescribeCompiler/tree/master/Highlighting), or use the instructions in said folder to set up your text editor.

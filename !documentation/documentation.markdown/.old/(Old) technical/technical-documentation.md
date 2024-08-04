---
layout: page
title: Technical
permalink: /technical/
---
The Describe Compiler is written in C# and consists of few different projects that are related to one another. Below is a list of those projects.

Describe is a domain specific language used to write and maintain complex data lists that are compiled on demand to html, xaml, xml, sql, json and any other language needed. Describe is simple to use, intuitive and easy to master, and readily extendible. Second-brain apps and some websites are some of the use cases, although anything that someone would rather think about in terms of lists is a good candidate. Describe is developed to be the markup language behind a particular wiki type website for lists, called world of lists.

There is the infrastructure related to the website, and the one related to the language compiler. There are 4 distinct pieces of software related to the compiler:
* DescribeCompilerApi - The actual compiler in a .net Dll. (FOSS - AGPL v3) DescribeCompilerCli - A CLI app that uses the API compiler and can be used to compile describe source files (FOSS - AGPL v3) 
* DescribeCompilerDb - A CLI app that uses the API compiler and can be used to compile, manipulate and maintain the MySQL database of the website (Proprietary for the moment) 
* GoldParserEngine - A rewrite of version 5.2 of the famous GOLD parser engine for .Net, on which the describe compiler is based (FOSS - AGPL v3)

#### Gold Parser Engine
The [Gold Parser Engine](/DescribeDocumentation/technical/gold-parser-engine) is the parser that powers the Describe Compiler. It is a .Net dll library that targets .Net Standard 2.0.

#### Describe Compiler API
The [Describe Compiler API](/DescribeDocumentation/technical/api) is the defacto compiler. It is a .Net dll library that targets .Net Standard 2.0. All the other projects are some kind of fronts for the Describe Compiler API.

#### Describe Compiler CLI
The Describe Compiler CLI is the command line version of the compiler. It is a .Net console application that acts as a wrapper around the dll library and provides a command line interface for the compiler. There are two versions of the Describe Compiler CLI, represented by two different projects - the [Describe Compiler CLI - Core](/DescribeDocumentation/technical/cli) and the [Describe Compiler CLI - Framework](/DescribeDocumentation/technical/cli), that target .Net Core and .Net Framework, respectively. Both apps should be more or less identical, but the Core App is the official one, which means tat it gets new features implemented first. The Framework App project is kept just in case that anyone anyone would need a .Net Framework implementation to work on.

#### Describe Compiler AWS
The [Describe Compiler AWS](/DescribeDocumentation/technical/aws-lambda) is Amazon Web Services Lambda function project. It is built for hosting the Describe Compiler as a microservice, in the form of a lambda function.

#### World of lists Tools
The **World of lists Tools** is a toolbox for administration and manipulation of the databases of the worldinlists.net website. It is more of a hackjob of different codes and a sandbox for different ideas. It is command line based. However, as worldinlists.net is currently a proprietary software, this project is not publically available for the moment.

## Links
* [Describe Compiler API](/DescribeDocumentation/technical/api)
* [Describe Compiler CLI](/DescribeDocumentation/technical/cli)
* [Describe Compiler AWS](/DescribeDocumentation/technical/aws-lambda)
* [Gold Parser Engine](/DescribeDocumentation/technical/gold-parser-engine)
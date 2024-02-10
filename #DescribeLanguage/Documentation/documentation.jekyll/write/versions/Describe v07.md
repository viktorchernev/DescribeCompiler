---
layout: page
title: Describe Tags
permalink: /language/v07/
exclude: true
---
Describe version 0.7, codenamed Tags is the second test version of the language. It introduced tags and tagging with ids in angle brackets - ```<tagid>```

The GOLD parser grammar is given next<br>
Keep in mind that the precompiler plays a role as well, and this cannot be seen from the grammar file.<br><br>


<span style="color:blue">_Describe 0.7 - Tags_</span>
```
! Attributes
"Name" = 'D#SCRIBE markup Language'
"Author" = 'DemonOfReason'
"Version" = '0.7'
"About" = 'D#SCRIBE Language'
"Character Mapping" = 'Unicode'
"Case Sensitive" = False
"Start Symbol" = <scripture>

! Comments
Comment Start = '/*'
Comment End = '*/'
Comment Line = '//'

! Symbols
Hyphen = '-'
LeftArrow = '<'
RightArrow = '>'
Separator = ','
Terminator = ';'
!Star = '*'
!FSlash = '/'
!BSlash = '\'

! Escaped symbols
EscapeHyphen = '\-'
EscapeLeftArrow = '\<'
EscapeRightArrow = '\>'
EscapeSeparator = '\,'
EscapeTerminator = '\;'
EscapeStar = '\*'
EscapeFSlash = '\/'
EscapeBSlash = '\\'

! Text
{SpecialCharacter} = ['-''<''>'','';''*''/''\''\-''\<''\>''\,''\;''\*''\/''\\']
{TextCharacter} = {Printable} - {SpecialCharacter}
Text = {TextCharacter}+


! Productions
<producer>
    ::= Hyphen RightArrow

! Tags
<tag>
    ::= LeftArrow <text> RightArrow

! Text
<text-chunk>
    ::= Text
    | EscapeHyphen
    | EscapeLeftArrow
    | EscapeRightArrow
    | EscapeSeparator
    | EscapeTerminator
    | EscapeStar
    | EscapeEscape
    | EscapeFSlash
    | EscapeBSlash

<text-chunk-list>    
    ::= <text-chunk> <text-chunk>    
     | <text-chunk> <text-chunk-list>

<text>     
    ::= <text-chunk>    
    | <text-chunk-list>
   


! Item
<item>    
    ::= <text>
    | <tag> <text>
    | <text> <tag>


! Expressions and more
<item-or-expression>    
    ::= <item>    
    | <expression>

<item-or-expression-list>
    ::= <item> Separator <item>
    | <item> Separator <expression>
    | <expression> <item>
    | <expression> <expression>
    
    | <item> Separator <item-or-expression-list>
    | <expression> <item-or-expression-list>

    
    

<expression>     
    ::= <item> <producer> Terminator    
    | <item> <producer> <item-or-expression> Terminator   
    | <item> <producer> <item-or-expression-list> Terminator
    | <item> <producer> <item-or-expression>
    | <item> <producer> <item-or-expression-list>

<expression-list>     
    ::= <expression> <expression>    
    | <expression> <expression-list>

<scripture>     
    ::= <expression>      
    | <expression-list>
```

### Links
[Back](/DescribeDocumentation/language/home)
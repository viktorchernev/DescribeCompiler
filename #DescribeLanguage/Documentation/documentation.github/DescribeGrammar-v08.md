Describe version 0.8, codenamed Links is the third test version of the language. It introduced links - ```[https://someurl.net/]```

The GOLD parser grammar is given next<br>
Keep in mind that the precompiler plays a role as well, and this cannot be seen from the grammar file.<br><br>


<span style="color:blue">_Describe 0.8 - Links_</span>
```
! Attributes
"Name" = 'D#SCRIBE markup Language'
"Author" = 'DemonOfReason'
"Version" = '0.8'
"About" = 'D#SCRIBE Language'
"Character Mapping" = 'Unicode'
"Case Sensitive" = False
"Start Symbol" = <scripture>

! Comments
Comment Start = '/*'
Comment End = '*/'
Comment Line = '//'
Link Start = '['
Link End = ']'

! Symbols
Hyphen = '-'
LeftArrow = '<'
RightArrow = '>'
Separator = ','
Terminator = ';'
!Star = '*'
!FSlash = '/'
!BSlash = '\'
!LeftSquare = '['
!RightSquare = ']'

! Escaped symbols
EscapeHyphen = '\-'
EscapeLeftArrow = '\<'
EscapeRightArrow = '\>'
EscapeLeftSquare = '\['
EscapeRightSquare = '\]'
EscapeSeparator = '\,'
EscapeTerminator = '\;'
EscapeStar = '\*'
EscapeFSlash = '\/'
EscapeBSlash = '\\'

! Text
{SpecialCharacter} = ['['']''-''<''>'','';''*''/''\''\-''\<''\>''\,''\;''\*''\/''\\']
{TextCharacter} = {Printable} - {SpecialCharacter}
Text = {TextCharacter}+


! Producer
<producer>
    ::= Hyphen RightArrow

! Tagging
<tag>
    ::= LeftArrow <text> RightArrow

<links>
    ::= Link Link
    | Link <links>

<decorators>
    ::= Decorator Decorator
    | Decorator <decorators>




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
    | EscapeLeftSquare
    | EscapeRightSquare

<text-chunk-list>    
    ::= <text-chunk> <text-chunk>    
     | <text-chunk> <text-chunk-list>

<text>     
    ::= <text-chunk>    
    | <text-chunk-list>
   


! Item
<item>    
    ::= <text>
    | <text> Link
    | <text> <tag>
    | <text> <tag> Link
    | <text> <tag> <links>
    | <text> Link <tag>
    | <text> <links> <tag>


    


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
[[Back | https://github.com/viktorchernev/DescribeCompiler/wiki/Grammar-How-To]]  
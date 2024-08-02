Describe version 0.6, codenamed Basics is the first test version of the language. It introduced the language in simple lists with separators ```,```, terminators ```;``` and production arrows ```->```.

The GOLD parser grammar is given next<br>
Keep in mind that the precompiler plays a role as well, and this cannot be seen from the grammar file.<br><br>

<span style="color:blue">_Describe 0.6 - Basics_</span>
```
! Attributes
"Name" = 'D#SCRIBE markup Language'
"Author" = 'DemonOfReason'
"Version" = '0.6'
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
!LeftArrow = '<'
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
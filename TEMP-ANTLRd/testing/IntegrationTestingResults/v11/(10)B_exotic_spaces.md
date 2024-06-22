========================================
Source Code (between the arrows)
========================================

🡆A vertical tab character (ASCII 11) ->

	A form feed character (ASCII 12),
	A next line (NEL) character (Unicode character U+0085),

	A non-breaking space (Unicode character U+00A0), 
	An ogham space mark (Unicode character U+1680), 
	En Quad (U+2000), 
	Em Quad (U+2001), 
	En Space (U+2002), 
	Em Space (U+2003), 
	Three-Per-Em Space (U+2004), 
	Four-Per-Em Space (U+2005), 
	Six-Per-Em Space (U+2006), 
	Punctuation Space (U+2008), 
	Thin Space (U+2009), 
	Hair Space (U+200A), 
	A paragraph separator (Unicode character U+2029),

	A narrow no-break space (Unicode character U+202F), 
	A medium mathematical space (Unicode character U+205F), 
	An ideographic space (Unicode character U+3000),　
	Figure Space; 🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   └── text_chunk
│   │       └── T(DATA|'A vertical tab character (ASCII 11) ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'>\r\n\r\n\t')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'A form feed character (ASCII 12)')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'A next line (NEL) character (Unicode character U+0085)')
│   │   │   └── T(SEPARATOR|',\r\n\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'A non')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(HYPHEN|'-')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'breaking space (Unicode character U+00A0)')
│   │   │   └── T(SEPARATOR|', \r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'An ogham space mark (Unicode character U+1680)')
│   │   │   └── T(SEPARATOR|', \r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'En Quad (U+2000)')
│   │   │   └── T(SEPARATOR|', \r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'Em Quad (U+2001)')
│   │   │   └── T(SEPARATOR|', \r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'En Space (U+2002)')
│   │   │   └── T(SEPARATOR|', \r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'Em Space (U+2003)')
│   │   │   └── T(SEPARATOR|', \r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'Three')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(HYPHEN|'-')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'Per')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(HYPHEN|'-')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'Em Space (U+2004)')
│   │   │   └── T(SEPARATOR|', \r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'Four')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(HYPHEN|'-')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'Per')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(HYPHEN|'-')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'Em Space (U+2005)')
│   │   │   └── T(SEPARATOR|', \r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'Six')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(HYPHEN|'-')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'Per')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(HYPHEN|'-')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'Em Space (U+2006)')
│   │   │   └── T(SEPARATOR|', \r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'Punctuation Space (U+2008)')
│   │   │   └── T(SEPARATOR|', \r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'Thin Space (U+2009)')
│   │   │   └── T(SEPARATOR|', \r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'Hair Space (U+200A)')
│   │   │   └── T(SEPARATOR|', \r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'A paragraph separator (Unicode character U+2029)')
│   │   │   └── T(SEPARATOR|',\r\n\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'A narrow no')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(HYPHEN|'-')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'break space (Unicode character U+202F)')
│   │   │   └── T(SEPARATOR|', \r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'A medium mathematical space (Unicode character U+205F)')
│   │   │   └── T(SEPARATOR|', \r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'An ideographic space (Unicode character U+3000)')
│   │   │   └── T(SEPARATOR|',　\r\n\t')
│   │   └── item
│   │       └── text_chunk
│   │           └── T(DATA|'Figure Space')
│   └── T(TERMINATOR|'; ')
└── T(EOF|'<EOF>')
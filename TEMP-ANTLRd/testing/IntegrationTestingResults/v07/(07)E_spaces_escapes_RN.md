========================================
Source Code (between the arrows)
========================================

🡆fabric     s    <sJZOzSdo>	->

	<UlJXGWLS>wool   fabrics	,
	cotton\, fabrics textiles  \<<d4\<jKusMe>,
    silk\->fabrics <Bgx8M6B1\<\>>,
    syntic 		fabrics <7vbW9VSB>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fabric     s    <sJZOzSdo')
│   │   └── text_chunk
│   │       └── T(RIGHT_ARROW|'>\t')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\r\n\r\n\t')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'<UlJXGWLS')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(RIGHT_ARROW|'>')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'wool   fabrics\t')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_SEPARATOR|'\,')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|' fabrics textiles  ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE|'\')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'<<d4')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE|'\')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'<jKusMe')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_HYPHEN|'\-')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(RIGHT_ARROW|'>')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'fabrics <Bgx8M6B1')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE|'\')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'<')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_RIGHT_ARROW|'\>')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'syntic \t\tfabrics <7vbW9VSB')
│   │       └── text_chunk
│   │           └── T(RIGHT_ARROW|'>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')
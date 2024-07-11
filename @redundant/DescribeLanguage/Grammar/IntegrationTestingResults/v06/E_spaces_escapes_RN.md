========================================
Source Code (between the arrows)
========================================

🡆fabric     s 	->

	wool   fabrics	,
	cotton\, fabrics textiles  ,
    silk\->fabrics,
    syntic 		fabrics;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   └── text_chunk
│   │       └── T(DATA|'fabric     s \t')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\r\n\r\n\t')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'wool   fabrics\t')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_SEPARATOR|'\, ')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'fabrics textiles  ')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_HYPHEN|'\-')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(RIGHT_ARROW|'>')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'fabrics')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       └── text_chunk
│   │           └── T(DATA|'syntic \t\tfabrics')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')
========================================
Source Code (between the arrows)
========================================

🡆fabric     s    <sJZOzSdo>[https://www.notube.com/watch?v=hTui12lKus]	->

	wool   fabrics[https://www.notube.com/watch?v=hTui12lKus]	<UlJXGWLS>,
	cotton\, fabrics textiles  \]<d4jKusMe>[https://www.notube.com/watch?v=hTui12lKus],
    silk\[fabrics <Bgx8M6B1>,
    syntic 		fabrics <7vbW9VSB>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fabric     s    ')
│   │   ├── T(TAG|'<sJZOzSdo>')
│   │   └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]\t')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\r\n\r\n\t')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool   fabrics')
│   │   │   │   ├── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]\t')
│   │   │   │   └── T(TAG|'<UlJXGWLS>')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_SEPARATOR|'\, ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'fabrics textiles  ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_RIGHT_SQUARE|'\]')
│   │   │   │   ├── T(TAG|'<d4jKusMe>')
│   │   │   │   └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_LEFT_SQUARE|'\[')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'fabrics ')
│   │   │   │   └── T(TAG|'<Bgx8M6B1>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'syntic \t\tfabrics ')
│   │       └── T(TAG|'<7vbW9VSB>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')
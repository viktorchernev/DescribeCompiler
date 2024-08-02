========================================
Source Code (between the arrows)
========================================

🡆fabric     s 	[https://www.notube.com/watch?v=hTui12lKus]     <TSbLGnNG> ->

	wool   fabrics	 <QWVZ3pp9> [https://www.notube.com/watch?v=hTui12lKus],
	cotton\[ fabrics textiles [https://www.notube.com/watch?v=hTui12lKus]   <75NTfebY>,
    silk\[\[\[\]fabrics <Sqs0lm7S>[https://www.notube.com/watch?v=hTui12lKus],
    syntic 		fabrics <GcZEI9gy>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fabric     s \t')
│   │   ├── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]     ')
│   │   └── T(TAG|'<TSbLGnNG> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'>\r\n\r\n\t')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool   fabrics\t ')
│   │   │   │   ├── T(TAG|'<QWVZ3pp9> ')
│   │   │   │   └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_LEFT_SQUARE|'\[ ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'fabrics textiles ')
│   │   │   │   ├── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]   ')
│   │   │   │   └── T(TAG|'<75NTfebY>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_LEFT_SQUARE|'\[')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_LEFT_SQUARE|'\[')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_LEFT_SQUARE|'\[')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_RIGHT_SQUARE|'\]')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'fabrics ')
│   │   │   │   ├── T(TAG|'<Sqs0lm7S>')
│   │   │   │   └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'syntic \t\tfabrics ')
│   │       └── T(TAG|'<GcZEI9gy>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')
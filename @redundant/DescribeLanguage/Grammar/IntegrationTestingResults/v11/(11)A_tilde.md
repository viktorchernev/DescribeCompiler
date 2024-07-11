========================================
Source Code (between the arrows)
========================================

🡆fabrics ->

	~ wool fabrics <<someid>>,
	~ cotton fabrics <<someid2>> ,

	silk fabrics<<someid>> ,
	synthetic fabrics;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   └── text_chunk
│   │       └── T(DATA|'fabrics ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'>\r\n\r\n\t')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── T(TILDE|'~')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|' wool fabrics ')
│   │   │   │   └── T(TAG|'<<someid>>')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── T(TILDE|'~')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|' cotton fabrics ')
│   │   │   │   └── T(TAG|'<<someid2>> ')
│   │   │   └── T(SEPARATOR|',\r\n\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk fabrics')
│   │   │   │   └── T(TAG|'<<someid>> ')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   └── item
│   │       └── text_chunk
│   │           └── T(DATA|'synthetic fabrics')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')
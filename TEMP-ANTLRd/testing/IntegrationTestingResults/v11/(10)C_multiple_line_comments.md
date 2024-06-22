========================================
Source Code (between the arrows)
========================================

🡆fabrics -> // comment
// comment

	wool fabrics,
	cotton fabrics, // comment
	// comment

	silk fabrics,
	synthetic fabrics; // comment
	// comment🡄

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
│   │   └── T(PRODUCTION_ARROW|'> // comment\r\n')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'wool fabrics')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'cotton fabrics')
│   │   │   └── T(SEPARATOR|', // comment\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'silk fabrics')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   └── item
│   │       └── text_chunk
│   │           └── T(DATA|'synthetic fabrics')
│   └── T(TERMINATOR|'; // comment\r\n\t')
└── T(EOF|'<EOF>')
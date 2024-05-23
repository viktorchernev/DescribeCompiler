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
│   │   └── T(RIGHT_ARROW|'>')
│   ├── item_or_expression_list
│   │   ├── item
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'\n\n\twool   fabrics\t')
│   │   ├── T(SEPARATOR|',')
│   │   └── item_or_expression_list
│   │       ├── item
│   │       │   ├── text_chunk
│   │       │   │   └── T(DATA|'\n\tcotton')
│   │       │   ├── text_chunk
│   │       │   │   └── T(ESCAPE_SEPARATOR|'\,')
│   │       │   └── text_chunk
│   │       │       └── T(DATA|' fabrics textiles  ')
│   │       ├── T(SEPARATOR|',')
│   │       └── item_or_expression_list
│   │           ├── item
│   │           │   ├── text_chunk
│   │           │   │   └── T(DATA|'\n    silk')
│   │           │   ├── text_chunk
│   │           │   │   └── T(ESCAPE_HYPHEN|'\-')
│   │           │   ├── text_chunk
│   │           │   │   └── T(RIGHT_ARROW|'>')
│   │           │   └── text_chunk
│   │           │       └── T(DATA|'fabrics')
│   │           ├── T(SEPARATOR|',')
│   │           └── item_or_expression
│   │               └── item
│   │                   └── text_chunk
│   │                       └── T(DATA|'\n    syntic \t\tfabrics')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')
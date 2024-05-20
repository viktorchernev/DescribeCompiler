========================================
Source Code (between the arrows)
========================================

🡆fabrics ->

	wool fabrics,
	cotton fabrics,
	silk fabrics,
	synthetic fabrics;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   └── text_chunk
│   │       └── T(DATA|'fabrics ')
│   ├── item_or_expression_list
│   │   ├── item
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'\n\n\twool fabrics')
│   │   ├── T(SEPARATOR|',')
│   │   └── item_or_expression_list
│   │       ├── item
│   │       │   └── text_chunk
│   │       │       └── T(DATA|'\n\tcotton fabrics')
│   │       ├── T(SEPARATOR|',')
│   │       └── item_or_expression_list
│   │           ├── item
│   │           │   └── text_chunk
│   │           │       └── T(DATA|'\n\tsilk fabrics')
│   │           ├── T(SEPARATOR|',')
│   │           └── item_or_expression
│   │               └── item
│   │                   └── text_chunk
│   │                       └── T(DATA|'\n\tsynthetic fabrics')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')
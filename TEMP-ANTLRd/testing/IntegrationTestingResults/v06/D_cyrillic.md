========================================
Source Code (between the arrows)
========================================

🡆платове ->

	вълнени платове,
	памучни платове,
	копринени платове,
	синтетични платове;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   └── text_chunk
│   │       └── T(DATA|'платове ')
│   ├── item_or_expression_list
│   │   ├── item
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'\n\n\tвълнени платове')
│   │   ├── T(SEPARATOR|',')
│   │   └── item_or_expression_list
│   │       ├── item
│   │       │   └── text_chunk
│   │       │       └── T(DATA|'\n\tпамучни платове')
│   │       ├── T(SEPARATOR|',')
│   │       └── item_or_expression_list
│   │           ├── item
│   │           │   └── text_chunk
│   │           │       └── T(DATA|'\n\tкопринени платове')
│   │           ├── T(SEPARATOR|',')
│   │           └── item_or_expression
│   │               └── item
│   │                   └── text_chunk
│   │                       └── T(DATA|'\n\tсинтетични платове')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')
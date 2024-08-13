========================================
Source Code (between the arrows)
========================================

🡆fabrics ->        // dude;

    wool fabrics, /* comment <*/
/* ->Comments, man */    cotton fabrics;🡄

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
│   │   └── T(RIGHT_ARROW|'>        ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'wool fabrics')
│   │   │   └── T(SEPARATOR|', ')
│   │   └── item
│   │       └── text_chunk
│   │           └── T(DATA|'cotton fabrics')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')
========================================
Source Code (between the arrows)
========================================

🡆fabrics -> // comment here

    wool fabrics,
    cotton fabrics,
    silk fabrics,
    synthetic fabrics;

// comment last🡄

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
│   │   └── T(PRODUCTION_ARROW|'> // comment here\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'wool fabrics')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'cotton fabrics')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'silk fabrics')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       └── text_chunk
│   │           └── T(DATA|'synthetic fabrics')
│   └── T(TERMINATOR|';\r\n\r\n')
└── T(EOF|'<EOF>')